





namespace UFIDA.U9.Cust.JSDY.BarCode
{
	using System;
	using System.Collections.Generic;
	using System.Text;
	using System.Reflection;
	using UFSoft.UBF.AopFrame; 	

	/// <summary>
	/// 获取登录用户对应的业务员 business operation
	/// 
	/// </summary>
	[Serializable]	
	public partial class GetOperatorsForLoginUser
	{
	    #region Fields
		
	    #endregion
		
	    #region constructor
		public GetOperatorsForLoginUser()
		{}
		
	    #endregion

	    #region member		
	    #endregion
		
	    #region do method 
		[Transaction(UFSoft.UBF.Transactions.TransactionOption.Supported)]
		[Logger]
		[Authorize]
		public UFIDA.U9.Cust.JSDY.BarCode.OperatorsDTO Do()
		{	
		    BaseStrategy selector = Select();	
				UFIDA.U9.Cust.JSDY.BarCode.OperatorsDTO result =  (UFIDA.U9.Cust.JSDY.BarCode.OperatorsDTO)selector.Execute(this);	
		    
			return result ; 
		}			
	    #endregion 					
	} 		
}
