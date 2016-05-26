#region Using directives

using System;
using System.Collections;
using System.Data;
using UFSoft.UBF.UI.MD.Runtime;
using UFSoft.UBF.UI.MD.Runtime.Implement;

#endregion

namespace UFIDA.U9.Cust.JSDY.CheckBarCodeBListUIModel
{
	[Serializable]
	public partial class CheckBarCodeBListUIModelModel : UIModel
	{
		#region Constructor
		public CheckBarCodeBListUIModelModel() : base("CheckBarCodeBListUIModel")
		{
			InitClass();
			this.SetResourceInfo("d4fb6df2-126b-48f9-b10d-69494790490b");
            try{
			    AfterInitModel();
            }catch(Exception exception){
              IUIModel model = this;
		      this.ErrorMessage.SetErrorMessage(ref model,exception);
			}
		}

		//just for Clone 
		private CheckBarCodeBListUIModelModel(bool isInit) : base("CheckBarCodeBListUIModel")
		{}
		protected override IUIModel CreateCloneInstance()
		{
			return new CheckBarCodeBListUIModelModel(false);
		}
		#endregion
		#region member
		#region views
		private CheckBarCodeView viewCheckBarCode;			
		#endregion
		
		#region links
		#endregion
		
		#region properties
		#endregion
		#endregion

		#region property
		public CheckBarCodeView CheckBarCode
		{
			get { return (CheckBarCodeView)this["CheckBarCode"]; }
		}
		
		#region RealViews
		#endregion
		
	
		#endregion

		#region function
		private void InitClass()
		{
			this.viewCheckBarCode = new CheckBarCodeView(this);
			this.viewCheckBarCode.SetResourceInfo("8f6785cc-66a2-4ebb-8681-0481719b13e2");
			this.Views.Add(this.viewCheckBarCode);			

			
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
	public partial class CheckBarCodeView : UIView
	{
		#region Constructor
		public CheckBarCodeView(IUIModel model) : base(model,"CheckBarCode","UFIDA.U9.Cust.JSDY.BarCode.CheckBarCode", true)
		{
			InitClass();
		}
		//构造空实例,不进行初始化.目前为Clone使用.
		private CheckBarCodeView():base(null,"CheckBarCode","UFIDA.U9.Cust.JSDY.BarCode.CheckBarCode", true)
		{
		}
		protected override IUIView CreateCloneInstance()
		{
			return new CheckBarCodeView();
		}
		#endregion

		#region fiels property filter
		public IUIField FieldID
		{
			get { return this.Fields["ID"]; }
		}


		#endregion

		#region Init
		private void InitClass()
		{
			UIModelRuntimeFactory.AddNewUIField(this,"ID", typeof(Int64), false,"","System.Int64", "ID", true,true, false, "",false,(UIFieldType)1,"ba391065-6c27-4c82-acc8-b52b1c93a910","77c3c53c-784a-4a9e-8e1f-9ae674470e55");


		}
		#endregion
		
		#region override method
		protected override IUIRecord BuildNewRecord(IUIRecordBuilder builder)
		{
			return new CheckBarCodeRecord(builder);
		}
		#endregion

		#region new method
		public new CheckBarCodeRecord FocusedRecord
		{
			get { return (CheckBarCodeRecord)base.FocusedRecord ; }
			set { base.FocusedRecord = value ; }
		}
		public new CheckBarCodeRecord AddNewUIRecord()
		{	
			return (CheckBarCodeRecord)base.AddNewUIRecord();
		}
		public new CheckBarCodeRecord NewUIRecord()
		{	
			return (CheckBarCodeRecord)base.NewUIRecord();
		}
		#endregion 

	}

	[Serializable]
	public class CheckBarCodeRecord : UIRecord
	{
		#region Constructor
		public CheckBarCodeRecord(IUIRecordBuilder builder):base(builder)
		{
		}
		private CheckBarCodeView uiviewCheckBarCode
		{
			get { return (CheckBarCodeView)this.ContainerView; }
		}
		protected override IUIRecord CreateCloneInstance(IUIRecordBuilder builder)
		{
			return new CheckBarCodeRecord(builder);
		}
		#endregion

		#region property
		
		
		public  Int64 ID
		{
			get{
				//object value = this[this.uiviewCheckBarCode.FieldID] ;
				//return (Int64)value;
				return GetValue<Int64>(this.uiviewCheckBarCode.FieldID);
			}
			set{
				this[this.uiviewCheckBarCode.FieldID] = value;
			}
		}
		#endregion
	}
	



}