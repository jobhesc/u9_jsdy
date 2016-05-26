using System;
using System.Data;
using System.Configuration;
using System.Xml;
using System.IO;
using JSDY.U9SV.Version;
using System.Collections.Generic;

namespace JSDY.U9SV.Utils
{
    /// <summary>
    /// PDAConfig 的摘要说明
    /// </summary>
    public class PDAConfig
    {
        public static string GetConnectionString()
        {
            return GetNodeValue("/PDAService/connectionString");
        }

        /// <summary>
        /// 查找节点
        /// </summary>
        /// <param name="xpath"></param>
        /// <returns></returns>
        private static XmlElement GetNode(string xpath)
        {
            XmlDocument configDoc = LoadPDAConfig();

            if (configDoc == null)
                throw new ArgumentException("配置文件为空");
            if (configDoc.DocumentElement == null)
                throw new ArgumentException("配置文件缺少根节点");

            return configDoc.DocumentElement.SelectSingleNode(xpath) as XmlElement;
        }

        /// <summary>
        /// 获取设置节点值
        /// </summary>
        /// <param name="xpath"></param>
        /// <returns></returns>
        private static string GetNodeValue(string xpath)
        {
            XmlNode xmlElement = GetNode(xpath);
            return xmlElement == null ? string.Empty : xmlElement.InnerText;
        }

        /// <summary>
        /// 装载U9服务配置文件
        /// </summary>
        /// <returns></returns>
        private static XmlDocument LoadPDAConfig()
        {
            string configFile = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "App_Data\\PDAConfig.xml");
            if (!File.Exists(configFile))
                throw new Exception("没有找到文件" + configFile);

            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(configFile);
            return xmlDoc;
        }


        #region 上下文数据

        /// <summary>
        /// 获取基础设置节点值
        /// </summary>
        /// <param name="configDoc"></param>
        /// <param name="node"></param>
        /// <returns></returns>
        public static string GetContextNodeValue(string nodeName)
        {
            return GetNodeValue("/PDAService/ServiceContext/" + nodeName);
        }

        /// <summary>
        /// 企业名称
        /// </summary>
        public static string EnterpriseName
        {
            get { return GetContextNodeValue("EnterpriseName"); }
        }

        /// <summary>
        /// 企业ID
        /// </summary>
        public static string EnterpriseID
        {
            get { return GetContextNodeValue("EnterpriseID"); }
        }

        #endregion

        #region 补丁版本

        /// <summary>
        /// 获取补丁最新版本
        /// </summary>
        /// <returns></returns>
        public static string GetPatchVersion()
        {
            return GetNodeValue("/PDAService/PatchVersion/Version");
        }
        
        /// <summary>
        /// 获取补丁下载信息
        /// </summary>
        /// <returns></returns>
        public static List<VersionItem> GetPatchDownloads()
        {
            XmlElement downloadFilesNode = GetNode("/PDAService/PatchVersion/DownloadFiles");
            if (downloadFilesNode == null) return null;
            string version = GetPatchVersion();
            List<VersionItem> versionItems = new List<VersionItem>();
            VersionItem versionItem = null;
            foreach(XmlElement downloadFileNode in downloadFilesNode)
            {
                versionItem = new VersionItem();
                versionItem.DownloadFile = downloadFileNode.InnerText;
                versionItem.InstallStyle = downloadFileNode.Attributes["mode"].Value;
                versionItem.Version = version;
                versionItems.Add(versionItem);
            }
            return versionItems;
        }
        #endregion
    }
}
