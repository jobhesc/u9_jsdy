


using System;
using System.Collections.Generic;
using System.Collections;
using System.Runtime.Serialization;

namespace UFIDA.U9.Cust.JSDY.BarCode
{
	/// <summary>
	/// 盘点条码记录DTO DTO :自定义的数据传输类型 
	/// 
	/// </summary>
	public  partial class CheckBarCodeDTO  : UFSoft.UBF.Business.DTOBase
	{
		#region Constructor
		
		/// <summary>
		/// Constructor
		/// </summary>
		public CheckBarCodeDTO(){
			initData();
		}
		private void initData()
		{
					OrgID = 0; 
					ItemID = 0; 
		
					ActualLength = 0; 
		
		

		}

		#endregion
		
		#region Properties
			/// <summary>
		/// 组织ID (该属性可为空,但有默认值)
		/// 盘点条码记录DTO.Misc.组织ID
		/// </summary>
		/// <value>System.Int64</value>
		public System.Int64 OrgID
		{
			get	
			{	
				return (System.Int64)base.GetValue("OrgID",typeof(System.Int64));
			}

			 set	
			{
				base.SetValue("OrgID",value);
			}
		}
				/// <summary>
		/// 料品ID (该属性可为空,但有默认值)
		/// 盘点条码记录DTO.Misc.料品ID
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
		/// 条码 (该属性可为空,且无默认值)
		/// 盘点条码记录DTO.Misc.条码
		/// </summary>
		/// <value>System.String</value>
		public System.String BarCode
		{
			get	
			{	
				return (System.String)base.GetValue("BarCode",typeof(System.String));
			}

			 set	
			{
				base.SetValue("BarCode",value);
			}
		}
				/// <summary>
		/// 实际长度 (该属性可为空,但有默认值)
		/// 盘点条码记录DTO.Misc.实际长度
		/// </summary>
		/// <value>System.Int32</value>
		public System.Int32 ActualLength
		{
			get	
			{	
				return (System.Int32)base.GetValue("ActualLength",typeof(System.Int32));
			}

			 set	
			{
				base.SetValue("ActualLength",value);
			}
		}
				/// <summary>
		/// 盘点时间 (该属性可为空,且无默认值)
		/// 盘点条码记录DTO.Misc.盘点时间
		/// </summary>
		/// <value>System.DateTime</value>
		public System.DateTime CheckedOn
		{
			get	
			{	
				return (System.DateTime)base.GetValue("CheckedOn",typeof(System.DateTime));
			}

			 set	
			{
				base.SetValue("CheckedOn",value);
			}
		}
				/// <summary>
		/// 盘点人 (该属性可为空,且无默认值)
		/// 盘点条码记录DTO.Misc.盘点人
		/// </summary>
		/// <value>System.String</value>
		public System.String CheckedBy
		{
			get	
			{	
				return (System.String)base.GetValue("CheckedBy",typeof(System.String));
			}

			 set	
			{
				base.SetValue("CheckedBy",value);
			}
		}
		
		#endregion	
		#region Multi_Fields
						
		#endregion 

		#region ModelResource
		/// <summary>
		/// 盘点条码记录DTO的显示名称资源--已经废弃，不使用.
		/// </summary>
		public string Res_TypeName {	get {return "" ;}	}
		/// <summary>
		/// 组织ID的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_OrgID　{ get { return "";　}　}
		/// <summary>
		/// 料品ID的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_ItemID　{ get { return "";　}　}
		/// <summary>
		/// 条码的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_BarCode　{ get { return "";　}　}
		/// <summary>
		/// 实际长度的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_ActualLength　{ get { return "";　}　}
		/// <summary>
		/// 盘点时间的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_CheckedOn　{ get { return "";　}　}
		/// <summary>
		/// 盘点人的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_CheckedBy　{ get { return "";　}　}
		#endregion 




		#region EntityData exchange
		
		#region  Do SerializeKey -ForDTOType
		//反序化Key到Data的ID中　－－由FromEntityData自动调用，不处理层次关系
		private void DeSerializeKey(CheckBarCodeDTOData data)
		{
		






		}

		#endregion 
		
		/// <summary>
		/// Copy Entity From EntityData
		/// </summary>
		public void FromEntityData(CheckBarCodeDTOData data)
		{
			this.FromEntityData(data,new Hashtable());
		}
		//used by ubf..
		public void FromEntityData(CheckBarCodeDTOData data,IDictionary dict)
		{
			if (data == null)
				return;
			if (dict == null ) dict = new Hashtable() ;
			dict[data] = this;
			DeSerializeKey(data);
		
			this.OrgID = data.OrgID;

			this.ItemID = data.ItemID;

			this.BarCode = data.BarCode;

			this.ActualLength = data.ActualLength;

			this.CheckedOn = data.CheckedOn;

			this.CheckedBy = data.CheckedBy;

		}

		/// <summary>
		/// Create EntityData From Entity
		/// </summary>
		public CheckBarCodeDTOData ToEntityData()
		{
			return ToEntityData(null,new Hashtable());
		}
		/// <summary>
		/// Create EntityData From Entity - used by ubf 
		/// </summary>
		public CheckBarCodeDTOData ToEntityData(CheckBarCodeDTOData data, IDictionary dict){
			if (data == null)
				data = new CheckBarCodeDTOData();
			if (dict == null ) 
				dict = new Hashtable() ;
			else
            {
                if (dict.Contains(this))
                {
                    data = (CheckBarCodeDTOData)dict[this];
                    return data;
                }
            }
			dict[this] = data;
		
			data.OrgID = this.OrgID;

			data.ItemID = this.ItemID;

			data.BarCode = this.BarCode;

			data.ActualLength = this.ActualLength;

			data.CheckedOn = this.CheckedOn;

			data.CheckedBy = this.CheckedBy;

			return data ;
		}

		#endregion	
	}	
	
}