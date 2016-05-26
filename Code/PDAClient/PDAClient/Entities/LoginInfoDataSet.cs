using System;
using PDAClient.Entities.LoginInfoDataSetTableAdapters;
using PDAClient.Utils;
namespace PDAClient.Entities
{

    partial class LoginInfoDataSet
    {
        private static LoginInfoDataSet _instance = null;

        public static LoginInfoDataSet Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new LoginInfoDataSet();
                    _instance.Load();
                }
                return _instance;
            }
        }

        public LoginInfoRow CurrentInfo
        {
            get
            {
                if (this.LoginInfo.Rows.Count == 0)
                    this.LoginInfo.AddLoginInfoRow(false, "", "", DateTime.MinValue, 0, "", 0, "");
                return this.LoginInfo[0];
            }
        }

        /// <summary>
        /// 装载数据
        /// </summary>
        public void Load()
        {
            LoginInfoTableAdapter adapter = new LoginInfoTableAdapter();
            adapter.Fill(this.LoginInfo);
        }

        /// <summary>
        /// 保存数据
        /// </summary>
        public void Save()
        {
            LoginInfoTableAdapter adapter = new LoginInfoTableAdapter();
            adapter.Update(this.LoginInfo);
        }

        /// <summary>
        /// 保存数据
        /// </summary>
        public void Save(bool isSavePassword, string loginPassword)
        {
            this.CurrentInfo.LastLoginUserID = PDAContext.LoginUserID;
            this.CurrentInfo.LastLoginUser = PDAContext.LoginUserCode;
            this.CurrentInfo.LastLoginUserName = PDAContext.LoginUserName;

            this.CurrentInfo.LastPassword = isSavePassword ? loginPassword : "";
            this.CurrentInfo.IsSavePassword = isSavePassword;
            this.CurrentInfo.LastLoginTime = PDAContext.LoginDateTime;

            this.CurrentInfo.LastLoginOrgID = PDAContext.LoginOrgID;
            this.CurrentInfo.LastLoginOrgName = PDAContext.LoginOrgName;

            Save();
        }

        public new void Reset()
        {
            Save(false, "");
        }
    }
}
