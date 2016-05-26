





namespace UFIDA.U9.Cust.JSDY.BarCode
{
	using System;
	using System.Collections.Generic;
	using System.Text;
	using System.Reflection;
	using UFSoft.UBF.AopFrame; 	

	/// <summary>
	/// 生成盘点条码记录 business operation
	/// 
	/// </summary>
	[Serializable]	
	public partial class GenCheckBarCodes
	{
	    #region Fields
		private List<UFIDA.U9.Cust.JSDY.BarCode.CheckBarCodeDTO> checkBarCodeDTOs;
		
	    #endregion
		
	    #region constructor
		public GenCheckBarCodes()
		{}
		
	    #endregion

	    #region member		
		/// <summary>
		/// 盘点条码记录DTO	
		/// 生成盘点条码记录.Misc.盘点条码记录DTO
		/// </summary>
		/// <value></value>
		public List<UFIDA.U9.Cust.JSDY.BarCode.CheckBarCodeDTO> CheckBarCodeDTOs
		{
			get
			{
				return this.checkBarCodeDTOs;
			}
			set
			{
				checkBarCodeDTOs = value;
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
