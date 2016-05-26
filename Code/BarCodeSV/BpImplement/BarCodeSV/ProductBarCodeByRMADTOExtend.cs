



#region Using directives

using System;
using System.Collections.Generic;
using System.Text;

#endregion

namespace UFIDA.U9.Cust.JSDY.BarCode {

	public partial class ProductBarCodeByRMADTO{

		#region Constructor
		/// <summary>
		/// Constructor with Full Argument 
		/// </summary>
		public ProductBarCodeByRMADTO(  System.Int64 orgID  , System.Int64 itemID  , System.String barCode  , System.Int32 actualLength  , System.Int64 qcOperator  , System.Int64 rMA  , System.Int64 rMALine  )
		{
			this.OrgID = orgID;
			this.ItemID = itemID;
			this.BarCode = barCode;
			this.ActualLength = actualLength;
			this.QcOperator = qcOperator;
			this.RMA = rMA;
			this.RMALine = rMALine;
		}
		#endregion	






		#region Model Methods
		#endregion

	}
}
