using System;

using System.Collections.Generic;
using System.Text;
using System.IO;
using PDAUpdate.Utils;
using System.Diagnostics;
using System.Xml;

namespace PDAUpdate
{
    class FileUpdate
    {
        /// <summary>
        /// 执行文件升级
        /// </summary>
        /// <param name="patchInfo"></param>
        /// <param name="tempPath"></param>
        /// <param name="updatePath"></param>
        public static void DoUpdate(PatchInfo patchInfo, string tempPath, string updatePath)
        {
            if (patchInfo == null) return;
            if (string.IsNullOrEmpty(patchInfo.DownloadPath)) return;

            if (Directory.Exists(tempPath))
                Directory.Delete(tempPath, true);
            Directory.CreateDirectory(tempPath);

            string installStyle = patchInfo.InstallStyle.Trim().ToLower();
            string extension = Path.GetExtension(patchInfo.DownloadPath).ToLower();
            if (installStyle == "update")
            {
                if (extension == ".zip")
                {
                    // 解压缩文件
                    ZipHelper.Extract(patchInfo.DownloadPath, tempPath);
                    CopyFiles(tempPath, updatePath);
                }
                else
                {
                    CopyFileToDir(patchInfo.DownloadPath, updatePath);
                }
            }
            else if (installStyle == "install")
            {
                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.UseShellExecute = false;  // 不弹出shell
                if (extension == ".cab")
                {
                    // 拷贝到temp目录下
                    CopyFileToDir(patchInfo.DownloadPath, tempPath);
                    string installfile = Path.Combine(tempPath, Path.GetFileName(patchInfo.DownloadPath));

                    //wceload命令格式： wceload [ /noaskdest | /askdest ] [ /delete <number> | /noui | /nouninstall ] <cab file location> 
                    // noaskdest不提示安装路径；askdest提示安装路径
                    // delete后的number可选：0为不删除；1为删除
                    // noui为不弹出任何窗体进行安装
                    // noinstall安装后的应用程序不能被卸载

                    startInfo.FileName = "wceload";
                    startInfo.Arguments = "/noui " + installfile; 
                }
                else
                    startInfo.FileName = patchInfo.DownloadPath;

                Process.Start(startInfo);
            }

            Directory.Delete(tempPath, true);
        }

        /// <summary>
        /// 拷贝文件到指定文件夹
        /// </summary>
        /// <param name="file"></param>
        /// <param name="destdir"></param>
        public static void CopyFileToDir(string file, string destdir)
        {
            if (!Directory.Exists(destdir))
                Directory.CreateDirectory(destdir);
            string destfile = Path.Combine(destdir, Path.GetFileName(file));
            File.Copy(file, destfile, true);
        }

        /// <summary>
        /// 拷贝文件并覆盖
        /// </summary>
        /// <param name="sourcePath"></param>
        /// <param name="destPath"></param>
        public static void CopyFiles(string sourcePath, string destPath)
        {
            string[] sourcefiles = Directory.GetFiles(sourcePath);
            string[] sourcedirs = Directory.GetDirectories(sourcePath);

            if (!Directory.Exists(destPath))
                Directory.CreateDirectory(destPath);

            foreach (string sourcefile in sourcefiles)
            {
                string destfile = Path.Combine(destPath, Path.GetFileName(sourcefile));
                File.Copy(sourcefile, destfile, true);
            }

            foreach (string sourcedir in sourcedirs)
            {
                string destdir = Path.Combine(destPath, Path.GetFileName(sourcedir));
                CopyFiles(sourcedir, destdir);
            }
        }
    }

    class VersionUpdate
    {
        /// <summary>
        /// 更新版本信息
        /// </summary>
        /// <param name="version"></param>
        public static void DoUpdate(string version)
        {
            XmlDocument verDoc = LoadConfig();
            XmlElement xmlElement = GetNode(verDoc, "/version/version");
            xmlElement.InnerText = version;
            verDoc.Save(PathHelper.GetVersionFilePath());
        }

        /// <summary>
        /// 查找节点
        /// </summary>
        /// <param name="xpath"></param>
        /// <returns></returns>
        private static XmlElement GetNode(XmlDocument verDoc, string xpath)
        {
            if (verDoc == null)
                throw new ArgumentException("版本文件为空");
            if (verDoc.DocumentElement == null)
                throw new ArgumentException("版本文件缺少根节点");

            return verDoc.DocumentElement.SelectSingleNode(xpath) as XmlElement;
        }

        /// <summary>
        /// 装载版本配置文件
        /// </summary>
        /// <returns></returns>
        private static XmlDocument LoadConfig()
        {
            string versionFile = PathHelper.GetVersionFilePath();
            if (!File.Exists(versionFile))
                throw new Exception("没有找到文件" + versionFile);

            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(versionFile);
            return xmlDoc;
        }
    }

    /// <summary>
    /// 补丁信息
    /// </summary>
    public class PatchInfo
    {
        /// <summary>
        /// 下载路径
        /// </summary>
        public string DownloadPath = string.Empty;
        /// <summary>
        /// 安装方式
        /// </summary>
        public string InstallStyle = string.Empty;
    }
}
