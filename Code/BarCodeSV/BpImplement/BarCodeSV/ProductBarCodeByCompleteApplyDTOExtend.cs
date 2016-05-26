



#region Using directives

using System;
using System.Collections.Generic;
using System.Text;

#endregion

namespace UFIDA.U9.Cust.JSDY.BarCode {

	public partial class ProductBarCodeByCompleteApplyDTO{

		#region Constructor
		/// <summary>
		/// Constructor with Full Argument 
		/// </summary>
		public ProductBarCodeByCompleteApplyDTO(  System.Int64 orgID  , System.Int64 itemID  , System.String barCode  , System.Int32 actualLength  , System.Int64 qcOperator  , System.Int64 completeApplyDoc  , System.Int64 completeApplyDocLine  , System.String scanBy  , System.DateTime scanOn  )
		{
			this.OrgID = orgID;
			this.ItemID = itemID;
			this.BarCode = barCode;
			this.ActualLength = actualLength;
			this.QcOperator = qcOperator;
			this.CompleteApplyDoc = completeApplyDoc;
			this.CompleteApplyDocLine = completeApplyDocLine;
			this.ScanBy = scanBy;
			this.ScanOn = scanOn;
		}
		#endregion	






		#region Model Methods
		#endregion

	}
}
