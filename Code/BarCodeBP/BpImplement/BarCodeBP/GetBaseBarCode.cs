





namespace UFIDA.U9.Cust.JSDY.BarCode
{
	using System;
	using System.Collections.Generic;
	using System.Text;
	using System.Reflection;
	using UFSoft.UBF.AopFrame; 	

	/// <summary>
	/// 获取条码基础部分 business operation
	/// 
	/// </summary>
	[Serializable]	
	public partial class GetBaseBarCode
	{
	    #region Fields
		private System.String itemCode;
		private System.Int32 segLength;
		private System.String operatorCode;
		private System.DateTime businessDate;
		
	    #endregion
		
	    #region constructor
		public GetBaseBarCode()
		{}
		
	    #endregion

	    #region member		
		/// <summary>
		/// 料号	
		/// 获取条码基础部分.Misc.料号
		/// </summary>
		/// <value></value>
		public System.String ItemCode
		{
			get
			{
				return this.itemCode;
			}
			set
			{
				itemCode = value;
			}
		}
		/// <summary>
		/// 段长	
		/// 获取条码基础部分.Misc.段长
		/// </summary>
		/// <value></value>
		public System.Int32 SegLength
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
		/// <summary>
		/// 检验员代号	
		/// 获取条码基础部分.Misc.检验员代号
		/// </summary>
		/// <value></value>
		public System.String OperatorCode
		{
			get
			{
				return this.operatorCode;
			}
			set
			{
				operatorCode = value;
			}
		}
		/// <summary>
		/// 日期	
		/// 获取条码基础部分.Misc.日期
		/// </summary>
		/// <value></value>
		public System.DateTime BusinessDate
		{
			get
			{
				return this.businessDate;
			}
			set
			{
				businessDate = value;
			}
		}
	    #endregion
		
	    #region do method 
		[Transaction(UFSoft.UBF.Transactions.TransactionOption.Supported)]
		[Logger]
		[Authorize]
		public System.String Do()
		{	
		    BaseStrategy selector = Select();	
				System.String result =  (System.String)selector.Execute(this);	
		    
			return result ; 
		}			
	    #endregion 					
	} 		
}
