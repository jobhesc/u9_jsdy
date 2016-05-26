
	using System; 
	using System.Collections;
	using System.Collections.Generic ;
	using System.Runtime.Serialization;

namespace UFIDA.U9.Cust.JSDY.BarCode
{
	/// <summary>
	/// 成品条码档案 缺省DTO 
	/// 
	/// </summary>
	[DataContract(Name = "UFIDA.U9.Cust.JSDY.BarCode.ProductBarCodeData", Namespace = "http://www.UFIDA.org/EntityData",IsReference=true)]	
	[Serializable]
    [KnownType("GetKnownTypes")]
	public partial class ProductBarCodeData : UFSoft.UBF.Business.DataTransObjectBase
	{

	    public static IList<Type> GetKnownTypes()
        {
            IList<Type> knownTypes = new List<Type>();
            
                        
                        
                        
                        
                        
                                        knownTypes.Add(typeof(UFIDA.U9.Base.Organization.OrganizationData));
                                        knownTypes.Add(typeof(UFIDA.U9.CBO.SCM.Item.ItemMasterData));
                        
                        
                        
                                        knownTypes.Add(typeof(UFIDA.U9.CBO.HR.Operator.OperatorsData));
                        
                        
                        
                        
                                        knownTypes.Add(typeof(UFIDA.U9.Complete.CompleteRpt.CompleteApplyDocData));
                                        knownTypes.Add(typeof(UFIDA.U9.Complete.CompleteRpt.CompleteApplyDocLineData));
                                        knownTypes.Add(typeof(UFIDA.U9.Complete.RCVRpt.RcvRptDocData));
                                        knownTypes.Add(typeof(UFIDA.U9.Complete.RCVRpt.RcvRptDocLineData));
                                        knownTypes.Add(typeof(UFIDA.U9.PM.Rcv.ReceivementData));
                                        knownTypes.Add(typeof(UFIDA.U9.PM.Rcv.RcvLineData));
                        
                                        knownTypes.Add(typeof(UFIDA.U9.SM.RMA.RMAData));
                                        knownTypes.Add(typeof(UFIDA.U9.SM.RMA.RMALineData));
                                        knownTypes.Add(typeof(UFIDA.U9.Lot.LotMasterData));
                                        knownTypes.Add(typeof(UFIDA.U9.InvDoc.TransferOut.TransferOutData));
                                        knownTypes.Add(typeof(UFIDA.U9.InvDoc.TransferOut.TransOutLineData));
                                        knownTypes.Add(typeof(UFIDA.U9.SM.ShipPlan.ShipPlanData));
                                        knownTypes.Add(typeof(UFIDA.U9.SM.ShipPlan.ShipPlanLineData));
            
                knownTypes.Add(typeof(UFSoft.UBF.Util.Data.MultiLangDataDict));
            return knownTypes;
        }
		/// <summary>
		/// Default Constructor
		/// </summary>
		public ProductBarCodeData()
		{
			initData() ;
		}
		private void initData()
		{
			//设置默认值
	     			
	     			
	     			
	     			
	     			
	     							SysVersion= 0; 			     			
	     			
	     			
	     							ActualLength= 0; 			     							MarkingLength= 0; 			     			
	     			
	     			
	     			
	     			
	     			
	     			
	     			
	     			
	     			
	     			
	     							ProductBarCodeKind= 0; 			     			
	     			
	     			
	     			
	     			
	     			
	     			


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
			get { return "UFIDA.U9.Cust.JSDY.BarCode.ProductBarCode" ;}
		}
		#endregion


		
		#region Properties Inner Component
	        					/// <summary>
		/// 条码状态
		/// 成品条码档案.Misc.条码状态
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.Int32 m_productBarCodeKind;
		public System.Int32 ProductBarCodeKind
		{
			get	
			{	
				return m_productBarCodeKind ;
			}
			set	
			{	
				m_productBarCodeKind = value ;
			}
		}		

			
		#endregion	

		#region Properties Outer Component
		
				/// <summary>
		/// ID
		/// 成品条码档案.Key.ID
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
		/// 成品条码档案.Sys.创建时间
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
		/// 成品条码档案.Sys.创建人
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
		/// 成品条码档案.Sys.修改时间
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
		/// 成品条码档案.Sys.修改人
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
		/// 成品条码档案.Sys.事务版本
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
		/// 成品条码档案.Misc.组织
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
		/// 成品条码档案.Misc.组织
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
		

		
		private UFSoft.UBF.Business.BusinessEntity.EntityKey m_item_SKey ;
		/// <summary>
		/// 料品 序列化Key属性。（传递跨组织序列列字段）
		/// 成品条码档案.Misc.料品
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
		/// 成品条码档案.Misc.料品
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
		/// 条码
		/// 成品条码档案.Misc.条码
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
		

				/// <summary>
		/// 实际长度
		/// 成品条码档案.Misc.实际长度
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
		/// 成品条码档案.Misc.合格证标示长度
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
		

		
		private UFSoft.UBF.Business.BusinessEntity.EntityKey m_operators_SKey ;
		/// <summary>
		/// 检验员 序列化Key属性。（传递跨组织序列列字段）
		/// 成品条码档案.Misc.检验员
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
		/// 成品条码档案.Misc.检验员
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
		/// 扫描时间
		/// 成品条码档案.Misc.扫描时间
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.DateTime m_scanOn ;
		public System.DateTime ScanOn
		{
			get	
			{	
				return m_scanOn  ;
			}
			set	
			{	
				m_scanOn = value ;	
			}
		}
		

				/// <summary>
		/// 扫描人
		/// 成品条码档案.Misc.扫描人
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.String m_scanBy ;
		public System.String ScanBy
		{
			get	
			{	
				return m_scanBy  ;
			}
			set	
			{	
				m_scanBy = value ;	
			}
		}
		

				/// <summary>
		/// 打印时间
		/// 成品条码档案.Misc.打印时间
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
		/// 成品条码档案.Misc.打印人
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
		

		
		private UFSoft.UBF.Business.BusinessEntity.EntityKey m_completeApplyDoc_SKey ;
		/// <summary>
		/// 完工申报单 序列化Key属性。（传递跨组织序列列字段）
		/// 成品条码档案.Misc.完工申报单
		/// </summary>
		[DataMember(IsRequired=false)]
		public UFSoft.UBF.Business.BusinessEntity.EntityKey CompleteApplyDoc_SKey
		{
			get 
			{
				return m_completeApplyDoc_SKey ;					
			}
			set
			{
				 m_completeApplyDoc_SKey = value ;	
			}
		}
		/// <summary>
		/// 完工申报单
		/// 成品条码档案.Misc.完工申报单
		/// </summary>
		[DataMember(IsRequired=false)]
		public System.Int64 CompleteApplyDoc
		{
			get	
			{	
				if (CompleteApplyDoc_SKey == null)
					return UFSoft.UBF.Business.Entity.EmptyObjectValue ;
				else
					return CompleteApplyDoc_SKey.ID ;
			}
			set	
			{	
				if (value == 0 || value == UFSoft.UBF.Business.Entity.EmptyObjectValue )
					CompleteApplyDoc_SKey = null ;
				else
				{
					if (CompleteApplyDoc_SKey == null )
						CompleteApplyDoc_SKey = new UFSoft.UBF.Business.BusinessEntity.EntityKey(value,"UFIDA.U9.Complete.CompleteRpt.CompleteApplyDoc") ;
					else
						CompleteApplyDoc_SKey.ID = value ;
				}
			}
		}
		

		
		private UFSoft.UBF.Business.BusinessEntity.EntityKey m_completeApplyDocLine_SKey ;
		/// <summary>
		/// 完工申报单行 序列化Key属性。（传递跨组织序列列字段）
		/// 成品条码档案.Misc.完工申报单行
		/// </summary>
		[DataMember(IsRequired=false)]
		public UFSoft.UBF.Business.BusinessEntity.EntityKey CompleteApplyDocLine_SKey
		{
			get 
			{
				return m_completeApplyDocLine_SKey ;					
			}
			set
			{
				 m_completeApplyDocLine_SKey = value ;	
			}
		}
		/// <summary>
		/// 完工申报单行
		/// 成品条码档案.Misc.完工申报单行
		/// </summary>
		[DataMember(IsRequired=false)]
		public System.Int64 CompleteApplyDocLine
		{
			get	
			{	
				if (CompleteApplyDocLine_SKey == null)
					return UFSoft.UBF.Business.Entity.EmptyObjectValue ;
				else
					return CompleteApplyDocLine_SKey.ID ;
			}
			set	
			{	
				if (value == 0 || value == UFSoft.UBF.Business.Entity.EmptyObjectValue )
					CompleteApplyDocLine_SKey = null ;
				else
				{
					if (CompleteApplyDocLine_SKey == null )
						CompleteApplyDocLine_SKey = new UFSoft.UBF.Business.BusinessEntity.EntityKey(value,"UFIDA.U9.Complete.CompleteRpt.CompleteApplyDocLine") ;
					else
						CompleteApplyDocLine_SKey.ID = value ;
				}
			}
		}
		

		
		private UFSoft.UBF.Business.BusinessEntity.EntityKey m_rcvRptDoc_SKey ;
		/// <summary>
		/// 成品入库单 序列化Key属性。（传递跨组织序列列字段）
		/// 成品条码档案.Misc.成品入库单
		/// </summary>
		[DataMember(IsRequired=false)]
		public UFSoft.UBF.Business.BusinessEntity.EntityKey RcvRptDoc_SKey
		{
			get 
			{
				return m_rcvRptDoc_SKey ;					
			}
			set
			{
				 m_rcvRptDoc_SKey = value ;	
			}
		}
		/// <summary>
		/// 成品入库单
		/// 成品条码档案.Misc.成品入库单
		/// </summary>
		[DataMember(IsRequired=false)]
		public System.Int64 RcvRptDoc
		{
			get	
			{	
				if (RcvRptDoc_SKey == null)
					return UFSoft.UBF.Business.Entity.EmptyObjectValue ;
				else
					return RcvRptDoc_SKey.ID ;
			}
			set	
			{	
				if (value == 0 || value == UFSoft.UBF.Business.Entity.EmptyObjectValue )
					RcvRptDoc_SKey = null ;
				else
				{
					if (RcvRptDoc_SKey == null )
						RcvRptDoc_SKey = new UFSoft.UBF.Business.BusinessEntity.EntityKey(value,"UFIDA.U9.Complete.RCVRpt.RcvRptDoc") ;
					else
						RcvRptDoc_SKey.ID = value ;
				}
			}
		}
		

		
		private UFSoft.UBF.Business.BusinessEntity.EntityKey m_rcvRptDocLine_SKey ;
		/// <summary>
		/// 成品入库单行 序列化Key属性。（传递跨组织序列列字段）
		/// 成品条码档案.Misc.成品入库单行
		/// </summary>
		[DataMember(IsRequired=false)]
		public UFSoft.UBF.Business.BusinessEntity.EntityKey RcvRptDocLine_SKey
		{
			get 
			{
				return m_rcvRptDocLine_SKey ;					
			}
			set
			{
				 m_rcvRptDocLine_SKey = value ;	
			}
		}
		/// <summary>
		/// 成品入库单行
		/// 成品条码档案.Misc.成品入库单行
		/// </summary>
		[DataMember(IsRequired=false)]
		public System.Int64 RcvRptDocLine
		{
			get	
			{	
				if (RcvRptDocLine_SKey == null)
					return UFSoft.UBF.Business.Entity.EmptyObjectValue ;
				else
					return RcvRptDocLine_SKey.ID ;
			}
			set	
			{	
				if (value == 0 || value == UFSoft.UBF.Business.Entity.EmptyObjectValue )
					RcvRptDocLine_SKey = null ;
				else
				{
					if (RcvRptDocLine_SKey == null )
						RcvRptDocLine_SKey = new UFSoft.UBF.Business.BusinessEntity.EntityKey(value,"UFIDA.U9.Complete.RCVRpt.RcvRptDocLine") ;
					else
						RcvRptDocLine_SKey.ID = value ;
				}
			}
		}
		

		
		private UFSoft.UBF.Business.BusinessEntity.EntityKey m_receivement_SKey ;
		/// <summary>
		/// 销售退回收货单 序列化Key属性。（传递跨组织序列列字段）
		/// 成品条码档案.Misc.销售退回收货单
		/// </summary>
		[DataMember(IsRequired=false)]
		public UFSoft.UBF.Business.BusinessEntity.EntityKey Receivement_SKey
		{
			get 
			{
				return m_receivement_SKey ;					
			}
			set
			{
				 m_receivement_SKey = value ;	
			}
		}
		/// <summary>
		/// 销售退回收货单
		/// 成品条码档案.Misc.销售退回收货单
		/// </summary>
		[DataMember(IsRequired=false)]
		public System.Int64 Receivement
		{
			get	
			{	
				if (Receivement_SKey == null)
					return UFSoft.UBF.Business.Entity.EmptyObjectValue ;
				else
					return Receivement_SKey.ID ;
			}
			set	
			{	
				if (value == 0 || value == UFSoft.UBF.Business.Entity.EmptyObjectValue )
					Receivement_SKey = null ;
				else
				{
					if (Receivement_SKey == null )
						Receivement_SKey = new UFSoft.UBF.Business.BusinessEntity.EntityKey(value,"UFIDA.U9.PM.Rcv.Receivement") ;
					else
						Receivement_SKey.ID = value ;
				}
			}
		}
		

		
		private UFSoft.UBF.Business.BusinessEntity.EntityKey m_rcvLine_SKey ;
		/// <summary>
		/// 销售退回收货行 序列化Key属性。（传递跨组织序列列字段）
		/// 成品条码档案.Misc.销售退回收货行
		/// </summary>
		[DataMember(IsRequired=false)]
		public UFSoft.UBF.Business.BusinessEntity.EntityKey RcvLine_SKey
		{
			get 
			{
				return m_rcvLine_SKey ;					
			}
			set
			{
				 m_rcvLine_SKey = value ;	
			}
		}
		/// <summary>
		/// 销售退回收货行
		/// 成品条码档案.Misc.销售退回收货行
		/// </summary>
		[DataMember(IsRequired=false)]
		public System.Int64 RcvLine
		{
			get	
			{	
				if (RcvLine_SKey == null)
					return UFSoft.UBF.Business.Entity.EmptyObjectValue ;
				else
					return RcvLine_SKey.ID ;
			}
			set	
			{	
				if (value == 0 || value == UFSoft.UBF.Business.Entity.EmptyObjectValue )
					RcvLine_SKey = null ;
				else
				{
					if (RcvLine_SKey == null )
						RcvLine_SKey = new UFSoft.UBF.Business.BusinessEntity.EntityKey(value,"UFIDA.U9.PM.Rcv.RcvLine") ;
					else
						RcvLine_SKey.ID = value ;
				}
			}
		}
		

		
		private UFSoft.UBF.Business.BusinessEntity.EntityKey m_rMA_SKey ;
		/// <summary>
		/// 退回处理单 序列化Key属性。（传递跨组织序列列字段）
		/// 成品条码档案.Misc.退回处理单
		/// </summary>
		[DataMember(IsRequired=false)]
		public UFSoft.UBF.Business.BusinessEntity.EntityKey RMA_SKey
		{
			get 
			{
				return m_rMA_SKey ;					
			}
			set
			{
				 m_rMA_SKey = value ;	
			}
		}
		/// <summary>
		/// 退回处理单
		/// 成品条码档案.Misc.退回处理单
		/// </summary>
		[DataMember(IsRequired=false)]
		public System.Int64 RMA
		{
			get	
			{	
				if (RMA_SKey == null)
					return UFSoft.UBF.Business.Entity.EmptyObjectValue ;
				else
					return RMA_SKey.ID ;
			}
			set	
			{	
				if (value == 0 || value == UFSoft.UBF.Business.Entity.EmptyObjectValue )
					RMA_SKey = null ;
				else
				{
					if (RMA_SKey == null )
						RMA_SKey = new UFSoft.UBF.Business.BusinessEntity.EntityKey(value,"UFIDA.U9.SM.RMA.RMA") ;
					else
						RMA_SKey.ID = value ;
				}
			}
		}
		

		
		private UFSoft.UBF.Business.BusinessEntity.EntityKey m_rMALine_SKey ;
		/// <summary>
		/// 退回处理行 序列化Key属性。（传递跨组织序列列字段）
		/// 成品条码档案.Misc.退回处理行
		/// </summary>
		[DataMember(IsRequired=false)]
		public UFSoft.UBF.Business.BusinessEntity.EntityKey RMALine_SKey
		{
			get 
			{
				return m_rMALine_SKey ;					
			}
			set
			{
				 m_rMALine_SKey = value ;	
			}
		}
		/// <summary>
		/// 退回处理行
		/// 成品条码档案.Misc.退回处理行
		/// </summary>
		[DataMember(IsRequired=false)]
		public System.Int64 RMALine
		{
			get	
			{	
				if (RMALine_SKey == null)
					return UFSoft.UBF.Business.Entity.EmptyObjectValue ;
				else
					return RMALine_SKey.ID ;
			}
			set	
			{	
				if (value == 0 || value == UFSoft.UBF.Business.Entity.EmptyObjectValue )
					RMALine_SKey = null ;
				else
				{
					if (RMALine_SKey == null )
						RMALine_SKey = new UFSoft.UBF.Business.BusinessEntity.EntityKey(value,"UFIDA.U9.SM.RMA.RMALine") ;
					else
						RMALine_SKey.ID = value ;
				}
			}
		}
		

		
		private UFSoft.UBF.Business.BusinessEntity.EntityKey m_lot_SKey ;
		/// <summary>
		/// 批号 序列化Key属性。（传递跨组织序列列字段）
		/// 成品条码档案.Misc.批号
		/// </summary>
		[DataMember(IsRequired=false)]
		public UFSoft.UBF.Business.BusinessEntity.EntityKey Lot_SKey
		{
			get 
			{
				return m_lot_SKey ;					
			}
			set
			{
				 m_lot_SKey = value ;	
			}
		}
		/// <summary>
		/// 批号
		/// 成品条码档案.Misc.批号
		/// </summary>
		[DataMember(IsRequired=false)]
		public System.Int64 Lot
		{
			get	
			{	
				if (Lot_SKey == null)
					return UFSoft.UBF.Business.Entity.EmptyObjectValue ;
				else
					return Lot_SKey.ID ;
			}
			set	
			{	
				if (value == 0 || value == UFSoft.UBF.Business.Entity.EmptyObjectValue )
					Lot_SKey = null ;
				else
				{
					if (Lot_SKey == null )
						Lot_SKey = new UFSoft.UBF.Business.BusinessEntity.EntityKey(value,"UFIDA.U9.Lot.LotMaster") ;
					else
						Lot_SKey.ID = value ;
				}
			}
		}
		

		
		private UFSoft.UBF.Business.BusinessEntity.EntityKey m_transferOut_SKey ;
		/// <summary>
		/// 调出单 序列化Key属性。（传递跨组织序列列字段）
		/// 成品条码档案.Misc.调出单
		/// </summary>
		[DataMember(IsRequired=false)]
		public UFSoft.UBF.Business.BusinessEntity.EntityKey TransferOut_SKey
		{
			get 
			{
				return m_transferOut_SKey ;					
			}
			set
			{
				 m_transferOut_SKey = value ;	
			}
		}
		/// <summary>
		/// 调出单
		/// 成品条码档案.Misc.调出单
		/// </summary>
		[DataMember(IsRequired=false)]
		public System.Int64 TransferOut
		{
			get	
			{	
				if (TransferOut_SKey == null)
					return UFSoft.UBF.Business.Entity.EmptyObjectValue ;
				else
					return TransferOut_SKey.ID ;
			}
			set	
			{	
				if (value == 0 || value == UFSoft.UBF.Business.Entity.EmptyObjectValue )
					TransferOut_SKey = null ;
				else
				{
					if (TransferOut_SKey == null )
						TransferOut_SKey = new UFSoft.UBF.Business.BusinessEntity.EntityKey(value,"UFIDA.U9.InvDoc.TransferOut.TransferOut") ;
					else
						TransferOut_SKey.ID = value ;
				}
			}
		}
		

		
		private UFSoft.UBF.Business.BusinessEntity.EntityKey m_transferOutLine_SKey ;
		/// <summary>
		/// 调出单行 序列化Key属性。（传递跨组织序列列字段）
		/// 成品条码档案.Misc.调出单行
		/// </summary>
		[DataMember(IsRequired=false)]
		public UFSoft.UBF.Business.BusinessEntity.EntityKey TransferOutLine_SKey
		{
			get 
			{
				return m_transferOutLine_SKey ;					
			}
			set
			{
				 m_transferOutLine_SKey = value ;	
			}
		}
		/// <summary>
		/// 调出单行
		/// 成品条码档案.Misc.调出单行
		/// </summary>
		[DataMember(IsRequired=false)]
		public System.Int64 TransferOutLine
		{
			get	
			{	
				if (TransferOutLine_SKey == null)
					return UFSoft.UBF.Business.Entity.EmptyObjectValue ;
				else
					return TransferOutLine_SKey.ID ;
			}
			set	
			{	
				if (value == 0 || value == UFSoft.UBF.Business.Entity.EmptyObjectValue )
					TransferOutLine_SKey = null ;
				else
				{
					if (TransferOutLine_SKey == null )
						TransferOutLine_SKey = new UFSoft.UBF.Business.BusinessEntity.EntityKey(value,"UFIDA.U9.InvDoc.TransferOut.TransOutLine") ;
					else
						TransferOutLine_SKey.ID = value ;
				}
			}
		}
		

		
		private UFSoft.UBF.Business.BusinessEntity.EntityKey m_shipPlan_SKey ;
		/// <summary>
		/// 出货计划 序列化Key属性。（传递跨组织序列列字段）
		/// 成品条码档案.Misc.出货计划
		/// </summary>
		[DataMember(IsRequired=false)]
		public UFSoft.UBF.Business.BusinessEntity.EntityKey ShipPlan_SKey
		{
			get 
			{
				return m_shipPlan_SKey ;					
			}
			set
			{
				 m_shipPlan_SKey = value ;	
			}
		}
		/// <summary>
		/// 出货计划
		/// 成品条码档案.Misc.出货计划
		/// </summary>
		[DataMember(IsRequired=false)]
		public System.Int64 ShipPlan
		{
			get	
			{	
				if (ShipPlan_SKey == null)
					return UFSoft.UBF.Business.Entity.EmptyObjectValue ;
				else
					return ShipPlan_SKey.ID ;
			}
			set	
			{	
				if (value == 0 || value == UFSoft.UBF.Business.Entity.EmptyObjectValue )
					ShipPlan_SKey = null ;
				else
				{
					if (ShipPlan_SKey == null )
						ShipPlan_SKey = new UFSoft.UBF.Business.BusinessEntity.EntityKey(value,"UFIDA.U9.SM.ShipPlan.ShipPlan") ;
					else
						ShipPlan_SKey.ID = value ;
				}
			}
		}
		

		
		private UFSoft.UBF.Business.BusinessEntity.EntityKey m_shipPlanLine_SKey ;
		/// <summary>
		/// 出货计划行 序列化Key属性。（传递跨组织序列列字段）
		/// 成品条码档案.Misc.出货计划行
		/// </summary>
		[DataMember(IsRequired=false)]
		public UFSoft.UBF.Business.BusinessEntity.EntityKey ShipPlanLine_SKey
		{
			get 
			{
				return m_shipPlanLine_SKey ;					
			}
			set
			{
				 m_shipPlanLine_SKey = value ;	
			}
		}
		/// <summary>
		/// 出货计划行
		/// 成品条码档案.Misc.出货计划行
		/// </summary>
		[DataMember(IsRequired=false)]
		public System.Int64 ShipPlanLine
		{
			get	
			{	
				if (ShipPlanLine_SKey == null)
					return UFSoft.UBF.Business.Entity.EmptyObjectValue ;
				else
					return ShipPlanLine_SKey.ID ;
			}
			set	
			{	
				if (value == 0 || value == UFSoft.UBF.Business.Entity.EmptyObjectValue )
					ShipPlanLine_SKey = null ;
				else
				{
					if (ShipPlanLine_SKey == null )
						ShipPlanLine_SKey = new UFSoft.UBF.Business.BusinessEntity.EntityKey(value,"UFIDA.U9.SM.ShipPlan.ShipPlanLine") ;
					else
						ShipPlanLine_SKey.ID = value ;
				}
			}
		}
		
		#endregion	

		#region Multi_Fields
																														
		#endregion 		
	}	

}

