



#region Using directives

using System;
using System.Collections.Generic;
using System.Text;

#endregion

namespace UFIDA.U9.Cust.JSDY.BarCode {

	public partial class ProductBarCodeByShipDTO{

		#region Constructor
		/// <summary>
		/// Constructor with Full Argument 
		/// </summary>
		public ProductBarCodeByShipDTO(  System.Int64 orgID  , System.Int64 itemID  , System.String barCode  , System.Int32 actualLength  , System.Int64 qcOperator  , System.Int64 shipPlan  , System.Int64 shipPlanLine  , System.DateTime scanOn  , System.String scanBy  , System.Int64 sOShipLine  )
		{
			this.OrgID = orgID;
			this.ItemID = itemID;
			this.BarCode = barCode;
			this.ActualLength = actualLength;
			this.QcOperator = qcOperator;
			this.ShipPlan = shipPlan;
			this.ShipPlanLine = shipPlanLine;
			this.ScanOn = scanOn;
			this.ScanBy = scanBy;
			this.SOShipLine = sOShipLine;
		}
		#endregion	






		#region Model Methods
		#endregion

	}
}
