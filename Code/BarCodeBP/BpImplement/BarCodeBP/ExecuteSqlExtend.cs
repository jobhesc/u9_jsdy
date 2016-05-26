namespace UFIDA.U9.Cust.JSDY.BarCode
{
	using System;
	using System.Collections.Generic;
	using System.Text; 
	using UFSoft.UBF.AopFrame;	
	using UFSoft.UBF.Util.Context;
    using UFSoft.UBF.Util.DataAccess;
    using UFSoft.UBF.Sys.Database;

	/// <summary>
	/// ExecuteSql partial 
	/// </summary>	
	public partial class ExecuteSql 
	{	
		internal BaseStrategy Select()
		{
			return new ExecuteSqlImpementStrategy();	
		}		
	}
	
	#region  implement strategy	
	/// <summary>
	/// Impement Implement
	/// 
	/// </summary>	
	internal partial class ExecuteSqlImpementStrategy : BaseStrategy
	{
		public ExecuteSqlImpementStrategy() { }

		public override object Do(object obj)
		{						
			ExecuteSql bpObj = (ExecuteSql)obj;
            DataAccessor.RunSQL(DatabaseManager.GetCurrentConnection(), bpObj.Sql, null);
            return null;
		}		
	}

	#endregion
	
	
}