





namespace UFIDA.U9.Cust.JSDY.BarCode
{
	using System;
	using System.Collections.Generic;
	using System.Text;
	using System.Reflection;
	using UFSoft.UBF.AopFrame; 	

	/// <summary>
	/// 执行sql语句 business operation
	/// 
	/// </summary>
	[Serializable]	
	public partial class ExecuteSql
	{
	    #region Fields
		private System.String sql;
		
	    #endregion
		
	    #region constructor
		public ExecuteSql()
		{}
		
	    #endregion

	    #region member		
		/// <summary>
		/// sql语句	
		/// 执行sql语句.Misc.sql语句
		/// </summary>
		/// <value></value>
		public System.String Sql
		{
			get
			{
				return this.sql;
			}
			set
			{
				sql = value;
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
