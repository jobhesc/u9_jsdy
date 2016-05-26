namespace UFIDA.U9.Cust.JSDY.BarCode
{
	using System;
	using System.Collections.Generic;
	using System.Text; 
	using UFSoft.UBF.AopFrame;	
	using UFSoft.UBF.Util.Context;
    using UFIDA.U9.Base.UserRole;
    using UFIDA.U9.CBO.HR.Operator;

	/// <summary>
	/// GetOperatorsForLoginUser partial 
	/// </summary>	
	public partial class GetOperatorsForLoginUser 
	{	
		internal BaseStrategy Select()
		{
			return new GetOperatorsForLoginUserImpementStrategy();	
		}		
	}
	
	#region  implement strategy	
	/// <summary>
	/// Impement Implement
	/// 
	/// </summary>	
	internal partial class GetOperatorsForLoginUserImpementStrategy : BaseStrategy
	{
		public GetOperatorsForLoginUserImpementStrategy() { }

		public override object Do(object obj)
		{						
			GetOperatorsForLoginUser bpObj = (GetOperatorsForLoginUser)obj;
            User user = User.Finder.FindByID(Base.Context.LoginUserID);
            if (user == null) return null;
            if(user.ContactKey == null) return null;

            Operators operators = Operators.Finder.Find(string.Format("Org={0} and Contact={1}", Base.Context.LoginOrg.ID, user.ContactKey.ID));
            if(operators == null) return null;

            OperatorsDTO dto = new OperatorsDTO();
            dto.OperatorsID = operators.ID;
            dto.OperatorsCode = operators.Code;
            dto.OperatorsName = operators.Name;
            return dto;
		}		
	}

	#endregion
	
	
}