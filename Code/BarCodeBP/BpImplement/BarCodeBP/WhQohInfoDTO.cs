


using System;
using System.Collections.Generic;
using System.Collections;
using System.Runtime.Serialization;

namespace UFIDA.U9.Cust.JSDY.BarCode
{
	/// <summary>
	/// 库存量信息DTO DTO :自定义的数据传输类型 
	/// 
	/// </summary>
	public  partial class WhQohInfoDTO  : UFSoft.UBF.Business.DTOBase
	{
		#region Constructor
		
		/// <summary>
		/// Constructor
		/// </summary>
		public WhQohInfoDTO(){
			initData();
		}
		private void initData()
		{
					ItemID = 0; 
		
		
		
		
					SegLength = 0; 
					StoreQty = 0m; 
		
					UOM_Precision = 0; 
					UOM_RoundType = 0; 
					UOM_RoundValue = 0; 

		}

		#endregion
		
		#region Properties
			/// <summary>
		/// 料品ID (该属性可为空,但有默认值)
		/// 库存量信息DTO.Misc.料品ID
		/// </summary>
		/// <value>System.Int64</value>
		public System.Int64 ItemID
		{
			get	
			{	
				return (System.Int64)base.GetValue("ItemID",typeof(System.Int64));
			}

			 set	
			{
				base.SetValue("ItemID",value);
			}
		}
				/// <summary>
		/// 料号 (该属性可为空,且无默认值)
		/// 库存量信息DTO.Misc.料号
		/// </summary>
		/// <value>System.String</value>
		public System.String ItemCode
		{
			get	
			{	
				return (System.String)base.GetValue("ItemCode",typeof(System.String));
			}

			 set	
			{
				base.SetValue("ItemCode",value);
			}
		}
				/// <summary>
		/// 品名 (该属性可为空,且无默认值)
		/// 库存量信息DTO.Misc.品名
		/// </summary>
		/// <value>System.String</value>
		public System.String ItemName
		{
			get	
			{	
				return (System.String)base.GetValue("ItemName",typeof(System.String));
			}

			 set	
			{
				base.SetValue("ItemName",value);
			}
		}
				/// <summary>
		/// 仓库 (该属性可为空,且无默认值)
		/// 库存量信息DTO.Misc.仓库
		/// </summary>
		/// <value>System.String</value>
		public System.String Wh
		{
			get	
			{	
				return (System.String)base.GetValue("Wh",typeof(System.String));
			}

			 set	
			{
				base.SetValue("Wh",value);
			}
		}
				/// <summary>
		/// 批号 (该属性可为空,且无默认值)
		/// 库存量信息DTO.Misc.批号
		/// </summary>
		/// <value>System.String</value>
		public System.String Lot
		{
			get	
			{	
				return (System.String)base.GetValue("Lot",typeof(System.String));
			}

			 set	
			{
				base.SetValue("Lot",value);
			}
		}
				/// <summary>
		/// 段长 (该属性可为空,但有默认值)
		/// 库存量信息DTO.Misc.段长
		/// </summary>
		/// <value>System.Int32</value>
		public System.Int32 SegLength
		{
			get	
			{	
				return (System.Int32)base.GetValue("SegLength",typeof(System.Int32));
			}

			 set	
			{
				base.SetValue("SegLength",value);
			}
		}
				/// <summary>
		/// 库存量 (该属性可为空,但有默认值)
		/// 库存量信息DTO.Misc.库存量
		/// </summary>
		/// <value>System.Decimal</value>
		public System.Decimal StoreQty
		{
			get	
			{	
				return (System.Decimal)base.GetValue("StoreQty",typeof(System.Decimal));
			}

			 set	
			{
				base.SetValue("StoreQty",value);
			}
		}
				/// <summary>
		/// 单位 (该属性可为空,且无默认值)
		/// 库存量信息DTO.Misc.单位
		/// </summary>
		/// <value>System.String</value>
		public System.String UOM
		{
			get	
			{	
				return (System.String)base.GetValue("UOM",typeof(System.String));
			}

			 set	
			{
				base.SetValue("UOM",value);
			}
		}
				/// <summary>
		/// 单位精度 (该属性可为空,但有默认值)
		/// 库存量信息DTO.Misc.单位精度
		/// </summary>
		/// <value>System.Int32</value>
		public System.Int32 UOM_Precision
		{
			get	
			{	
				return (System.Int32)base.GetValue("UOM_Precision",typeof(System.Int32));
			}

			 set	
			{
				base.SetValue("UOM_Precision",value);
			}
		}
				/// <summary>
		/// 单位舍入类型 (该属性可为空,但有默认值)
		/// 库存量信息DTO.Misc.单位舍入类型
		/// </summary>
		/// <value>System.Int32</value>
		public System.Int32 UOM_RoundType
		{
			get	
			{	
				return (System.Int32)base.GetValue("UOM_RoundType",typeof(System.Int32));
			}

			 set	
			{
				base.SetValue("UOM_RoundType",value);
			}
		}
				/// <summary>
		/// 单位舍入值 (该属性可为空,但有默认值)
		/// 库存量信息DTO.Misc.单位舍入值
		/// </summary>
		/// <value>System.Int32</value>
		public System.Int32 UOM_RoundValue
		{
			get	
			{	
				return (System.Int32)base.GetValue("UOM_RoundValue",typeof(System.Int32));
			}

			 set	
			{
				base.SetValue("UOM_RoundValue",value);
			}
		}
		
		#endregion	
		#region Multi_Fields
											
		#endregion 

		#region ModelResource
		/// <summary>
		/// 库存量信息DTO的显示名称资源--已经废弃，不使用.
		/// </summary>
		public string Res_TypeName {	get {return "" ;}	}
		/// <summary>
		/// 料品ID的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_ItemID　{ get { return "";　}　}
		/// <summary>
		/// 料号的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_ItemCode　{ get { return "";　}　}
		/// <summary>
		/// 品名的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_ItemName　{ get { return "";　}　}
		/// <summary>
		/// 仓库的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_Wh　{ get { return "";　}　}
		/// <summary>
		/// 批号的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_Lot　{ get { return "";　}　}
		/// <summary>
		/// 段长的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_SegLength　{ get { return "";　}　}
		/// <summary>
		/// 库存量的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_StoreQty　{ get { return "";　}　}
		/// <summary>
		/// 单位的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_UOM　{ get { return "";　}　}
		/// <summary>
		/// 单位精度的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_UOM_Precision　{ get { return "";　}　}
		/// <summary>
		/// 单位舍入类型的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_UOM_RoundType　{ get { return "";　}　}
		/// <summary>
		/// 单位舍入值的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_UOM_RoundValue　{ get { return "";　}　}
		#endregion 




		#region EntityData exchange
		
		#region  Do SerializeKey -ForDTOType
		//反序化Key到Data的ID中　－－由FromEntityData自动调用，不处理层次关系
		private void DeSerializeKey(WhQohInfoDTOData data)
		{
		











		}

		#endregion 
		
		/// <summary>
		/// Copy Entity From EntityData
		/// </summary>
		public void FromEntityData(WhQohInfoDTOData data)
		{
			this.FromEntityData(data,new Hashtable());
		}
		//used by ubf..
		public void FromEntityData(WhQohInfoDTOData data,IDictionary dict)
		{
			if (data == null)
				return;
			if (dict == null ) dict = new Hashtable() ;
			dict[data] = this;
			DeSerializeKey(data);
		
			this.ItemID = data.ItemID;

			this.ItemCode = data.ItemCode;

			this.ItemName = data.ItemName;

			this.Wh = data.Wh;

			this.Lot = data.Lot;

			this.SegLength = data.SegLength;

			this.StoreQty = data.StoreQty;

			this.UOM = data.UOM;

			this.UOM_Precision = data.UOM_Precision;

			this.UOM_RoundType = data.UOM_RoundType;

			this.UOM_RoundValue = data.UOM_RoundValue;

		}

		/// <summary>
		/// Create EntityData From Entity
		/// </summary>
		public WhQohInfoDTOData ToEntityData()
		{
			return ToEntityData(null,new Hashtable());
		}
		/// <summary>
		/// Create EntityData From Entity - used by ubf 
		/// </summary>
		public WhQohInfoDTOData ToEntityData(WhQohInfoDTOData data, IDictionary dict){
			if (data == null)
				data = new WhQohInfoDTOData();
			if (dict == null ) 
				dict = new Hashtable() ;
			else
            {
                if (dict.Contains(this))
                {
                    data = (WhQohInfoDTOData)dict[this];
                    return data;
                }
            }
			dict[this] = data;
		
			data.ItemID = this.ItemID;

			data.ItemCode = this.ItemCode;

			data.ItemName = this.ItemName;

			data.Wh = this.Wh;

			data.Lot = this.Lot;

			data.SegLength = this.SegLength;

			data.StoreQty = this.StoreQty;

			data.UOM = this.UOM;

			data.UOM_Precision = this.UOM_Precision;

			data.UOM_RoundType = this.UOM_RoundType;

			data.UOM_RoundValue = this.UOM_RoundValue;

			return data ;
		}

		#endregion	
	}	
	
}