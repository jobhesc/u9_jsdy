


using System;
using System.Collections.Generic;
using System.Collections;
using System.Runtime.Serialization;

namespace UFIDA.U9.Cust.JSDY.BarCode
{
	/// <summary>
	/// 业务员DTO DTO :自定义的数据传输类型 
	/// 
	/// </summary>
	public  partial class OperatorsDTO  : UFSoft.UBF.Business.DTOBase
	{
		#region Constructor
		
		/// <summary>
		/// Constructor
		/// </summary>
		public OperatorsDTO(){
			initData();
		}
		private void initData()
		{
					OperatorsID = 0; 
		
		

		}

		#endregion
		
		#region Properties
			/// <summary>
		/// 业务员ID (该属性可为空,但有默认值)
		/// 业务员DTO.Misc.业务员ID
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
		/// 业务员编码 (该属性可为空,且无默认值)
		/// 业务员DTO.Misc.业务员编码
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
		/// 业务员每次 (该属性可为空,且无默认值)
		/// 业务员DTO.Misc.业务员每次
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
		
		#endregion	
		#region Multi_Fields
			
		#endregion 

		#region ModelResource
		/// <summary>
		/// 业务员DTO的显示名称资源--已经废弃，不使用.
		/// </summary>
		public string Res_TypeName {	get {return "" ;}	}
		/// <summary>
		/// 业务员ID的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_OperatorsID　{ get { return "";　}　}
		/// <summary>
		/// 业务员编码的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_OperatorsCode　{ get { return "";　}　}
		/// <summary>
		/// 业务员每次的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_OperatorsName　{ get { return "";　}　}
		#endregion 




		#region EntityData exchange
		
		#region  Do SerializeKey -ForDTOType
		//反序化Key到Data的ID中　－－由FromEntityData自动调用，不处理层次关系
		private void DeSerializeKey(OperatorsDTOData data)
		{
		



		}

		#endregion 
		
		/// <summary>
		/// Copy Entity From EntityData
		/// </summary>
		public void FromEntityData(OperatorsDTOData data)
		{
			this.FromEntityData(data,new Hashtable());
		}
		//used by ubf..
		public void FromEntityData(OperatorsDTOData data,IDictionary dict)
		{
			if (data == null)
				return;
			if (dict == null ) dict = new Hashtable() ;
			dict[data] = this;
			DeSerializeKey(data);
		
			this.OperatorsID = data.OperatorsID;

			this.OperatorsCode = data.OperatorsCode;

			this.OperatorsName = data.OperatorsName;

		}

		/// <summary>
		/// Create EntityData From Entity
		/// </summary>
		public OperatorsDTOData ToEntityData()
		{
			return ToEntityData(null,new Hashtable());
		}
		/// <summary>
		/// Create EntityData From Entity - used by ubf 
		/// </summary>
		public OperatorsDTOData ToEntityData(OperatorsDTOData data, IDictionary dict){
			if (data == null)
				data = new OperatorsDTOData();
			if (dict == null ) 
				dict = new Hashtable() ;
			else
            {
                if (dict.Contains(this))
                {
                    data = (OperatorsDTOData)dict[this];
                    return data;
                }
            }
			dict[this] = data;
		
			data.OperatorsID = this.OperatorsID;

			data.OperatorsCode = this.OperatorsCode;

			data.OperatorsName = this.OperatorsName;

			return data ;
		}

		#endregion	
	}	
	
}