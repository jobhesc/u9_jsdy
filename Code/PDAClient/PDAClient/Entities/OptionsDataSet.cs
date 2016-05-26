using PDAClient.Entities.OptionsDataSetTableAdapters;
using System.Collections.Generic;
using System;
namespace PDAClient.Entities
{


    partial class OptionsDataSet
    {
        private static OptionsDataSet _instance = null;

        public static OptionsDataSet Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new OptionsDataSet();
                    _instance.Load();
                }
                return _instance;
            }
        }

        public const string SERVER_SERVICE_FILE = "U9PDAService.asmx";
        public const string SERVER_PROTOCOL = "http://";
        public const string SERVER_PATH = "/PDAService/";

        /// <summary>
        /// 初始化参数
        /// </summary>
        public void InitOption()
        {
            // 服务地址
            if (string.IsNullOrEmpty(Host))
                Host = "10.211.55.3";
            // 最大连接数
            if (MaxConnCount == 0)
                MaxConnCount = 10;
            // 连接超时
            if (ConnTimeout == 0)
                ConnTimeout = 90;

            Save();
        }

        /// <summary>
        /// 装载数据
        /// </summary>
        public void Load()
        {
            originalValues.Clear();
            OptionsTableAdapter adapter = new OptionsTableAdapter();
            adapter.Fill(this.Options);
        }

        /// <summary>
        /// 保存数据
        /// </summary>
        public void Save()
        {
            OptionsTableAdapter adapter = new OptionsTableAdapter();
            adapter.Update(this.Options);
            originalValues.Clear();
        }

        /// <summary>
        /// 根据name查找行
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public OptionsDataSet.OptionsRow FindRow(string name)
        {
            foreach (OptionsDataSet.OptionsRow optionsRow in this.Options)
                if (optionsRow.Name == name)
                    return optionsRow;
            return null;
        }

        /// <summary>
        /// 根据Name获取Value
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public string GetValue(string name)
        {
            OptionsDataSet.OptionsRow optionsRow = FindRow(name);
            return optionsRow == null ? string.Empty : optionsRow.Value;
        }

        /// <summary>
        /// 设置name的value
        /// </summary>
        /// <param name="name"></param>
        /// <param name="value"></param>
        public void SetValue(string name, string value)
        {
            // 记录原始值
            if (!originalValues.ContainsKey(name))
                originalValues.Add(name, "");
            originalValues[name] = GetValue(name);

            InnerSetValue(name, value);
        }

        private void InnerSetValue(string name, string value)
        {
            OptionsDataSet.OptionsRow optionsRow = FindRow(name);
            if (optionsRow == null)
                this.Options.AddOptionsRow(name, value);
            else
                optionsRow.Value = value;
        }

        /// <summary>
        /// 回滚到上一次存储的值
        /// </summary>
        public void Rollback()
        {
            foreach (string key in originalValues.Keys)
                InnerSetValue(key, originalValues[key]);
        }

        private Dictionary<string, string> originalValues = new Dictionary<string, string>();

        /// <summary>
        /// 服务基址
        /// </summary>
        public string Host
        {
            get
            {
                return GetValue("ServiceUrl");
            }
            set { SetValue("ServiceUrl", value); }
        }

        public string ServerBaseUrl
        {
            get
            {
                string url = this.Host.Trim();
                if (!url.StartsWith(SERVER_PROTOCOL, System.StringComparison.OrdinalIgnoreCase))
                    url = SERVER_PROTOCOL + url;
                return url+SERVER_PATH;
            }
        }

        /// <summary>
        /// 服务地址
        /// </summary>
        public string ServerUrl
        {
            get
            {
                return ServerBaseUrl + SERVER_SERVICE_FILE;
            }
        }        

        /// <summary>
        /// 最大连接次数
        /// </summary>
        public int MaxConnCount
        {
            get
            {
                string value = GetValue("MaxConnCount");
                if (string.IsNullOrEmpty(value)) return 0;
                return int.Parse(value);
            }
            set { SetValue("MaxConnCount", value.ToString()); }
        }

        /// <summary>
        /// 连接超时(单位为秒)
        /// </summary>
        public int ConnTimeout
        {
            get
            {
                string value = GetValue("ConnTimeout");
                if (string.IsNullOrEmpty(value)) return 0;
                return int.Parse(value);
            }
            set { SetValue("ConnTimeout", value.ToString()); }
        }

    }
}
