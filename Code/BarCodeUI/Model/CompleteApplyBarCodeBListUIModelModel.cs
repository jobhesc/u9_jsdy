#region Using directives

using System;
using System.Collections;
using System.Data;
using UFSoft.UBF.UI.MD.Runtime;
using UFSoft.UBF.UI.MD.Runtime.Implement;

#endregion

namespace UFIDA.U9.Cust.JSDY.CompleteApplyBarCodeBListUIModel
{
	[Serializable]
	public partial class CompleteApplyBarCodeBListUIModelModel : UIModel
	{
		#region Constructor
		public CompleteApplyBarCodeBListUIModelModel() : base("CompleteApplyBarCodeBListUIModel")
		{
			InitClass();
			this.SetResourceInfo("62cadc16-b90a-4b08-b586-b3c70a366565");
            try{
			    AfterInitModel();
            }catch(Exception exception){
              IUIModel model = this;
		      this.ErrorMessage.SetErrorMessage(ref model,exception);
			}
		}

		//just for Clone 
		private CompleteApplyBarCodeBListUIModelModel(bool isInit) : base("CompleteApplyBarCodeBListUIModel")
		{}
		protected override IUIModel CreateCloneInstance()
		{
			return new CompleteApplyBarCodeBListUIModelModel(false);
		}
		#endregion
		#region member
		#region views
		private CompleteApplyBarCodeView viewCompleteApplyBarCode;			
		#endregion
		
		#region links
		#endregion
		
		#region properties
		#endregion
		#endregion

		#region property
		public CompleteApplyBarCodeView CompleteApplyBarCode
		{
			get { return (CompleteApplyBarCodeView)this["CompleteApplyBarCode"]; }
		}
		
		#region RealViews
		#endregion
		
	
		#endregion

		#region function
		private void InitClass()
		{
			this.viewCompleteApplyBarCode = new CompleteApplyBarCodeView(this);
			this.viewCompleteApplyBarCode.SetResourceInfo("5bdc0496-f2fa-42d1-b448-0c0bc89e3876");
			this.Views.Add(this.viewCompleteApplyBarCode);			

			
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
	public partial class CompleteApplyBarCodeView : UIView
	{
		#region Constructor
		public CompleteApplyBarCodeView(IUIModel model) : base(model,"CompleteApplyBarCode","UFIDA.U9.Cust.JSDY.BarCode.CompleteApplyBarCode", true)
		{
			InitClass();
		}
		//构造空实例,不进行初始化.目前为Clone使用.
		private CompleteApplyBarCodeView():base(null,"CompleteApplyBarCode","UFIDA.U9.Cust.JSDY.BarCode.CompleteApplyBarCode", true)
		{
		}
		protected override IUIView CreateCloneInstance()
		{
			return new CompleteApplyBarCodeView();
		}
		#endregion

		#region fiels property filter
		public IUIField FieldID
		{
			get { return this.Fields["ID"]; }
		}
		public IUIField FieldIsPrinted
		{
			get { return this.Fields["IsPrinted"]; }
		}
		public IUIField FieldBarCode
		{
			get { return this.Fields["BarCode"]; }
		}
		public IUIField FieldIsPrintWrapper
		{
			get { return this.Fields["IsPrintWrapper"]; }
		}
		public IUIField FieldPrintCount
		{
			get { return this.Fields["PrintCount"]; }
		}


		[Obsolete("请使用CurrentFilter属性，这个方法有可能会导致强弱类型转换出错")]
		public CompleteApplyBarCodeDefaultFilterFilter DefaultFilter
		{
			get { return (CompleteApplyBarCodeDefaultFilterFilter)this.CurrentFilter; }
		}
		#endregion

		#region Init
		private void InitClass()
		{
			UIModelRuntimeFactory.AddNewUIField(this,"ID", typeof(Int64), false,"","System.Int64", "ID", true,true, false, "",false,(UIFieldType)1,"ba391065-6c27-4c82-acc8-b52b1c93a910","efe83ccc-22ae-4c1e-bdec-6713313976ef");
			UIModelRuntimeFactory.AddNewUIField(this,"IsPrinted", typeof(Boolean), true,"false","System.Boolean", "IsPrinted", true,true, false, "",false,(UIFieldType)1,"5efeea06-cae7-4cc0-82e9-20a789e4e582","12e47b15-f149-4eb1-aa9a-fcc765defc0c");
			UIModelRuntimeFactory.AddNewUIField(this,"BarCode", typeof(String), false,"","System.String", "BarCode", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","05372780-f1f3-4347-b3f7-64977c022d0b");
			UIModelRuntimeFactory.AddNewUIField(this,"IsPrintWrapper", typeof(Boolean), true,"false","System.Boolean", "IsPrintWrapper", true,true, false, "",false,(UIFieldType)1,"5efeea06-cae7-4cc0-82e9-20a789e4e582","040b33e7-0dd7-4423-88c1-ee12ceda5186");
			UIModelRuntimeFactory.AddNewUIField(this,"PrintCount", typeof(Int32), true,"0","System.Int32", "PrintCount", true,true, false, "",false,(UIFieldType)1,"d7c6031e-d3fe-41aa-a397-5edd86c10cae","d9394e8f-c06c-4112-9d32-80adb79a46c8");


			this.CurrentFilter = new CompleteApplyBarCodeDefaultFilterFilter(this);
		}
		#endregion
		
		#region override method
		protected override IUIRecord BuildNewRecord(IUIRecordBuilder builder)
		{
			return new CompleteApplyBarCodeRecord(builder);
		}
		#endregion

		#region new method
		public new CompleteApplyBarCodeRecord FocusedRecord
		{
			get { return (CompleteApplyBarCodeRecord)base.FocusedRecord ; }
			set { base.FocusedRecord = value ; }
		}
		public new CompleteApplyBarCodeRecord AddNewUIRecord()
		{	
			return (CompleteApplyBarCodeRecord)base.AddNewUIRecord();
		}
		public new CompleteApplyBarCodeRecord NewUIRecord()
		{	
			return (CompleteApplyBarCodeRecord)base.NewUIRecord();
		}
		#endregion 

	}

	[Serializable]
	public class CompleteApplyBarCodeRecord : UIRecord
	{
		#region Constructor
		public CompleteApplyBarCodeRecord(IUIRecordBuilder builder):base(builder)
		{
		}
		private CompleteApplyBarCodeView uiviewCompleteApplyBarCode
		{
			get { return (CompleteApplyBarCodeView)this.ContainerView; }
		}
		protected override IUIRecord CreateCloneInstance(IUIRecordBuilder builder)
		{
			return new CompleteApplyBarCodeRecord(builder);
		}
		#endregion

		#region property
		
		
		public  Int64 ID
		{
			get{
				//object value = this[this.uiviewCompleteApplyBarCode.FieldID] ;
				//return (Int64)value;
				return GetValue<Int64>(this.uiviewCompleteApplyBarCode.FieldID);
			}
			set{
				this[this.uiviewCompleteApplyBarCode.FieldID] = value;
			}
		}
		
		
		public  Boolean? IsPrinted
		{
			get{
				//object value = this[this.uiviewCompleteApplyBarCode.FieldIsPrinted] ;
				//return (Boolean?)value;
				return GetValue<Boolean?>(this.uiviewCompleteApplyBarCode.FieldIsPrinted);
			}
			set{
				this[this.uiviewCompleteApplyBarCode.FieldIsPrinted] = value;
			}
		}
		
		
		public  String BarCode
		{
			get{
				//object value = this[this.uiviewCompleteApplyBarCode.FieldBarCode] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCompleteApplyBarCode.FieldBarCode);
			}
			set{
				this[this.uiviewCompleteApplyBarCode.FieldBarCode] = value;
			}
		}
		
		
		public  Boolean? IsPrintWrapper
		{
			get{
				//object value = this[this.uiviewCompleteApplyBarCode.FieldIsPrintWrapper] ;
				//return (Boolean?)value;
				return GetValue<Boolean?>(this.uiviewCompleteApplyBarCode.FieldIsPrintWrapper);
			}
			set{
				this[this.uiviewCompleteApplyBarCode.FieldIsPrintWrapper] = value;
			}
		}
		
		
		public  Int32? PrintCount
		{
			get{
				//object value = this[this.uiviewCompleteApplyBarCode.FieldPrintCount] ;
				//return (Int32?)value;
				return GetValue<Int32?>(this.uiviewCompleteApplyBarCode.FieldPrintCount);
			}
			set{
				this[this.uiviewCompleteApplyBarCode.FieldPrintCount] = value;
			}
		}
		#endregion
	}
	
	[Serializable]
	public class CompleteApplyBarCodeDefaultFilterFilter : UIFilter
	{
		#region Constructor
		public CompleteApplyBarCodeDefaultFilterFilter(IUIView view) 
			: base("DefaultFilter",view,@"",@"")
		{
			InitClass();
		}
		//for Clone Constructor
		private CompleteApplyBarCodeDefaultFilterFilter()
			: base("DefaultFilter",null,"","")
		{}
		protected override IUIFilter CreateCloneInstance()
		{
			return new CompleteApplyBarCodeDefaultFilterFilter();
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