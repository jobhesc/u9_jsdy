using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.IO;
using System.Reflection;
using PDAClient.Entities;
using System.Diagnostics;
using PDAClient.PDAService;
using System.Net;
using PDAClient.Progress;
using System.Xml;
using PDAUtils.Progress;

namespace PDAClient.Utils
{
    class VersionHelper
    {
        /// <summary>
        /// 获取当前程序版本
        /// </summary>
        /// <returns></returns>
        public static string GetCurrVersion()
        {
            return GetNode("/version/version").InnerText;
        }

        /// <summary>
        /// 查找节点
        /// </summary>
        /// <param name="xpath"></param>
        /// <returns></returns>
        private static XmlElement GetNode(string xpath)
        {
            XmlDocument configDoc = LoadConfig();

            if (configDoc == null)
                throw new ArgumentException("配置文件为空");
            if (configDoc.DocumentElement == null)
                throw new ArgumentException("配置文件缺少根节点");

            return configDoc.DocumentElement.SelectSingleNode(xpath) as XmlElement;
        }

        /// <summary>
        /// 装载版本配置文件
        /// </summary>
        /// <returns></returns>
        private static XmlDocument LoadConfig()
        {
            string configFile = Path.Combine(GetCurrentPath(), "version.xml");
            if (!File.Exists(configFile))
                throw new Exception("没有找到文件" + configFile);

            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(configFile);
            return xmlDoc;
        }

        /// <summary>
        /// 校验是否需要更新
        /// </summary>
        /// <returns></returns>
        public static bool IsNeedUpdate()
        {
            string version = GetCurrVersion();
            if (string.IsNullOrEmpty(version))
                throw new Exception("产品版本为空异常！");
            return ServiceAgent.Agent.IsNeedUpdateVersion(version);
        }

        /// <summary>
        /// 检查更新版本
        /// </summary>
        public static void CheckUpdate(string baseUrl)
        {
            if (!IsNeedUpdate()) return;

            VersionItem[] remoteDownloadfiles = ServiceAgent.Agent.GetPatchDownloads();
            if (remoteDownloadfiles == null || remoteDownloadfiles.Length == 0) return;

            if (MessageBox.Show("服务器存在新版本，是否需要立即更新？", "版本更新", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.OK)
            {
                Application.DoEvents();
                // 下载文件
                List<VersionItem> localDownloadfiles = BuildLocalDownloadfiles(remoteDownloadfiles, baseUrl);

                string arguments = BuildUpdateArguments(localDownloadfiles);
                if (string.IsNullOrEmpty(arguments)) return;

                // 启用PDAUpdate.exe进程进行更新
                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.FileName = GetPDAUpdatePath();
                startInfo.UseShellExecute = false;
                startInfo.Arguments = arguments;  // 参数

                Process updateProcess = new Process();
                updateProcess.StartInfo = startInfo;
                updateProcess.EnableRaisingEvents = false;
                updateProcess.Start();
            }
        }

        private static List<VersionItem> BuildLocalDownloadfiles(VersionItem[] remoteDownloadfiles, string baseUrl)
        {
            List<VersionItem> localDownloadfiles = new List<VersionItem>();
            ProgressActor progress = new ProgressActor();
            progress.Show();
            try
            {
                // 创建下载目录
                string localPatchPath = BuildPatchPath();
                // 下载文件
                VersionItem localDownloadfile = null;
                foreach (VersionItem remoteDownloadfile in remoteDownloadfiles)
                {
                    localDownloadfile = DownloadPatch(remoteDownloadfile, baseUrl, localPatchPath, progress);
                    if (localDownloadfile != null)
                        localDownloadfiles.Add(localDownloadfile);
                }
                return localDownloadfiles;
            }
            finally
            {
                progress.Hide();
            }
        }

        /// <summary>
        /// 构造补丁目录
        /// </summary>
        /// <returns></returns>
        private static string BuildPatchPath()
        {
            string basePath = Path.Combine(GetCurrentPath(), "Patch");
            ForcePathExist(basePath);

            string todayPath = Path.Combine(basePath, DateTime.Now.ToString("yyyyMMdd"));
            ForcePathExist(todayPath);

            string realPath = Path.Combine(todayPath, Guid.NewGuid().ToString());
            ForcePathExist(realPath);

            return realPath;
        }

        /// <summary>
        /// 创建文件夹
        /// </summary>
        /// <param name="path"></param>
        private static void ForcePathExist(string path)
        {
            if (!Directory.Exists(path))
                Directory.CreateDirectory(path);
        }

        /// <summary>
        /// 下载补丁文件
        /// </summary>
        /// <param name="versionItem"></param>
        /// <param name="baseUrl"></param>
        /// <param name="path"></param>
        /// <param name="progress"></param>
        /// <returns></returns>
        private static VersionItem DownloadPatch(VersionItem versionItem, string baseUrl, string path, ProgressActor progress)
        {
            if (versionItem == null) return null;
            if (string.IsNullOrEmpty(versionItem.DownloadFile)) return null;

            string url = versionItem.DownloadFile;
            if (!url.ToLower().Trim().StartsWith("http://"))
            {
                url = Path.Combine(baseUrl, url);
            }
            // 获取文件名
            String fileName = url.Substring(url.LastIndexOf("/") + 1);
            // 获取文件下载路径
            String refer = url.Substring(0, url.LastIndexOf("/") + 1);

            VersionItem localDownloadfile = new VersionItem();
            localDownloadfile.InstallStyle = versionItem.InstallStyle;
            localDownloadfile.DownloadFile = Path.Combine(path, fileName);
            localDownloadfile.Version = versionItem.Version;

            // 开始下载
            progress.Init(100);
            progress.ProgressHint = "正在下载:" + url;

            HttpWebRequest req = HttpWebRequest.Create(url) as HttpWebRequest;
            req.AllowAutoRedirect = true;
            req.Referer = refer;
            req.UserAgent = "Mozilla/5.0 (Windows; U; Windows NT 6.1; zh-CN; rv:1.9.2.13) Gecko/20101203 Firefox/3.6.13";
            HttpWebResponse res = req.GetResponse() as HttpWebResponse;
            Stream stream = res.GetResponseStream();

            byte[] buffer = new byte[32 * 1024];
            FileStream fs = File.Create(localDownloadfile.DownloadFile);
            int index = 0;
            try
            {
                int bytesProcessed = 0, bytesRead = 0;
                do
                {
                    bytesRead = stream.Read(buffer, 0, buffer.Length);
                    fs.Write(buffer, 0, bytesRead);
                    bytesProcessed += bytesRead;

                    progress.SetProgress(index++);
                }
                while (bytesRead > 0);
                fs.Flush();
                progress.SetProgress(100);
            }
            finally
            {
                fs.Close();
                stream.Close();
                res.Close();
            }

            return localDownloadfile;
        }

        /// <summary>
        /// 构建更新参数
        /// </summary>
        /// <returns></returns>
        private static string BuildUpdateArguments(List<VersionItem> versionItems)
        {
            if (versionItems == null || versionItems.Count == 0) return string.Empty;

            StringBuilder builer = new StringBuilder();
            // 第一个参数是当前进程id
            builer.Append(Process.GetCurrentProcess().Id.ToString());
            builer.Append(" ");
            // 第二个参数是版本号
            builer.Append(versionItems[0].Version);
            builer.Append(" ");
            // 第二个参数才是补丁信息
            foreach (VersionItem item in versionItems)
            {
                builer.Append(string.Format("{0}&{1}", item.DownloadFile, item.InstallStyle));
                builer.Append("|");
            }
            return builer.ToString(0, builer.Length - 1);
        }

        /// <summary>
        /// 获取当前应用程序目录
        /// </summary>
        /// <returns></returns>
        private static string GetCurrentPath()
        {
            return Path.GetDirectoryName(Assembly.GetExecutingAssembly().GetName().CodeBase);
        }

        /// <summary>
        /// 获取PDAUpdate.exe路径
        /// </summary>
        /// <returns></returns>
        private static string GetPDAUpdatePath()
        {
            return Path.Combine(GetCurrentPath(), "PDAUpdate.exe");
        }
    }
}
