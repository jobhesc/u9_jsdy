using System;
using System.Collections;
using System.Collections.Generic ;
using System.Runtime.Serialization;

namespace UFIDA.U9.Cust.JSDY.BarCode
{
	
	/// <summary>
	/// 实体: 成品条码档案
	/// 
	/// </summary>
	[Serializable]	
	public  partial class ProductBarCode : UFSoft.UBF.Business.BusinessEntity
	{





		#region Create Instance
		/// <summary>
		/// Constructor
		/// </summary>
		public ProductBarCode(){
		}


	
		/// <summary>
		/// Create Instance
		/// </summary>
		/// <returns>Instance</returns>
		public  static ProductBarCode Create() {
			ProductBarCode entity = (ProductBarCode)UFSoft.UBF.Business.Entity.Create(CurrentClassKey, null);
																																																																																													 
			return entity;
		}

		/// <summary>
		/// use for Serialization
		/// </summary>
		protected ProductBarCode(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
			:base(info,context)
		{
		}
		protected override bool IsMainEntity
		{
			get { return true ;}
		}
		#endregion

		#region Create Default 
		/// <summary>
		/// Create Instance
		/// </summary>
		/// <returns>Default Instance</returns>
		public static ProductBarCode CreateDefault() {
		#if Test		
			return CreateDefault_Extend() ;
		#else 
		    return null;
		#endif
		}
		/// <summary>
		/// Create DefaultComponent
		/// </summary>
		/// <returns>DefaultComponent Instance</returns>
		public static ProductBarCode CreateDefaultComponent(){
		#if Test		
			return CreateDefaultComponent_Extend() ;
		#else 
		    return null;
		#endif
		}

		#endregion

		#region ClassKey
		protected override string ClassKey_FullName
        {
            get { return "UFIDA.U9.Cust.JSDY.BarCode.ProductBarCode"; }    
        }
		//private static UFSoft.UBF.PL.IClassKey _currentClassKey;
		//由于可能每次访问时的Enterprise不一样，所以每次重取.
		private static UFSoft.UBF.PL.IClassKey CurrentClassKey
		{
			get {
				return  UFSoft.UBF.PL.ClassKeyFacatory.CreateKey("UFIDA.U9.Cust.JSDY.BarCode.ProductBarCode");
			}
		}
		


		#endregion 

		#region EntityKey
		/// <summary>
		/// Strong Class ProductBarCode EntityKey 
		/// </summary>
		[Serializable()]
	    [DataContract(Name = "EntityKey", Namespace = "UFSoft.UBF.Business.BusinessEntity")]
		public new partial class EntityKey : UFSoft.UBF.Business.BusinessEntity.EntityKey
		{
			public EntityKey(long id): this(id, "UFIDA.U9.Cust.JSDY.BarCode.ProductBarCode")
			{}
			//Construct using by freamwork.
			protected EntityKey(long id , string entityType):base(id,entityType)
			{}
			/// <summary>
			/// 得到当前Key所对应的Entity．(Session级有缓存,性能不用考虑．)
			/// </summary>
			public new ProductBarCode GetEntity()
			{
				return (ProductBarCode)base.GetEntity();
			}
			public static bool operator ==(EntityKey obja, EntityKey objb)
			{
				if (object.ReferenceEquals(obja, null))
				{
					if (object.ReferenceEquals(objb, null))
						return true;
					return false;
				}
				return obja.Equals(objb);
			}
			public static bool operator !=(EntityKey obja, EntityKey objb)
			{
				return !(obja == objb);
			}
			public override int GetHashCode()
			{
				return base.GetHashCode();
			}
			public override bool Equals(object obj)
			{
				return base.Equals(obj);
			}
		}
		protected override UFSoft.UBF.Business.BusinessEntity.EntityKey CreateEntityKey()
		{
			return new EntityKey(this.ID);
		}
		/// <summary>
		/// Strong Class EntityKey Property
		/// </summary>
		public new EntityKey Key
		{
			get
			{
				return base.Key as EntityKey;
			}
		}
		#endregion

		#region Finder
		/// <summary>
		/// Strong Class EntityFinder
		/// </summary>
		public new partial class EntityFinder : UFSoft.UBF.Business.BusinessEntity.EntityFinder<ProductBarCode> 
		{
		    public EntityFinder():base(CurrentClassKey)
			{
			}
			public new EntityList FindAll(string opath, params UFSoft.UBF.PL.OqlParam[] oqlParameters)
			{
				return new EntityList(base.FindAll(opath, oqlParameters));                
			}
			public new EntityList FindAll(UFSoft.UBF.PL.ObjectQueryOptions options, string opath, params UFSoft.UBF.PL.OqlParam[] oqlParameters)
			{
				return new EntityList(base.FindAll(options,opath, oqlParameters));                
			}









						
		}

		//private static EntityFinder _finder  ;

		/// <summary>
		/// Finder
		/// </summary>
		public static EntityFinder Finder {
			get {
				//if (_finder == null)
				//	_finder =  new EntityFinder() ;
				return new EntityFinder() ;
			}
		}
		#endregion
			
		#region List

		/// <summary>
		/// EntityList
		/// </summary>
		public partial class EntityList :UFSoft.UBF.Business.Entity.EntityList<ProductBarCode>{
		    #region constructor 
		    /// <summary>
		    /// EntityList 无参的构造方法,用于其它特殊情况
		    /// </summary>
		    public EntityList()
		    {
		    }

		    /// <summary>
		    /// EntityList Constructor With Collection .主要用于查询返回实体集时使用.
		    /// </summary>
		    public EntityList(IList list) : base(list)
		    { 
		    }
		    
		    /// <summary>
		    ///  EntityList Constructor , used by  peresidence
		    /// </summary>
		    /// <param name="childAttrName">this EntityList's child Attribute Name</param>
		    /// <param name="parentEntity">this EntityList's Parent Entity </param>
		    /// <param name="parentAttrName">Parent Entity's Attribute Name with this EntityList's </param>
		    /// <param name="list">list </param>
		    public EntityList(string childAttrName,UFSoft.UBF.Business.BusinessEntity parentEntity, string parentAttrName, IList list)
			    :base(childAttrName,parentEntity,parentAttrName,list) 
		    { 
			
		    }

		    #endregion 
		    //用于一对多关联.	
		    internal IList InnerList
		    {
		    	//get { return this.innerList; }
		    	set {
		    		if (value != null)
		    		    this.innerList = value; 
		    	}
		    }
		    protected override bool IsMainEntity
		    {
			    get { return true ;}
		    }
		}
		#endregion
		
		#region Typeed OriginalData
		/// <summary>
		/// 当前实体对象的旧数据对象(为上次更新后的数据)
		/// </summary>
		public new EntityOriginal OriginalData
		{
			get {
				return (EntityOriginal)base.OriginalData;
			}
            protected set
            {
				base.OriginalData = value ;
            }
		}
		protected override UFSoft.UBF.Business.BusinessEntity.EntityOriginal CreateOriginalData()
		{
			return new EntityOriginal(this);
		}
		
		public new partial class EntityOriginal: UFSoft.UBF.Business.Entity.EntityOriginal
		{
		    //private ProductBarCode ContainerEntity ;
		    public  new ProductBarCode ContainerEntity 
		    {
				get { return  (ProductBarCode)base.ContainerEntity ;}
				set { base.ContainerEntity = value ;}
		    }
		    
		    public EntityOriginal(ProductBarCode container)
		    {
				if (container == null )
					throw new ArgumentNullException("container") ;
				ContainerEntity = container ;
				base.innerData = container.OldValues ;
				InitInnerData();
		    }
	




			#region member					
			
			/// <summary>
			///  OrginalData属性。只可读。
			/// ID (该属性不可为空,且无默认值)
			/// 成品条码档案.Key.ID
			/// </summary>
			/// <value></value>
			public  System.Int64 ID
			{
				get
				{
					System.Int64 value  = (System.Int64)base.GetValue("ID");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 创建时间 (该属性可为空,且无默认值)
			/// 成品条码档案.Sys.创建时间
			/// </summary>
			/// <value></value>
			public  System.DateTime CreatedOn
			{
				get
				{
					object obj = base.GetValue("CreatedOn");
					if (obj == null)
						return System.DateTime.MinValue;
					else
					       return (System.DateTime)obj;
				}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 创建人 (该属性可为空,且无默认值)
			/// 成品条码档案.Sys.创建人
			/// </summary>
			/// <value></value>
			public  System.String CreatedBy
			{
				get
				{
					System.String value  = (System.String)base.GetValue("CreatedBy");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 修改时间 (该属性可为空,且无默认值)
			/// 成品条码档案.Sys.修改时间
			/// </summary>
			/// <value></value>
			public  System.DateTime ModifiedOn
			{
				get
				{
					object obj = base.GetValue("ModifiedOn");
					if (obj == null)
						return System.DateTime.MinValue;
					else
					       return (System.DateTime)obj;
				}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 修改人 (该属性可为空,且无默认值)
			/// 成品条码档案.Sys.修改人
			/// </summary>
			/// <value></value>
			public  System.String ModifiedBy
			{
				get
				{
					System.String value  = (System.String)base.GetValue("ModifiedBy");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 事务版本 (该属性可为空,但有默认值)
			/// 成品条码档案.Sys.事务版本
			/// </summary>
			/// <value></value>
			public  System.Int64 SysVersion
			{
				get
				{
					System.Int64 value  = (System.Int64)base.GetValue("SysVersion");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 组织 (该属性不可为空,且无默认值)
			/// 成品条码档案.Misc.组织
			/// </summary>
			/// <value></value>
			public  UFIDA.U9.Base.Organization.Organization Org
			{
				get
				{
					if (OrgKey == null)
						return null ;
					UFIDA.U9.Base.Organization.Organization value =  (UFIDA.U9.Base.Organization.Organization)OrgKey.GetEntity();
					return value ;
				}
			}
		


   		private UFIDA.U9.Base.Organization.Organization.EntityKey m_OrgKey ;
		/// <summary>
		/// EntityKey 属性
		/// 组织 的Key (该属性不可为空,且无默认值)
		/// 成品条码档案.Misc.组织
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.Base.Organization.Organization.EntityKey OrgKey
		{
			get 
			{
				object obj = base.GetValue("Org") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_OrgKey==null || m_OrgKey.ID != key )
					m_OrgKey = new UFIDA.U9.Base.Organization.Organization.EntityKey(key); 
				return m_OrgKey ;
			}
		}

				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 料品 (该属性不可为空,且无默认值)
			/// 成品条码档案.Misc.料品
			/// </summary>
			/// <value></value>
			public  UFIDA.U9.CBO.SCM.Item.ItemMaster Item
			{
				get
				{
					if (ItemKey == null)
						return null ;
					UFIDA.U9.CBO.SCM.Item.ItemMaster value =  (UFIDA.U9.CBO.SCM.Item.ItemMaster)ItemKey.GetEntity();
					return value ;
				}
			}
		


   		private UFIDA.U9.CBO.SCM.Item.ItemMaster.EntityKey m_ItemKey ;
		/// <summary>
		/// EntityKey 属性
		/// 料品 的Key (该属性不可为空,且无默认值)
		/// 成品条码档案.Misc.料品
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.CBO.SCM.Item.ItemMaster.EntityKey ItemKey
		{
			get 
			{
				object obj = base.GetValue("Item") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_ItemKey==null || m_ItemKey.ID != key )
					m_ItemKey = new UFIDA.U9.CBO.SCM.Item.ItemMaster.EntityKey(key); 
				return m_ItemKey ;
			}
		}

				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 条码 (该属性不可为空,且无默认值)
			/// 成品条码档案.Misc.条码
			/// </summary>
			/// <value></value>
			public  System.String BarCode
			{
				get
				{
					System.String value  = (System.String)base.GetValue("BarCode");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 实际长度 (该属性可为空,但有默认值)
			/// 成品条码档案.Misc.实际长度
			/// </summary>
			/// <value></value>
			public  System.Int32 ActualLength
			{
				get
				{
					System.Int32 value  = (System.Int32)base.GetValue("ActualLength");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 合格证标示长度 (该属性可为空,但有默认值)
			/// 成品条码档案.Misc.合格证标示长度
			/// </summary>
			/// <value></value>
			public  System.Int32 MarkingLength
			{
				get
				{
					System.Int32 value  = (System.Int32)base.GetValue("MarkingLength");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 检验员 (该属性可为空,且无默认值)
			/// 成品条码档案.Misc.检验员
			/// </summary>
			/// <value></value>
			public  UFIDA.U9.CBO.HR.Operator.Operators Operators
			{
				get
				{
					if (OperatorsKey == null)
						return null ;
					UFIDA.U9.CBO.HR.Operator.Operators value =  (UFIDA.U9.CBO.HR.Operator.Operators)OperatorsKey.GetEntity();
					return value ;
				}
			}
		


   		private UFIDA.U9.CBO.HR.Operator.Operators.EntityKey m_OperatorsKey ;
		/// <summary>
		/// EntityKey 属性
		/// 检验员 的Key (该属性可为空,且无默认值)
		/// 成品条码档案.Misc.检验员
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.CBO.HR.Operator.Operators.EntityKey OperatorsKey
		{
			get 
			{
				object obj = base.GetValue("Operators") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_OperatorsKey==null || m_OperatorsKey.ID != key )
					m_OperatorsKey = new UFIDA.U9.CBO.HR.Operator.Operators.EntityKey(key); 
				return m_OperatorsKey ;
			}
		}

				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 扫描时间 (该属性可为空,且无默认值)
			/// 成品条码档案.Misc.扫描时间
			/// </summary>
			/// <value></value>
			public  System.DateTime ScanOn
			{
				get
				{
					object obj = base.GetValue("ScanOn");
					if (obj == null)
						return System.DateTime.MinValue;
					else
					       return (System.DateTime)obj;
				}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 扫描人 (该属性可为空,且无默认值)
			/// 成品条码档案.Misc.扫描人
			/// </summary>
			/// <value></value>
			public  System.String ScanBy
			{
				get
				{
					System.String value  = (System.String)base.GetValue("ScanBy");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 打印时间 (该属性可为空,且无默认值)
			/// 成品条码档案.Misc.打印时间
			/// </summary>
			/// <value></value>
			public  System.DateTime PrintedOn
			{
				get
				{
					object obj = base.GetValue("PrintedOn");
					if (obj == null)
						return System.DateTime.MinValue;
					else
					       return (System.DateTime)obj;
				}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 打印人 (该属性可为空,且无默认值)
			/// 成品条码档案.Misc.打印人
			/// </summary>
			/// <value></value>
			public  System.String PrintedBy
			{
				get
				{
					System.String value  = (System.String)base.GetValue("PrintedBy");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 完工申报单 (该属性可为空,且无默认值)
			/// 成品条码档案.Misc.完工申报单
			/// </summary>
			/// <value></value>
			public  UFIDA.U9.Complete.CompleteRpt.CompleteApplyDoc CompleteApplyDoc
			{
				get
				{
					if (CompleteApplyDocKey == null)
						return null ;
					UFIDA.U9.Complete.CompleteRpt.CompleteApplyDoc value =  (UFIDA.U9.Complete.CompleteRpt.CompleteApplyDoc)CompleteApplyDocKey.GetEntity();
					return value ;
				}
			}
		


   		private UFIDA.U9.Complete.CompleteRpt.CompleteApplyDoc.EntityKey m_CompleteApplyDocKey ;
		/// <summary>
		/// EntityKey 属性
		/// 完工申报单 的Key (该属性可为空,且无默认值)
		/// 成品条码档案.Misc.完工申报单
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.Complete.CompleteRpt.CompleteApplyDoc.EntityKey CompleteApplyDocKey
		{
			get 
			{
				object obj = base.GetValue("CompleteApplyDoc") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_CompleteApplyDocKey==null || m_CompleteApplyDocKey.ID != key )
					m_CompleteApplyDocKey = new UFIDA.U9.Complete.CompleteRpt.CompleteApplyDoc.EntityKey(key); 
				return m_CompleteApplyDocKey ;
			}
		}

				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 完工申报单行 (该属性可为空,且无默认值)
			/// 成品条码档案.Misc.完工申报单行
			/// </summary>
			/// <value></value>
			public  UFIDA.U9.Complete.CompleteRpt.CompleteApplyDocLine CompleteApplyDocLine
			{
				get
				{
					if (CompleteApplyDocLineKey == null)
						return null ;
					UFIDA.U9.Complete.CompleteRpt.CompleteApplyDocLine value =  (UFIDA.U9.Complete.CompleteRpt.CompleteApplyDocLine)CompleteApplyDocLineKey.GetEntity();
					return value ;
				}
			}
		


   		private UFIDA.U9.Complete.CompleteRpt.CompleteApplyDocLine.EntityKey m_CompleteApplyDocLineKey ;
		/// <summary>
		/// EntityKey 属性
		/// 完工申报单行 的Key (该属性可为空,且无默认值)
		/// 成品条码档案.Misc.完工申报单行
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.Complete.CompleteRpt.CompleteApplyDocLine.EntityKey CompleteApplyDocLineKey
		{
			get 
			{
				object obj = base.GetValue("CompleteApplyDocLine") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_CompleteApplyDocLineKey==null || m_CompleteApplyDocLineKey.ID != key )
					m_CompleteApplyDocLineKey = new UFIDA.U9.Complete.CompleteRpt.CompleteApplyDocLine.EntityKey(key); 
				return m_CompleteApplyDocLineKey ;
			}
		}

				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 成品入库单 (该属性可为空,且无默认值)
			/// 成品条码档案.Misc.成品入库单
			/// </summary>
			/// <value></value>
			public  UFIDA.U9.Complete.RCVRpt.RcvRptDoc RcvRptDoc
			{
				get
				{
					if (RcvRptDocKey == null)
						return null ;
					UFIDA.U9.Complete.RCVRpt.RcvRptDoc value =  (UFIDA.U9.Complete.RCVRpt.RcvRptDoc)RcvRptDocKey.GetEntity();
					return value ;
				}
			}
		


   		private UFIDA.U9.Complete.RCVRpt.RcvRptDoc.EntityKey m_RcvRptDocKey ;
		/// <summary>
		/// EntityKey 属性
		/// 成品入库单 的Key (该属性可为空,且无默认值)
		/// 成品条码档案.Misc.成品入库单
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.Complete.RCVRpt.RcvRptDoc.EntityKey RcvRptDocKey
		{
			get 
			{
				object obj = base.GetValue("RcvRptDoc") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_RcvRptDocKey==null || m_RcvRptDocKey.ID != key )
					m_RcvRptDocKey = new UFIDA.U9.Complete.RCVRpt.RcvRptDoc.EntityKey(key); 
				return m_RcvRptDocKey ;
			}
		}

				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 成品入库单行 (该属性可为空,且无默认值)
			/// 成品条码档案.Misc.成品入库单行
			/// </summary>
			/// <value></value>
			public  UFIDA.U9.Complete.RCVRpt.RcvRptDocLine RcvRptDocLine
			{
				get
				{
					if (RcvRptDocLineKey == null)
						return null ;
					UFIDA.U9.Complete.RCVRpt.RcvRptDocLine value =  (UFIDA.U9.Complete.RCVRpt.RcvRptDocLine)RcvRptDocLineKey.GetEntity();
					return value ;
				}
			}
		


   		private UFIDA.U9.Complete.RCVRpt.RcvRptDocLine.EntityKey m_RcvRptDocLineKey ;
		/// <summary>
		/// EntityKey 属性
		/// 成品入库单行 的Key (该属性可为空,且无默认值)
		/// 成品条码档案.Misc.成品入库单行
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.Complete.RCVRpt.RcvRptDocLine.EntityKey RcvRptDocLineKey
		{
			get 
			{
				object obj = base.GetValue("RcvRptDocLine") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_RcvRptDocLineKey==null || m_RcvRptDocLineKey.ID != key )
					m_RcvRptDocLineKey = new UFIDA.U9.Complete.RCVRpt.RcvRptDocLine.EntityKey(key); 
				return m_RcvRptDocLineKey ;
			}
		}

				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 销售退回收货单 (该属性可为空,且无默认值)
			/// 成品条码档案.Misc.销售退回收货单
			/// </summary>
			/// <value></value>
			public  UFIDA.U9.PM.Rcv.Receivement Receivement
			{
				get
				{
					if (ReceivementKey == null)
						return null ;
					UFIDA.U9.PM.Rcv.Receivement value =  (UFIDA.U9.PM.Rcv.Receivement)ReceivementKey.GetEntity();
					return value ;
				}
			}
		


   		private UFIDA.U9.PM.Rcv.Receivement.EntityKey m_ReceivementKey ;
		/// <summary>
		/// EntityKey 属性
		/// 销售退回收货单 的Key (该属性可为空,且无默认值)
		/// 成品条码档案.Misc.销售退回收货单
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.PM.Rcv.Receivement.EntityKey ReceivementKey
		{
			get 
			{
				object obj = base.GetValue("Receivement") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_ReceivementKey==null || m_ReceivementKey.ID != key )
					m_ReceivementKey = new UFIDA.U9.PM.Rcv.Receivement.EntityKey(key); 
				return m_ReceivementKey ;
			}
		}

				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 销售退回收货行 (该属性可为空,且无默认值)
			/// 成品条码档案.Misc.销售退回收货行
			/// </summary>
			/// <value></value>
			public  UFIDA.U9.PM.Rcv.RcvLine RcvLine
			{
				get
				{
					if (RcvLineKey == null)
						return null ;
					UFIDA.U9.PM.Rcv.RcvLine value =  (UFIDA.U9.PM.Rcv.RcvLine)RcvLineKey.GetEntity();
					return value ;
				}
			}
		


   		private UFIDA.U9.PM.Rcv.RcvLine.EntityKey m_RcvLineKey ;
		/// <summary>
		/// EntityKey 属性
		/// 销售退回收货行 的Key (该属性可为空,且无默认值)
		/// 成品条码档案.Misc.销售退回收货行
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.PM.Rcv.RcvLine.EntityKey RcvLineKey
		{
			get 
			{
				object obj = base.GetValue("RcvLine") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_RcvLineKey==null || m_RcvLineKey.ID != key )
					m_RcvLineKey = new UFIDA.U9.PM.Rcv.RcvLine.EntityKey(key); 
				return m_RcvLineKey ;
			}
		}

				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 条码状态 (该属性可为空,但有默认值)
			/// 成品条码档案.Misc.条码状态
			/// </summary>
			/// <value></value>
			public  UFIDA.U9.Cust.JSDY.BarCode.ProductBarCodeKindEnum ProductBarCodeKind
			{
				get
				{

					UFIDA.U9.Cust.JSDY.BarCode.ProductBarCodeKindEnum value  = UFIDA.U9.Cust.JSDY.BarCode.ProductBarCodeKindEnum.GetFromValue(base.GetValue("ProductBarCodeKind"));
					return value;
				}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 退回处理单 (该属性可为空,且无默认值)
			/// 成品条码档案.Misc.退回处理单
			/// </summary>
			/// <value></value>
			public  UFIDA.U9.SM.RMA.RMA RMA
			{
				get
				{
					if (RMAKey == null)
						return null ;
					UFIDA.U9.SM.RMA.RMA value =  (UFIDA.U9.SM.RMA.RMA)RMAKey.GetEntity();
					return value ;
				}
			}
		


   		private UFIDA.U9.SM.RMA.RMA.EntityKey m_RMAKey ;
		/// <summary>
		/// EntityKey 属性
		/// 退回处理单 的Key (该属性可为空,且无默认值)
		/// 成品条码档案.Misc.退回处理单
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.SM.RMA.RMA.EntityKey RMAKey
		{
			get 
			{
				object obj = base.GetValue("RMA") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_RMAKey==null || m_RMAKey.ID != key )
					m_RMAKey = new UFIDA.U9.SM.RMA.RMA.EntityKey(key); 
				return m_RMAKey ;
			}
		}

				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 退回处理行 (该属性可为空,且无默认值)
			/// 成品条码档案.Misc.退回处理行
			/// </summary>
			/// <value></value>
			public  UFIDA.U9.SM.RMA.RMALine RMALine
			{
				get
				{
					if (RMALineKey == null)
						return null ;
					UFIDA.U9.SM.RMA.RMALine value =  (UFIDA.U9.SM.RMA.RMALine)RMALineKey.GetEntity();
					return value ;
				}
			}
		


   		private UFIDA.U9.SM.RMA.RMALine.EntityKey m_RMALineKey ;
		/// <summary>
		/// EntityKey 属性
		/// 退回处理行 的Key (该属性可为空,且无默认值)
		/// 成品条码档案.Misc.退回处理行
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.SM.RMA.RMALine.EntityKey RMALineKey
		{
			get 
			{
				object obj = base.GetValue("RMALine") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_RMALineKey==null || m_RMALineKey.ID != key )
					m_RMALineKey = new UFIDA.U9.SM.RMA.RMALine.EntityKey(key); 
				return m_RMALineKey ;
			}
		}

				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 批号 (该属性可为空,且无默认值)
			/// 成品条码档案.Misc.批号
			/// </summary>
			/// <value></value>
			public  UFIDA.U9.Lot.LotMaster Lot
			{
				get
				{
					if (LotKey == null)
						return null ;
					UFIDA.U9.Lot.LotMaster value =  (UFIDA.U9.Lot.LotMaster)LotKey.GetEntity();
					return value ;
				}
			}
		


   		private UFIDA.U9.Lot.LotMaster.EntityKey m_LotKey ;
		/// <summary>
		/// EntityKey 属性
		/// 批号 的Key (该属性可为空,且无默认值)
		/// 成品条码档案.Misc.批号
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.Lot.LotMaster.EntityKey LotKey
		{
			get 
			{
				object obj = base.GetValue("Lot") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_LotKey==null || m_LotKey.ID != key )
					m_LotKey = new UFIDA.U9.Lot.LotMaster.EntityKey(key); 
				return m_LotKey ;
			}
		}

				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 调出单 (该属性可为空,且无默认值)
			/// 成品条码档案.Misc.调出单
			/// </summary>
			/// <value></value>
			public  UFIDA.U9.InvDoc.TransferOut.TransferOut TransferOut
			{
				get
				{
					if (TransferOutKey == null)
						return null ;
					UFIDA.U9.InvDoc.TransferOut.TransferOut value =  (UFIDA.U9.InvDoc.TransferOut.TransferOut)TransferOutKey.GetEntity();
					return value ;
				}
			}
		


   		private UFIDA.U9.InvDoc.TransferOut.TransferOut.EntityKey m_TransferOutKey ;
		/// <summary>
		/// EntityKey 属性
		/// 调出单 的Key (该属性可为空,且无默认值)
		/// 成品条码档案.Misc.调出单
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.InvDoc.TransferOut.TransferOut.EntityKey TransferOutKey
		{
			get 
			{
				object obj = base.GetValue("TransferOut") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_TransferOutKey==null || m_TransferOutKey.ID != key )
					m_TransferOutKey = new UFIDA.U9.InvDoc.TransferOut.TransferOut.EntityKey(key); 
				return m_TransferOutKey ;
			}
		}

				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 调出单行 (该属性可为空,且无默认值)
			/// 成品条码档案.Misc.调出单行
			/// </summary>
			/// <value></value>
			public  UFIDA.U9.InvDoc.TransferOut.TransOutLine TransferOutLine
			{
				get
				{
					if (TransferOutLineKey == null)
						return null ;
					UFIDA.U9.InvDoc.TransferOut.TransOutLine value =  (UFIDA.U9.InvDoc.TransferOut.TransOutLine)TransferOutLineKey.GetEntity();
					return value ;
				}
			}
		


   		private UFIDA.U9.InvDoc.TransferOut.TransOutLine.EntityKey m_TransferOutLineKey ;
		/// <summary>
		/// EntityKey 属性
		/// 调出单行 的Key (该属性可为空,且无默认值)
		/// 成品条码档案.Misc.调出单行
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.InvDoc.TransferOut.TransOutLine.EntityKey TransferOutLineKey
		{
			get 
			{
				object obj = base.GetValue("TransferOutLine") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_TransferOutLineKey==null || m_TransferOutLineKey.ID != key )
					m_TransferOutLineKey = new UFIDA.U9.InvDoc.TransferOut.TransOutLine.EntityKey(key); 
				return m_TransferOutLineKey ;
			}
		}

				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 出货计划 (该属性可为空,且无默认值)
			/// 成品条码档案.Misc.出货计划
			/// </summary>
			/// <value></value>
			public  UFIDA.U9.SM.ShipPlan.ShipPlan ShipPlan
			{
				get
				{
					if (ShipPlanKey == null)
						return null ;
					UFIDA.U9.SM.ShipPlan.ShipPlan value =  (UFIDA.U9.SM.ShipPlan.ShipPlan)ShipPlanKey.GetEntity();
					return value ;
				}
			}
		


   		private UFIDA.U9.SM.ShipPlan.ShipPlan.EntityKey m_ShipPlanKey ;
		/// <summary>
		/// EntityKey 属性
		/// 出货计划 的Key (该属性可为空,且无默认值)
		/// 成品条码档案.Misc.出货计划
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.SM.ShipPlan.ShipPlan.EntityKey ShipPlanKey
		{
			get 
			{
				object obj = base.GetValue("ShipPlan") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_ShipPlanKey==null || m_ShipPlanKey.ID != key )
					m_ShipPlanKey = new UFIDA.U9.SM.ShipPlan.ShipPlan.EntityKey(key); 
				return m_ShipPlanKey ;
			}
		}

				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 出货计划行 (该属性可为空,且无默认值)
			/// 成品条码档案.Misc.出货计划行
			/// </summary>
			/// <value></value>
			public  UFIDA.U9.SM.ShipPlan.ShipPlanLine ShipPlanLine
			{
				get
				{
					if (ShipPlanLineKey == null)
						return null ;
					UFIDA.U9.SM.ShipPlan.ShipPlanLine value =  (UFIDA.U9.SM.ShipPlan.ShipPlanLine)ShipPlanLineKey.GetEntity();
					return value ;
				}
			}
		


   		private UFIDA.U9.SM.ShipPlan.ShipPlanLine.EntityKey m_ShipPlanLineKey ;
		/// <summary>
		/// EntityKey 属性
		/// 出货计划行 的Key (该属性可为空,且无默认值)
		/// 成品条码档案.Misc.出货计划行
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.SM.ShipPlan.ShipPlanLine.EntityKey ShipPlanLineKey
		{
			get 
			{
				object obj = base.GetValue("ShipPlanLine") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_ShipPlanLineKey==null || m_ShipPlanLineKey.ID != key )
					m_ShipPlanLineKey = new UFIDA.U9.SM.ShipPlan.ShipPlanLine.EntityKey(key); 
				return m_ShipPlanLineKey ;
			}
		}

		

			#endregion

			#region List member						
			#endregion

			#region Be List member						
			#endregion



		    
		}
		#endregion 







		#region member					
		
			/// <summary>
		/// ID (该属性不可为空,且无默认值)
		/// 成品条码档案.Key.ID
		/// </summary>
		/// <value></value>
	 
		public new System.Int64 ID
		{
			get
			{
				System.Int64 value  = (System.Int64)base.GetValue("ID");
				return value;
				}
				set
			{
				
								base.SetValue("ID", value);
						 
			}
		}
	



		
			/// <summary>
		/// 创建时间 (该属性可为空,且无默认值)
		/// 成品条码档案.Sys.创建时间
		/// </summary>
		/// <value></value>
			public  System.DateTime CreatedOn
		{
			get
			{
				System.DateTime value  = (System.DateTime)base.GetValue("CreatedOn");
				return value;
				}
				set
			{
				
								base.SetValue("CreatedOn", value);
						 
			}
		}
	



		
			/// <summary>
		/// 创建人 (该属性可为空,且无默认值)
		/// 成品条码档案.Sys.创建人
		/// </summary>
		/// <value></value>
			public  System.String CreatedBy
		{
			get
			{
				System.String value  = (System.String)base.GetValue("CreatedBy");
				return value;
				}
				set
			{
				
								base.SetValue("CreatedBy", value);
						 
			}
		}
	



		
			/// <summary>
		/// 修改时间 (该属性可为空,且无默认值)
		/// 成品条码档案.Sys.修改时间
		/// </summary>
		/// <value></value>
			public  System.DateTime ModifiedOn
		{
			get
			{
				System.DateTime value  = (System.DateTime)base.GetValue("ModifiedOn");
				return value;
				}
				set
			{
				
								base.SetValue("ModifiedOn", value);
						 
			}
		}
	



		
			/// <summary>
		/// 修改人 (该属性可为空,且无默认值)
		/// 成品条码档案.Sys.修改人
		/// </summary>
		/// <value></value>
			public  System.String ModifiedBy
		{
			get
			{
				System.String value  = (System.String)base.GetValue("ModifiedBy");
				return value;
				}
				set
			{
				
								base.SetValue("ModifiedBy", value);
						 
			}
		}
	



		
			/// <summary>
		/// 事务版本 (该属性可为空,但有默认值)
		/// 成品条码档案.Sys.事务版本
		/// </summary>
		/// <value></value>
			public  System.Int64 SysVersion
		{
			get
			{
				System.Int64 value  = (System.Int64)base.GetValue("SysVersion");
				return value;
				}
				set
			{
				
								base.SetValue("SysVersion", value);
						 
			}
		}
	



		
			/// <summary>
		/// 组织 (该属性不可为空,且无默认值)
		/// 成品条码档案.Misc.组织
		/// </summary>
		/// <value></value>
			public  UFIDA.U9.Base.Organization.Organization Org
		{
			get
			{
				object  obj = this.GetRelation("Org");
				if (obj == null)
				{
					return null ;
				}
				else
				{
					UFIDA.U9.Base.Organization.Organization value  = (UFIDA.U9.Base.Organization.Organization)obj;
					return value;
				 }
			}
				set
			{
				
				this.SetRelation("Org", value);
					 
			}
		}
	


   		private UFIDA.U9.Base.Organization.Organization.EntityKey m_OrgKey ;
		/// <summary>
		/// 组织 的Key (该属性不可为空,且无默认值)
		/// 成品条码档案.Misc.组织
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.Base.Organization.Organization.EntityKey OrgKey
		{
			get 
			{
				object obj = base.GetValue("Org") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_OrgKey==null || m_OrgKey.ID != key )
					m_OrgKey = new UFIDA.U9.Base.Organization.Organization.EntityKey(key); 
				return m_OrgKey ;
			}
			set
			{	
				if (OrgKey==value)
					return ;
				this.SetRelation("Org", null);
				m_OrgKey = value ;
				if (value != null) 
				{
					base.SetValue("Org",value.ID);
				}
				else
					base.SetValue("Org",UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag);
			}
		}

		
			/// <summary>
		/// 料品 (该属性不可为空,且无默认值)
		/// 成品条码档案.Misc.料品
		/// </summary>
		/// <value></value>
			public  UFIDA.U9.CBO.SCM.Item.ItemMaster Item
		{
			get
			{
				object  obj = this.GetRelation("Item");
				if (obj == null)
				{
					return null ;
				}
				else
				{
					UFIDA.U9.CBO.SCM.Item.ItemMaster value  = (UFIDA.U9.CBO.SCM.Item.ItemMaster)obj;
					return value;
				 }
			}
				set
			{
				
				this.SetRelation("Item", value);
					 
			}
		}
	


   		private UFIDA.U9.CBO.SCM.Item.ItemMaster.EntityKey m_ItemKey ;
		/// <summary>
		/// 料品 的Key (该属性不可为空,且无默认值)
		/// 成品条码档案.Misc.料品
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.CBO.SCM.Item.ItemMaster.EntityKey ItemKey
		{
			get 
			{
				object obj = base.GetValue("Item") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_ItemKey==null || m_ItemKey.ID != key )
					m_ItemKey = new UFIDA.U9.CBO.SCM.Item.ItemMaster.EntityKey(key); 
				return m_ItemKey ;
			}
			set
			{	
				if (ItemKey==value)
					return ;
				this.SetRelation("Item", null);
				m_ItemKey = value ;
				if (value != null) 
				{
					base.SetValue("Item",value.ID);
				}
				else
					base.SetValue("Item",UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag);
			}
		}

		
			/// <summary>
		/// 条码 (该属性不可为空,且无默认值)
		/// 成品条码档案.Misc.条码
		/// </summary>
		/// <value></value>
			public  System.String BarCode
		{
			get
			{
				System.String value  = (System.String)base.GetValue("BarCode");
				return value;
				}
				set
			{
				
								base.SetValue("BarCode", value);
						 
			}
		}
	



		
			/// <summary>
		/// 实际长度 (该属性可为空,但有默认值)
		/// 成品条码档案.Misc.实际长度
		/// </summary>
		/// <value></value>
			public  System.Int32 ActualLength
		{
			get
			{
				System.Int32 value  = (System.Int32)base.GetValue("ActualLength");
				return value;
				}
				set
			{
				
								base.SetValue("ActualLength", value);
						 
			}
		}
	



		
			/// <summary>
		/// 合格证标示长度 (该属性可为空,但有默认值)
		/// 成品条码档案.Misc.合格证标示长度
		/// </summary>
		/// <value></value>
			public  System.Int32 MarkingLength
		{
			get
			{
				System.Int32 value  = (System.Int32)base.GetValue("MarkingLength");
				return value;
				}
				set
			{
				
								base.SetValue("MarkingLength", value);
						 
			}
		}
	



		
			/// <summary>
		/// 检验员 (该属性可为空,且无默认值)
		/// 成品条码档案.Misc.检验员
		/// </summary>
		/// <value></value>
			public  UFIDA.U9.CBO.HR.Operator.Operators Operators
		{
			get
			{
				object  obj = this.GetRelation("Operators");
				if (obj == null)
				{
					return null ;
				}
				else
				{
					UFIDA.U9.CBO.HR.Operator.Operators value  = (UFIDA.U9.CBO.HR.Operator.Operators)obj;
					return value;
				 }
			}
				set
			{
				
				this.SetRelation("Operators", value);
					 
			}
		}
	


   		private UFIDA.U9.CBO.HR.Operator.Operators.EntityKey m_OperatorsKey ;
		/// <summary>
		/// 检验员 的Key (该属性可为空,且无默认值)
		/// 成品条码档案.Misc.检验员
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.CBO.HR.Operator.Operators.EntityKey OperatorsKey
		{
			get 
			{
				object obj = base.GetValue("Operators") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_OperatorsKey==null || m_OperatorsKey.ID != key )
					m_OperatorsKey = new UFIDA.U9.CBO.HR.Operator.Operators.EntityKey(key); 
				return m_OperatorsKey ;
			}
			set
			{	
				if (OperatorsKey==value)
					return ;
				this.SetRelation("Operators", null);
				m_OperatorsKey = value ;
				if (value != null) 
				{
					base.SetValue("Operators",value.ID);
				}
				else
					base.SetValue("Operators",UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag);
			}
		}

		
			/// <summary>
		/// 扫描时间 (该属性可为空,且无默认值)
		/// 成品条码档案.Misc.扫描时间
		/// </summary>
		/// <value></value>
			public  System.DateTime ScanOn
		{
			get
			{
				System.DateTime value  = (System.DateTime)base.GetValue("ScanOn");
				return value;
				}
				set
			{
				
								base.SetValue("ScanOn", value);
						 
			}
		}
	



		
			/// <summary>
		/// 扫描人 (该属性可为空,且无默认值)
		/// 成品条码档案.Misc.扫描人
		/// </summary>
		/// <value></value>
			public  System.String ScanBy
		{
			get
			{
				System.String value  = (System.String)base.GetValue("ScanBy");
				return value;
				}
				set
			{
				
								base.SetValue("ScanBy", value);
						 
			}
		}
	



		
			/// <summary>
		/// 打印时间 (该属性可为空,且无默认值)
		/// 成品条码档案.Misc.打印时间
		/// </summary>
		/// <value></value>
			public  System.DateTime PrintedOn
		{
			get
			{
				System.DateTime value  = (System.DateTime)base.GetValue("PrintedOn");
				return value;
				}
				set
			{
				
								base.SetValue("PrintedOn", value);
						 
			}
		}
	



		
			/// <summary>
		/// 打印人 (该属性可为空,且无默认值)
		/// 成品条码档案.Misc.打印人
		/// </summary>
		/// <value></value>
			public  System.String PrintedBy
		{
			get
			{
				System.String value  = (System.String)base.GetValue("PrintedBy");
				return value;
				}
				set
			{
				
								base.SetValue("PrintedBy", value);
						 
			}
		}
	



		
			/// <summary>
		/// 完工申报单 (该属性可为空,且无默认值)
		/// 成品条码档案.Misc.完工申报单
		/// </summary>
		/// <value></value>
			public  UFIDA.U9.Complete.CompleteRpt.CompleteApplyDoc CompleteApplyDoc
		{
			get
			{
				object  obj = this.GetRelation("CompleteApplyDoc");
				if (obj == null)
				{
					return null ;
				}
				else
				{
					UFIDA.U9.Complete.CompleteRpt.CompleteApplyDoc value  = (UFIDA.U9.Complete.CompleteRpt.CompleteApplyDoc)obj;
					return value;
				 }
			}
				set
			{
				
				this.SetRelation("CompleteApplyDoc", value);
					 
			}
		}
	


   		private UFIDA.U9.Complete.CompleteRpt.CompleteApplyDoc.EntityKey m_CompleteApplyDocKey ;
		/// <summary>
		/// 完工申报单 的Key (该属性可为空,且无默认值)
		/// 成品条码档案.Misc.完工申报单
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.Complete.CompleteRpt.CompleteApplyDoc.EntityKey CompleteApplyDocKey
		{
			get 
			{
				object obj = base.GetValue("CompleteApplyDoc") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_CompleteApplyDocKey==null || m_CompleteApplyDocKey.ID != key )
					m_CompleteApplyDocKey = new UFIDA.U9.Complete.CompleteRpt.CompleteApplyDoc.EntityKey(key); 
				return m_CompleteApplyDocKey ;
			}
			set
			{	
				if (CompleteApplyDocKey==value)
					return ;
				this.SetRelation("CompleteApplyDoc", null);
				m_CompleteApplyDocKey = value ;
				if (value != null) 
				{
					base.SetValue("CompleteApplyDoc",value.ID);
				}
				else
					base.SetValue("CompleteApplyDoc",UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag);
			}
		}

		
			/// <summary>
		/// 完工申报单行 (该属性可为空,且无默认值)
		/// 成品条码档案.Misc.完工申报单行
		/// </summary>
		/// <value></value>
			public  UFIDA.U9.Complete.CompleteRpt.CompleteApplyDocLine CompleteApplyDocLine
		{
			get
			{
				object  obj = this.GetRelation("CompleteApplyDocLine");
				if (obj == null)
				{
					return null ;
				}
				else
				{
					UFIDA.U9.Complete.CompleteRpt.CompleteApplyDocLine value  = (UFIDA.U9.Complete.CompleteRpt.CompleteApplyDocLine)obj;
					return value;
				 }
			}
				set
			{
				
				this.SetRelation("CompleteApplyDocLine", value);
					 
			}
		}
	


   		private UFIDA.U9.Complete.CompleteRpt.CompleteApplyDocLine.EntityKey m_CompleteApplyDocLineKey ;
		/// <summary>
		/// 完工申报单行 的Key (该属性可为空,且无默认值)
		/// 成品条码档案.Misc.完工申报单行
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.Complete.CompleteRpt.CompleteApplyDocLine.EntityKey CompleteApplyDocLineKey
		{
			get 
			{
				object obj = base.GetValue("CompleteApplyDocLine") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_CompleteApplyDocLineKey==null || m_CompleteApplyDocLineKey.ID != key )
					m_CompleteApplyDocLineKey = new UFIDA.U9.Complete.CompleteRpt.CompleteApplyDocLine.EntityKey(key); 
				return m_CompleteApplyDocLineKey ;
			}
			set
			{	
				if (CompleteApplyDocLineKey==value)
					return ;
				this.SetRelation("CompleteApplyDocLine", null);
				m_CompleteApplyDocLineKey = value ;
				if (value != null) 
				{
					base.SetValue("CompleteApplyDocLine",value.ID);
				}
				else
					base.SetValue("CompleteApplyDocLine",UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag);
			}
		}

		
			/// <summary>
		/// 成品入库单 (该属性可为空,且无默认值)
		/// 成品条码档案.Misc.成品入库单
		/// </summary>
		/// <value></value>
			public  UFIDA.U9.Complete.RCVRpt.RcvRptDoc RcvRptDoc
		{
			get
			{
				object  obj = this.GetRelation("RcvRptDoc");
				if (obj == null)
				{
					return null ;
				}
				else
				{
					UFIDA.U9.Complete.RCVRpt.RcvRptDoc value  = (UFIDA.U9.Complete.RCVRpt.RcvRptDoc)obj;
					return value;
				 }
			}
				set
			{
				
				this.SetRelation("RcvRptDoc", value);
					 
			}
		}
	


   		private UFIDA.U9.Complete.RCVRpt.RcvRptDoc.EntityKey m_RcvRptDocKey ;
		/// <summary>
		/// 成品入库单 的Key (该属性可为空,且无默认值)
		/// 成品条码档案.Misc.成品入库单
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.Complete.RCVRpt.RcvRptDoc.EntityKey RcvRptDocKey
		{
			get 
			{
				object obj = base.GetValue("RcvRptDoc") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_RcvRptDocKey==null || m_RcvRptDocKey.ID != key )
					m_RcvRptDocKey = new UFIDA.U9.Complete.RCVRpt.RcvRptDoc.EntityKey(key); 
				return m_RcvRptDocKey ;
			}
			set
			{	
				if (RcvRptDocKey==value)
					return ;
				this.SetRelation("RcvRptDoc", null);
				m_RcvRptDocKey = value ;
				if (value != null) 
				{
					base.SetValue("RcvRptDoc",value.ID);
				}
				else
					base.SetValue("RcvRptDoc",UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag);
			}
		}

		
			/// <summary>
		/// 成品入库单行 (该属性可为空,且无默认值)
		/// 成品条码档案.Misc.成品入库单行
		/// </summary>
		/// <value></value>
			public  UFIDA.U9.Complete.RCVRpt.RcvRptDocLine RcvRptDocLine
		{
			get
			{
				object  obj = this.GetRelation("RcvRptDocLine");
				if (obj == null)
				{
					return null ;
				}
				else
				{
					UFIDA.U9.Complete.RCVRpt.RcvRptDocLine value  = (UFIDA.U9.Complete.RCVRpt.RcvRptDocLine)obj;
					return value;
				 }
			}
				set
			{
				
				this.SetRelation("RcvRptDocLine", value);
					 
			}
		}
	


   		private UFIDA.U9.Complete.RCVRpt.RcvRptDocLine.EntityKey m_RcvRptDocLineKey ;
		/// <summary>
		/// 成品入库单行 的Key (该属性可为空,且无默认值)
		/// 成品条码档案.Misc.成品入库单行
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.Complete.RCVRpt.RcvRptDocLine.EntityKey RcvRptDocLineKey
		{
			get 
			{
				object obj = base.GetValue("RcvRptDocLine") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_RcvRptDocLineKey==null || m_RcvRptDocLineKey.ID != key )
					m_RcvRptDocLineKey = new UFIDA.U9.Complete.RCVRpt.RcvRptDocLine.EntityKey(key); 
				return m_RcvRptDocLineKey ;
			}
			set
			{	
				if (RcvRptDocLineKey==value)
					return ;
				this.SetRelation("RcvRptDocLine", null);
				m_RcvRptDocLineKey = value ;
				if (value != null) 
				{
					base.SetValue("RcvRptDocLine",value.ID);
				}
				else
					base.SetValue("RcvRptDocLine",UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag);
			}
		}

		
			/// <summary>
		/// 销售退回收货单 (该属性可为空,且无默认值)
		/// 成品条码档案.Misc.销售退回收货单
		/// </summary>
		/// <value></value>
			public  UFIDA.U9.PM.Rcv.Receivement Receivement
		{
			get
			{
				object  obj = this.GetRelation("Receivement");
				if (obj == null)
				{
					return null ;
				}
				else
				{
					UFIDA.U9.PM.Rcv.Receivement value  = (UFIDA.U9.PM.Rcv.Receivement)obj;
					return value;
				 }
			}
				set
			{
				
				this.SetRelation("Receivement", value);
					 
			}
		}
	


   		private UFIDA.U9.PM.Rcv.Receivement.EntityKey m_ReceivementKey ;
		/// <summary>
		/// 销售退回收货单 的Key (该属性可为空,且无默认值)
		/// 成品条码档案.Misc.销售退回收货单
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.PM.Rcv.Receivement.EntityKey ReceivementKey
		{
			get 
			{
				object obj = base.GetValue("Receivement") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_ReceivementKey==null || m_ReceivementKey.ID != key )
					m_ReceivementKey = new UFIDA.U9.PM.Rcv.Receivement.EntityKey(key); 
				return m_ReceivementKey ;
			}
			set
			{	
				if (ReceivementKey==value)
					return ;
				this.SetRelation("Receivement", null);
				m_ReceivementKey = value ;
				if (value != null) 
				{
					base.SetValue("Receivement",value.ID);
				}
				else
					base.SetValue("Receivement",UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag);
			}
		}

		
			/// <summary>
		/// 销售退回收货行 (该属性可为空,且无默认值)
		/// 成品条码档案.Misc.销售退回收货行
		/// </summary>
		/// <value></value>
			public  UFIDA.U9.PM.Rcv.RcvLine RcvLine
		{
			get
			{
				object  obj = this.GetRelation("RcvLine");
				if (obj == null)
				{
					return null ;
				}
				else
				{
					UFIDA.U9.PM.Rcv.RcvLine value  = (UFIDA.U9.PM.Rcv.RcvLine)obj;
					return value;
				 }
			}
				set
			{
				
				this.SetRelation("RcvLine", value);
					 
			}
		}
	


   		private UFIDA.U9.PM.Rcv.RcvLine.EntityKey m_RcvLineKey ;
		/// <summary>
		/// 销售退回收货行 的Key (该属性可为空,且无默认值)
		/// 成品条码档案.Misc.销售退回收货行
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.PM.Rcv.RcvLine.EntityKey RcvLineKey
		{
			get 
			{
				object obj = base.GetValue("RcvLine") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_RcvLineKey==null || m_RcvLineKey.ID != key )
					m_RcvLineKey = new UFIDA.U9.PM.Rcv.RcvLine.EntityKey(key); 
				return m_RcvLineKey ;
			}
			set
			{	
				if (RcvLineKey==value)
					return ;
				this.SetRelation("RcvLine", null);
				m_RcvLineKey = value ;
				if (value != null) 
				{
					base.SetValue("RcvLine",value.ID);
				}
				else
					base.SetValue("RcvLine",UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag);
			}
		}

		
			/// <summary>
		/// 条码状态 (该属性可为空,但有默认值)
		/// 成品条码档案.Misc.条码状态
		/// </summary>
		/// <value></value>
			public  UFIDA.U9.Cust.JSDY.BarCode.ProductBarCodeKindEnum ProductBarCodeKind
		{
			get
			{

				UFIDA.U9.Cust.JSDY.BarCode.ProductBarCodeKindEnum value  = UFIDA.U9.Cust.JSDY.BarCode.ProductBarCodeKindEnum.GetFromValue(base.GetValue("ProductBarCodeKind"));
				return value;
			}
				set
			{
				
				if (value == null)
					base.SetValue("ProductBarCodeKind",UFIDA.U9.Cust.JSDY.BarCode.ProductBarCodeKindEnum.Empty.Value);
				else
					base.SetValue("ProductBarCodeKind",value.Value);
					 
			}
		}
	



		
			/// <summary>
		/// 退回处理单 (该属性可为空,且无默认值)
		/// 成品条码档案.Misc.退回处理单
		/// </summary>
		/// <value></value>
			public  UFIDA.U9.SM.RMA.RMA RMA
		{
			get
			{
				object  obj = this.GetRelation("RMA");
				if (obj == null)
				{
					return null ;
				}
				else
				{
					UFIDA.U9.SM.RMA.RMA value  = (UFIDA.U9.SM.RMA.RMA)obj;
					return value;
				 }
			}
				set
			{
				
				this.SetRelation("RMA", value);
					 
			}
		}
	


   		private UFIDA.U9.SM.RMA.RMA.EntityKey m_RMAKey ;
		/// <summary>
		/// 退回处理单 的Key (该属性可为空,且无默认值)
		/// 成品条码档案.Misc.退回处理单
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.SM.RMA.RMA.EntityKey RMAKey
		{
			get 
			{
				object obj = base.GetValue("RMA") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_RMAKey==null || m_RMAKey.ID != key )
					m_RMAKey = new UFIDA.U9.SM.RMA.RMA.EntityKey(key); 
				return m_RMAKey ;
			}
			set
			{	
				if (RMAKey==value)
					return ;
				this.SetRelation("RMA", null);
				m_RMAKey = value ;
				if (value != null) 
				{
					base.SetValue("RMA",value.ID);
				}
				else
					base.SetValue("RMA",UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag);
			}
		}

		
			/// <summary>
		/// 退回处理行 (该属性可为空,且无默认值)
		/// 成品条码档案.Misc.退回处理行
		/// </summary>
		/// <value></value>
			public  UFIDA.U9.SM.RMA.RMALine RMALine
		{
			get
			{
				object  obj = this.GetRelation("RMALine");
				if (obj == null)
				{
					return null ;
				}
				else
				{
					UFIDA.U9.SM.RMA.RMALine value  = (UFIDA.U9.SM.RMA.RMALine)obj;
					return value;
				 }
			}
				set
			{
				
				this.SetRelation("RMALine", value);
					 
			}
		}
	


   		private UFIDA.U9.SM.RMA.RMALine.EntityKey m_RMALineKey ;
		/// <summary>
		/// 退回处理行 的Key (该属性可为空,且无默认值)
		/// 成品条码档案.Misc.退回处理行
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.SM.RMA.RMALine.EntityKey RMALineKey
		{
			get 
			{
				object obj = base.GetValue("RMALine") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_RMALineKey==null || m_RMALineKey.ID != key )
					m_RMALineKey = new UFIDA.U9.SM.RMA.RMALine.EntityKey(key); 
				return m_RMALineKey ;
			}
			set
			{	
				if (RMALineKey==value)
					return ;
				this.SetRelation("RMALine", null);
				m_RMALineKey = value ;
				if (value != null) 
				{
					base.SetValue("RMALine",value.ID);
				}
				else
					base.SetValue("RMALine",UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag);
			}
		}

		
			/// <summary>
		/// 批号 (该属性可为空,且无默认值)
		/// 成品条码档案.Misc.批号
		/// </summary>
		/// <value></value>
			public  UFIDA.U9.Lot.LotMaster Lot
		{
			get
			{
				object  obj = this.GetRelation("Lot");
				if (obj == null)
				{
					return null ;
				}
				else
				{
					UFIDA.U9.Lot.LotMaster value  = (UFIDA.U9.Lot.LotMaster)obj;
					return value;
				 }
			}
				set
			{
				
				this.SetRelation("Lot", value);
					 
			}
		}
	


   		private UFIDA.U9.Lot.LotMaster.EntityKey m_LotKey ;
		/// <summary>
		/// 批号 的Key (该属性可为空,且无默认值)
		/// 成品条码档案.Misc.批号
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.Lot.LotMaster.EntityKey LotKey
		{
			get 
			{
				object obj = base.GetValue("Lot") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_LotKey==null || m_LotKey.ID != key )
					m_LotKey = new UFIDA.U9.Lot.LotMaster.EntityKey(key); 
				return m_LotKey ;
			}
			set
			{	
				if (LotKey==value)
					return ;
				this.SetRelation("Lot", null);
				m_LotKey = value ;
				if (value != null) 
				{
					base.SetValue("Lot",value.ID);
				}
				else
					base.SetValue("Lot",UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag);
			}
		}

		
			/// <summary>
		/// 调出单 (该属性可为空,且无默认值)
		/// 成品条码档案.Misc.调出单
		/// </summary>
		/// <value></value>
			public  UFIDA.U9.InvDoc.TransferOut.TransferOut TransferOut
		{
			get
			{
				object  obj = this.GetRelation("TransferOut");
				if (obj == null)
				{
					return null ;
				}
				else
				{
					UFIDA.U9.InvDoc.TransferOut.TransferOut value  = (UFIDA.U9.InvDoc.TransferOut.TransferOut)obj;
					return value;
				 }
			}
				set
			{
				
				this.SetRelation("TransferOut", value);
					 
			}
		}
	


   		private UFIDA.U9.InvDoc.TransferOut.TransferOut.EntityKey m_TransferOutKey ;
		/// <summary>
		/// 调出单 的Key (该属性可为空,且无默认值)
		/// 成品条码档案.Misc.调出单
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.InvDoc.TransferOut.TransferOut.EntityKey TransferOutKey
		{
			get 
			{
				object obj = base.GetValue("TransferOut") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_TransferOutKey==null || m_TransferOutKey.ID != key )
					m_TransferOutKey = new UFIDA.U9.InvDoc.TransferOut.TransferOut.EntityKey(key); 
				return m_TransferOutKey ;
			}
			set
			{	
				if (TransferOutKey==value)
					return ;
				this.SetRelation("TransferOut", null);
				m_TransferOutKey = value ;
				if (value != null) 
				{
					base.SetValue("TransferOut",value.ID);
				}
				else
					base.SetValue("TransferOut",UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag);
			}
		}

		
			/// <summary>
		/// 调出单行 (该属性可为空,且无默认值)
		/// 成品条码档案.Misc.调出单行
		/// </summary>
		/// <value></value>
			public  UFIDA.U9.InvDoc.TransferOut.TransOutLine TransferOutLine
		{
			get
			{
				object  obj = this.GetRelation("TransferOutLine");
				if (obj == null)
				{
					return null ;
				}
				else
				{
					UFIDA.U9.InvDoc.TransferOut.TransOutLine value  = (UFIDA.U9.InvDoc.TransferOut.TransOutLine)obj;
					return value;
				 }
			}
				set
			{
				
				this.SetRelation("TransferOutLine", value);
					 
			}
		}
	


   		private UFIDA.U9.InvDoc.TransferOut.TransOutLine.EntityKey m_TransferOutLineKey ;
		/// <summary>
		/// 调出单行 的Key (该属性可为空,且无默认值)
		/// 成品条码档案.Misc.调出单行
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.InvDoc.TransferOut.TransOutLine.EntityKey TransferOutLineKey
		{
			get 
			{
				object obj = base.GetValue("TransferOutLine") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_TransferOutLineKey==null || m_TransferOutLineKey.ID != key )
					m_TransferOutLineKey = new UFIDA.U9.InvDoc.TransferOut.TransOutLine.EntityKey(key); 
				return m_TransferOutLineKey ;
			}
			set
			{	
				if (TransferOutLineKey==value)
					return ;
				this.SetRelation("TransferOutLine", null);
				m_TransferOutLineKey = value ;
				if (value != null) 
				{
					base.SetValue("TransferOutLine",value.ID);
				}
				else
					base.SetValue("TransferOutLine",UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag);
			}
		}

		
			/// <summary>
		/// 出货计划 (该属性可为空,且无默认值)
		/// 成品条码档案.Misc.出货计划
		/// </summary>
		/// <value></value>
			public  UFIDA.U9.SM.ShipPlan.ShipPlan ShipPlan
		{
			get
			{
				object  obj = this.GetRelation("ShipPlan");
				if (obj == null)
				{
					return null ;
				}
				else
				{
					UFIDA.U9.SM.ShipPlan.ShipPlan value  = (UFIDA.U9.SM.ShipPlan.ShipPlan)obj;
					return value;
				 }
			}
				set
			{
				
				this.SetRelation("ShipPlan", value);
					 
			}
		}
	


   		private UFIDA.U9.SM.ShipPlan.ShipPlan.EntityKey m_ShipPlanKey ;
		/// <summary>
		/// 出货计划 的Key (该属性可为空,且无默认值)
		/// 成品条码档案.Misc.出货计划
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.SM.ShipPlan.ShipPlan.EntityKey ShipPlanKey
		{
			get 
			{
				object obj = base.GetValue("ShipPlan") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_ShipPlanKey==null || m_ShipPlanKey.ID != key )
					m_ShipPlanKey = new UFIDA.U9.SM.ShipPlan.ShipPlan.EntityKey(key); 
				return m_ShipPlanKey ;
			}
			set
			{	
				if (ShipPlanKey==value)
					return ;
				this.SetRelation("ShipPlan", null);
				m_ShipPlanKey = value ;
				if (value != null) 
				{
					base.SetValue("ShipPlan",value.ID);
				}
				else
					base.SetValue("ShipPlan",UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag);
			}
		}

		
			/// <summary>
		/// 出货计划行 (该属性可为空,且无默认值)
		/// 成品条码档案.Misc.出货计划行
		/// </summary>
		/// <value></value>
			public  UFIDA.U9.SM.ShipPlan.ShipPlanLine ShipPlanLine
		{
			get
			{
				object  obj = this.GetRelation("ShipPlanLine");
				if (obj == null)
				{
					return null ;
				}
				else
				{
					UFIDA.U9.SM.ShipPlan.ShipPlanLine value  = (UFIDA.U9.SM.ShipPlan.ShipPlanLine)obj;
					return value;
				 }
			}
				set
			{
				
				this.SetRelation("ShipPlanLine", value);
					 
			}
		}
	


   		private UFIDA.U9.SM.ShipPlan.ShipPlanLine.EntityKey m_ShipPlanLineKey ;
		/// <summary>
		/// 出货计划行 的Key (该属性可为空,且无默认值)
		/// 成品条码档案.Misc.出货计划行
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.SM.ShipPlan.ShipPlanLine.EntityKey ShipPlanLineKey
		{
			get 
			{
				object obj = base.GetValue("ShipPlanLine") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_ShipPlanLineKey==null || m_ShipPlanLineKey.ID != key )
					m_ShipPlanLineKey = new UFIDA.U9.SM.ShipPlan.ShipPlanLine.EntityKey(key); 
				return m_ShipPlanLineKey ;
			}
			set
			{	
				if (ShipPlanLineKey==value)
					return ;
				this.SetRelation("ShipPlanLine", null);
				m_ShipPlanLineKey = value ;
				if (value != null) 
				{
					base.SetValue("ShipPlanLine",value.ID);
				}
				else
					base.SetValue("ShipPlanLine",UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag);
			}
		}

	

		#endregion

		#region List member						
		#endregion

		#region Be List member						
		#endregion
		
		#region ModelResource 其余去除，保留EntityName
		/// <summary>
		/// Entity的显示名称资源-请使用EntityRes.GetResource(EntityRes.BE_FullName)的方式取 Entity的显示名称资源.
		/// </summary>
		[Obsolete("")]
		public  string Res_EntityName {	get {return Res_EntityNameS ;}	}
		/// <summary>
		/// Entity的显示名称资源-请使用EntityRes.GetResource(EntityRes.BE_FullName)的方式取 Entity的显示名称资源.
		/// </summary>
		[Obsolete("")]
		public  static string Res_EntityNameS {	get {return EntityRes.GetResource("UFIDA.U9.Cust.JSDY.BarCode.ProductBarCode")  ;}	}
		#endregion 		

		#region ModelResource,这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource()内部类的方式取资源
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("ID")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_ID　{ get { return EntityRes.GetResource("ID");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("CreatedOn")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_CreatedOn　{ get { return EntityRes.GetResource("CreatedOn");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("CreatedBy")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_CreatedBy　{ get { return EntityRes.GetResource("CreatedBy");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("ModifiedOn")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_ModifiedOn　{ get { return EntityRes.GetResource("ModifiedOn");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("ModifiedBy")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_ModifiedBy　{ get { return EntityRes.GetResource("ModifiedBy");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("SysVersion")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_SysVersion　{ get { return EntityRes.GetResource("SysVersion");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("Org")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_Org　{ get { return EntityRes.GetResource("Org");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("Item")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_Item　{ get { return EntityRes.GetResource("Item");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("BarCode")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_BarCode　{ get { return EntityRes.GetResource("BarCode");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("ActualLength")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_ActualLength　{ get { return EntityRes.GetResource("ActualLength");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("MarkingLength")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_MarkingLength　{ get { return EntityRes.GetResource("MarkingLength");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("Operators")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_Operators　{ get { return EntityRes.GetResource("Operators");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("ScanOn")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_ScanOn　{ get { return EntityRes.GetResource("ScanOn");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("ScanBy")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_ScanBy　{ get { return EntityRes.GetResource("ScanBy");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("PrintedOn")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_PrintedOn　{ get { return EntityRes.GetResource("PrintedOn");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("PrintedBy")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_PrintedBy　{ get { return EntityRes.GetResource("PrintedBy");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("CompleteApplyDoc")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_CompleteApplyDoc　{ get { return EntityRes.GetResource("CompleteApplyDoc");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("CompleteApplyDocLine")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_CompleteApplyDocLine　{ get { return EntityRes.GetResource("CompleteApplyDocLine");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("RcvRptDoc")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_RcvRptDoc　{ get { return EntityRes.GetResource("RcvRptDoc");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("RcvRptDocLine")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_RcvRptDocLine　{ get { return EntityRes.GetResource("RcvRptDocLine");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("Receivement")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_Receivement　{ get { return EntityRes.GetResource("Receivement");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("RcvLine")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_RcvLine　{ get { return EntityRes.GetResource("RcvLine");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("ProductBarCodeKind")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_ProductBarCodeKind　{ get { return EntityRes.GetResource("ProductBarCodeKind");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("RMA")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_RMA　{ get { return EntityRes.GetResource("RMA");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("RMALine")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_RMALine　{ get { return EntityRes.GetResource("RMALine");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("Lot")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_Lot　{ get { return EntityRes.GetResource("Lot");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("TransferOut")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_TransferOut　{ get { return EntityRes.GetResource("TransferOut");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("TransferOutLine")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_TransferOutLine　{ get { return EntityRes.GetResource("TransferOutLine");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("ShipPlan")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_ShipPlan　{ get { return EntityRes.GetResource("ShipPlan");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("ShipPlanLine")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_ShipPlanLine　{ get { return EntityRes.GetResource("ShipPlanLine");　}　}
		#endregion 



		#region EntityResource 实体的属性名称及相应显示名称资源访问方法
		public class EntityRes
		{
			/// <summary>
			/// EntityName的名称
			/// </summary>
			public static string BE_Name { get { return "ProductBarCode";　}　}
			
			/// <summary>
			/// Entity　的全名. 
			/// </summary>
			public static string BE_FullName { get { return "UFIDA.U9.Cust.JSDY.BarCode.ProductBarCode";　}　}
		
			/// <summary>
			/// 属性: ID 的名称
			/// </summary>
			public static string ID　{ get { return "ID";　}　}
				
			/// <summary>
			/// 属性: 创建时间 的名称
			/// </summary>
			public static string CreatedOn　{ get { return "CreatedOn";　}　}
				
			/// <summary>
			/// 属性: 创建人 的名称
			/// </summary>
			public static string CreatedBy　{ get { return "CreatedBy";　}　}
				
			/// <summary>
			/// 属性: 修改时间 的名称
			/// </summary>
			public static string ModifiedOn　{ get { return "ModifiedOn";　}　}
				
			/// <summary>
			/// 属性: 修改人 的名称
			/// </summary>
			public static string ModifiedBy　{ get { return "ModifiedBy";　}　}
				
			/// <summary>
			/// 属性: 事务版本 的名称
			/// </summary>
			public static string SysVersion　{ get { return "SysVersion";　}　}
				
			/// <summary>
			/// 属性: 组织 的名称
			/// </summary>
			public static string Org　{ get { return "Org";　}　}
				
			/// <summary>
			/// 属性: 料品 的名称
			/// </summary>
			public static string Item　{ get { return "Item";　}　}
				
			/// <summary>
			/// 属性: 条码 的名称
			/// </summary>
			public static string BarCode　{ get { return "BarCode";　}　}
				
			/// <summary>
			/// 属性: 实际长度 的名称
			/// </summary>
			public static string ActualLength　{ get { return "ActualLength";　}　}
				
			/// <summary>
			/// 属性: 合格证标示长度 的名称
			/// </summary>
			public static string MarkingLength　{ get { return "MarkingLength";　}　}
				
			/// <summary>
			/// 属性: 检验员 的名称
			/// </summary>
			public static string Operators　{ get { return "Operators";　}　}
				
			/// <summary>
			/// 属性: 扫描时间 的名称
			/// </summary>
			public static string ScanOn　{ get { return "ScanOn";　}　}
				
			/// <summary>
			/// 属性: 扫描人 的名称
			/// </summary>
			public static string ScanBy　{ get { return "ScanBy";　}　}
				
			/// <summary>
			/// 属性: 打印时间 的名称
			/// </summary>
			public static string PrintedOn　{ get { return "PrintedOn";　}　}
				
			/// <summary>
			/// 属性: 打印人 的名称
			/// </summary>
			public static string PrintedBy　{ get { return "PrintedBy";　}　}
				
			/// <summary>
			/// 属性: 完工申报单 的名称
			/// </summary>
			public static string CompleteApplyDoc　{ get { return "CompleteApplyDoc";　}　}
				
			/// <summary>
			/// 属性: 完工申报单行 的名称
			/// </summary>
			public static string CompleteApplyDocLine　{ get { return "CompleteApplyDocLine";　}　}
				
			/// <summary>
			/// 属性: 成品入库单 的名称
			/// </summary>
			public static string RcvRptDoc　{ get { return "RcvRptDoc";　}　}
				
			/// <summary>
			/// 属性: 成品入库单行 的名称
			/// </summary>
			public static string RcvRptDocLine　{ get { return "RcvRptDocLine";　}　}
				
			/// <summary>
			/// 属性: 销售退回收货单 的名称
			/// </summary>
			public static string Receivement　{ get { return "Receivement";　}　}
				
			/// <summary>
			/// 属性: 销售退回收货行 的名称
			/// </summary>
			public static string RcvLine　{ get { return "RcvLine";　}　}
				
			/// <summary>
			/// 属性: 条码状态 的名称
			/// </summary>
			public static string ProductBarCodeKind　{ get { return "ProductBarCodeKind";　}　}
				
			/// <summary>
			/// 属性: 退回处理单 的名称
			/// </summary>
			public static string RMA　{ get { return "RMA";　}　}
				
			/// <summary>
			/// 属性: 退回处理行 的名称
			/// </summary>
			public static string RMALine　{ get { return "RMALine";　}　}
				
			/// <summary>
			/// 属性: 批号 的名称
			/// </summary>
			public static string Lot　{ get { return "Lot";　}　}
				
			/// <summary>
			/// 属性: 调出单 的名称
			/// </summary>
			public static string TransferOut　{ get { return "TransferOut";　}　}
				
			/// <summary>
			/// 属性: 调出单行 的名称
			/// </summary>
			public static string TransferOutLine　{ get { return "TransferOutLine";　}　}
				
			/// <summary>
			/// 属性: 出货计划 的名称
			/// </summary>
			public static string ShipPlan　{ get { return "ShipPlan";　}　}
				
			/// <summary>
			/// 属性: 出货计划行 的名称
			/// </summary>
			public static string ShipPlanLine　{ get { return "ShipPlanLine";　}　}
		
			/// <summary>
			/// 获取显示名称资源方法
			/// </summary>
			public static string GetResource(String attrName){
				if (attrName == BE_Name || attrName== BE_FullName)
					return UFSoft.UBF.Business.Tool.ExtendHelpAPI.GetEntityResource(BE_FullName);
																																																												
				return UFSoft.UBF.Business.Tool.ExtendHelpAPI.GetAttrResource(BE_FullName, attrName);
			}

		}
		#endregion 


		#region EntityObjectBuilder 持久化性能优化
        private Dictionary<string, string> multiLangAttrs = null;
        private Dictionary<string, string> exdMultiLangAttrs = null;
        private string col_ID_Name = string.Empty;

        public override  Dictionary<string, string> MultiLangAttrs
        {
			get
			{
				return multiLangAttrs;
			}
        }
        public override  Dictionary<string, string> ExdMultiLangAttrs
        {
			get
			{
				return exdMultiLangAttrs;
			}
        }
        public override string Col_ID_Name
        {
			get
			{
				return col_ID_Name;
			}
        }  
        public override void IniData()
        {
			this.multiLangAttrs = new Dictionary<string, string>();
			this.exdMultiLangAttrs = new Dictionary<string, string>();
	
			this.col_ID_Name ="ID";
			this.exdMultiLangAttrs.Add("ID","ID");
			this.exdMultiLangAttrs.Add("CreatedOn","CreatedOn");
			this.exdMultiLangAttrs.Add("CreatedBy","CreatedBy");
			this.exdMultiLangAttrs.Add("ModifiedOn","ModifiedOn");
			this.exdMultiLangAttrs.Add("ModifiedBy","ModifiedBy");
			this.exdMultiLangAttrs.Add("SysVersion","SysVersion");
			this.exdMultiLangAttrs.Add("Org","Org");
			this.exdMultiLangAttrs.Add("Item","Item");
			this.exdMultiLangAttrs.Add("BarCode","BarCode");
			this.exdMultiLangAttrs.Add("ActualLength","ActualLength");
			this.exdMultiLangAttrs.Add("MarkingLength","MarkingLength");
			this.exdMultiLangAttrs.Add("Operators","Operators");
			this.exdMultiLangAttrs.Add("ScanOn","ScanOn");
			this.exdMultiLangAttrs.Add("ScanBy","ScanBy");
			this.exdMultiLangAttrs.Add("PrintedOn","PrintedOn");
			this.exdMultiLangAttrs.Add("PrintedBy","PrintedBy");
			this.exdMultiLangAttrs.Add("CompleteApplyDoc","CompleteApplyDoc");
			this.exdMultiLangAttrs.Add("CompleteApplyDocLine","CompleteApplyDocLine");
			this.exdMultiLangAttrs.Add("RcvRptDoc","RcvRptDoc");
			this.exdMultiLangAttrs.Add("RcvRptDocLine","RcvRptDocLine");
			this.exdMultiLangAttrs.Add("Receivement","Receivement");
			this.exdMultiLangAttrs.Add("RcvLine","RcvLine");
			this.exdMultiLangAttrs.Add("ProductBarCodeKind","ProductBarCodeKind");
			this.exdMultiLangAttrs.Add("RMA","RMA");
			this.exdMultiLangAttrs.Add("RMALine","RMALine");
			this.exdMultiLangAttrs.Add("Lot","Lot");
			this.exdMultiLangAttrs.Add("TransferOut","TransferOut");
			this.exdMultiLangAttrs.Add("TransferOutLine","TransferOutLine");
			this.exdMultiLangAttrs.Add("ShipPlan","ShipPlan");
			this.exdMultiLangAttrs.Add("ShipPlanLine","ShipPlanLine");
        }
	#endregion 




		
		
		#region override SetTypeValue method(Use By UICommonCRUD OR Weakly Type Operation)
		public override void SetTypeValue(object propName, object value)
		{
			
			string propstr = propName.ToString();
			switch(propstr)
			{
			
																																																																																										

				default:
					//调用基类的实现，最终Entity基类为SetValue()
					base.SetTypeValue(propName,value);
					return;
			}
		}
		#endregion


	


		#region EntityData exchange
		
		#region  DeSerializeKey -ForEntityPorpertyType
		//反序化Key到Data的ID中 --由FromEntityData自动调用一次。实际可以分离,由跨组织服务去调用.
		private void DeSerializeKey(ProductBarCodeData data)
		{
		
			

			

			

			

			

			

			if (data.Org == -1 && data.Org_SKey!=null)
				data.Org = data.Org_SKey.GetEntity().ID ;
	

			if (data.Item == -1 && data.Item_SKey!=null)
				data.Item = data.Item_SKey.GetEntity().ID ;
	

			

			

			

			if (data.Operators == -1 && data.Operators_SKey!=null)
				data.Operators = data.Operators_SKey.GetEntity().ID ;
	

			

			

			

			

			if (data.CompleteApplyDoc == -1 && data.CompleteApplyDoc_SKey!=null)
				data.CompleteApplyDoc = data.CompleteApplyDoc_SKey.GetEntity().ID ;
	

			if (data.CompleteApplyDocLine == -1 && data.CompleteApplyDocLine_SKey!=null)
				data.CompleteApplyDocLine = data.CompleteApplyDocLine_SKey.GetEntity().ID ;
	

			if (data.RcvRptDoc == -1 && data.RcvRptDoc_SKey!=null)
				data.RcvRptDoc = data.RcvRptDoc_SKey.GetEntity().ID ;
	

			if (data.RcvRptDocLine == -1 && data.RcvRptDocLine_SKey!=null)
				data.RcvRptDocLine = data.RcvRptDocLine_SKey.GetEntity().ID ;
	

			if (data.Receivement == -1 && data.Receivement_SKey!=null)
				data.Receivement = data.Receivement_SKey.GetEntity().ID ;
	

			if (data.RcvLine == -1 && data.RcvLine_SKey!=null)
				data.RcvLine = data.RcvLine_SKey.GetEntity().ID ;
	

			if (data.RMA == -1 && data.RMA_SKey!=null)
				data.RMA = data.RMA_SKey.GetEntity().ID ;
	

			if (data.RMALine == -1 && data.RMALine_SKey!=null)
				data.RMALine = data.RMALine_SKey.GetEntity().ID ;
	

			if (data.Lot == -1 && data.Lot_SKey!=null)
				data.Lot = data.Lot_SKey.GetEntity().ID ;
	

			if (data.TransferOut == -1 && data.TransferOut_SKey!=null)
				data.TransferOut = data.TransferOut_SKey.GetEntity().ID ;
	

			if (data.TransferOutLine == -1 && data.TransferOutLine_SKey!=null)
				data.TransferOutLine = data.TransferOutLine_SKey.GetEntity().ID ;
	

			if (data.ShipPlan == -1 && data.ShipPlan_SKey!=null)
				data.ShipPlan = data.ShipPlan_SKey.GetEntity().ID ;
	

			if (data.ShipPlanLine == -1 && data.ShipPlanLine_SKey!=null)
				data.ShipPlanLine = data.ShipPlanLine_SKey.GetEntity().ID ;
	
	
			//Entity中没有EntityKey集合，不用处理。
		}
		
		#endregion 	
        public override void FromEntityData(UFSoft.UBF.Business.DataTransObjectBase dto)
        {
			ProductBarCodeData data = dto as ProductBarCodeData ;
			if (data == null)
				return ;
            this.FromEntityData(data) ;
        }

        public override UFSoft.UBF.Business.DataTransObjectBase ToEntityDataBase()
        {
            return this.ToEntityData();
        }
		/// <summary>
		/// Copy Entity From EntityData
		/// </summary>
		public void FromEntityData(ProductBarCodeData data)
		{
			this.FromEntityData(data,new Hashtable());
		}
		//used by ubf..
		public void FromEntityData(ProductBarCodeData data,IDictionary dict)
		{
			if (data == null)
				return;
			bool m_isNeedPersistable = this.NeedPersistable ;
			this.NeedPersistable = false ;
			
			//this.innerData.ChangeEventEnabled = false;
			//this.innerRelation.RelationEventEnabled = false;
				
			if (dict == null ) dict = new Hashtable() ;
			dict[data] = this;
			this.SysState = data.SysState ;
			DeSerializeKey(data);
			#region 组件外属性
		
			//ID与系统字段不处理 --Sysversion需要处理。

		
			//ID与系统字段不处理 --Sysversion需要处理。

		
			//ID与系统字段不处理 --Sysversion需要处理。

		
			//ID与系统字段不处理 --Sysversion需要处理。

		
			//ID与系统字段不处理 --Sysversion需要处理。

								this.SetTypeValue("SysVersion",data.SysVersion);
		
								this.SetTypeValue("Org",data.Org);
		
								this.SetTypeValue("Item",data.Item);
		
								this.SetTypeValue("BarCode",data.BarCode);
		
								this.SetTypeValue("ActualLength",data.ActualLength);
		
								this.SetTypeValue("MarkingLength",data.MarkingLength);
		
								this.SetTypeValue("Operators",data.Operators);
		
								this.SetTypeValue("ScanOn",data.ScanOn);
		
								this.SetTypeValue("ScanBy",data.ScanBy);
		
								this.SetTypeValue("PrintedOn",data.PrintedOn);
		
								this.SetTypeValue("PrintedBy",data.PrintedBy);
		
								this.SetTypeValue("CompleteApplyDoc",data.CompleteApplyDoc);
		
								this.SetTypeValue("CompleteApplyDocLine",data.CompleteApplyDocLine);
		
								this.SetTypeValue("RcvRptDoc",data.RcvRptDoc);
		
								this.SetTypeValue("RcvRptDocLine",data.RcvRptDocLine);
		
								this.SetTypeValue("Receivement",data.Receivement);
		
								this.SetTypeValue("RcvLine",data.RcvLine);
		
								this.SetTypeValue("RMA",data.RMA);
		
								this.SetTypeValue("RMALine",data.RMALine);
		
								this.SetTypeValue("Lot",data.Lot);
		
								this.SetTypeValue("TransferOut",data.TransferOut);
		
								this.SetTypeValue("TransferOutLine",data.TransferOutLine);
		
								this.SetTypeValue("ShipPlan",data.ShipPlan);
		
								this.SetTypeValue("ShipPlanLine",data.ShipPlanLine);
		
			#endregion 

			#region 组件内属性
	
					this.SetTypeValue("ProductBarCodeKind",data.ProductBarCodeKind);
	     

			#endregion 
			this.NeedPersistable = m_isNeedPersistable ;
			dict[data] = this;
		}

		/// <summary>
		/// Create EntityData From Entity
		/// </summary>
		public ProductBarCodeData ToEntityData()
		{
			return ToEntityData(null,null);
		}
		/// <summary>
		/// Create EntityData From Entity - used by ubf 
		/// </summary>
		public ProductBarCodeData ToEntityData(ProductBarCodeData data, IDictionary dict){
			if (data == null)
				data = new ProductBarCodeData();
			
			if (dict == null ) dict = new Hashtable() ;
			//就直接用ID,如果不同实体会出现相同ID，则到时候要改进。? ID一定要有。
			dict["UFIDA.U9.Cust.JSDY.BarCode.ProductBarCode"+this.ID.ToString()] = data;
		
			data.SysState = this.SysState ;
			#region 组件外属性 -BusinessEntity,"简单值对象",简单类型,多语言.不可能存在一对多.没有集合可能.
	    
			{
				object obj =this.GetValue("ID");
				if (obj != null)
					data.ID=(System.Int64)obj;
			}
	     
	    
			{
				object obj =this.GetValue("CreatedOn");
				if (obj != null)
					data.CreatedOn=(System.DateTime)obj;
			}
	     
	    
			{
				object obj =this.GetValue("CreatedBy");
				if (obj != null)
					data.CreatedBy=(System.String)obj;
			}
	     
	    
			{
				object obj =this.GetValue("ModifiedOn");
				if (obj != null)
					data.ModifiedOn=(System.DateTime)obj;
			}
	     
	    
			{
				object obj =this.GetValue("ModifiedBy");
				if (obj != null)
					data.ModifiedBy=(System.String)obj;
			}
	     
	    
			{
				object obj =this.GetValue("SysVersion");
				if (obj != null)
					data.SysVersion=(System.Int64)obj;
			}
	     
	    
			{
				object obj =this.GetValue("Org");
				if (obj != null)
					data.Org=(System.Int64)obj;
			}
	     
	    
			{
				object obj =this.GetValue("Item");
				if (obj != null)
					data.Item=(System.Int64)obj;
			}
	     
	    
			{
				object obj =this.GetValue("BarCode");
				if (obj != null)
					data.BarCode=(System.String)obj;
			}
	     
	    
			{
				object obj =this.GetValue("ActualLength");
				if (obj != null)
					data.ActualLength=(System.Int32)obj;
			}
	     
	    
			{
				object obj =this.GetValue("MarkingLength");
				if (obj != null)
					data.MarkingLength=(System.Int32)obj;
			}
	     
	    
			{
				object obj =this.GetValue("Operators");
				if (obj != null)
					data.Operators=(System.Int64)obj;
			}
	     
	    
			{
				object obj =this.GetValue("ScanOn");
				if (obj != null)
					data.ScanOn=(System.DateTime)obj;
			}
	     
	    
			{
				object obj =this.GetValue("ScanBy");
				if (obj != null)
					data.ScanBy=(System.String)obj;
			}
	     
	    
			{
				object obj =this.GetValue("PrintedOn");
				if (obj != null)
					data.PrintedOn=(System.DateTime)obj;
			}
	     
	    
			{
				object obj =this.GetValue("PrintedBy");
				if (obj != null)
					data.PrintedBy=(System.String)obj;
			}
	     
	    
			{
				object obj =this.GetValue("CompleteApplyDoc");
				if (obj != null)
					data.CompleteApplyDoc=(System.Int64)obj;
			}
	     
	    
			{
				object obj =this.GetValue("CompleteApplyDocLine");
				if (obj != null)
					data.CompleteApplyDocLine=(System.Int64)obj;
			}
	     
	    
			{
				object obj =this.GetValue("RcvRptDoc");
				if (obj != null)
					data.RcvRptDoc=(System.Int64)obj;
			}
	     
	    
			{
				object obj =this.GetValue("RcvRptDocLine");
				if (obj != null)
					data.RcvRptDocLine=(System.Int64)obj;
			}
	     
	    
			{
				object obj =this.GetValue("Receivement");
				if (obj != null)
					data.Receivement=(System.Int64)obj;
			}
	     
	    
			{
				object obj =this.GetValue("RcvLine");
				if (obj != null)
					data.RcvLine=(System.Int64)obj;
			}
	     
	    
			{
				object obj =this.GetValue("RMA");
				if (obj != null)
					data.RMA=(System.Int64)obj;
			}
	     
	    
			{
				object obj =this.GetValue("RMALine");
				if (obj != null)
					data.RMALine=(System.Int64)obj;
			}
	     
	    
			{
				object obj =this.GetValue("Lot");
				if (obj != null)
					data.Lot=(System.Int64)obj;
			}
	     
	    
			{
				object obj =this.GetValue("TransferOut");
				if (obj != null)
					data.TransferOut=(System.Int64)obj;
			}
	     
	    
			{
				object obj =this.GetValue("TransferOutLine");
				if (obj != null)
					data.TransferOutLine=(System.Int64)obj;
			}
	     
	    
			{
				object obj =this.GetValue("ShipPlan");
				if (obj != null)
					data.ShipPlan=(System.Int64)obj;
			}
	     
	    
			{
				object obj =this.GetValue("ShipPlanLine");
				if (obj != null)
					data.ShipPlanLine=(System.Int64)obj;
			}
	     
			#endregion 

			#region 组件内属性 -Entity,"复杂值对象",枚举,实体集合.
	
			{
				object obj =this.GetValue("ProductBarCodeKind");
				if (obj != null)
					data.ProductBarCodeKind=System.Int32.Parse(obj.ToString());
			}
	

			#endregion 
			return data ;
		}

		#endregion
	



	
        #region EntityValidator 
	//实体检验： 含自身检验器检验，内嵌属性类型的检验以及属性类型上的校验器的检验。
        private bool SelfEntityValidator()
        {
        






























			//调用实体自身校验器代码.
            return true; 
        }
		//校验属性是否为空的检验。主要是关联对象的效验
		public override void SelfNullableVlidator()
		{
			base.SelfNullableVlidator();
		
			if (Convert.ToInt64(base.GetValue("Org")) == UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag){
				UFSoft.UBF.Business.AttributeInValidException Org_Exception = new UFSoft.UBF.Business.AttributeInValidException("UFIDA.U9.Cust.JSDY.BarCode.ProductBarCode","Org","489a2e39-beab-4f12-b042-15683a62fda1");
				if (UFSoft.UBF.PL.Tool.ConfigParm.SupportNullableVlidatorStackTrace)
					Org_Exception.MyStackTrace =  new System.Diagnostics.StackTrace(true).ToString();
				this.PropertyExceptions.Add(Org_Exception);
			}

			if (Convert.ToInt64(base.GetValue("Item")) == UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag){
				UFSoft.UBF.Business.AttributeInValidException Item_Exception = new UFSoft.UBF.Business.AttributeInValidException("UFIDA.U9.Cust.JSDY.BarCode.ProductBarCode","Item","90aa2599-1735-42ac-bd7f-1cb5cafdbad3");
				if (UFSoft.UBF.PL.Tool.ConfigParm.SupportNullableVlidatorStackTrace)
					Item_Exception.MyStackTrace =  new System.Diagnostics.StackTrace(true).ToString();
				this.PropertyExceptions.Add(Item_Exception);
			}

			if (string.IsNullOrEmpty((string)base.GetValue("BarCode"))){
				UFSoft.UBF.Business.AttributeInValidException BarCode_Exception =new UFSoft.UBF.Business.AttributeInValidException("UFIDA.U9.Cust.JSDY.BarCode.ProductBarCode","BarCode","54339b61-9e61-4f13-bca3-9c6559e2d374");
				if (UFSoft.UBF.PL.Tool.ConfigParm.SupportNullableVlidatorStackTrace)
					BarCode_Exception.MyStackTrace =  new System.Diagnostics.StackTrace(true).ToString();
				this.PropertyExceptions.Add(BarCode_Exception);
			}

			
		}
			    
	#endregion 
	
	
		#region 应用版型代码区
		#endregion 


	}	
}