



#region Using directives

using System;
using System.Collections.Generic;
using System.Text;

#endregion

namespace UFIDA.U9.Cust.JSDY.BarCode {

	public partial class CompleteApplyBarCodeDTO{

		#region Constructor
		/// <summary>
		/// Constructor with Full Argument 
		/// </summary>
		public CompleteApplyBarCodeDTO(  System.String barCode  , System.String itemCode  , System.String itemName  , System.String itemSPECS  , System.Int32 actualLength  , System.Int32 markingLength  , System.String operatorsCode  , System.String operatorsName  , System.Int64 operatorsID  , System.Int64 itemID  , System.Int64 barCodeID  )
		{
			this.BarCode = barCode;
			this.ItemCode = itemCode;
			this.ItemName = itemName;
			this.ItemSPECS = itemSPECS;
			this.ActualLength = actualLength;
			this.MarkingLength = markingLength;
			this.OperatorsCode = operatorsCode;
			this.OperatorsName = operatorsName;
			this.OperatorsID = operatorsID;
			this.ItemID = itemID;
			this.BarCodeID = barCodeID;
		}
		#endregion	






		#region Model Methods
		#endregion

	}
}
