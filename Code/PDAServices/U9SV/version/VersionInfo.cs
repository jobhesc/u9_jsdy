using System;
using System.Data;
using System.Configuration;
using System.Web;

namespace JSDY.U9SV.Version
{
    /// <summary>
    /// 版本信息项
    /// </summary>
    [Serializable]
    public class VersionItem
    {
        private string downloadFile = string.Empty;
        private string installStyle = string.Empty;
        private string version = string.Empty;

        /// <summary>
        /// 版本号
        /// </summary>
        public string Version
        {
            get { return version; }
            set { version = value; }
        }

        /// <summary>
        /// 下载的文件
        /// </summary>
        public string DownloadFile
        {
            get { return downloadFile; }
            set { downloadFile = value; }
        }

        /// <summary>
        /// 文件安装的方式
        /// </summary>
        public string InstallStyle
        {
            get { return installStyle; }
            set { installStyle = value; }
        }

    }
}
