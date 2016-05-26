



using System; 
using System.Collections;
using System.Collections.Generic ;
using System.Runtime.Serialization;

namespace UFIDA.U9.Cust.JSDY.BarCode
{
	/// <summary>
	/// 业务员DTO DTO :自定义的数据传输类型 
	/// 
	/// </summary>
	[DataContract(Name = "UFIDA.U9.Cust.JSDY.BarCode.OperatorsDTOData", Namespace = "http://www.UFIDA.org/EntityData",IsReference=true)]
	[Serializable]
	[KnownType("GetKnownTypes")]
	public partial class OperatorsDTOData : UFSoft.UBF.Business.DataTransObjectBase
	{
		public static IList<Type> GetKnownTypes()
        {
            IList<Type> knownTypes = new List<Type>();
                                       
            knownTypes.Add(typeof(UFSoft.UBF.Util.Data.MultiLangDataDict));
            return knownTypes;
        }
		/// <summary>
		/// Default Constructor
		/// </summary>
		public OperatorsDTOData()
		{
			initData();
		}
		private void initData()
		{
					OperatorsID= 0; 
				
		

			//调用默认值初始化服务进行配置方式初始化
			UFSoft.UBF.Service.DTOService.InitConfigDefault(this);
		}
		[System.Runtime.Serialization.OnDeserializing]
        internal void OnDeserializing(System.Runtime.Serialization.StreamingContext context)
        {
			 initData();
        }
		#region Do SerializeKey -ForDTODataType
		//只为处理集合型EntityKey。原因集合型EntityKey由于使用臫的集合对象，无法实现数据共享.-UBF专用.
		public void DoSerializeKeyList(IDictionary dict)
		{
			if (dict == null ) dict = new Hashtable() ;
			if (dict[this] != null)
				return ;
			dict[this] = this;
	        	        	        
		}
		#endregion 
		/// <summary>
		/// Constructor Full Argument
		/// </summary>
		public OperatorsDTOData(  System.Int64 operatorsID  , System.String operatorsCode  , System.String operatorsName  )
		{
			initData();
			this.OperatorsID = operatorsID;
			this.OperatorsCode = operatorsCode;
			this.OperatorsName = operatorsName;
		}
		#region System Fields 
		//--系统字段,目前没有.EntityData上有相应的字段,用于保存相关的实体状态信息,DTO上没有状态信息.	
		#endregion
		
		#region DTO Properties 
	
		

		/// <summary>
		/// 业务员ID
		/// 业务员DTO.Misc.业务员ID
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.Int64 m_operatorsID ;
		public System.Int64 OperatorsID
		{
			get	
			{	
				return m_operatorsID ;
			}
			set	
			{	
				m_operatorsID = value ;	
			}
		}
			
		

		/// <summary>
		/// 业务员编码
		/// 业务员DTO.Misc.业务员编码
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.String m_operatorsCode ;
		public System.String OperatorsCode
		{
			get	
			{	
				return m_operatorsCode ;
			}
			set	
			{	
				m_operatorsCode = value ;	
			}
		}
			
		

		/// <summary>
		/// 业务员每次
		/// 业务员DTO.Misc.业务员每次
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.String m_operatorsName ;
		public System.String OperatorsName
		{
			get	
			{	
				return m_operatorsName ;
			}
			set	
			{	
				m_operatorsName = value ;	
			}
		}
			
		#endregion	

		#region Multi_Fields
						
		#endregion 
	} 	
}

	
