using System;
using System.Data;
using System.Configuration;
using System.Web;

namespace JSDY.U9SV.DTO
{
    /// <summary>
    /// 盘点条码导入信息
    /// </summary>
    [Serializable]
    public class InvCheckBarCodeImportDTO
    {
        private string barCode = "";
        private long itemID = 0;
        private long orgID = 0;
        private int qty = 0;
        private DateTime scanDate = DateTime.MinValue;
        private string scanPerson = string.Empty;

        public long ItemID
        {
            get { return itemID; }
            set { itemID = value; }
        }

        public long OrgID
        {
            get { return orgID; }
            set { orgID = value; }
        }

        public int Qty
        {
            get { return qty; }
            set { qty = value; }
        }

        public DateTime ScanDate
        {
            get { return scanDate; }
            set { scanDate = value; }
        }

        public string ScanPerson
        {
            get { return scanPerson; }
            set { scanPerson = value; }
        }


        public string BarCode
        {
            get { return barCode; }
            set { barCode = value; }
        }
    }
}