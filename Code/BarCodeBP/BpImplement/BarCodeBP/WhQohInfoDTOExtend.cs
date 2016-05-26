



#region Using directives

using System;
using System.Collections.Generic;
using System.Text;

#endregion

namespace UFIDA.U9.Cust.JSDY.BarCode {

	public partial class WhQohInfoDTO{

		#region Constructor
		/// <summary>
		/// Constructor with Full Argument 
		/// </summary>
		public WhQohInfoDTO(  System.Int64 itemID  , System.String itemCode  , System.String itemName  , System.String wh  , System.String lot  , System.Int32 segLength  , System.Decimal storeQty  , System.String uOM  , System.Int32 uOM_Precision  , System.Int32 uOM_RoundType  , System.Int32 uOM_RoundValue  )
		{
			this.ItemID = itemID;
			this.ItemCode = itemCode;
			this.ItemName = itemName;
			this.Wh = wh;
			this.Lot = lot;
			this.SegLength = segLength;
			this.StoreQty = storeQty;
			this.UOM = uOM;
			this.UOM_Precision = uOM_Precision;
			this.UOM_RoundType = uOM_RoundType;
			this.UOM_RoundValue = uOM_RoundValue;
		}
		#endregion	






		#region Model Methods
		#endregion

	}
}
