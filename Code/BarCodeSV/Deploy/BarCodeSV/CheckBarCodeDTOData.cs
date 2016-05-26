



using System; 
using System.Collections;
using System.Collections.Generic ;
using System.Runtime.Serialization;

namespace UFIDA.U9.Cust.JSDY.BarCode
{
	/// <summary>
	/// 盘点条码记录DTO DTO :自定义的数据传输类型 
	/// 
	/// </summary>
	[DataContract(Name = "UFIDA.U9.Cust.JSDY.BarCode.CheckBarCodeDTOData", Namespace = "http://www.UFIDA.org/EntityData",IsReference=true)]
	[Serializable]
	[KnownType("GetKnownTypes")]
	public partial class CheckBarCodeDTOData : UFSoft.UBF.Business.DataTransObjectBase
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
		public CheckBarCodeDTOData()
		{
			initData();
		}
		private void initData()
		{
					OrgID= 0; 
							ItemID= 0; 
				
					ActualLength= 0; 
				
		

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
		public CheckBarCodeDTOData(  System.Int64 orgID  , System.Int64 itemID  , System.String barCode  , System.Int32 actualLength  , System.DateTime checkedOn  , System.String checkedBy  )
		{
			initData();
			this.OrgID = orgID;
			this.ItemID = itemID;
			this.BarCode = barCode;
			this.ActualLength = actualLength;
			this.CheckedOn = checkedOn;
			this.CheckedBy = checkedBy;
		}
		#region System Fields 
		//--系统字段,目前没有.EntityData上有相应的字段,用于保存相关的实体状态信息,DTO上没有状态信息.	
		#endregion
		
		#region DTO Properties 
	
		

		/// <summary>
		/// 组织ID
		/// 盘点条码记录DTO.Misc.组织ID
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.Int64 m_orgID ;
		public System.Int64 OrgID
		{
			get	
			{	
				return m_orgID ;
			}
			set	
			{	
				m_orgID = value ;	
			}
		}
			
		

		/// <summary>
		/// 料品ID
		/// 盘点条码记录DTO.Misc.料品ID
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.Int64 m_itemID ;
		public System.Int64 ItemID
		{
			get	
			{	
				return m_itemID ;
			}
			set	
			{	
				m_itemID = value ;	
			}
		}
			
		

		/// <summary>
		/// 条码
		/// 盘点条码记录DTO.Misc.条码
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.String m_barCode ;
		public System.String BarCode
		{
			get	
			{	
				return m_barCode ;
			}
			set	
			{	
				m_barCode = value ;	
			}
		}
			
		

		/// <summary>
		/// 实际长度
		/// 盘点条码记录DTO.Misc.实际长度
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.Int32 m_actualLength ;
		public System.Int32 ActualLength
		{
			get	
			{	
				return m_actualLength ;
			}
			set	
			{	
				m_actualLength = value ;	
			}
		}
			
		

		/// <summary>
		/// 盘点时间
		/// 盘点条码记录DTO.Misc.盘点时间
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.DateTime m_checkedOn ;
		public System.DateTime CheckedOn
		{
			get	
			{	
				return m_checkedOn ;
			}
			set	
			{	
				m_checkedOn = value ;	
			}
		}
			
		

		/// <summary>
		/// 盘点人
		/// 盘点条码记录DTO.Misc.盘点人
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.String m_checkedBy ;
		public System.String CheckedBy
		{
			get	
			{	
				return m_checkedBy ;
			}
			set	
			{	
				m_checkedBy = value ;	
			}
		}
			
		#endregion	

		#region Multi_Fields
												
		#endregion 
	} 	
}

	
