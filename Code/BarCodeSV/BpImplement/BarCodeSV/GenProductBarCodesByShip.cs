





namespace UFIDA.U9.Cust.JSDY.BarCode
{
	using System;
	using System.Collections.Generic;
	using System.Text;
	using System.Reflection;
	using UFSoft.UBF.AopFrame; 	

	/// <summary>
	/// 根据出货计划生成成品条码记录 business operation
	/// 
	/// </summary>
	[Serializable]	
	public partial class GenProductBarCodesByShip
	{
	    #region Fields
		private List<UFIDA.U9.Cust.JSDY.BarCode.ProductBarCodeByShipDTO> productBarCodeDTOs;
		
	    #endregion
		
	    #region constructor
		public GenProductBarCodesByShip()
		{}
		
	    #endregion

	    #region member		
		/// <summary>
		/// 出货条码记录DTO	
		/// 根据出货计划生成成品条码记录.Misc.出货条码记录DTO
		/// </summary>
		/// <value></value>
		public List<UFIDA.U9.Cust.JSDY.BarCode.ProductBarCodeByShipDTO> ProductBarCodeDTOs
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
