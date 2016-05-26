using System;
using System.Collections.Generic;
using System.Text;

namespace PDAClient.Utils
{
    /// <summary>
    /// PDA上下文
    /// </summary>
    class PDAContext
    {
        private static long loginUserID = 0;
        private static string loginUserCode = string.Empty;
        private static string loginUserName = string.Empty;
        private static DateTime loginDateTime = DateTime.MinValue;
        private static long loginOrgID = 0;
        private static string loginOrgName = string.Empty;

        /// <summary>
        /// 登录时间
        /// </summary>
        public static DateTime LoginDateTime
        {
            get { return loginDateTime; }
            set { loginDateTime = value; }
        }

        /// <summary>
        /// 登录用户编号
        /// </summary>
        public static string LoginUserCode
        {
            get { return loginUserCode; }
            set { loginUserCode = value; }
        }
        
        /// <summary>
        /// 登录用户ID
        /// </summary>
        public static long LoginUserID
        {
            get { return PDAContext.loginUserID; }
            set { PDAContext.loginUserID = value; }
        }

        /// <summary>
        /// 登录用户名称
        /// </summary>
        public static string LoginUserName
        {
            get { return PDAContext.loginUserName; }
            set { PDAContext.loginUserName = value; }
        }

        /// <summary>
        /// 登录组织ID
        /// </summary>
        public static long LoginOrgID
        {
            get { return PDAContext.loginOrgID; }
            set { PDAContext.loginOrgID = value; }
        }

        /// <summary>
        /// 登录组织名称
        /// </summary>
        public static string LoginOrgName
        {
            get { return PDAContext.loginOrgName; }
            set { PDAContext.loginOrgName = value; }
        }
    }
}
