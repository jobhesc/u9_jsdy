





namespace UFIDA.U9.Cust.JSDY.BarCode
{
	using System;
	using System.Collections.Generic;
	using System.Text;
	using System.Reflection;
	using UFSoft.UBF.AopFrame; 	

	/// <summary>
	/// 查询库存量 business operation
	/// 
	/// </summary>
	[Serializable]	
	public partial class QueryWhQoh
	{
	    #region Fields
		private System.String itemID;
		private System.String segLength;
		
	    #endregion
		
	    #region constructor
		public QueryWhQoh()
		{}
		
	    #endregion

	    #region member		
		/// <summary>
		/// 料品ID	
		/// 查询库存量.Misc.料品ID
		/// </summary>
		/// <value></value>
		public System.String ItemID
		{
			get
			{
				return this.itemID;
			}
			set
			{
				itemID = value;
			}
		}
		/// <summary>
		/// 段长	
		/// 查询库存量.Misc.段长
		/// </summary>
		/// <value></value>
		public System.String SegLength
		{
			get
			{
				return this.segLength;
			}
			set
			{
				segLength = value;
			}
		}
	    #endregion
		
	    #region do method 
		[Transaction(UFSoft.UBF.Transactions.TransactionOption.Supported)]
		[Logger]
		[Authorize]
		public List<UFIDA.U9.Cust.JSDY.BarCode.WhQohInfoDTO> Do()
		{	
		    BaseStrategy selector = Select();	
				List<UFIDA.U9.Cust.JSDY.BarCode.WhQohInfoDTO> result =  (List<UFIDA.U9.Cust.JSDY.BarCode.WhQohInfoDTO>)selector.Execute(this);	
		    
			return result ; 
		}			
	    #endregion 					
	} 		
}
