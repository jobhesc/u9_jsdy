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
	/// GetCompleteApplyBarCodePrintData partial 
	/// </summary>	
	public partial class GetCompleteApplyBarCodePrintData 
	{	
		internal BaseStrategy Select()
		{
			return new GetCompleteApplyBarCodePrintDataImpementStrategy();	
		}		
	}
	
	#region  implement strategy	
	/// <summary>
	/// Impement Implement
	/// 
	/// </summary>	
	internal partial class GetCompleteApplyBarCodePrintDataImpementStrategy : BaseStrategy
	{
		public GetCompleteApplyBarCodePrintDataImpementStrategy() { }

		public override object Do(object obj)
		{						
			GetCompleteApplyBarCodePrintData bpObj = (GetCompleteApplyBarCodePrintData)obj;
            if (bpObj.CompleteApplyBarCodeIDs == null || bpObj.CompleteApplyBarCodeIDs.Count == 0) return null;

            string sql = string.Format(@"
select barcode.ID as BarCodeID,
	barcode.BarCode as BarCode,
	barcode.ActualLength,
	barcode.MarkingLength,
	item.ID as ItemID,
	item.Code as ItemCode,
	item.Name as ItemName,
	item.SPECS as ItemSPECS,
	op.ID as OperatorsID,
	op.Code as OperatorsCode,
	opTrl.Name as OperatorsName
from Cust_CompleteApplyBarCode barcode
inner join CBO_ItemMaster as item on barcode.Item=item.ID
left join CBO_Operators as op on barcode.Operators=op.ID
left join CBO_Operators_Trl as opTrl on op.ID=opTrl.ID and opTrl.SysMLFlag='zh-CN'
where barcode.ID in ({0})", string.Join(",", bpObj.CompleteApplyBarCodeIDs.ToArray()));

            DataSet dataset = new DataSet();
            DataAccessor.RunSQL(DatabaseManager.GetCurrentConnection(), sql, null, out dataset);
            if (dataset == null || dataset.Tables.Count == 0 || dataset.Tables[0].Rows.Count == 0) return null;

            List<CompleteApplyBarCodeDTO> barCodeDTOs = new List<CompleteApplyBarCodeDTO>();
            foreach (DataRow dataRow in dataset.Tables[0].Rows)
            {
                CompleteApplyBarCodeDTO barCodeDTO = new CompleteApplyBarCodeDTO();
                barCodeDTO.ActualLength = TypeHelper.ConvertType<int>(dataRow["ActualLength"], 0);
                barCodeDTO.MarkingLength = TypeHelper.ConvertType<int>(dataRow["MarkingLength"], 0);
                barCodeDTO.BarCodeID = TypeHelper.ConvertType<long>(dataRow["BarCodeID"], 0);
                barCodeDTO.BarCode = TypeHelper.ConvertType<string>(dataRow["BarCode"], "");
                
                barCodeDTO.ItemID = TypeHelper.ConvertType<long>(dataRow["ItemID"], 0);
                barCodeDTO.ItemCode = TypeHelper.ConvertType<string>(dataRow["ItemCode"], "");
                barCodeDTO.ItemName = TypeHelper.ConvertType<string>(dataRow["ItemName"], "");
                barCodeDTO.ItemSPECS = TypeHelper.ConvertType<string>(dataRow["ItemSPECS"], "");

                barCodeDTO.OperatorsID = TypeHelper.ConvertType<long>(dataRow["OperatorsID"], 0);
                barCodeDTO.OperatorsCode = TypeHelper.ConvertType<string>(dataRow["OperatorsCode"], "");
                barCodeDTO.OperatorsName = TypeHelper.ConvertType<string>(dataRow["OperatorsName"], "");

                barCodeDTOs.Add(barCodeDTO);
            }
            return barCodeDTOs;
		}		
	}

	#endregion
	
	
}