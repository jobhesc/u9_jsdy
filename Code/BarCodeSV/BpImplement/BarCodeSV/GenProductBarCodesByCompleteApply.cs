





namespace UFIDA.U9.Cust.JSDY.BarCode
{
	using System;
	using System.Collections.Generic;
	using System.Text;
	using System.Reflection;
	using UFSoft.UBF.AopFrame; 	

	/// <summary>
	/// 根据完工申报单生成成品条码记录 business operation
	/// 
	/// </summary>
	[Serializable]	
	public partial class GenProductBarCodesByCompleteApply
	{
	    #region Fields
		private List<UFIDA.U9.Cust.JSDY.BarCode.ProductBarCodeByCompleteApplyDTO> productBarCodeDTOs;
		
	    #endregion
		
	    #region constructor
		public GenProductBarCodesByCompleteApply()
		{}
		
	    #endregion

	    #region member		
		/// <summary>
		/// 成品条码记录DTO	
		/// 根据完工申报单生成成品条码记录.Misc.成品条码记录DTO
		/// </summary>
		/// <value></value>
		public List<UFIDA.U9.Cust.JSDY.BarCode.ProductBarCodeByCompleteApplyDTO> ProductBarCodeDTOs
		{
			get
			{
				return this.productBarCodeDTOs;
			}
			set
			{
				productBarCodeDTOs = value;
			}
		}
	    #endregion
		
	    #region do method 
		[Transaction(UFSoft.UBF.Transactions.TransactionOption.Required)]
		[Logger]
		[Authorize]
		public void Do()
		{	
		    BaseStrategy selector = Select();	
				selector.Execute(this);
		    
		}			
	    #endregion 					
	} 		
}
