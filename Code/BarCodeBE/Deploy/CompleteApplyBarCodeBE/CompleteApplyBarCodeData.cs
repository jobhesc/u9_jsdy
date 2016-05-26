
	using System; 
	using System.Collections;
	using System.Collections.Generic ;
	using System.Runtime.Serialization;

namespace UFIDA.U9.Cust.JSDY.BarCode
{
	/// <summary>
	/// 完工申报条码档案 缺省DTO 
	/// 
	/// </summary>
	[DataContract(Name = "UFIDA.U9.Cust.JSDY.BarCode.CompleteApplyBarCodeData", Namespace = "http://www.UFIDA.org/EntityData",IsReference=true)]	
	[Serializable]
    [KnownType("GetKnownTypes")]
	public partial class CompleteApplyBarCodeData : UFSoft.UBF.Business.DataTransObjectBase
	{

	    public static IList<Type> GetKnownTypes()
        {
            IList<Type> knownTypes = new List<Type>();
            
                        
                        
                        
                        
                        
                                        knownTypes.Add(typeof(UFIDA.U9.Base.Organization.OrganizationData));
                        
                                        knownTypes.Add(typeof(UFIDA.U9.CBO.SCM.Item.ItemMasterData));
                        
                        
                        
                                        knownTypes.Add(typeof(UFIDA.U9.CBO.HR.Operator.OperatorsData));
                        
                                        knownTypes.Add(typeof(UFIDA.U9.Base.FlexField.DescFlexField.DescFlexSegmentsData));
                        
                        
                        
                        
                        
            
                knownTypes.Add(typeof(UFSoft.UBF.Util.Data.MultiLangDataDict));
            return knownTypes;
        }
		/// <summary>
		/// Default Constructor
		/// </summary>
		public CompleteApplyBarCodeData()
		{
			initData() ;
		}
		private void initData()
		{
			//设置默认值
	     			
	     			
	     			
	     			
	     			
	     							SysVersion= 0; 			     			
	     			
	     			
	     							ActualLength= 0; 			     							MarkingLength= 0; 			     			
	     			
	     			
	     			
	     							IsPrinted=false; 
	     			
	     			
	     							IsPrintWrapper=false; 
	     							PrintCount= 0; 		

			//设置组合的集合属性为List<>对象. -目前直接在属性上处理.
			
			//调用默认值初始化服务进行配置方式初始化
			UFSoft.UBF.Service.DTOService.InitConfigDefault(this);
		}		
		[System.Runtime.Serialization.OnDeserializing]
        internal void OnDeserializing(System.Runtime.Serialization.StreamingContext context)
        {
			 initData();
        }
        
		#region System Fields
		///<summary>
		/// 实体类型. 
		/// </summary>
		[DataMember(IsRequired=false)]
		public override string SysEntityType
		{
			get { return "UFIDA.U9.Cust.JSDY.BarCode.CompleteApplyBarCode" ;}
		}
		#endregion


		
		#region Properties Inner Component
	
		#endregion	

		#region Properties Outer Component
		
				/// <summary>
		/// ID
		/// 完工申报条码档案.Key.ID
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.Int64 m_iD ;
		public System.Int64 ID
		{
			get	
			{	
				return m_iD  ;
			}
			set	
			{	
				m_iD = value ;	
			}
		}
		

				/// <summary>
		/// 创建时间
		/// 完工申报条码档案.Sys.创建时间
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.DateTime m_createdOn ;
		public System.DateTime CreatedOn
		{
			get	
			{	
				return m_createdOn  ;
			}
			set	
			{	
				m_createdOn = value ;	
			}
		}
		

				/// <summary>
		/// 创建人
		/// 完工申报条码档案.Sys.创建人
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.String m_createdBy ;
		public System.String CreatedBy
		{
			get	
			{	
				return m_createdBy  ;
			}
			set	
			{	
				m_createdBy = value ;	
			}
		}
		

				/// <summary>
		/// 修改时间
		/// 完工申报条码档案.Sys.修改时间
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.DateTime m_modifiedOn ;
		public System.DateTime ModifiedOn
		{
			get	
			{	
				return m_modifiedOn  ;
			}
			set	
			{	
				m_modifiedOn = value ;	
			}
		}
		

				/// <summary>
		/// 修改人
		/// 完工申报条码档案.Sys.修改人
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.String m_modifiedBy ;
		public System.String ModifiedBy
		{
			get	
			{	
				return m_modifiedBy  ;
			}
			set	
			{	
				m_modifiedBy = value ;	
			}
		}
		

				/// <summary>
		/// 事务版本
		/// 完工申报条码档案.Sys.事务版本
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.Int64 m_sysVersion ;
		public System.Int64 SysVersion
		{
			get	
			{	
				return m_sysVersion  ;
			}
			set	
			{	
				m_sysVersion = value ;	
			}
		}
		

		
		private UFSoft.UBF.Business.BusinessEntity.EntityKey m_org_SKey ;
		/// <summary>
		/// 组织 序列化Key属性。（传递跨组织序列列字段）
		/// 完工申报条码档案.Misc.组织
		/// </summary>
		[DataMember(IsRequired=false)]
		public UFSoft.UBF.Business.BusinessEntity.EntityKey Org_SKey
		{
			get 
			{
				return m_org_SKey ;					
			}
			set
			{
				 m_org_SKey = value ;	
			}
		}
		/// <summary>
		/// 组织
		/// 完工申报条码档案.Misc.组织
		/// </summary>
		[DataMember(IsRequired=false)]
		public System.Int64 Org
		{
			get	
			{	
				if (Org_SKey == null)
					return UFSoft.UBF.Business.Entity.EmptyObjectValue ;
				else
					return Org_SKey.ID ;
			}
			set	
			{	
				if (value == 0 || value == UFSoft.UBF.Business.Entity.EmptyObjectValue )
					Org_SKey = null ;
				else
				{
					if (Org_SKey == null )
						Org_SKey = new UFSoft.UBF.Business.BusinessEntity.EntityKey(value,"UFIDA.U9.Base.Organization.Organization") ;
					else
						Org_SKey.ID = value ;
				}
			}
		}
		

				/// <summary>
		/// 条形码
		/// 完工申报条码档案.Misc.条形码
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.String m_barCode ;
		public System.String BarCode
		{
			get	
			{	
				return m_barCode  ;
			}
			set	
			{	
				m_barCode = value ;	
			}
		}
		

		
		private UFSoft.UBF.Business.BusinessEntity.EntityKey m_item_SKey ;
		/// <summary>
		/// 料品 序列化Key属性。（传递跨组织序列列字段）
		/// 完工申报条码档案.Misc.料品
		/// </summary>
		[DataMember(IsRequired=false)]
		public UFSoft.UBF.Business.BusinessEntity.EntityKey Item_SKey
		{
			get 
			{
				return m_item_SKey ;					
			}
			set
			{
				 m_item_SKey = value ;	
			}
		}
		/// <summary>
		/// 料品
		/// 完工申报条码档案.Misc.料品
		/// </summary>
		[DataMember(IsRequired=false)]
		public System.Int64 Item
		{
			get	
			{	
				if (Item_SKey == null)
					return UFSoft.UBF.Business.Entity.EmptyObjectValue ;
				else
					return Item_SKey.ID ;
			}
			set	
			{	
				if (value == 0 || value == UFSoft.UBF.Business.Entity.EmptyObjectValue )
					Item_SKey = null ;
				else
				{
					if (Item_SKey == null )
						Item_SKey = new UFSoft.UBF.Business.BusinessEntity.EntityKey(value,"UFIDA.U9.CBO.SCM.Item.ItemMaster") ;
					else
						Item_SKey.ID = value ;
				}
			}
		}
		

				/// <summary>
		/// 实际长度
		/// 完工申报条码档案.Misc.实际长度
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.Int32 m_actualLength ;
		public System.Int32 ActualLength
		{
			get	
			{	
				return m_actualLength  ;
			}
			set	
			{	
				m_actualLength = value ;	
			}
		}
		

				/// <summary>
		/// 合格证标示长度
		/// 完工申报条码档案.Misc.合格证标示长度
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.Int32 m_markingLength ;
		public System.Int32 MarkingLength
		{
			get	
			{	
				return m_markingLength  ;
			}
			set	
			{	
				m_markingLength = value ;	
			}
		}
		

				/// <summary>
		/// 完工申报日期
		/// 完工申报条码档案.Misc.完工申报日期
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.DateTime m_businessDate ;
		public System.DateTime BusinessDate
		{
			get	
			{	
				return m_businessDate  ;
			}
			set	
			{	
				m_businessDate = value ;	
			}
		}
		

		
		private UFSoft.UBF.Business.BusinessEntity.EntityKey m_operators_SKey ;
		/// <summary>
		/// 检验员 序列化Key属性。（传递跨组织序列列字段）
		/// 完工申报条码档案.Misc.检验员
		/// </summary>
		[DataMember(IsRequired=false)]
		public UFSoft.UBF.Business.BusinessEntity.EntityKey Operators_SKey
		{
			get 
			{
				return m_operators_SKey ;					
			}
			set
			{
				 m_operators_SKey = value ;	
			}
		}
		/// <summary>
		/// 检验员
		/// 完工申报条码档案.Misc.检验员
		/// </summary>
		[DataMember(IsRequired=false)]
		public System.Int64 Operators
		{
			get	
			{	
				if (Operators_SKey == null)
					return UFSoft.UBF.Business.Entity.EmptyObjectValue ;
				else
					return Operators_SKey.ID ;
			}
			set	
			{	
				if (value == 0 || value == UFSoft.UBF.Business.Entity.EmptyObjectValue )
					Operators_SKey = null ;
				else
				{
					if (Operators_SKey == null )
						Operators_SKey = new UFSoft.UBF.Business.BusinessEntity.EntityKey(value,"UFIDA.U9.CBO.HR.Operator.Operators") ;
					else
						Operators_SKey.ID = value ;
				}
			}
		}
		

				/// <summary>
		/// 备注
		/// 完工申报条码档案.Misc.备注
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.String m_memo ;
		public System.String Memo
		{
			get	
			{	
				return m_memo  ;
			}
			set	
			{	
				m_memo = value ;	
			}
		}
		

				/// <summary>
		/// 实体扩展字段
		/// 完工申报条码档案.Misc.实体扩展字段
		/// </summary>
		[DataMember(IsRequired=false)]
		private UFIDA.U9.Base.FlexField.DescFlexField.DescFlexSegmentsData m_descFlexField ;
		public UFIDA.U9.Base.FlexField.DescFlexField.DescFlexSegmentsData DescFlexField
		{
			get	
			{	
				return m_descFlexField  ;
			}
			set	
			{	
				m_descFlexField = value ;	
			}
		}
		

				/// <summary>
		/// 已打印
		/// 完工申报条码档案.Misc.已打印
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.Boolean m_isPrinted ;
		public System.Boolean IsPrinted
		{
			get	
			{	
				return m_isPrinted  ;
			}
			set	
			{	
				m_isPrinted = value ;	
			}
		}
		

				/// <summary>
		/// 打印时间
		/// 完工申报条码档案.Misc.打印时间
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.DateTime m_printedOn ;
		public System.DateTime PrintedOn
		{
			get	
			{	
				return m_printedOn  ;
			}
			set	
			{	
				m_printedOn = value ;	
			}
		}
		

				/// <summary>
		/// 打印人
		/// 完工申报条码档案.Misc.打印人
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.String m_printedBy ;
		public System.String PrintedBy
		{
			get	
			{	
				return m_printedBy  ;
			}
			set	
			{	
				m_printedBy = value ;	
			}
		}
		

				/// <summary>
		/// 打印外包装条码
		/// 完工申报条码档案.Misc.打印外包装条码
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.Boolean m_isPrintWrapper ;
		public System.Boolean IsPrintWrapper
		{
			get	
			{	
				return m_isPrintWrapper  ;
			}
			set	
			{	
				m_isPrintWrapper = value ;	
			}
		}
		

				/// <summary>
		/// 打印次数
		/// 完工申报条码档案.Misc.打印次数
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.Int32 m_printCount ;
		public System.Int32 PrintCount
		{
			get	
			{	
				return m_printCount  ;
			}
			set	
			{	
				m_printCount = value ;	
			}
		}
		
		#endregion	

		#region Multi_Fields
																				
		#endregion 		
	}	

}

