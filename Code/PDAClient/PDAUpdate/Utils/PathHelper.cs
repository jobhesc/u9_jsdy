using System;

using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Reflection;

namespace PDAUpdate.Utils
{
    class PathHelper
    {
        /// <summary>
        /// 获取临时目录
        /// </summary>
        /// <returns></returns>
        public static string GetTempPath()
        {
            return Path.Combine(GetCurrentPath(), "temp");
        }

        /// <summary>
        /// 获取当前应用程序目录
        /// </summary>
        /// <returns></returns>
        public static string GetCurrentPath()
        {
            return Path.GetDirectoryName(Assembly.GetExecutingAssembly().GetName().CodeBase);
        }

        /// <summary>
        /// 获取PDAClient.exe路径
        /// </summary>
        /// <returns></returns>
        public static string GetPDAClientPath()
        {
            return Path.Combine(GetCurrentPath(), "PDAClient.exe");
        }

        /// <summary>
        /// 获取version.xml路径
        /// </summary>
        /// <returns></returns>
        public static string GetVersionFilePath()
        {
            return Path.Combine(PathHelper.GetCurrentPath(), "version.xml");
        }
    }
}
