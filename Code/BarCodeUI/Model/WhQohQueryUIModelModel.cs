#region Using directives

using System;
using System.Collections;
using System.Data;
using UFSoft.UBF.UI.MD.Runtime;
using UFSoft.UBF.UI.MD.Runtime.Implement;

#endregion

namespace UFIDA.U9.Cust.JSDY.WhQohQueryUIModel
{
	[Serializable]
	public partial class WhQohQueryUIModelModel : UIModel
	{
		#region Constructor
		public WhQohQueryUIModelModel() : base("WhQohQueryUIModel")
		{
			InitClass();
			this.SetResourceInfo("1c0bcb53-4808-4521-9734-c26e99447e9f");
            try{
			    AfterInitModel();
            }catch(Exception exception){
              IUIModel model = this;
		      this.ErrorMessage.SetErrorMessage(ref model,exception);
			}
		}

		//just for Clone 
		private WhQohQueryUIModelModel(bool isInit) : base("WhQohQueryUIModel")
		{}
		protected override IUIModel CreateCloneInstance()
		{
			return new WhQohQueryUIModelModel(false);
		}
		#endregion
		#region member
		#region views
		private QueryResultViewView viewQueryResultView;			
		#endregion
		
		#region links
		#endregion
		
		#region properties
		#endregion
		#endregion

		#region property
		public QueryResultViewView QueryResultView
		{
			get { return (QueryResultViewView)this["QueryResultView"]; }
		}
		
		#region RealViews
		#endregion
		
	
		#endregion

		#region function
		private void InitClass()
		{
			this.viewQueryResultView = new QueryResultViewView(this);
			this.viewQueryResultView.SetResourceInfo("24174d0c-ad94-4b82-8c54-a44968e320c7");
			this.Views.Add(this.viewQueryResultView);			

			
		}

		public override string AssemblyName
		{
			get { return "UFIDA.U9.Cust.JSDY.BarCodeUI"; }
		}
		
		#endregion
		private void OnValidate_DefualtImpl()
    {
    }

	}


	[Serializable]
	public partial class QueryResultViewView : UIView
	{
		#region Constructor
		public QueryResultViewView(IUIModel model) : base(model,"QueryResultView","", true)
		{
			InitClass();
		}
		//构造空实例,不进行初始化.目前为Clone使用.
		private QueryResultViewView():base(null,"QueryResultView","", true)
		{
		}
		protected override IUIView CreateCloneInstance()
		{
			return new QueryResultViewView();
		}
		#endregion

		#region fiels property filter
		public IUIField FieldID
		{
			get { return this.Fields["ID"]; }
		}
		public IUIField FieldCreatedOn
		{
			get { return this.Fields["CreatedOn"]; }
		}
		public IUIField FieldCreatedBy
		{
			get { return this.Fields["CreatedBy"]; }
		}
		public IUIField FieldModifiedOn
		{
			get { return this.Fields["ModifiedOn"]; }
		}
		public IUIField FieldModifiedBy
		{
			get { return this.Fields["ModifiedBy"]; }
		}
		public IUIField FieldSysVersion
		{
			get { return this.Fields["SysVersion"]; }
		}
		public IUIField FieldItemCode
		{
			get { return this.Fields["ItemCode"]; }
		}
		public IUIField FieldItemName
		{
			get { return this.Fields["ItemName"]; }
		}
		public IUIField FieldWh
		{
			get { return this.Fields["Wh"]; }
		}
		public IUIField FieldLot
		{
			get { return this.Fields["Lot"]; }
		}
		public IUIField FieldSegLength
		{
			get { return this.Fields["SegLength"]; }
		}
		public IUIField FieldStoreQty
		{
			get { return this.Fields["StoreQty"]; }
		}
		public IUIField FieldUOM
		{
			get { return this.Fields["UOM"]; }
		}
		public IUIField FieldUOM_RoundValue
		{
			get { return this.Fields["UOM_RoundValue"]; }
		}
		public IUIField FieldUOM_RoundType
		{
			get { return this.Fields["UOM_RoundType"]; }
		}
		public IUIField FieldUOM_Precision
		{
			get { return this.Fields["UOM_Precision"]; }
		}


		[Obsolete("请使用CurrentFilter属性，这个方法有可能会导致强弱类型转换出错")]
		public QueryResultViewDefaultFilterFilter DefaultFilter
		{
			get { return (QueryResultViewDefaultFilterFilter)this.CurrentFilter; }
		}
		#endregion

		#region Init
		private void InitClass()
		{
			UIModelRuntimeFactory.AddNewUIField(this,"ID", typeof(Int64), false,"","System.Int64", "", false,false, false, "",false,(UIFieldType)1,"ba391065-6c27-4c82-acc8-b52b1c93a910","bd23db22-cec0-4810-892d-56c5a8a5c48e");
			UIModelRuntimeFactory.AddNewUIField(this,"CreatedOn", typeof(DateTime), false,"","System.DateTime", "", false,false, false, "",false,(UIFieldType)1,"3834a958-120f-4ac9-8d60-1a7be6d3f12f","0a3ed034-db21-4958-b450-2baadd11aa9e");
			UIModelRuntimeFactory.AddNewUIField(this,"CreatedBy", typeof(String), false,"","System.String", "", false,false, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","2137d0dc-b98f-441b-a55c-2a87c73d87ff");
			UIModelRuntimeFactory.AddNewUIField(this,"ModifiedOn", typeof(DateTime), false,"","System.DateTime", "", false,false, false, "",false,(UIFieldType)1,"3834a958-120f-4ac9-8d60-1a7be6d3f12f","38d21d77-7343-43e3-ba4f-0e28f3451f24");
			UIModelRuntimeFactory.AddNewUIField(this,"ModifiedBy", typeof(String), false,"","System.String", "", false,false, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","195ec0c1-e380-4df0-b2d9-128994ab3931");
			UIModelRuntimeFactory.AddNewUIField(this,"SysVersion", typeof(Int64), false,"","System.Int64", "", false,false, false, "",false,(UIFieldType)1,"ba391065-6c27-4c82-acc8-b52b1c93a910","6f35218b-7ff1-4f7c-9873-4dc0fb26c6bd");
			UIModelRuntimeFactory.AddNewUIField(this,"ItemCode", typeof(String), true,"","System.String", "", false,false, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","04608a9a-4967-43b7-bbc8-a50dc4b07445");
			UIModelRuntimeFactory.AddNewUIField(this,"ItemName", typeof(String), true,"","System.String", "", false,false, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","91e031ef-341d-403a-bc51-e9c777dbf70d");
			UIModelRuntimeFactory.AddNewUIField(this,"Wh", typeof(String), true,"","System.String", "", false,false, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","ac8283b3-01f5-41dd-8746-c510a51571af");
			UIModelRuntimeFactory.AddNewUIField(this,"Lot", typeof(String), true,"","System.String", "", false,false, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","d80bd22e-9afc-4026-a057-fe9b62eea3f1");
			UIModelRuntimeFactory.AddNewUIField(this,"SegLength", typeof(Int32), true,"","System.String", "", false,false, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","ddaf03b4-3ad0-4bcb-908b-e7a8bdef0506");
			UIModelRuntimeFactory.AddNewUIField(this,"StoreQty", typeof(Decimal), true,"","System.String", "", false,false, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","18766b44-b2a2-49c3-97e0-a04ec0bf188f");
			UIModelRuntimeFactory.AddNewUIField(this,"UOM", typeof(String), true,"","System.String", "", false,false, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","d1656cf6-0ddb-47a8-948f-ef57d35245c7");
			UIModelRuntimeFactory.AddNewUIField(this,"UOM_RoundValue", typeof(Int32), true,"","System.String", "", false,false, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","1980cbcd-8670-4b36-93f0-d4c7d2b35b92");
			UIModelRuntimeFactory.AddNewUIField(this,"UOM_RoundType", typeof(Int32), true,"","System.String", "", false,false, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","a9128ff4-706d-4d37-b343-2962451eff33");
			UIModelRuntimeFactory.AddNewUIField(this,"UOM_Precision", typeof(Int32), true,"","System.String", "", false,false, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","440f9ef3-6b40-46ce-8963-bf783cb18899");


			this.CurrentFilter = new QueryResultViewDefaultFilterFilter(this);
		}
		#endregion
		
		#region override method
		protected override IUIRecord BuildNewRecord(IUIRecordBuilder builder)
		{
			return new QueryResultViewRecord(builder);
		}
		#endregion

		#region new method
		public new QueryResultViewRecord FocusedRecord
		{
			get { return (QueryResultViewRecord)base.FocusedRecord ; }
			set { base.FocusedRecord = value ; }
		}
		public new QueryResultViewRecord AddNewUIRecord()
		{	
			return (QueryResultViewRecord)base.AddNewUIRecord();
		}
		public new QueryResultViewRecord NewUIRecord()
		{	
			return (QueryResultViewRecord)base.NewUIRecord();
		}
		#endregion 

	}

	[Serializable]
	public class QueryResultViewRecord : UIRecord
	{
		#region Constructor
		public QueryResultViewRecord(IUIRecordBuilder builder):base(builder)
		{
		}
		private QueryResultViewView uiviewQueryResultView
		{
			get { return (QueryResultViewView)this.ContainerView; }
		}
		protected override IUIRecord CreateCloneInstance(IUIRecordBuilder builder)
		{
			return new QueryResultViewRecord(builder);
		}
		#endregion

		#region property
		
		
		public  Int64 ID
		{
			get{
				//object value = this[this.uiviewQueryResultView.FieldID] ;
				//return (Int64)value;
				return GetValue<Int64>(this.uiviewQueryResultView.FieldID);
			}
			set{
				this[this.uiviewQueryResultView.FieldID] = value;
			}
		}
		
		
		public  DateTime CreatedOn
		{
			get{
				//object value = this[this.uiviewQueryResultView.FieldCreatedOn] ;
				//return (DateTime)value;
				return GetValue<DateTime>(this.uiviewQueryResultView.FieldCreatedOn);
			}
			set{
				this[this.uiviewQueryResultView.FieldCreatedOn] = value;
			}
		}
		
		
		public  String CreatedBy
		{
			get{
				//object value = this[this.uiviewQueryResultView.FieldCreatedBy] ;
				//return (String)value;
				return GetValue<String>(this.uiviewQueryResultView.FieldCreatedBy);
			}
			set{
				this[this.uiviewQueryResultView.FieldCreatedBy] = value;
			}
		}
		
		
		public  DateTime ModifiedOn
		{
			get{
				//object value = this[this.uiviewQueryResultView.FieldModifiedOn] ;
				//return (DateTime)value;
				return GetValue<DateTime>(this.uiviewQueryResultView.FieldModifiedOn);
			}
			set{
				this[this.uiviewQueryResultView.FieldModifiedOn] = value;
			}
		}
		
		
		public  String ModifiedBy
		{
			get{
				//object value = this[this.uiviewQueryResultView.FieldModifiedBy] ;
				//return (String)value;
				return GetValue<String>(this.uiviewQueryResultView.FieldModifiedBy);
			}
			set{
				this[this.uiviewQueryResultView.FieldModifiedBy] = value;
			}
		}
		
		
		public new Int64 SysVersion
		{
			get{
				//object value = this[this.uiviewQueryResultView.FieldSysVersion] ;
				//return (Int64)value;
				return GetValue<Int64>(this.uiviewQueryResultView.FieldSysVersion);
			}
			set{
				this[this.uiviewQueryResultView.FieldSysVersion] = value;
			}
		}
		
		
		public  String ItemCode
		{
			get{
				//object value = this[this.uiviewQueryResultView.FieldItemCode] ;
				//return (String)value;
				return GetValue<String>(this.uiviewQueryResultView.FieldItemCode);
			}
			set{
				this[this.uiviewQueryResultView.FieldItemCode] = value;
			}
		}
		
		
		public  String ItemName
		{
			get{
				//object value = this[this.uiviewQueryResultView.FieldItemName] ;
				//return (String)value;
				return GetValue<String>(this.uiviewQueryResultView.FieldItemName);
			}
			set{
				this[this.uiviewQueryResultView.FieldItemName] = value;
			}
		}
		
		
		public  String Wh
		{
			get{
				//object value = this[this.uiviewQueryResultView.FieldWh] ;
				//return (String)value;
				return GetValue<String>(this.uiviewQueryResultView.FieldWh);
			}
			set{
				this[this.uiviewQueryResultView.FieldWh] = value;
			}
		}
		
		
		public  String Lot
		{
			get{
				//object value = this[this.uiviewQueryResultView.FieldLot] ;
				//return (String)value;
				return GetValue<String>(this.uiviewQueryResultView.FieldLot);
			}
			set{
				this[this.uiviewQueryResultView.FieldLot] = value;
			}
		}
		
		
		public  Int32? SegLength
		{
			get{
				//object value = this[this.uiviewQueryResultView.FieldSegLength] ;
				//return (Int32?)value;
				return GetValue<Int32?>(this.uiviewQueryResultView.FieldSegLength);
			}
			set{
				this[this.uiviewQueryResultView.FieldSegLength] = value;
			}
		}
		
		
		public  Decimal? StoreQty
		{
			get{
				//object value = this[this.uiviewQueryResultView.FieldStoreQty] ;
				//return (Decimal?)value;
				return GetValue<Decimal?>(this.uiviewQueryResultView.FieldStoreQty);
			}
			set{
				this[this.uiviewQueryResultView.FieldStoreQty] = value;
			}
		}
		
		
		public  String UOM
		{
			get{
				//object value = this[this.uiviewQueryResultView.FieldUOM] ;
				//return (String)value;
				return GetValue<String>(this.uiviewQueryResultView.FieldUOM);
			}
			set{
				this[this.uiviewQueryResultView.FieldUOM] = value;
			}
		}
		
		
		public  Int32? UOM_RoundValue
		{
			get{
				//object value = this[this.uiviewQueryResultView.FieldUOM_RoundValue] ;
				//return (Int32?)value;
				return GetValue<Int32?>(this.uiviewQueryResultView.FieldUOM_RoundValue);
			}
			set{
				this[this.uiviewQueryResultView.FieldUOM_RoundValue] = value;
			}
		}
		
		
		public  Int32? UOM_RoundType
		{
			get{
				//object value = this[this.uiviewQueryResultView.FieldUOM_RoundType] ;
				//return (Int32?)value;
				return GetValue<Int32?>(this.uiviewQueryResultView.FieldUOM_RoundType);
			}
			set{
				this[this.uiviewQueryResultView.FieldUOM_RoundType] = value;
			}
		}
		
		
		public  Int32? UOM_Precision
		{
			get{
				//object value = this[this.uiviewQueryResultView.FieldUOM_Precision] ;
				//return (Int32?)value;
				return GetValue<Int32?>(this.uiviewQueryResultView.FieldUOM_Precision);
			}
			set{
				this[this.uiviewQueryResultView.FieldUOM_Precision] = value;
			}
		}
		#endregion
	}
	
	[Serializable]
	public class QueryResultViewDefaultFilterFilter : UIFilter
	{
		#region Constructor
		public QueryResultViewDefaultFilterFilter(IUIView view) 
			: base("DefaultFilter",view,@"",@"")
		{
			InitClass();
		}
		//for Clone Constructor
		private QueryResultViewDefaultFilterFilter()
			: base("DefaultFilter",null,"","")
		{}
		protected override IUIFilter CreateCloneInstance()
		{
			return new QueryResultViewDefaultFilterFilter();
		}
		#endregion

		#region property
		#endregion
		
		#region function
		private void InitClass()
		{
		}
		#endregion

	}



}