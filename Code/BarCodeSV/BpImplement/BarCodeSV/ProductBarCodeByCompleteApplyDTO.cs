


using System;
using System.Collections.Generic;
using System.Collections;
using System.Runtime.Serialization;

namespace UFIDA.U9.Cust.JSDY.BarCode
{
	/// <summary>
	/// 根据完工申报单生成成品条码记录DTO DTO :自定义的数据传输类型 
	/// 
	/// </summary>
	public  partial class ProductBarCodeByCompleteApplyDTO  : UFSoft.UBF.Business.DTOBase
	{
		#region Constructor
		
		/// <summary>
		/// Constructor
		/// </summary>
		public ProductBarCodeByCompleteApplyDTO(){
			initData();
		}
		private void initData()
		{
					OrgID = 0; 
					ItemID = 0; 
		
					ActualLength = 0; 
					QcOperator = 0; 
					CompleteApplyDoc = 0; 
					CompleteApplyDocLine = 0; 
		
		

		}

		#endregion
		
		#region Properties
			/// <summary>
		/// 组织ID (该属性可为空,但有默认值)
		/// 根据完工申报单生成成品条码记录DTO.Misc.组织ID
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
		/// 根据完工申报单生成成品条码记录DTO.Misc.料品ID
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
		/// 根据完工申报单生成成品条码记录DTO.Misc.条码
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
		/// 根据完工申报单生成成品条码记录DTO.Misc.实际长度
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
		/// 检验员 (该属性可为空,但有默认值)
		/// 根据完工申报单生成成品条码记录DTO.Misc.检验员
		/// </summary>
		/// <value>System.Int64</value>
		public System.Int64 QcOperator
		{
			get	
			{	
				return (System.Int64)base.GetValue("QcOperator",typeof(System.Int64));
			}

			 set	
			{
				base.SetValue("QcOperator",value);
			}
		}
				/// <summary>
		/// 完工申报单ID (该属性可为空,但有默认值)
		/// 根据完工申报单生成成品条码记录DTO.Misc.完工申报单ID
		/// </summary>
		/// <value>System.Int64</value>
		public System.Int64 CompleteApplyDoc
		{
			get	
			{	
				return (System.Int64)base.GetValue("CompleteApplyDoc",typeof(System.Int64));
			}

			 set	
			{
				base.SetValue("CompleteApplyDoc",value);
			}
		}
				/// <summary>
		/// 完工申报行ID (该属性可为空,但有默认值)
		/// 根据完工申报单生成成品条码记录DTO.Misc.完工申报行ID
		/// </summary>
		/// <value>System.Int64</value>
		public System.Int64 CompleteApplyDocLine
		{
			get	
			{	
				return (System.Int64)base.GetValue("CompleteApplyDocLine",typeof(System.Int64));
			}

			 set	
			{
				base.SetValue("CompleteApplyDocLine",value);
			}
		}
				/// <summary>
		/// 扫描人 (该属性可为空,且无默认值)
		/// 根据完工申报单生成成品条码记录DTO.Misc.扫描人
		/// </summary>
		/// <value>System.String</value>
		public System.String ScanBy
		{
			get	
			{	
				return (System.String)base.GetValue("ScanBy",typeof(System.String));
			}

			 set	
			{
				base.SetValue("ScanBy",value);
			}
		}
				/// <summary>
		/// 扫描时间 (该属性可为空,且无默认值)
		/// 根据完工申报单生成成品条码记录DTO.Misc.扫描时间
		/// </summary>
		/// <value>System.DateTime</value>
		public System.DateTime ScanOn
		{
			get	
			{	
				return (System.DateTime)base.GetValue("ScanOn",typeof(System.DateTime));
			}

			 set	
			{
				base.SetValue("ScanOn",value);
			}
		}
		
		#endregion	
		#region Multi_Fields
									
		#endregion 

		#region ModelResource
		/// <summary>
		/// 根据完工申报单生成成品条码记录DTO的显示名称资源--已经废弃，不使用.
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
		/// 检验员的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_QcOperator　{ get { return "";　}　}
		/// <summary>
		/// 完工申报单ID的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_CompleteApplyDoc　{ get { return "";　}　}
		/// <summary>
		/// 完工申报行ID的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_CompleteApplyDocLine　{ get { return "";　}　}
		/// <summary>
		/// 扫描人的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_ScanBy　{ get { return "";　}　}
		/// <summary>
		/// 扫描时间的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_ScanOn　{ get { return "";　}　}
		#endregion 




		#region EntityData exchange
		
		#region  Do SerializeKey -ForDTOType
		//反序化Key到Data的ID中　－－由FromEntityData自动调用，不处理层次关系
		private void DeSerializeKey(ProductBarCodeByCompleteApplyDTOData data)
		{
		









		}

		#endregion 
		
		/// <summary>
		/// Copy Entity From EntityData
		/// </summary>
		public void FromEntityData(ProductBarCodeByCompleteApplyDTOData data)
		{
			this.FromEntityData(data,new Hashtable());
		}
		//used by ubf..
		public void FromEntityData(ProductBarCodeByCompleteApplyDTOData data,IDictionary dict)
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

			this.QcOperator = data.QcOperator;

			this.CompleteApplyDoc = data.CompleteApplyDoc;

			this.CompleteApplyDocLine = data.CompleteApplyDocLine;

			this.ScanBy = data.ScanBy;

			this.ScanOn = data.ScanOn;

		}

		/// <summary>
		/// Create EntityData From Entity
		/// </summary>
		public ProductBarCodeByCompleteApplyDTOData ToEntityData()
		{
			return ToEntityData(null,new Hashtable());
		}
		/// <summary>
		/// Create EntityData From Entity - used by ubf 
		/// </summary>
		public ProductBarCodeByCompleteApplyDTOData ToEntityData(ProductBarCodeByCompleteApplyDTOData data, IDictionary dict){
			if (data == null)
				data = new ProductBarCodeByCompleteApplyDTOData();
			if (dict == null ) 
				dict = new Hashtable() ;
			else
            {
                if (dict.Contains(this))
                {
                    data = (ProductBarCodeByCompleteApplyDTOData)dict[this];
                    return data;
                }
            }
			dict[this] = data;
		
			data.OrgID = this.OrgID;

			data.ItemID = this.ItemID;

			data.BarCode = this.BarCode;

			data.ActualLength = this.ActualLength;

			data.QcOperator = this.QcOperator;

			data.CompleteApplyDoc = this.CompleteApplyDoc;

			data.CompleteApplyDocLine = this.CompleteApplyDocLine;

			data.ScanBy = this.ScanBy;

			data.ScanOn = this.ScanOn;

			return data ;
		}

		#endregion	
	}	
	
}