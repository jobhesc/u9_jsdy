using System;
using System.Data;
using System.Configuration;
using System.Web;

namespace JSDY.U9SV.DTO
{
    /// <summary>
    /// 出货计划信息
    /// </summary>
    [Serializable]
    public class ShipPlanDocDTO
    {
        private long itemID = 0;
        private string itemCode = string.Empty;
        private string itemName = string.Empty;
        private string itemSPECS = string.Empty;
        private long shipPlanID = 0;
        private long shipPlanLineID = 0;
        private int segLength = 0;  //段长
        private int count = 0; //盘数
        private int totalLength = 0; //总长

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

        public long ShipPlanID
        {
            get { return shipPlanID; }
            set { shipPlanID = value; }
        }

        public long ShipPlanLineID
        {
            get { return shipPlanLineID; }
            set { shipPlanLineID = value; }
        }

        public int SegLength
        {
            get { return segLength; }
            set { segLength = value; }
        }

        public int Count
        {
            get { return count; }
            set { count = value; }
        }

        public int TotalLength
        {
            get { return totalLength; }
            set { totalLength = value; }
        }


    }
}