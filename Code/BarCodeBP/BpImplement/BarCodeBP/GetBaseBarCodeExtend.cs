namespace UFIDA.U9.Cust.JSDY.BarCode
{
	using System;
	using System.Collections.Generic;
	using System.Text; 
	using UFSoft.UBF.AopFrame;	
	using UFSoft.UBF.Util.Context;

	/// <summary>
	/// GetBaseBarCode partial 
	/// </summary>	
	public partial class GetBaseBarCode 
	{	
		internal BaseStrategy Select()
		{
			return new GetBaseBarCodeImpementStrategy();	
		}		
	}
	
	#region  implement strategy	
	/// <summary>
	/// Impement Implement
	/// 
	/// </summary>	
	internal partial class GetBaseBarCodeImpementStrategy : BaseStrategy
	{
		public GetBaseBarCodeImpementStrategy() { }

		public override object Do(object obj)
		{						
			GetBaseBarCode bpObj = (GetBaseBarCode)obj;
            return ProductBarCode.GetBaseBarCode(bpObj.ItemCode, bpObj.SegLength, bpObj.BusinessDate, bpObj.OperatorCode);
		}		
	}

	#endregion
	
	
}