





namespace UFIDA.U9.Cust.JSDY.BarCode
{
	using System;
	using System.Collections.Generic;
	using System.Text;
	using System.Reflection;
	using UFSoft.UBF.AopFrame; 	

	/// <summary>
	/// 获取条码流水号 business operation
	/// 
	/// </summary>
	[Serializable]	
	public partial class GetBarCodeFlowNo
	{
	    #region Fields
		private System.String baseBarCode;
		
	    #endregion
		
	    #region constructor
		public GetBarCodeFlowNo()
		{}
		
	    #endregion

	    #region member		
		/// <summary>
		/// 条码基础部分	
		/// 获取条码流水号.Misc.条码基础部分
		/// </summary>
		/// <value></value>
		public System.String BaseBarCode
		{
			get
			{
				return this.baseBarCode;
			}
			set
			{
				baseBarCode = value;
			}
		}
	    #endregion
		
	    #region do method 
		[Transaction(UFSoft.UBF.Transactions.TransactionOption.Supported)]
		[Logger]
		[Authorize]
		public System.Int32 Do()
		{	
		    BaseStrategy selector = Select();	
				System.Int32 result =  (System.Int32)selector.Execute(this);	
		    
			return result ; 
		}			
	    #endregion 					
	} 		
}
