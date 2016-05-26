



using System; 
using System.Collections;
using System.Collections.Generic ;
using System.Runtime.Serialization;

namespace UFIDA.U9.Cust.JSDY.BarCode
{
	/// <summary>
	/// 完工申报条码打印数据DTO DTO :自定义的数据传输类型 
	/// 
	/// </summary>
	[DataContract(Name = "UFIDA.U9.Cust.JSDY.BarCode.CompleteApplyBarCodeDTOData", Namespace = "http://www.UFIDA.org/EntityData",IsReference=true)]
	[Serializable]
	[KnownType("GetKnownTypes")]
	public partial class CompleteApplyBarCodeDTOData : UFSoft.UBF.Business.DataTransObjectBase
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
		public CompleteApplyBarCodeDTOData()
		{
			initData();
		}
		private void initData()
		{
		
		
		
		
					ActualLength= 0; 
							MarkingLength= 0; 
				
		
					OperatorsID= 0; 
							ItemID= 0; 
							BarCodeID= 0; 
		
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
		public CompleteApplyBarCodeDTOData(  System.String barCode  , System.String itemCode  , System.String itemName  , System.String itemSPECS  , System.Int32 actualLength  , System.Int32 markingLength  , System.String operatorsCode  , System.String operatorsName  , System.Int64 operatorsID  , System.Int64 itemID  , System.Int64 barCodeID  )
		{
			initData();
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
		#region System Fields 
		//--系统字段,目前没有.EntityData上有相应的字段,用于保存相关的实体状态信息,DTO上没有状态信息.	
		#endregion
		
		#region DTO Properties 
	
		

		/// <summary>
		/// 条码
		/// 完工申报条码打印数据DTO.Misc.条码
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
		/// 料号
		/// 完工申报条码打印数据DTO.Misc.料号
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.String m_itemCode ;
		public System.String ItemCode
		{
			get	
			{	
				return m_itemCode ;
			}
			set	
			{	
				m_itemCode = value ;	
			}
		}
			
		

		/// <summary>
		/// 品名
		/// 完工申报条码打印数据DTO.Misc.品名
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.String m_itemName ;
		public System.String ItemName
		{
			get	
			{	
				return m_itemName ;
			}
			set	
			{	
				m_itemName = value ;	
			}
		}
			
		

		/// <summary>
		/// 规格
		/// 完工申报条码打印数据DTO.Misc.规格
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.String m_itemSPECS ;
		public System.String ItemSPECS
		{
			get	
			{	
				return m_itemSPECS ;
			}
			set	
			{	
				m_itemSPECS = value ;	
			}
		}
			
		

		/// <summary>
		/// 实际长度
		/// 完工申报条码打印数据DTO.Misc.实际长度
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
		/// 合格证标示长度
		/// 完工申报条码打印数据DTO.Misc.合格证标示长度
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.Int32 m_markingLength ;
		public System.Int32 MarkingLength
		{
			get	
			{	
				return m_markingLength ;
			}
			set	
			{	
				m_markingLength = value ;	
			}
		}
			
		

		/// <summary>
		/// 检验员编码
		/// 完工申报条码打印数据DTO.Misc.检验员编码
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
		/// 检验员名称
		/// 完工申报条码打印数据DTO.Misc.检验员名称
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
			
		

		/// <summary>
		/// 检验员ID
		/// 完工申报条码打印数据DTO.Misc.检验员ID
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
		/// 料品ID
		/// 完工申报条码打印数据DTO.Misc.料品ID
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
		/// 条码ID
		/// 完工申报条码打印数据DTO.Misc.条码ID
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.Int64 m_barCodeID ;
		public System.Int64 BarCodeID
		{
			get	
			{	
				return m_barCodeID ;
			}
			set	
			{	
				m_barCodeID = value ;	
			}
		}
			
		#endregion	

		#region Multi_Fields
																						
		#endregion 
	} 	
}

	
