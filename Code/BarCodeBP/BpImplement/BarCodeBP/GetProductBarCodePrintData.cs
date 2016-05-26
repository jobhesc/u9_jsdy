





namespace UFIDA.U9.Cust.JSDY.BarCode
{
	using System;
	using System.Collections.Generic;
	using System.Text;
	using System.Reflection;
	using UFSoft.UBF.AopFrame; 	

	/// <summary>
	/// 获取成品条码打印数据 business operation
	/// 
	/// </summary>
	[Serializable]	
	public partial class GetProductBarCodePrintData
	{
	    #region Fields
		private List<System.String> productBarCodeIDs;
		
	    #endregion
		
	    #region constructor
		public GetProductBarCodePrintData()
		{}
		
	    #endregion

	    #region member		
		/// <summary>
		/// 成品条码ID列表	
		/// 获取成品条码打印数据.Misc.成品条码ID列表
		/// </summary>
		/// <value></value>
		public List<System.String> ProductBarCodeIDs
		{
			get
			{
				return this.productBarCodeIDs;
			}
			set
			{
				productBarCodeIDs = value;
			}
		}
	    #endregion
		
	    #region do method 
		[Transaction(UFSoft.UBF.Transactions.TransactionOption.Supported)]
		[Logger]
		[Authorize]
		public List<UFIDA.U9.Cust.JSDY.BarCode.ProductBarCodeDTO> Do()
		{	
		    BaseStrategy selector = Select();	
				List<UFIDA.U9.Cust.JSDY.BarCode.ProductBarCodeDTO> result =  (List<UFIDA.U9.Cust.JSDY.BarCode.ProductBarCodeDTO>)selector.Execute(this);	
		    
			return result ; 
		}			
	    #endregion 					
	} 		
}
