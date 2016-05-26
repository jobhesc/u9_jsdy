



#region Using directives

using System;
using System.Collections.Generic;
using System.Text;

#endregion

namespace UFIDA.U9.Cust.JSDY.BarCode {

	public partial class CheckBarCodeDTO{

		#region Constructor
		/// <summary>
		/// Constructor with Full Argument 
		/// </summary>
		public CheckBarCodeDTO(  System.Int64 orgID  , System.Int64 itemID  , System.String barCode  , System.Int32 actualLength  , System.DateTime checkedOn  , System.String checkedBy  )
		{
			this.OrgID = orgID;
			this.ItemID = itemID;
			this.BarCode = barCode;
			this.ActualLength = actualLength;
			this.CheckedOn = checkedOn;
			this.CheckedBy = checkedBy;
		}
		#endregion	






		#region Model Methods
		#endregion

	}
}
