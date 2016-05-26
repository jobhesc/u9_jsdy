using System;
using System.Data;
using System.Configuration;
using System.Web;

namespace JSDY.U9SV.DTO
{
    /// <summary>
    /// 用户信息
    /// </summary>
    [Serializable]
    public class UserInfoDTO
    {
        private long userID = 0;
        private string userCode = string.Empty;
        private string userName = string.Empty;

        /// <summary>
        /// 用户ID
        /// </summary>
        public long UserID
        {
            get { return userID; }
            set { userID = value; }
        }

        /// <summary>
        /// 用户编号
        /// </summary>
        public string UserCode
        {
            get { return userCode; }
            set { userCode = value; }
        }

        /// <summary>
        /// 用户名称
        /// </summary>
        public string UserName
        {
            get { return userName; }
            set { userName = value; }
        }
    }
}
