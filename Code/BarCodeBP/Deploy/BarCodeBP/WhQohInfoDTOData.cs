



using System; 
using System.Collections;
using System.Collections.Generic ;
using System.Runtime.Serialization;

namespace UFIDA.U9.Cust.JSDY.BarCode
{
	/// <summary>
	/// 库存量信息DTO DTO :自定义的数据传输类型 
	/// 
	/// </summary>
	[DataContract(Name = "UFIDA.U9.Cust.JSDY.BarCode.WhQohInfoDTOData", Namespace = "http://www.UFIDA.org/EntityData",IsReference=true)]
	[Serializable]
	[KnownType("GetKnownTypes")]
	public partial class WhQohInfoDTOData : UFSoft.UBF.Business.DataTransObjectBase
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
		public WhQohInfoDTOData()
		{
			initData();
		}
		private void initData()
		{
					ItemID= 0; 
				
		
		
		
					SegLength= 0; 
							StoreQty=0m; 
		
					UOM_Precision= 0; 
							UOM_RoundType= 0; 
							UOM_RoundValue= 0; 
		
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
		public WhQohInfoDTOData(  System.Int64 itemID  , System.String itemCode  , System.String itemName  , System.String wh  , System.String lot  , System.Int32 segLength  , System.Decimal storeQty  , System.String uOM  , System.Int32 uOM_Precision  , System.Int32 uOM_RoundType  , System.Int32 uOM_RoundValue  )
		{
			initData();
			this.ItemID = itemID;
			this.ItemCode = itemCode;
			this.ItemName = itemName;
			this.Wh = wh;
			this.Lot = lot;
			this.SegLength = segLength;
			this.StoreQty = storeQty;
			this.UOM = uOM;
			this.UOM_Precision = uOM_Precision;
			this.UOM_RoundType = uOM_RoundType;
			this.UOM_RoundValue = uOM_RoundValue;
		}
		#region System Fields 
		//--系统字段,目前没有.EntityData上有相应的字段,用于保存相关的实体状态信息,DTO上没有状态信息.	
		#endregion
		
		#region DTO Properties 
	
		

		/// <summary>
		/// 料品ID
		/// 库存量信息DTO.Misc.料品ID
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
		/// 料号
		/// 库存量信息DTO.Misc.料号
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
		/// 库存量信息DTO.Misc.品名
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
		/// 仓库
		/// 库存量信息DTO.Misc.仓库
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.String m_wh ;
		public System.String Wh
		{
			get	
			{	
				return m_wh ;
			}
			set	
			{	
				m_wh = value ;	
			}
		}
			
		

		/// <summary>
		/// 批号
		/// 库存量信息DTO.Misc.批号
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.String m_lot ;
		public System.String Lot
		{
			get	
			{	
				return m_lot ;
			}
			set	
			{	
				m_lot = value ;	
			}
		}
			
		

		/// <summary>
		/// 段长
		/// 库存量信息DTO.Misc.段长
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.Int32 m_segLength ;
		public System.Int32 SegLength
		{
			get	
			{	
				return m_segLength ;
			}
			set	
			{	
				m_segLength = value ;	
			}
		}
			
		

		/// <summary>
		/// 库存量
		/// 库存量信息DTO.Misc.库存量
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.Decimal m_storeQty ;
		public System.Decimal StoreQty
		{
			get	
			{	
				return m_storeQty ;
			}
			set	
			{	
				m_storeQty = value ;	
			}
		}
			
		

		/// <summary>
		/// 单位
		/// 库存量信息DTO.Misc.单位
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.String m_uOM ;
		public System.String UOM
		{
			get	
			{	
				return m_uOM ;
			}
			set	
			{	
				m_uOM = value ;	
			}
		}
			
		

		/// <summary>
		/// 单位精度
		/// 库存量信息DTO.Misc.单位精度
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.Int32 m_uOM_Precision ;
		public System.Int32 UOM_Precision
		{
			get	
			{	
				return m_uOM_Precision ;
			}
			set	
			{	
				m_uOM_Precision = value ;	
			}
		}
			
		

		/// <summary>
		/// 单位舍入类型
		/// 库存量信息DTO.Misc.单位舍入类型
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.Int32 m_uOM_RoundType ;
		public System.Int32 UOM_RoundType
		{
			get	
			{	
				return m_uOM_RoundType ;
			}
			set	
			{	
				m_uOM_RoundType = value ;	
			}
		}
			
		

		/// <summary>
		/// 单位舍入值
		/// 库存量信息DTO.Misc.单位舍入值
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.Int32 m_uOM_RoundValue ;
		public System.Int32 UOM_RoundValue
		{
			get	
			{	
				return m_uOM_RoundValue ;
			}
			set	
			{	
				m_uOM_RoundValue = value ;	
			}
		}
			
		#endregion	

		#region Multi_Fields
																						
		#endregion 
	} 	
}

	
