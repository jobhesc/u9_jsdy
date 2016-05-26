using System;
using System.Collections.Generic;
using System.Text;

namespace JSDY.U9SV.Utils
{
    [Serializable]
    public class LoginContext
    {
        private long orgID = 0;
        private long userID = 0;
        private string userName = string.Empty;

        public long OrgID
        {
            get { return orgID; }
            set { orgID = value; }
        }

        public long UserID
        {
            get { return userID; }
            set { userID = value; }
        }

        public string UserName
        {
            get { return userName; }
            set { userName = value; }
        }
    }

}
