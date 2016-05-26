using System;
using System.Collections.Generic;
using System.Text;

namespace PDAClient.Utils
{
    /// <summary>
    /// PDA������
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
        /// ��¼ʱ��
        /// </summary>
        public static DateTime LoginDateTime
        {
            get { return loginDateTime; }
            set { loginDateTime = value; }
        }

        /// <summary>
        /// ��¼�û����
        /// </summary>
        public static string LoginUserCode
        {
            get { return loginUserCode; }
            set { loginUserCode = value; }
        }
        
        /// <summary>
        /// ��¼�û�ID
        /// </summary>
        public static long LoginUserID
        {
            get { return PDAContext.loginUserID; }
            set { PDAContext.loginUserID = value; }
        }

        /// <summary>
        /// ��¼�û�����
        /// </summary>
        public static string LoginUserName
        {
            get { return PDAContext.loginUserName; }
            set { PDAContext.loginUserName = value; }
        }

        /// <summary>
        /// ��¼��֯ID
        /// </summary>
        public static long LoginOrgID
        {
            get { return PDAContext.loginOrgID; }
            set { PDAContext.loginOrgID = value; }
        }

        /// <summary>
        /// ��¼��֯����
        /// </summary>
        public static string LoginOrgName
        {
            get { return PDAContext.loginOrgName; }
            set { PDAContext.loginOrgName = value; }
        }
    }
}
