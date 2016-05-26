#region Using directives

using System;
using System.Collections;
using System.Data;
using UFSoft.UBF.UI.MD.Runtime;
using UFSoft.UBF.UI.MD.Runtime.Implement;

#endregion

namespace UFIDA.U9.Cust.JSDY.ProductBarCodeBListUIModel
{
	[Serializable]
	public partial class ProductBarCodeBListUIModelModel : UIModel
	{
		#region Constructor
		public ProductBarCodeBListUIModelModel() : base("ProductBarCodeBListUIModel")
		{
			InitClass();
			this.SetResourceInfo("fe92083f-7196-4a16-83de-16d3224fdd23");
            try{
			    AfterInitModel();
            }catch(Exception exception){
              IUIModel model = this;
		      this.ErrorMessage.SetErrorMessage(ref model,exception);
			}
		}

		//just for Clone 
		private ProductBarCodeBListUIModelModel(bool isInit) : base("ProductBarCodeBListUIModel")
		{}
		protected override IUIModel CreateCloneInstance()
		{
			return new ProductBarCodeBListUIModelModel(false);
		}
		#endregion
		#region member
		#region views
		private ProductBarCodeView viewProductBarCode;			
		#endregion
		
		#region links
		#endregion
		
		#region properties
		#endregion
		#endregion

		#region property
		public ProductBarCodeView ProductBarCode
		{
			get { return (ProductBarCodeView)this["ProductBarCode"]; }
		}
		
		#region RealViews
		#endregion
		
	
		#endregion

		#region function
		private void InitClass()
		{
			this.viewProductBarCode = new ProductBarCodeView(this);
			this.viewProductBarCode.SetResourceInfo("f1c38348-3c2d-4f56-bce1-7a5f4141b35f");
			this.Views.Add(this.viewProductBarCode);			

			
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
	public partial class ProductBarCodeView : UIView
	{
		#region Constructor
		public ProductBarCodeView(IUIModel model) : base(model,"ProductBarCode","UFIDA.U9.Cust.JSDY.BarCode.ProductBarCode", true)
		{
			InitClass();
		}
		//构造空实例,不进行初始化.目前为Clone使用.
		private ProductBarCodeView():base(null,"ProductBarCode","UFIDA.U9.Cust.JSDY.BarCode.ProductBarCode", true)
		{
		}
		protected override IUIView CreateCloneInstance()
		{
			return new ProductBarCodeView();
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
			UIModelRuntimeFactory.AddNewUIField(this,"ID", typeof(Int64), false,"","System.Int64", "ID", true,true, false, "",false,(UIFieldType)1,"ba391065-6c27-4c82-acc8-b52b1c93a910","2480b225-72aa-4bf2-be3a-ce339f41808c");


		}
		#endregion
		
		#region override method
		protected override IUIRecord BuildNewRecord(IUIRecordBuilder builder)
		{
			return new ProductBarCodeRecord(builder);
		}
		#endregion

		#region new method
		public new ProductBarCodeRecord FocusedRecord
		{
			get { return (ProductBarCodeRecord)base.FocusedRecord ; }
			set { base.FocusedRecord = value ; }
		}
		public new ProductBarCodeRecord AddNewUIRecord()
		{	
			return (ProductBarCodeRecord)base.AddNewUIRecord();
		}
		public new ProductBarCodeRecord NewUIRecord()
		{	
			return (ProductBarCodeRecord)base.NewUIRecord();
		}
		#endregion 

	}

	[Serializable]
	public class ProductBarCodeRecord : UIRecord
	{
		#region Constructor
		public ProductBarCodeRecord(IUIRecordBuilder builder):base(builder)
		{
		}
		private ProductBarCodeView uiviewProductBarCode
		{
			get { return (ProductBarCodeView)this.ContainerView; }
		}
		protected override IUIRecord CreateCloneInstance(IUIRecordBuilder builder)
		{
			return new ProductBarCodeRecord(builder);
		}
		#endregion

		#region property
		
		
		public  Int64 ID
		{
			get{
				//object value = this[this.uiviewProductBarCode.FieldID] ;
				//return (Int64)value;
				return GetValue<Int64>(this.uiviewProductBarCode.FieldID);
			}
			set{
				this[this.uiviewProductBarCode.FieldID] = value;
			}
		}
		#endregion
	}
	



}