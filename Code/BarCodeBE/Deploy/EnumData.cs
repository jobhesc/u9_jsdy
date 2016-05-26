using System;
using System.Collections.Generic;
using System.Text;
using UFSoft.UBF.Business;

namespace UFIDA.U9.Cust.JSDY.BarCode
{
	/// <summary>
	/// 枚举值: 条码状态 
	/// 
	/// </summary>
	//枚举可以考虑加基类，目前不改也没影响。
	public enum ProductBarCodeKindEnumData
	{
		/// <summary>
		/// 入库
		/// </summary>
		Rcv = 0,
		/// <summary>
		/// 出库
		/// </summary>
		Ship = 1,
		/// <summary>
		/// 销售退回
		/// </summary>
		RMR = 2,
		/// <summary>
		/// 空值(-1)
		/// </summary>
		Empty  = -1 
	}
}

