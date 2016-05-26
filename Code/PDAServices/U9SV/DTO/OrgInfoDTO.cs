using System;
using System.Data;
using System.Configuration;
using System.Web;

namespace JSDY.U9SV.DTO
{
    /// <summary>
    /// 组织信息
    /// </summary>
    [Serializable]
    public class OrgInfoDTO
    {
        private long orgID = 0;
        private string orgCode = string.Empty;
        private string orgName = string.Empty;

        /// <summary>
        /// 组织ID
        /// </summary>
        public long OrgID
        {
            get { return orgID; }
            set { orgID = value; }
        }

        /// <summary>
        /// 组织编号
        /// </summary>
        public string OrgCode
        {
            get { return orgCode; }
            set { orgCode = value; }
        }

        /// <summary>
        /// 组织名称
        /// </summary>
        public string OrgName
        {
            get { return orgName; }
            set { orgName = value; }
        }
    }
}
