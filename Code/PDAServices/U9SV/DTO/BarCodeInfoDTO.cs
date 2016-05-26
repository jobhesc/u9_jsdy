using System;
using System.Data;
using System.Configuration;
using System.Web;

namespace JSDY.U9SV.DTO
{
    /// <summary>
    /// 条码信息
    /// </summary>
    [Serializable]
    public class BarCodeInfoDTO
    {
        private long itemID = 0;
        private string itemCode = string.Empty;
        private string itemName = string.Empty;
        private string itemSPECS = string.Empty;
        private string itemCheckStandard = string.Empty;
        private int actualLength = 0;
        private long qcOperatorID = 0;
        private string qcOperatorCode = string.Empty;
        private string barCode = string.Empty;

        public long ItemID
        {
            get { return itemID; }
            set { itemID = value; }
        }

        public string ItemCode
        {
            get { return itemCode; }
            set { itemCode = value; }
        }

        public string ItemName
        {
            get { return itemName; }
            set { itemName = value; }
        }

        public string ItemSPECS
        {
            get { return itemSPECS; }
            set { itemSPECS = value; }
        }

        public string ItemCheckStandard
        {
            get { return itemCheckStandard; }
            set { itemCheckStandard = value; }
        }

        public int ActualLength
        {
            get { return actualLength; }
            set { actualLength = value; }
        }

        public long QcOperatorID
        {
            get { return qcOperatorID; }
            set { qcOperatorID = value; }
        }

        public string QcOperatorCode
        {
            get { return qcOperatorCode; }
            set { qcOperatorCode = value; }
        }

        public string BarCode
        {
            get { return barCode; }
            set { barCode = value; }
        }

    }
}
