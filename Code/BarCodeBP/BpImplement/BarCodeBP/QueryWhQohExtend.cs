namespace UFIDA.U9.Cust.JSDY.BarCode
{
	using System;
	using System.Collections.Generic;
	using System.Text; 
	using UFSoft.UBF.AopFrame;	
	using UFSoft.UBF.Util.Context;
    using UFSoft.UBF.Util.DataAccess;
    using UFSoft.UBF.Sys.Database;
    using System.Data;

	/// <summary>
	/// QueryWhQoh partial 
	/// </summary>	
	public partial class QueryWhQoh 
	{	
		internal BaseStrategy Select()
		{
			return new QueryWhQohImpementStrategy();	
		}		
	}
	
	#region  implement strategy	
	/// <summary>
	/// Impement Implement
	/// 
	/// </summary>	
	internal partial class QueryWhQohImpementStrategy : BaseStrategy
	{
		public QueryWhQohImpementStrategy() { }

		public override object Do(object obj)
		{						
			QueryWhQoh bpObj = (QueryWhQoh)obj;

            string sql = string.Format(@"
select whQoh.ItemInfo_ItemID,
	whQoh.ItemInfo_ItemCode,
	whQoh.ItemInfo_ItemName,
	lot.LotCode,
	lot.DescFlexSegments_PubDescSeg1 as SegLength,
	wh.Name as wh,
	sum(whQoh.StoreQty) as StoreQty,
	uomTrl.Name as uom,
	uom.Round_Precision,
	uom.Round_RoundType,
	uom.Round_RoundValue
from InvTrans_WhQoh as whQoh
inner join Lot_LotMaster as lot on whQoh.LotInfo_LotMaster_EntityID = lot.ID
inner join CBO_Wh_Trl as wh on wh.ID = whQoh.Wh and wh.SysMLFlag='zh-CN'
inner join Base_UOM as uom on uom.ID = whQoh.StoreUOM
inner join Base_UOM_Trl as uomTrl on uom.ID=uomTrl.ID and uomTrl.SysMLFlag='zh-CN'
where whQoh.ItemInfo_ItemID='{0}' and lot.DescFlexSegments_PubDescSeg1='{1}' and whQoh.StoreQty!=0 
group by whQoh.ItemInfo_ItemID,
    whQoh.ItemInfo_ItemCode,
    whQoh.ItemInfo_ItemName,
    lot.LotCode,
    lot.DescFlexSegments_PubDescSeg1,
    wh.Name,
    uomTrl.Name,
    uom.Round_Precision,
    uom.Round_RoundType,
    uom.Round_RoundValue", bpObj.ItemID, bpObj.SegLength);

            DataSet ds = new DataSet();
            DataAccessor.RunSQL(DatabaseManager.GetCurrentConnection(), sql, null, out ds);
            if (ds == null || ds.Tables.Count == 0 || ds.Tables[0].Rows.Count == 0) return null;

            List<WhQohInfoDTO> whQohInfoDTOs = new List<WhQohInfoDTO>();
            WhQohInfoDTO whQohInfoDTO = null;
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                whQohInfoDTO = new WhQohInfoDTO();
                whQohInfoDTO.ItemID = TypeHelper.ConvertType<long>(dr["ItemInfo_ItemID"], 0);
                whQohInfoDTO.ItemCode = TypeHelper.ConvertType<string>(dr["ItemInfo_ItemCode"], "");
                whQohInfoDTO.ItemName = TypeHelper.ConvertType<string>(dr["ItemInfo_ItemName"], "");
                whQohInfoDTO.Lot = TypeHelper.ConvertType<string>(dr["LotCode"], "");
                whQohInfoDTO.SegLength = TypeHelper.ConvertType<int>(dr["SegLength"], 0);
                whQohInfoDTO.Wh = TypeHelper.ConvertType<string>(dr["wh"], "");
                whQohInfoDTO.StoreQty = TypeHelper.ConvertType<decimal>(dr["StoreQty"], 0);
                whQohInfoDTO.UOM = TypeHelper.ConvertType<string>(dr["uom"], "");
                whQohInfoDTO.UOM_Precision = TypeHelper.ConvertType<int>(dr["Round_Precision"], 0);
                whQohInfoDTO.UOM_RoundType = TypeHelper.ConvertType<int>(dr["Round_RoundType"], 0);
                whQohInfoDTO.UOM_RoundValue = TypeHelper.ConvertType<int>(dr["Round_RoundValue"], 0);
                whQohInfoDTOs.Add(whQohInfoDTO);
            }
            return whQohInfoDTOs;
		}		
	}

	#endregion
	
	
}