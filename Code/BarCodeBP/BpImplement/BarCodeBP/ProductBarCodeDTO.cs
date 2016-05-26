


using System;
using System.Collections.Generic;
using System.Collections;
using System.Runtime.Serialization;

namespace UFIDA.U9.Cust.JSDY.BarCode
{
	/// <summary>
	/// 成品条码打印数据DTO DTO :自定义的数据传输类型 
	/// 
	/// </summary>
	public  partial class ProductBarCodeDTO  : UFSoft.UBF.Business.DTOBase
	{
		#region Constructor
		
		/// <summary>
		/// Constructor
		/// </summary>
		public ProductBarCodeDTO(){
			initData();
		}
		private void initData()
		{
		
		
		
		
					ActualLength = 0; 
					MarkingLength = 0; 
		
		
					OperatorsID = 0; 
					ItemID = 0; 
					BarCodeID = 0; 

		}

		#endregion
		
		#region Properties
			/// <summary>
		/// 条码 (该属性可为空,且无默认值)
		/// 成品条码打印数据DTO.Misc.条码
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
		/// 料号 (该属性可为空,且无默认值)
		/// 成品条码打印数据DTO.Misc.料号
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
		/// 成品条码打印数据DTO.Misc.品名
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
		/// 规格 (该属性可为空,且无默认值)
		/// 成品条码打印数据DTO.Misc.规格
		/// </summary>
		/// <value>System.String</value>
		public System.String ItemSPECS
		{
			get	
			{	
				return (System.String)base.GetValue("ItemSPECS",typeof(System.String));
			}

			 set	
			{
				base.SetValue("ItemSPECS",value);
			}
		}
				/// <summary>
		/// 实际长度 (该属性可为空,但有默认值)
		/// 成品条码打印数据DTO.Misc.实际长度
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
		/// 合格证标示长度 (该属性可为空,但有默认值)
		/// 成品条码打印数据DTO.Misc.合格证标示长度
		/// </summary>
		/// <value>System.Int32</value>
		public System.Int32 MarkingLength
		{
			get	
			{	
				return (System.Int32)base.GetValue("MarkingLength",typeof(System.Int32));
			}

			 set	
			{
				base.SetValue("MarkingLength",value);
			}
		}
				/// <summary>
		/// 检验员编码 (该属性可为空,且无默认值)
		/// 成品条码打印数据DTO.Misc.检验员编码
		/// </summary>
		/// <value>System.String</value>
		public System.String OperatorsCode
		{
			get	
			{	
				return (System.String)base.GetValue("OperatorsCode",typeof(System.String));
			}

			 set	
			{
				base.SetValue("OperatorsCode",value);
			}
		}
				/// <summary>
		/// 检验员名称 (该属性可为空,且无默认值)
		/// 成品条码打印数据DTO.Misc.检验员名称
		/// </summary>
		/// <value>System.String</value>
		public System.String OperatorsName
		{
			get	
			{	
				return (System.String)base.GetValue("OperatorsName",typeof(System.String));
			}

			 set	
			{
				base.SetValue("OperatorsName",value);
			}
		}
				/// <summary>
		/// 检验员ID (该属性可为空,但有默认值)
		/// 成品条码打印数据DTO.Misc.检验员ID
		/// </summary>
		/// <value>System.Int64</value>
		public System.Int64 OperatorsID
		{
			get	
			{	
				return (System.Int64)base.GetValue("OperatorsID",typeof(System.Int64));
			}

			 set	
			{
				base.SetValue("OperatorsID",value);
			}
		}
				/// <summary>
		/// 料品ID (该属性可为空,但有默认值)
		/// 成品条码打印数据DTO.Misc.料品ID
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
		/// 条码ID (该属性可为空,但有默认值)
		/// 成品条码打印数据DTO.Misc.条码ID
		/// </summary>
		/// <value>System.Int64</value>
		public System.Int64 BarCodeID
		{
			get	
			{	
				return (System.Int64)base.GetValue("BarCodeID",typeof(System.Int64));
			}

			 set	
			{
				base.SetValue("BarCodeID",value);
			}
		}
		
		#endregion	
		#region Multi_Fields
											
		#endregion 

		#region ModelResource
		/// <summary>
		/// 成品条码打印数据DTO的显示名称资源--已经废弃，不使用.
		/// </summary>
		public string Res_TypeName {	get {return "" ;}	}
		/// <summary>
		/// 条码的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_BarCode　{ get { return "";　}　}
		/// <summary>
		/// 料号的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_ItemCode　{ get { return "";　}　}
		/// <summary>
		/// 品名的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_ItemName　{ get { return "";　}　}
		/// <summary>
		/// 规格的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_ItemSPECS　{ get { return "";　}　}
		/// <summary>
		/// 实际长度的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_ActualLength　{ get { return "";　}　}
		/// <summary>
		/// 合格证标示长度的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_MarkingLength　{ get { return "";　}　}
		/// <summary>
		/// 检验员编码的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_OperatorsCode　{ get { return "";　}　}
		/// <summary>
		/// 检验员名称的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_OperatorsName　{ get { return "";　}　}
		/// <summary>
		/// 检验员ID的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_OperatorsID　{ get { return "";　}　}
		/// <summary>
		/// 料品ID的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_ItemID　{ get { return "";　}　}
		/// <summary>
		/// 条码ID的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_BarCodeID　{ get { return "";　}　}
		#endregion 




		#region EntityData exchange
		
		#region  Do SerializeKey -ForDTOType
		//反序化Key到Data的ID中　－－由FromEntityData自动调用，不处理层次关系
		private void DeSerializeKey(ProductBarCodeDTOData data)
		{
		











		}

		#endregion 
		
		/// <summary>
		/// Copy Entity From EntityData
		/// </summary>
		public void FromEntityData(ProductBarCodeDTOData data)
		{
			this.FromEntityData(data,new Hashtable());
		}
		//used by ubf..
		public void FromEntityData(ProductBarCodeDTOData data,IDictionary dict)
		{
			if (data == null)
				return;
			if (dict == null ) dict = new Hashtable() ;
			dict[data] = this;
			DeSerializeKey(data);
		
			this.BarCode = data.BarCode;

			this.ItemCode = data.ItemCode;

			this.ItemName = data.ItemName;

			this.ItemSPECS = data.ItemSPECS;

			this.ActualLength = data.ActualLength;

			this.MarkingLength = data.MarkingLength;

			this.OperatorsCode = data.OperatorsCode;

			this.OperatorsName = data.OperatorsName;

			this.OperatorsID = data.OperatorsID;

			this.ItemID = data.ItemID;

			this.BarCodeID = data.BarCodeID;

		}

		/// <summary>
		/// Create EntityData From Entity
		/// </summary>
		public ProductBarCodeDTOData ToEntityData()
		{
			return ToEntityData(null,new Hashtable());
		}
		/// <summary>
		/// Create EntityData From Entity - used by ubf 
		/// </summary>
		public ProductBarCodeDTOData ToEntityData(ProductBarCodeDTOData data, IDictionary dict){
			if (data == null)
				data = new ProductBarCodeDTOData();
			if (dict == null ) 
				dict = new Hashtable() ;
			else
            {
                if (dict.Contains(this))
                {
                    data = (ProductBarCodeDTOData)dict[this];
                    return data;
                }
            }
			dict[this] = data;
		
			data.BarCode = this.BarCode;

			data.ItemCode = this.ItemCode;

			data.ItemName = this.ItemName;

			data.ItemSPECS = this.ItemSPECS;

			data.ActualLength = this.ActualLength;

			data.MarkingLength = this.MarkingLength;

			data.OperatorsCode = this.OperatorsCode;

			data.OperatorsName = this.OperatorsName;

			data.OperatorsID = this.OperatorsID;

			data.ItemID = this.ItemID;

			data.BarCodeID = this.BarCodeID;

			return data ;
		}

		#endregion	
	}	
	
}