namespace UFIDA.U9.Cust.JSDY.BarCode
{
	using System;
	using System.Collections.Generic;
	using System.Text; 
	using UFSoft.UBF.AopFrame;	
	using UFSoft.UBF.Util.Context;
    using System.Data;
    using UFSoft.UBF.Util.DataAccess;
    using UFSoft.UBF.Sys.Database;
    using UFSoft.UBF.Business;
    using UFIDA.U9.Base.Organization;
    using UFIDA.U9.CBO.SCM.Item;

	/// <summary>
	/// GenCheckBarCodes partial 
	/// </summary>	
	public partial class GenCheckBarCodes 
	{	
		internal BaseStrategy Select()
		{
			return new GenCheckBarCodesImpementStrategy();	
		}		
	}
	
	#region  implement strategy	
	/// <summary>
	/// Impement Implement
	/// 
	/// </summary>	
	internal partial class GenCheckBarCodesImpementStrategy : BaseStrategy
	{
		public GenCheckBarCodesImpementStrategy() { }

		public override object Do(object obj)
		{						
			GenCheckBarCodes bpObj = (GenCheckBarCodes)obj;
            if (bpObj.CheckBarCodeDTOs == null || bpObj.CheckBarCodeDTOs.Count == 0) return null;
            long orgID = bpObj.CheckBarCodeDTOs[0].OrgID;

            using (Session s = Session.Open())
            {
                foreach (CheckBarCodeDTO dto in bpObj.CheckBarCodeDTOs)
                {
                    CheckBarCode be = CheckBarCode.Create();
                    be.OrgKey = new Organization.EntityKey(dto.OrgID);
                    be.ItemKey = new ItemMaster.EntityKey(dto.ItemID);
                    be.BarCode = dto.BarCode;
                    be.ActualLength = dto.ActualLength;
                    be.CheckedBy = dto.CheckedBy;
                    be.CheckedOn = dto.CheckedOn;
                }
                s.Commit();
            }

            return null;
		}
	}

	#endregion
	
	
}