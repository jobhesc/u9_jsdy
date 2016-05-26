namespace UFIDA.U9.Cust.JSDY.BarCode
{
	using System;
	using System.Collections.Generic;
	using System.Text; 
	using UFSoft.UBF.AopFrame;	
	using UFSoft.UBF.Util.Context;

	/// <summary>
	/// GetBarCodeFlowNo partial 
	/// </summary>	
	public partial class GetBarCodeFlowNo 
	{	
		internal BaseStrategy Select()
		{
			return new GetBarCodeFlowNoImpementStrategy();	
		}		
	}
	
	#region  implement strategy	
	/// <summary>
	/// Impement Implement
	/// 
	/// </summary>	
	internal partial class GetBarCodeFlowNoImpementStrategy : BaseStrategy
	{
		public GetBarCodeFlowNoImpementStrategy() { }

		public override object Do(object obj)
		{						
			GetBarCodeFlowNo bpObj = (GetBarCodeFlowNo)obj;
            return ProductBarCode.GetBarCodeFlowNo(bpObj.BaseBarCode);
		}		
	}

	#endregion
	
	
}