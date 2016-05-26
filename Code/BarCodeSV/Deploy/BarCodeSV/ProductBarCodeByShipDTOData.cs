



using System; 
using System.Collections;
using System.Collections.Generic ;
using System.Runtime.Serialization;

namespace UFIDA.U9.Cust.JSDY.BarCode
{
	/// <summary>
	/// 根据出货计划生成成品条码记录DTO DTO :自定义的数据传输类型 
	/// 
	/// </summary>
	[DataContract(Name = "UFIDA.U9.Cust.JSDY.BarCode.ProductBarCodeByShipDTOData", Namespace = "http://www.UFIDA.org/EntityData",IsReference=true)]
	[Serializable]
	[KnownType("GetKnownTypes")]
	public partial class ProductBarCodeByShipDTOData : UFSoft.UBF.Business.DataTransObjectBase
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
		public ProductBarCodeByShipDTOData()
		{
			initData();
		}
		private void initData()
		{
					OrgID= 0; 
							ItemID= 0; 
				
					ActualLength= 0; 
							QcOperator= 0; 
							ShipPlan= 0; 
							ShipPlanLine= 0; 
				
		
					SOShipLine= 0; 
		
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
		public ProductBarCodeByShipDTOData(  System.Int64 orgID  , System.Int64 itemID  , System.String barCode  , System.Int32 actualLength  , System.Int64 qcOperator  , System.Int64 shipPlan  , System.Int64 shipPlanLine  , System.DateTime scanOn  , System.String scanBy  , System.Int64 sOShipLine  )
		{
			initData();
			this.OrgID = orgID;
			this.ItemID = itemID;
			this.BarCode = barCode;
			this.ActualLength = actualLength;
			this.QcOperator = qcOperator;
			this.ShipPlan = shipPlan;
			this.ShipPlanLine = shipPlanLine;
			this.ScanOn = scanOn;
			this.ScanBy = scanBy;
			this.SOShipLine = sOShipLine;
		}
		#region System Fields 
		//--系统字段,目前没有.EntityData上有相应的字段,用于保存相关的实体状态信息,DTO上没有状态信息.	
		#endregion
		
		#region DTO Properties 
	
		

		/// <summary>
		/// 组织ID
		/// 根据出货计划生成成品条码记录DTO.Misc.组织ID
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
		/// 根据出货计划生成成品条码记录DTO.Misc.料品ID
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
		/// 根据出货计划生成成品条码记录DTO.Misc.条码
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
		/// 根据出货计划生成成品条码记录DTO.Misc.实际长度
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
		/// 检验员ID
		/// 根据出货计划生成成品条码记录DTO.Misc.检验员ID
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.Int64 m_qcOperator ;
		public System.Int64 QcOperator
		{
			get	
			{	
				return m_qcOperator ;
			}
			set	
			{	
				m_qcOperator = value ;	
			}
		}
			
		

		/// <summary>
		/// 出货计划ID
		/// 根据出货计划生成成品条码记录DTO.Misc.出货计划ID
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.Int64 m_shipPlan ;
		public System.Int64 ShipPlan
		{
			get	
			{	
				return m_shipPlan ;
			}
			set	
			{	
				m_shipPlan = value ;	
			}
		}
			
		

		/// <summary>
		/// 出货计划行ID
		/// 根据出货计划生成成品条码记录DTO.Misc.出货计划行ID
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.Int64 m_shipPlanLine ;
		public System.Int64 ShipPlanLine
		{
			get	
			{	
				return m_shipPlanLine ;
			}
			set	
			{	
				m_shipPlanLine = value ;	
			}
		}
			
		

		/// <summary>
		/// 扫描时间
		/// 根据出货计划生成成品条码记录DTO.Misc.扫描时间
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.DateTime m_scanOn ;
		public System.DateTime ScanOn
		{
			get	
			{	
				return m_scanOn ;
			}
			set	
			{	
				m_scanOn = value ;	
			}
		}
			
		

		/// <summary>
		/// 扫描人
		/// 根据出货计划生成成品条码记录DTO.Misc.扫描人
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.String m_scanBy ;
		public System.String ScanBy
		{
			get	
			{	
				return m_scanBy ;
			}
			set	
			{	
				m_scanBy = value ;	
			}
		}
			
		

		/// <summary>
		/// 销售订单子行ID
		/// 根据出货计划生成成品条码记录DTO.Misc.销售订单子行ID
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.Int64 m_sOShipLine ;
		public System.Int64 SOShipLine
		{
			get	
			{	
				return m_sOShipLine ;
			}
			set	
			{	
				m_sOShipLine = value ;	
			}
		}
			
		#endregion	

		#region Multi_Fields
																				
		#endregion 
	} 	
}

	
