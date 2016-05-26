





namespace UFIDA.U9.Cust.JSDY.BarCode
{
	using System;
	using System.Collections.Generic;
	using System.Text;
	using System.Reflection;
	using UFSoft.UBF.AopFrame; 	

	/// <summary>
	/// 根据退回处理单生成成品条码记录 business operation
	/// 
	/// </summary>
	[Serializable]	
	public partial class GenProductBarCodesByRMA
	{
	    #region Fields
		private List<UFIDA.U9.Cust.JSDY.BarCode.ProductBarCodeByRMADTO> productBarCodeDTOs;
		
	    #endregion
		
	    #region constructor
		public GenProductBarCodesByRMA()
		{}
		
	    #endregion

	    #region member		
		/// <summary>
		/// 退货条码记录DTO	
		/// 根据退回处理单生成成品条码记录.Misc.退货条码记录DTO
		/// </summary>
		/// <value></value>
		public List<UFIDA.U9.Cust.JSDY.BarCode.ProductBarCodeByRMADTO> ProductBarCodeDTOs
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
