namespace UFIDA.U9.Cust.JSDY.BarCode
{
	using System;
	using System.Collections.Generic;
	using System.Text; 
	using UFSoft.UBF.AopFrame;	
	using UFSoft.UBF.Util.Context;
    using System.Data;
    using UFSoft.UBF.Util.DataAccess;
    using UFSoft.UBF.Sys.Database;

	/// <summary>
	/// GetProductBarCodePrintData partial 
	/// </summary>	
	public partial class GetProductBarCodePrintData 
	{	
		internal BaseStrategy Select()
		{
			return new GetProductBarCodePrintDataImpementStrategy();	
		}		
	}
	
	#region  implement strategy	
	/// <summary>
	/// Impement Implement
	/// 
	/// </summary>	
	internal partial class GetProductBarCodePrintDataImpementStrategy : BaseStrategy
	{
		public GetProductBarCodePrintDataImpementStrategy() { }

		public override object Do(object obj)
		{						
			GetProductBarCodePrintData bpObj = (GetProductBarCodePrintData)obj;

            if (bpObj.ProductBarCodeIDs == null || bpObj.ProductBarCodeIDs.Count == 0) return null;

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
from Cust_ProductBarCode barcode
inner join CBO_ItemMaster as item on barcode.Item=item.ID
left join CBO_Operators as op on barcode.Operators=op.ID
left join CBO_Operators_Trl as opTrl on op.ID=opTrl.ID and opTrl.SysMLFlag='zh-CN'
where barcode.ID in ({0})", string.Join(",", bpObj.ProductBarCodeIDs.ToArray()));

            DataSet dataset = new DataSet();
            DataAccessor.RunSQL(DatabaseManager.GetCurrentConnection(), sql, null, out dataset);
            if (dataset == null || dataset.Tables.Count == 0 || dataset.Tables[0].Rows.Count == 0) return null;

            List<ProductBarCodeDTO> barCodeDTOs = new List<ProductBarCodeDTO>();
            foreach (DataRow dataRow in dataset.Tables[0].Rows)
            {
                ProductBarCodeDTO barCodeDTO = new ProductBarCodeDTO();
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