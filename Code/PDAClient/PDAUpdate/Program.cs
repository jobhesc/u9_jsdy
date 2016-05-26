using System;

using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.IO;
using System.Reflection;
using System.Diagnostics;
using System.Net;
using PDAUpdate.Utils;
using PDAUpdate.Progress;

namespace PDAUpdate
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args == null || args.Length < 3) return;
            // 第一个参数是PDAClient.exe进程ID
            Process pdaclientProcess = GetProcess(int.Parse(args[0]));
            // 第二个是版本号信息
            string version = args[1];
            // 第三个才是补丁信息
            List<PatchInfo> patchInfos = ParsePatchInfos(args[2]);
            if (patchInfos == null || patchInfos.Count == 0) return;
            // 杀掉PDAClient.exe进程
            if (pdaclientProcess != null)
                pdaclientProcess.Kill();

            ProgressActor progress = new ProgressActor();
            progress.Show();
            try
            {
                progress.Init(patchInfos.Count + 2);
                // 拷贝文件更新
                int index = 0;
                foreach (PatchInfo patchInfo in patchInfos)
                {
                    if (string.IsNullOrEmpty(patchInfo.DownloadPath)) continue;
                    progress.ProgressHint = "正在安装:" + Path.GetFileName(patchInfo.DownloadPath);
                    progress.SetProgress(index++);
                    FileUpdate.DoUpdate(patchInfo, PathHelper.GetTempPath(), PathHelper.GetCurrentPath());
                }

                progress.ProgressHint = "正在更新版本信息";
                progress.SetProgress(index++);
                // 更新版本信息
                VersionUpdate.DoUpdate(version);

                progress.ProgressHint = "正在启动PDAClient进程";
                progress.SetProgress(index++);
                // 重新启动PDAClient.exe
                Process.Start(PathHelper.GetPDAClientPath(), "");
            }
            finally
            {
                progress.Hide();
            }
        }

        /// <summary>
        /// 获取进程
        /// </summary>
        /// <param name="processid"></param>
        /// <returns></returns>
        private static Process GetProcess(int processid)
        {
            try
            {
                return Process.GetProcessById(processid);
            }
            catch
            {
            }
            return null;
        }

        /// <summary>
        /// 解析补丁信息
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        private static List<PatchInfo> ParsePatchInfos(string args)
        {
            if (string.IsNullOrEmpty(args)) return null;
            string[] patchInfos = args.Split("|".ToCharArray());
            if (patchInfos == null || patchInfos.Length == 0) return null;

            List<PatchInfo> resultList = new List<PatchInfo>();
            PatchInfo result = null;
            foreach (string s in patchInfos)
            {
                result = ParsePatchInfo(s);
                if (result != null)
                    resultList.Add(result);
            }
            return resultList;
        }

        /// <summary>
        /// 解析补丁信息
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        private static PatchInfo ParsePatchInfo(string s)
        {
            if (string.IsNullOrEmpty(s)) return null;
            string[] pa = s.Split('&');
            if (pa == null || pa.Length == 0) return null;

            PatchInfo patchInfo = new PatchInfo();
            patchInfo.DownloadPath = pa[0];
            patchInfo.InstallStyle = "update";
            if (pa.Length > 1)
                patchInfo.InstallStyle = pa[1];

            return patchInfo;
        }
    }
}
