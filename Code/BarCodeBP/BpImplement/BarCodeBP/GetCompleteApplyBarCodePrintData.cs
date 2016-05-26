





namespace UFIDA.U9.Cust.JSDY.BarCode
{
	using System;
	using System.Collections.Generic;
	using System.Text;
	using System.Reflection;
	using UFSoft.UBF.AopFrame; 	

	/// <summary>
	/// 获取完工申报条码打印数据 business operation
	/// 
	/// </summary>
	[Serializable]	
	public partial class GetCompleteApplyBarCodePrintData
	{
	    #region Fields
		private List<System.String> completeApplyBarCodeIDs;
		
	    #endregion
		
	    #region constructor
		public GetCompleteApplyBarCodePrintData()
		{}
		
	    #endregion

	    #region member		
		/// <summary>
		/// 完工申报条码ID列表	
		/// 获取完工申报条码打印数据.Misc.完工申报条码ID列表
		/// </summary>
		/// <value></value>
		public List<System.String> CompleteApplyBarCodeIDs
		{
			get
			{
				return this.completeApplyBarCodeIDs;
			}
			set
			{
				completeApplyBarCodeIDs = value;
			}
		}
	    #endregion
		
	    #region do method 
		[Transaction(UFSoft.UBF.Transactions.TransactionOption.Supported)]
		[Logger]
		[Authorize]
		public List<UFIDA.U9.Cust.JSDY.BarCode.CompleteApplyBarCodeDTO> Do()
		{	
		    BaseStrategy selector = Select();	
				List<UFIDA.U9.Cust.JSDY.BarCode.CompleteApplyBarCodeDTO> result =  (List<UFIDA.U9.Cust.JSDY.BarCode.CompleteApplyBarCodeDTO>)selector.Execute(this);	
		    
			return result ; 
		}			
	    #endregion 					
	} 		
}
