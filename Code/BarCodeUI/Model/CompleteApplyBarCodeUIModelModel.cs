#region Using directives

using System;
using System.Collections;
using System.Data;
using UFSoft.UBF.UI.MD.Runtime;
using UFSoft.UBF.UI.MD.Runtime.Implement;

#endregion

namespace UFIDA.U9.Cust.JSDY.CompleteApplyBarCodeUIModel
{
	[Serializable]
	public partial class CompleteApplyBarCodeUIModelModel : UIModel
	{
		#region Constructor
		public CompleteApplyBarCodeUIModelModel() : base("CompleteApplyBarCodeUIModel")
		{
			InitClass();
			this.SetResourceInfo("947d8be5-0d6b-43c7-a816-d26b62e5bfc3");
            try{
			    AfterInitModel();
            }catch(Exception exception){
              IUIModel model = this;
		      this.ErrorMessage.SetErrorMessage(ref model,exception);
			}
		}

		//just for Clone 
		private CompleteApplyBarCodeUIModelModel(bool isInit) : base("CompleteApplyBarCodeUIModel")
		{}
		protected override IUIModel CreateCloneInstance()
		{
			return new CompleteApplyBarCodeUIModelModel(false);
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
			this.viewCompleteApplyBarCode.SetResourceInfo("23eba7f5-b32e-44ad-a0fd-aaa99e6284ce");
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
		public IUIField FieldOrg
		{
			get { return this.Fields["Org"]; }
		}
		public IUIField FieldOrg_Code
		{
			get { return this.Fields["Org_Code"]; }
		}
		public IUIField FieldOrg_Name
		{
			get { return this.Fields["Org_Name"]; }
		}
		public IUIField FieldBarCode
		{
			get { return this.Fields["BarCode"]; }
		}
		public IUIField FieldItem
		{
			get { return this.Fields["Item"]; }
		}
		public IUIField FieldItem_Code
		{
			get { return this.Fields["Item_Code"]; }
		}
		public IUIField FieldItem_Name
		{
			get { return this.Fields["Item_Name"]; }
		}
		public IUIField FieldActualLength
		{
			get { return this.Fields["ActualLength"]; }
		}
		public IUIField FieldMarkingLength
		{
			get { return this.Fields["MarkingLength"]; }
		}
		public IUIField FieldBusinessDate
		{
			get { return this.Fields["BusinessDate"]; }
		}
		public IUIField FieldOperators
		{
			get { return this.Fields["Operators"]; }
		}
		public IUIField FieldOperators_Code
		{
			get { return this.Fields["Operators_Code"]; }
		}
		public IUIField FieldOperators_Name
		{
			get { return this.Fields["Operators_Name"]; }
		}
		public IUIField FieldMemo
		{
			get { return this.Fields["Memo"]; }
		}
		public IUIField FieldDescFlexField_PubDescSeg1
		{
			get { return this.Fields["DescFlexField_PubDescSeg1"]; }
		}
		public IUIField FieldDescFlexField_PubDescSeg2
		{
			get { return this.Fields["DescFlexField_PubDescSeg2"]; }
		}
		public IUIField FieldDescFlexField_PubDescSeg3
		{
			get { return this.Fields["DescFlexField_PubDescSeg3"]; }
		}
		public IUIField FieldDescFlexField_PubDescSeg4
		{
			get { return this.Fields["DescFlexField_PubDescSeg4"]; }
		}
		public IUIField FieldDescFlexField_PubDescSeg5
		{
			get { return this.Fields["DescFlexField_PubDescSeg5"]; }
		}
		public IUIField FieldDescFlexField_PubDescSeg6
		{
			get { return this.Fields["DescFlexField_PubDescSeg6"]; }
		}
		public IUIField FieldDescFlexField_PubDescSeg7
		{
			get { return this.Fields["DescFlexField_PubDescSeg7"]; }
		}
		public IUIField FieldDescFlexField_PubDescSeg8
		{
			get { return this.Fields["DescFlexField_PubDescSeg8"]; }
		}
		public IUIField FieldDescFlexField_PubDescSeg9
		{
			get { return this.Fields["DescFlexField_PubDescSeg9"]; }
		}
		public IUIField FieldDescFlexField_PubDescSeg10
		{
			get { return this.Fields["DescFlexField_PubDescSeg10"]; }
		}
		public IUIField FieldDescFlexField_PubDescSeg11
		{
			get { return this.Fields["DescFlexField_PubDescSeg11"]; }
		}
		public IUIField FieldDescFlexField_PubDescSeg12
		{
			get { return this.Fields["DescFlexField_PubDescSeg12"]; }
		}
		public IUIField FieldDescFlexField_PubDescSeg13
		{
			get { return this.Fields["DescFlexField_PubDescSeg13"]; }
		}
		public IUIField FieldDescFlexField_PubDescSeg14
		{
			get { return this.Fields["DescFlexField_PubDescSeg14"]; }
		}
		public IUIField FieldDescFlexField_PubDescSeg15
		{
			get { return this.Fields["DescFlexField_PubDescSeg15"]; }
		}
		public IUIField FieldDescFlexField_PubDescSeg16
		{
			get { return this.Fields["DescFlexField_PubDescSeg16"]; }
		}
		public IUIField FieldDescFlexField_PubDescSeg17
		{
			get { return this.Fields["DescFlexField_PubDescSeg17"]; }
		}
		public IUIField FieldDescFlexField_PubDescSeg18
		{
			get { return this.Fields["DescFlexField_PubDescSeg18"]; }
		}
		public IUIField FieldDescFlexField_PubDescSeg19
		{
			get { return this.Fields["DescFlexField_PubDescSeg19"]; }
		}
		public IUIField FieldDescFlexField_PubDescSeg20
		{
			get { return this.Fields["DescFlexField_PubDescSeg20"]; }
		}
		public IUIField FieldDescFlexField_PubDescSeg21
		{
			get { return this.Fields["DescFlexField_PubDescSeg21"]; }
		}
		public IUIField FieldDescFlexField_PubDescSeg22
		{
			get { return this.Fields["DescFlexField_PubDescSeg22"]; }
		}
		public IUIField FieldDescFlexField_PubDescSeg23
		{
			get { return this.Fields["DescFlexField_PubDescSeg23"]; }
		}
		public IUIField FieldDescFlexField_PubDescSeg24
		{
			get { return this.Fields["DescFlexField_PubDescSeg24"]; }
		}
		public IUIField FieldDescFlexField_PubDescSeg25
		{
			get { return this.Fields["DescFlexField_PubDescSeg25"]; }
		}
		public IUIField FieldDescFlexField_PubDescSeg26
		{
			get { return this.Fields["DescFlexField_PubDescSeg26"]; }
		}
		public IUIField FieldDescFlexField_PubDescSeg27
		{
			get { return this.Fields["DescFlexField_PubDescSeg27"]; }
		}
		public IUIField FieldDescFlexField_PubDescSeg28
		{
			get { return this.Fields["DescFlexField_PubDescSeg28"]; }
		}
		public IUIField FieldDescFlexField_PubDescSeg29
		{
			get { return this.Fields["DescFlexField_PubDescSeg29"]; }
		}
		public IUIField FieldDescFlexField_PubDescSeg30
		{
			get { return this.Fields["DescFlexField_PubDescSeg30"]; }
		}
		public IUIField FieldDescFlexField_PubDescSeg31
		{
			get { return this.Fields["DescFlexField_PubDescSeg31"]; }
		}
		public IUIField FieldDescFlexField_PubDescSeg32
		{
			get { return this.Fields["DescFlexField_PubDescSeg32"]; }
		}
		public IUIField FieldDescFlexField_PubDescSeg33
		{
			get { return this.Fields["DescFlexField_PubDescSeg33"]; }
		}
		public IUIField FieldDescFlexField_PubDescSeg34
		{
			get { return this.Fields["DescFlexField_PubDescSeg34"]; }
		}
		public IUIField FieldDescFlexField_PubDescSeg35
		{
			get { return this.Fields["DescFlexField_PubDescSeg35"]; }
		}
		public IUIField FieldDescFlexField_PubDescSeg36
		{
			get { return this.Fields["DescFlexField_PubDescSeg36"]; }
		}
		public IUIField FieldDescFlexField_PubDescSeg37
		{
			get { return this.Fields["DescFlexField_PubDescSeg37"]; }
		}
		public IUIField FieldDescFlexField_PubDescSeg38
		{
			get { return this.Fields["DescFlexField_PubDescSeg38"]; }
		}
		public IUIField FieldDescFlexField_PubDescSeg39
		{
			get { return this.Fields["DescFlexField_PubDescSeg39"]; }
		}
		public IUIField FieldDescFlexField_PubDescSeg40
		{
			get { return this.Fields["DescFlexField_PubDescSeg40"]; }
		}
		public IUIField FieldDescFlexField_PubDescSeg41
		{
			get { return this.Fields["DescFlexField_PubDescSeg41"]; }
		}
		public IUIField FieldDescFlexField_PubDescSeg42
		{
			get { return this.Fields["DescFlexField_PubDescSeg42"]; }
		}
		public IUIField FieldDescFlexField_PubDescSeg43
		{
			get { return this.Fields["DescFlexField_PubDescSeg43"]; }
		}
		public IUIField FieldDescFlexField_PubDescSeg44
		{
			get { return this.Fields["DescFlexField_PubDescSeg44"]; }
		}
		public IUIField FieldDescFlexField_PubDescSeg45
		{
			get { return this.Fields["DescFlexField_PubDescSeg45"]; }
		}
		public IUIField FieldDescFlexField_PubDescSeg46
		{
			get { return this.Fields["DescFlexField_PubDescSeg46"]; }
		}
		public IUIField FieldDescFlexField_PubDescSeg47
		{
			get { return this.Fields["DescFlexField_PubDescSeg47"]; }
		}
		public IUIField FieldDescFlexField_PubDescSeg48
		{
			get { return this.Fields["DescFlexField_PubDescSeg48"]; }
		}
		public IUIField FieldDescFlexField_PubDescSeg49
		{
			get { return this.Fields["DescFlexField_PubDescSeg49"]; }
		}
		public IUIField FieldDescFlexField_PubDescSeg50
		{
			get { return this.Fields["DescFlexField_PubDescSeg50"]; }
		}
		public IUIField FieldDescFlexField_ContextValue
		{
			get { return this.Fields["DescFlexField_ContextValue"]; }
		}
		public IUIField FieldDescFlexField_PrivateDescSeg1
		{
			get { return this.Fields["DescFlexField_PrivateDescSeg1"]; }
		}
		public IUIField FieldDescFlexField_PrivateDescSeg2
		{
			get { return this.Fields["DescFlexField_PrivateDescSeg2"]; }
		}
		public IUIField FieldDescFlexField_PrivateDescSeg3
		{
			get { return this.Fields["DescFlexField_PrivateDescSeg3"]; }
		}
		public IUIField FieldDescFlexField_PrivateDescSeg4
		{
			get { return this.Fields["DescFlexField_PrivateDescSeg4"]; }
		}
		public IUIField FieldDescFlexField_PrivateDescSeg5
		{
			get { return this.Fields["DescFlexField_PrivateDescSeg5"]; }
		}
		public IUIField FieldDescFlexField_PrivateDescSeg6
		{
			get { return this.Fields["DescFlexField_PrivateDescSeg6"]; }
		}
		public IUIField FieldDescFlexField_PrivateDescSeg7
		{
			get { return this.Fields["DescFlexField_PrivateDescSeg7"]; }
		}
		public IUIField FieldDescFlexField_PrivateDescSeg8
		{
			get { return this.Fields["DescFlexField_PrivateDescSeg8"]; }
		}
		public IUIField FieldDescFlexField_PrivateDescSeg9
		{
			get { return this.Fields["DescFlexField_PrivateDescSeg9"]; }
		}
		public IUIField FieldDescFlexField_PrivateDescSeg10
		{
			get { return this.Fields["DescFlexField_PrivateDescSeg10"]; }
		}
		public IUIField FieldDescFlexField_PrivateDescSeg11
		{
			get { return this.Fields["DescFlexField_PrivateDescSeg11"]; }
		}
		public IUIField FieldDescFlexField_PrivateDescSeg12
		{
			get { return this.Fields["DescFlexField_PrivateDescSeg12"]; }
		}
		public IUIField FieldDescFlexField_PrivateDescSeg13
		{
			get { return this.Fields["DescFlexField_PrivateDescSeg13"]; }
		}
		public IUIField FieldDescFlexField_PrivateDescSeg14
		{
			get { return this.Fields["DescFlexField_PrivateDescSeg14"]; }
		}
		public IUIField FieldDescFlexField_PrivateDescSeg15
		{
			get { return this.Fields["DescFlexField_PrivateDescSeg15"]; }
		}
		public IUIField FieldDescFlexField_PrivateDescSeg16
		{
			get { return this.Fields["DescFlexField_PrivateDescSeg16"]; }
		}
		public IUIField FieldDescFlexField_PrivateDescSeg17
		{
			get { return this.Fields["DescFlexField_PrivateDescSeg17"]; }
		}
		public IUIField FieldDescFlexField_PrivateDescSeg18
		{
			get { return this.Fields["DescFlexField_PrivateDescSeg18"]; }
		}
		public IUIField FieldDescFlexField_PrivateDescSeg19
		{
			get { return this.Fields["DescFlexField_PrivateDescSeg19"]; }
		}
		public IUIField FieldDescFlexField_PrivateDescSeg20
		{
			get { return this.Fields["DescFlexField_PrivateDescSeg20"]; }
		}
		public IUIField FieldDescFlexField_PrivateDescSeg21
		{
			get { return this.Fields["DescFlexField_PrivateDescSeg21"]; }
		}
		public IUIField FieldDescFlexField_PrivateDescSeg22
		{
			get { return this.Fields["DescFlexField_PrivateDescSeg22"]; }
		}
		public IUIField FieldDescFlexField_PrivateDescSeg23
		{
			get { return this.Fields["DescFlexField_PrivateDescSeg23"]; }
		}
		public IUIField FieldDescFlexField_PrivateDescSeg24
		{
			get { return this.Fields["DescFlexField_PrivateDescSeg24"]; }
		}
		public IUIField FieldDescFlexField_PrivateDescSeg25
		{
			get { return this.Fields["DescFlexField_PrivateDescSeg25"]; }
		}
		public IUIField FieldDescFlexField_PrivateDescSeg26
		{
			get { return this.Fields["DescFlexField_PrivateDescSeg26"]; }
		}
		public IUIField FieldDescFlexField_PrivateDescSeg27
		{
			get { return this.Fields["DescFlexField_PrivateDescSeg27"]; }
		}
		public IUIField FieldDescFlexField_PrivateDescSeg28
		{
			get { return this.Fields["DescFlexField_PrivateDescSeg28"]; }
		}
		public IUIField FieldDescFlexField_PrivateDescSeg29
		{
			get { return this.Fields["DescFlexField_PrivateDescSeg29"]; }
		}
		public IUIField FieldDescFlexField_PrivateDescSeg30
		{
			get { return this.Fields["DescFlexField_PrivateDescSeg30"]; }
		}
		public IUIField FieldDescFlexField_CombineName
		{
			get { return this.Fields["DescFlexField_CombineName"]; }
		}
		public IUIField FieldIsPrinted
		{
			get { return this.Fields["IsPrinted"]; }
		}
		public IUIField FieldPrintedOn
		{
			get { return this.Fields["PrintedOn"]; }
		}
		public IUIField FieldPrintedBy
		{
			get { return this.Fields["PrintedBy"]; }
		}
		public IUIField FieldItem_SPECS
		{
			get { return this.Fields["Item_SPECS"]; }
		}
		public IUIField FieldItem_DescFlexField_PrivateDescSeg1
		{
			get { return this.Fields["Item_DescFlexField_PrivateDescSeg1"]; }
		}
		public IUIField FieldQty
		{
			get { return this.Fields["Qty"]; }
		}
		public IUIField FieldIsPrintWrapper
		{
			get { return this.Fields["IsPrintWrapper"]; }
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
			UIModelRuntimeFactory.AddNewUIField(this,"ID", typeof(Int64), false,"","System.Int64", "ID", true,true, false, "",false,(UIFieldType)1,"ba391065-6c27-4c82-acc8-b52b1c93a910","a40e4527-5e00-41fd-abf6-53b57a5d5a2e");
			UIModelRuntimeFactory.AddNewUIField(this,"CreatedOn", typeof(DateTime), true,"","System.DateTime", "CreatedOn", true,true, false, "",false,(UIFieldType)1,"3834a958-120f-4ac9-8d60-1a7be6d3f12f","2db2e90f-0319-43d9-b69b-e23c8e29df77");
			UIModelRuntimeFactory.AddNewUIField(this,"CreatedBy", typeof(String), true,"","System.String", "CreatedBy", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","d57f8bcb-f91b-4c8f-b1ac-d36ab58cf032");
			UIModelRuntimeFactory.AddNewUIField(this,"ModifiedOn", typeof(DateTime), true,"","System.DateTime", "ModifiedOn", true,true, false, "",false,(UIFieldType)1,"3834a958-120f-4ac9-8d60-1a7be6d3f12f","9ec95033-fbe9-43b9-9342-2d514c84bc3c");
			UIModelRuntimeFactory.AddNewUIField(this,"ModifiedBy", typeof(String), true,"","System.String", "ModifiedBy", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","32ab5ebb-c896-4e61-a9db-f2cd5b59cedf");
			UIModelRuntimeFactory.AddNewUIField(this,"SysVersion", typeof(Int64), true,"0","System.Int64", "SysVersion", true,true, false, "",false,(UIFieldType)1,"ba391065-6c27-4c82-acc8-b52b1c93a910","a010b438-e547-420a-be2c-14aa47f6d971");
			UIModelRuntimeFactory.AddNewUIField(this,"Org", typeof(Int64), false,"","UFIDA.U9.Base.Organization.Organization", "Org", true,true, false, "",false,(UIFieldType)4,"73eb56da-f25a-4636-94e7-61b0cb4b7784","11a20751-3aed-4576-b614-bd3b681469f9");
			UIModelRuntimeFactory.AddNewUIField(this,"Org_Code", typeof(String), false,"","System.String", "Org.Code", false,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","e56a66eb-1135-4483-b23e-32f01dd1acbe");
			UIModelRuntimeFactory.AddNewUIField(this,"Org_Name", typeof(String), true,"","System.String", "Org.Name", false,true, false, "",true,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","da43b460-cadb-4221-8c4f-5faf3152376b");
			UIModelRuntimeFactory.AddNewUIField(this,"BarCode", typeof(String), false,"","System.String", "BarCode", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","89a99397-5a9f-4c62-89d9-d3c1e369878e");
			UIModelRuntimeFactory.AddNewUIField(this,"Item", typeof(Int64), false,"","UFIDA.U9.CBO.SCM.Item.ItemMaster", "Item", true,true, false, "",false,(UIFieldType)4,"636d3e47-48aa-47fc-aca4-e6322bce775b","efc89e4f-e2de-4319-a1cd-cdef95f3bbd9");
			UIModelRuntimeFactory.AddNewUIField(this,"Item_Code", typeof(String), false,"","System.String", "Item.Code", false,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","9edb0dc5-e3af-426b-a855-50b4cba6fbf2");
			UIModelRuntimeFactory.AddNewUIField(this,"Item_Name", typeof(String), false,"","System.String", "Item.Name", false,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","6aa2daba-3c6d-4767-b633-99fa1e5b99a2");
			UIModelRuntimeFactory.AddNewUIField(this,"ActualLength", typeof(Int32), false,"0","System.Int32", "ActualLength", true,true, false, "",false,(UIFieldType)1,"d7c6031e-d3fe-41aa-a397-5edd86c10cae","f13ef3bc-cfe1-4449-ab5a-44e451cbc921");
			UIModelRuntimeFactory.AddNewUIField(this,"MarkingLength", typeof(Int32), true,"0","System.Int32", "MarkingLength", true,true, false, "",false,(UIFieldType)1,"d7c6031e-d3fe-41aa-a397-5edd86c10cae","53dd95fd-6336-4100-beae-f66a86998beb");
			UIModelRuntimeFactory.AddNewUIField(this,"BusinessDate", typeof(DateTime), false,"","System.Date", "BusinessDate", true,true, false, "",false,(UIFieldType)1,"c9e6bc50-2e39-4f27-9519-da0c7859d37e","8c27c721-3992-4766-b325-82cd965083cc");
			UIModelRuntimeFactory.AddNewUIField(this,"Operators", typeof(Int64), false,"","UFIDA.U9.CBO.HR.Operator.Operators", "Operators", true,true, false, "",false,(UIFieldType)4,"198b0f81-207e-4707-8a8c-e0475b7674bd","98072be1-8c91-470a-919d-6884d6384f38");
			UIModelRuntimeFactory.AddNewUIField(this,"Operators_Code", typeof(String), false,"","System.String", "Operators.Code", false,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","25d8f2a3-5616-476a-9e5b-265a8b1c74b2");
			UIModelRuntimeFactory.AddNewUIField(this,"Operators_Name", typeof(String), true,"","System.String", "Operators.Name", false,true, false, "",true,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","8eefd7f2-c1de-4d9e-a512-358906d71cf3");
			UIModelRuntimeFactory.AddNewUIField(this,"Memo", typeof(String), true,"","System.String", "Memo", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","456accbe-5afe-42fb-9e71-51b0f5db4a02");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg1", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg1", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","9628826a-2bb7-48c1-abfb-a5b584c7f5d2");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg2", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg2", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","7ab3670f-d839-471b-a148-e8a396951e9a");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg3", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg3", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","2c3fb644-40f4-4374-b8f9-4d78b869b9e9");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg4", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg4", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","6eb43c59-b975-47e1-8ce6-17be1ac099b6");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg5", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg5", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","ae9bfb04-29e2-4c9b-9604-33ca20af361d");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg6", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg6", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","3fe3d527-7baa-4c04-a433-059cc11dbc9f");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg7", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg7", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","23e379fa-4175-4d2d-9ea2-7cc1d3a53fc4");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg8", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg8", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","ba899cb9-dc0e-4586-9a4e-5d037a283e68");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg9", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg9", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","293b45d7-c882-44e1-9369-7e1e44a90f7f");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg10", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg10", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","de02a749-6481-40ae-9497-2bd5f2cba77e");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg11", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg11", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","38161089-3d30-4c36-8458-a22e9dd3a6f8");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg12", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg12", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","78272690-e082-422b-b45f-c6e26e2cb0fa");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg13", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg13", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","3cc8aa30-130b-47f1-9621-5c51f6427e5f");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg14", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg14", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","65fe937f-12c5-4d80-9bd2-ec1420941c1c");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg15", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg15", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","658db8bb-0f4a-474d-8b70-986ec204eb64");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg16", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg16", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","7f60aad0-3144-42b0-bf44-8c1653dc5426");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg17", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg17", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","5435a640-fc4b-41ee-9e06-2280395f1194");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg18", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg18", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","4c00e7c7-812f-4f70-a20c-634db6902ea9");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg19", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg19", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","eda74ba8-32c9-4be9-9567-b41c72c471bd");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg20", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg20", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","c38f95ce-c8b3-4879-9f31-14d2a7315250");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg21", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg21", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","e7b84904-e05a-4915-906b-afe27cefcea0");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg22", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg22", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","e63264ec-12b6-4389-ad9e-ef6d1b35b409");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg23", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg23", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","a48371d3-51bd-4608-9125-d8e45becf672");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg24", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg24", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","cb6ccd9e-0d18-4e1b-9cea-5786959e2d84");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg25", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg25", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","7af67ead-f835-4c0c-b3d6-5cc1bb576807");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg26", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg26", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","e49d3c7f-6a73-45d2-975c-9a2a34d4f44d");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg27", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg27", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","e32f9267-c06e-4fed-adcf-b314adabf403");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg28", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg28", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","74fa64a5-8dbc-4718-8a4b-a50748481c6d");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg29", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg29", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","4c48923a-97d3-45d4-a6fe-bbf7ea3ed5ea");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg30", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg30", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","382e9334-8aaa-4a02-a9cf-64fc397d6506");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg31", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg31", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","a184e5af-2f81-4d7b-82fb-7623fa311204");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg32", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg32", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","f41e8d40-3dea-4394-a9e6-6c57b97c8497");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg33", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg33", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","1f4aef1e-5f1b-481a-8f02-3f8cb9c801e9");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg34", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg34", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","008abe9e-9f15-405b-82a6-c51d3075bfb8");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg35", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg35", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","294aaa36-190e-45a9-8507-bb69e18398ce");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg36", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg36", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","7800751f-345c-4c14-b2df-29e05d0cfc81");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg37", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg37", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","ab4ab0c5-2eab-4f34-936b-88b486b8711a");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg38", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg38", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","c99b8b75-580c-45f1-9a90-a8d1873e2853");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg39", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg39", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","f74c198e-6b30-47f4-9123-be9f54bd92d9");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg40", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg40", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","24c8bd78-644a-45cd-9d7d-3b0a7e11837c");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg41", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg41", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","76bc75e7-fd0d-4967-8488-ea7818c96303");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg42", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg42", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","a802ca9b-f957-4359-a2e0-d32e52e05d5d");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg43", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg43", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","29f4d0f2-a45f-4187-8156-22f7de0eca21");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg44", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg44", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","0927a481-fc05-4eb8-8cd1-a151fa3823f4");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg45", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg45", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","c158651e-008c-4a8f-b924-c290d3abc243");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg46", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg46", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","4956a039-0d27-469f-9f76-1536262bab90");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg47", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg47", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","4e7d3786-d995-4ebe-a135-e906bd1c2829");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg48", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg48", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","72a828a7-41e3-48e1-8030-6095e9cbc686");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg49", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg49", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","7d86ace9-cc0a-4881-ad3c-4ada748c8973");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg50", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg50", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","aa6d13c2-379f-4f48-bc54-c40b14858d8b");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_ContextValue", typeof(String), true,"","System.String", "DescFlexField.ContextValue", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","86f503a3-00a2-49b6-8c65-cb7c7e9d59be");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg1", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg1", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","27b5f82b-ce5c-4263-922c-03ebc3f232f5");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg2", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg2", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","eee45c5b-b6e4-463b-b0f4-c89144d1b931");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg3", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg3", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","6e4b1475-ffc4-4a89-8959-af2526579771");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg4", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg4", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","136534d3-aa75-4601-a926-694e64f1dd7d");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg5", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg5", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","ba5f880c-de84-45ac-aac8-c9d02ad6994d");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg6", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg6", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","2704122f-ce31-40c4-804d-5054d17cb464");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg7", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg7", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","4c449981-a92d-4d35-b81b-35bd055f0d08");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg8", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg8", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","b9a9da1e-533a-4bb3-94e0-1ab4482ab205");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg9", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg9", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","0e81bf13-2c67-467f-8c5f-e6b32dca00ea");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg10", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg10", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","9ff86d6b-95e8-473f-b088-2e80cbd970c3");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg11", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg11", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","3cdc3be8-1453-4564-85db-da60eb0dad6b");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg12", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg12", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","a9d07cf1-848a-44ae-984a-9c614b93591b");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg13", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg13", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","300d0591-9629-46c4-bd74-c0a37cea50bc");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg14", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg14", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","80ad8d48-6036-4322-be38-b748bbe765b9");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg15", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg15", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","03ad0bfe-3f67-40cd-9510-d3ce4dcf8ff3");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg16", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg16", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","67655cb3-f706-4b10-9b18-d0e23a298ae5");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg17", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg17", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","06696a22-2543-431a-b6eb-3508bddf8ec6");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg18", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg18", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","8518b0f0-0ca0-49e3-81ae-0b11774f02a4");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg19", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg19", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","1d29f33d-c60d-4be7-9b56-c02a5c355e23");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg20", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg20", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","e3febe96-df26-48e4-a96e-9db66337f262");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg21", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg21", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","83e10904-14f0-46c9-9237-8da3d9508807");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg22", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg22", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","81fdd13c-0e0c-4d60-af04-cab1df670f45");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg23", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg23", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","78f9fbfe-10d3-4192-a239-a1d33555fbc1");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg24", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg24", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","ccab5e75-2eb9-4984-913f-26d99bf1f03d");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg25", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg25", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","126933cc-7992-4a59-b3ea-639edee4f00d");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg26", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg26", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","a2119775-4d2e-4ab2-9ddb-82a08480b9d5");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg27", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg27", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","77da402f-887d-4327-95ea-c09a87b2a1ee");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg28", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg28", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","4b932827-50d4-4ad5-ba0b-afc63347561c");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg29", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg29", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","54a00567-7814-4e47-a89e-0e8358b7e958");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg30", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg30", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","a8119e62-9984-4c7a-89e4-babad0ab3f50");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_CombineName", typeof(String), true,"","System.String", "DescFlexField.CombineName", true,true, false, "",true,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","bc7995b3-36d7-42b5-946a-a058475904ad");
			UIModelRuntimeFactory.AddNewUIField(this,"IsPrinted", typeof(Boolean), true,"false","System.Boolean", "IsPrinted", true,true, false, "",false,(UIFieldType)1,"5efeea06-cae7-4cc0-82e9-20a789e4e582","5a30441e-7dd3-4e39-aedf-e349ccf635fa");
			UIModelRuntimeFactory.AddNewUIField(this,"PrintedOn", typeof(DateTime), true,"","System.DateTime", "PrintedOn", true,true, false, "",false,(UIFieldType)1,"3834a958-120f-4ac9-8d60-1a7be6d3f12f","58f55d13-44a5-4ad4-aab2-80625e0c1386");
			UIModelRuntimeFactory.AddNewUIField(this,"PrintedBy", typeof(String), true,"","System.String", "PrintedBy", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","595c10ad-124d-4b5a-ab5a-a046a7331d19");
			UIModelRuntimeFactory.AddNewUIField(this,"Item_SPECS", typeof(String), true,"","System.String", "Item.SPECS", false,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","6fcbb7a9-0fa2-4f81-9f66-746feeb00979");
			UIModelRuntimeFactory.AddNewUIField(this,"Item_DescFlexField_PrivateDescSeg1", typeof(String), true,"","System.String", "Item.DescFlexField.PrivateDescSeg1", false,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","e6f05870-463e-45a6-b544-e88e4c64ebfb");
			UIModelRuntimeFactory.AddNewUIField(this,"Qty", typeof(Int32), true,"","System.String", "", false,false, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","c7fa73e0-c717-4b0c-8286-cecaa8f87b20");
			UIModelRuntimeFactory.AddNewUIField(this,"IsPrintWrapper", typeof(Boolean), true,"false","System.Boolean", "IsPrintWrapper", true,true, false, "",false,(UIFieldType)1,"5efeea06-cae7-4cc0-82e9-20a789e4e582","96142854-33ed-4a9b-95df-3f54181f180d");


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
		
		
		public  DateTime? CreatedOn
		{
			get{
				//object value = this[this.uiviewCompleteApplyBarCode.FieldCreatedOn] ;
				//return (DateTime?)value;
				return GetValue<DateTime?>(this.uiviewCompleteApplyBarCode.FieldCreatedOn);
			}
			set{
				this[this.uiviewCompleteApplyBarCode.FieldCreatedOn] = value;
			}
		}
		
		
		public  String CreatedBy
		{
			get{
				//object value = this[this.uiviewCompleteApplyBarCode.FieldCreatedBy] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCompleteApplyBarCode.FieldCreatedBy);
			}
			set{
				this[this.uiviewCompleteApplyBarCode.FieldCreatedBy] = value;
			}
		}
		
		
		public  DateTime? ModifiedOn
		{
			get{
				//object value = this[this.uiviewCompleteApplyBarCode.FieldModifiedOn] ;
				//return (DateTime?)value;
				return GetValue<DateTime?>(this.uiviewCompleteApplyBarCode.FieldModifiedOn);
			}
			set{
				this[this.uiviewCompleteApplyBarCode.FieldModifiedOn] = value;
			}
		}
		
		
		public  String ModifiedBy
		{
			get{
				//object value = this[this.uiviewCompleteApplyBarCode.FieldModifiedBy] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCompleteApplyBarCode.FieldModifiedBy);
			}
			set{
				this[this.uiviewCompleteApplyBarCode.FieldModifiedBy] = value;
			}
		}
		
		
		public new Int64? SysVersion
		{
			get{
				//object value = this[this.uiviewCompleteApplyBarCode.FieldSysVersion] ;
				//return (Int64?)value;
				return GetValue<Int64?>(this.uiviewCompleteApplyBarCode.FieldSysVersion);
			}
			set{
				this[this.uiviewCompleteApplyBarCode.FieldSysVersion] = value;
			}
		}
		
		
		public  Int64 Org
		{
			get{
				//object value = this[this.uiviewCompleteApplyBarCode.FieldOrg] ;
				//return (Int64)value;
				return GetValue<Int64>(this.uiviewCompleteApplyBarCode.FieldOrg);
			}
			set{
				this[this.uiviewCompleteApplyBarCode.FieldOrg] = value;
			}
		}
		
		
		public  String Org_Code
		{
			get{
				//object value = this[this.uiviewCompleteApplyBarCode.FieldOrg_Code] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCompleteApplyBarCode.FieldOrg_Code);
			}
			set{
				this[this.uiviewCompleteApplyBarCode.FieldOrg_Code] = value;
			}
		}
		
		
		public  String Org_Name
		{
			get{
				//object value = this[this.uiviewCompleteApplyBarCode.FieldOrg_Name] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCompleteApplyBarCode.FieldOrg_Name);
			}
			set{
				this[this.uiviewCompleteApplyBarCode.FieldOrg_Name] = value;
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
		
		
		public  Int64 Item
		{
			get{
				//object value = this[this.uiviewCompleteApplyBarCode.FieldItem] ;
				//return (Int64)value;
				return GetValue<Int64>(this.uiviewCompleteApplyBarCode.FieldItem);
			}
			set{
				this[this.uiviewCompleteApplyBarCode.FieldItem] = value;
			}
		}
		
		
		public  String Item_Code
		{
			get{
				//object value = this[this.uiviewCompleteApplyBarCode.FieldItem_Code] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCompleteApplyBarCode.FieldItem_Code);
			}
			set{
				this[this.uiviewCompleteApplyBarCode.FieldItem_Code] = value;
			}
		}
		
		
		public  String Item_Name
		{
			get{
				//object value = this[this.uiviewCompleteApplyBarCode.FieldItem_Name] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCompleteApplyBarCode.FieldItem_Name);
			}
			set{
				this[this.uiviewCompleteApplyBarCode.FieldItem_Name] = value;
			}
		}
		
		
		public  Int32 ActualLength
		{
			get{
				//object value = this[this.uiviewCompleteApplyBarCode.FieldActualLength] ;
				//return (Int32)value;
				return GetValue<Int32>(this.uiviewCompleteApplyBarCode.FieldActualLength);
			}
			set{
				this[this.uiviewCompleteApplyBarCode.FieldActualLength] = value;
			}
		}
		
		
		public  Int32? MarkingLength
		{
			get{
				//object value = this[this.uiviewCompleteApplyBarCode.FieldMarkingLength] ;
				//return (Int32?)value;
				return GetValue<Int32?>(this.uiviewCompleteApplyBarCode.FieldMarkingLength);
			}
			set{
				this[this.uiviewCompleteApplyBarCode.FieldMarkingLength] = value;
			}
		}
		
		
		public  DateTime BusinessDate
		{
			get{
				//object value = this[this.uiviewCompleteApplyBarCode.FieldBusinessDate] ;
				//return (DateTime)value;
				return GetValue<DateTime>(this.uiviewCompleteApplyBarCode.FieldBusinessDate);
			}
			set{
				this[this.uiviewCompleteApplyBarCode.FieldBusinessDate] = value;
			}
		}
		
		
		public  Int64 Operators
		{
			get{
				//object value = this[this.uiviewCompleteApplyBarCode.FieldOperators] ;
				//return (Int64)value;
				return GetValue<Int64>(this.uiviewCompleteApplyBarCode.FieldOperators);
			}
			set{
				this[this.uiviewCompleteApplyBarCode.FieldOperators] = value;
			}
		}
		
		
		public  String Operators_Code
		{
			get{
				//object value = this[this.uiviewCompleteApplyBarCode.FieldOperators_Code] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCompleteApplyBarCode.FieldOperators_Code);
			}
			set{
				this[this.uiviewCompleteApplyBarCode.FieldOperators_Code] = value;
			}
		}
		
		
		public  String Operators_Name
		{
			get{
				//object value = this[this.uiviewCompleteApplyBarCode.FieldOperators_Name] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCompleteApplyBarCode.FieldOperators_Name);
			}
			set{
				this[this.uiviewCompleteApplyBarCode.FieldOperators_Name] = value;
			}
		}
		
		
		public  String Memo
		{
			get{
				//object value = this[this.uiviewCompleteApplyBarCode.FieldMemo] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCompleteApplyBarCode.FieldMemo);
			}
			set{
				this[this.uiviewCompleteApplyBarCode.FieldMemo] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg1
		{
			get{
				//object value = this[this.uiviewCompleteApplyBarCode.FieldDescFlexField_PubDescSeg1] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCompleteApplyBarCode.FieldDescFlexField_PubDescSeg1);
			}
			set{
				this[this.uiviewCompleteApplyBarCode.FieldDescFlexField_PubDescSeg1] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg2
		{
			get{
				//object value = this[this.uiviewCompleteApplyBarCode.FieldDescFlexField_PubDescSeg2] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCompleteApplyBarCode.FieldDescFlexField_PubDescSeg2);
			}
			set{
				this[this.uiviewCompleteApplyBarCode.FieldDescFlexField_PubDescSeg2] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg3
		{
			get{
				//object value = this[this.uiviewCompleteApplyBarCode.FieldDescFlexField_PubDescSeg3] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCompleteApplyBarCode.FieldDescFlexField_PubDescSeg3);
			}
			set{
				this[this.uiviewCompleteApplyBarCode.FieldDescFlexField_PubDescSeg3] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg4
		{
			get{
				//object value = this[this.uiviewCompleteApplyBarCode.FieldDescFlexField_PubDescSeg4] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCompleteApplyBarCode.FieldDescFlexField_PubDescSeg4);
			}
			set{
				this[this.uiviewCompleteApplyBarCode.FieldDescFlexField_PubDescSeg4] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg5
		{
			get{
				//object value = this[this.uiviewCompleteApplyBarCode.FieldDescFlexField_PubDescSeg5] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCompleteApplyBarCode.FieldDescFlexField_PubDescSeg5);
			}
			set{
				this[this.uiviewCompleteApplyBarCode.FieldDescFlexField_PubDescSeg5] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg6
		{
			get{
				//object value = this[this.uiviewCompleteApplyBarCode.FieldDescFlexField_PubDescSeg6] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCompleteApplyBarCode.FieldDescFlexField_PubDescSeg6);
			}
			set{
				this[this.uiviewCompleteApplyBarCode.FieldDescFlexField_PubDescSeg6] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg7
		{
			get{
				//object value = this[this.uiviewCompleteApplyBarCode.FieldDescFlexField_PubDescSeg7] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCompleteApplyBarCode.FieldDescFlexField_PubDescSeg7);
			}
			set{
				this[this.uiviewCompleteApplyBarCode.FieldDescFlexField_PubDescSeg7] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg8
		{
			get{
				//object value = this[this.uiviewCompleteApplyBarCode.FieldDescFlexField_PubDescSeg8] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCompleteApplyBarCode.FieldDescFlexField_PubDescSeg8);
			}
			set{
				this[this.uiviewCompleteApplyBarCode.FieldDescFlexField_PubDescSeg8] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg9
		{
			get{
				//object value = this[this.uiviewCompleteApplyBarCode.FieldDescFlexField_PubDescSeg9] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCompleteApplyBarCode.FieldDescFlexField_PubDescSeg9);
			}
			set{
				this[this.uiviewCompleteApplyBarCode.FieldDescFlexField_PubDescSeg9] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg10
		{
			get{
				//object value = this[this.uiviewCompleteApplyBarCode.FieldDescFlexField_PubDescSeg10] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCompleteApplyBarCode.FieldDescFlexField_PubDescSeg10);
			}
			set{
				this[this.uiviewCompleteApplyBarCode.FieldDescFlexField_PubDescSeg10] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg11
		{
			get{
				//object value = this[this.uiviewCompleteApplyBarCode.FieldDescFlexField_PubDescSeg11] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCompleteApplyBarCode.FieldDescFlexField_PubDescSeg11);
			}
			set{
				this[this.uiviewCompleteApplyBarCode.FieldDescFlexField_PubDescSeg11] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg12
		{
			get{
				//object value = this[this.uiviewCompleteApplyBarCode.FieldDescFlexField_PubDescSeg12] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCompleteApplyBarCode.FieldDescFlexField_PubDescSeg12);
			}
			set{
				this[this.uiviewCompleteApplyBarCode.FieldDescFlexField_PubDescSeg12] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg13
		{
			get{
				//object value = this[this.uiviewCompleteApplyBarCode.FieldDescFlexField_PubDescSeg13] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCompleteApplyBarCode.FieldDescFlexField_PubDescSeg13);
			}
			set{
				this[this.uiviewCompleteApplyBarCode.FieldDescFlexField_PubDescSeg13] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg14
		{
			get{
				//object value = this[this.uiviewCompleteApplyBarCode.FieldDescFlexField_PubDescSeg14] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCompleteApplyBarCode.FieldDescFlexField_PubDescSeg14);
			}
			set{
				this[this.uiviewCompleteApplyBarCode.FieldDescFlexField_PubDescSeg14] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg15
		{
			get{
				//object value = this[this.uiviewCompleteApplyBarCode.FieldDescFlexField_PubDescSeg15] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCompleteApplyBarCode.FieldDescFlexField_PubDescSeg15);
			}
			set{
				this[this.uiviewCompleteApplyBarCode.FieldDescFlexField_PubDescSeg15] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg16
		{
			get{
				//object value = this[this.uiviewCompleteApplyBarCode.FieldDescFlexField_PubDescSeg16] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCompleteApplyBarCode.FieldDescFlexField_PubDescSeg16);
			}
			set{
				this[this.uiviewCompleteApplyBarCode.FieldDescFlexField_PubDescSeg16] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg17
		{
			get{
				//object value = this[this.uiviewCompleteApplyBarCode.FieldDescFlexField_PubDescSeg17] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCompleteApplyBarCode.FieldDescFlexField_PubDescSeg17);
			}
			set{
				this[this.uiviewCompleteApplyBarCode.FieldDescFlexField_PubDescSeg17] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg18
		{
			get{
				//object value = this[this.uiviewCompleteApplyBarCode.FieldDescFlexField_PubDescSeg18] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCompleteApplyBarCode.FieldDescFlexField_PubDescSeg18);
			}
			set{
				this[this.uiviewCompleteApplyBarCode.FieldDescFlexField_PubDescSeg18] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg19
		{
			get{
				//object value = this[this.uiviewCompleteApplyBarCode.FieldDescFlexField_PubDescSeg19] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCompleteApplyBarCode.FieldDescFlexField_PubDescSeg19);
			}
			set{
				this[this.uiviewCompleteApplyBarCode.FieldDescFlexField_PubDescSeg19] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg20
		{
			get{
				//object value = this[this.uiviewCompleteApplyBarCode.FieldDescFlexField_PubDescSeg20] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCompleteApplyBarCode.FieldDescFlexField_PubDescSeg20);
			}
			set{
				this[this.uiviewCompleteApplyBarCode.FieldDescFlexField_PubDescSeg20] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg21
		{
			get{
				//object value = this[this.uiviewCompleteApplyBarCode.FieldDescFlexField_PubDescSeg21] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCompleteApplyBarCode.FieldDescFlexField_PubDescSeg21);
			}
			set{
				this[this.uiviewCompleteApplyBarCode.FieldDescFlexField_PubDescSeg21] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg22
		{
			get{
				//object value = this[this.uiviewCompleteApplyBarCode.FieldDescFlexField_PubDescSeg22] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCompleteApplyBarCode.FieldDescFlexField_PubDescSeg22);
			}
			set{
				this[this.uiviewCompleteApplyBarCode.FieldDescFlexField_PubDescSeg22] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg23
		{
			get{
				//object value = this[this.uiviewCompleteApplyBarCode.FieldDescFlexField_PubDescSeg23] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCompleteApplyBarCode.FieldDescFlexField_PubDescSeg23);
			}
			set{
				this[this.uiviewCompleteApplyBarCode.FieldDescFlexField_PubDescSeg23] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg24
		{
			get{
				//object value = this[this.uiviewCompleteApplyBarCode.FieldDescFlexField_PubDescSeg24] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCompleteApplyBarCode.FieldDescFlexField_PubDescSeg24);
			}
			set{
				this[this.uiviewCompleteApplyBarCode.FieldDescFlexField_PubDescSeg24] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg25
		{
			get{
				//object value = this[this.uiviewCompleteApplyBarCode.FieldDescFlexField_PubDescSeg25] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCompleteApplyBarCode.FieldDescFlexField_PubDescSeg25);
			}
			set{
				this[this.uiviewCompleteApplyBarCode.FieldDescFlexField_PubDescSeg25] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg26
		{
			get{
				//object value = this[this.uiviewCompleteApplyBarCode.FieldDescFlexField_PubDescSeg26] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCompleteApplyBarCode.FieldDescFlexField_PubDescSeg26);
			}
			set{
				this[this.uiviewCompleteApplyBarCode.FieldDescFlexField_PubDescSeg26] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg27
		{
			get{
				//object value = this[this.uiviewCompleteApplyBarCode.FieldDescFlexField_PubDescSeg27] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCompleteApplyBarCode.FieldDescFlexField_PubDescSeg27);
			}
			set{
				this[this.uiviewCompleteApplyBarCode.FieldDescFlexField_PubDescSeg27] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg28
		{
			get{
				//object value = this[this.uiviewCompleteApplyBarCode.FieldDescFlexField_PubDescSeg28] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCompleteApplyBarCode.FieldDescFlexField_PubDescSeg28);
			}
			set{
				this[this.uiviewCompleteApplyBarCode.FieldDescFlexField_PubDescSeg28] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg29
		{
			get{
				//object value = this[this.uiviewCompleteApplyBarCode.FieldDescFlexField_PubDescSeg29] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCompleteApplyBarCode.FieldDescFlexField_PubDescSeg29);
			}
			set{
				this[this.uiviewCompleteApplyBarCode.FieldDescFlexField_PubDescSeg29] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg30
		{
			get{
				//object value = this[this.uiviewCompleteApplyBarCode.FieldDescFlexField_PubDescSeg30] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCompleteApplyBarCode.FieldDescFlexField_PubDescSeg30);
			}
			set{
				this[this.uiviewCompleteApplyBarCode.FieldDescFlexField_PubDescSeg30] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg31
		{
			get{
				//object value = this[this.uiviewCompleteApplyBarCode.FieldDescFlexField_PubDescSeg31] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCompleteApplyBarCode.FieldDescFlexField_PubDescSeg31);
			}
			set{
				this[this.uiviewCompleteApplyBarCode.FieldDescFlexField_PubDescSeg31] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg32
		{
			get{
				//object value = this[this.uiviewCompleteApplyBarCode.FieldDescFlexField_PubDescSeg32] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCompleteApplyBarCode.FieldDescFlexField_PubDescSeg32);
			}
			set{
				this[this.uiviewCompleteApplyBarCode.FieldDescFlexField_PubDescSeg32] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg33
		{
			get{
				//object value = this[this.uiviewCompleteApplyBarCode.FieldDescFlexField_PubDescSeg33] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCompleteApplyBarCode.FieldDescFlexField_PubDescSeg33);
			}
			set{
				this[this.uiviewCompleteApplyBarCode.FieldDescFlexField_PubDescSeg33] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg34
		{
			get{
				//object value = this[this.uiviewCompleteApplyBarCode.FieldDescFlexField_PubDescSeg34] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCompleteApplyBarCode.FieldDescFlexField_PubDescSeg34);
			}
			set{
				this[this.uiviewCompleteApplyBarCode.FieldDescFlexField_PubDescSeg34] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg35
		{
			get{
				//object value = this[this.uiviewCompleteApplyBarCode.FieldDescFlexField_PubDescSeg35] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCompleteApplyBarCode.FieldDescFlexField_PubDescSeg35);
			}
			set{
				this[this.uiviewCompleteApplyBarCode.FieldDescFlexField_PubDescSeg35] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg36
		{
			get{
				//object value = this[this.uiviewCompleteApplyBarCode.FieldDescFlexField_PubDescSeg36] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCompleteApplyBarCode.FieldDescFlexField_PubDescSeg36);
			}
			set{
				this[this.uiviewCompleteApplyBarCode.FieldDescFlexField_PubDescSeg36] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg37
		{
			get{
				//object value = this[this.uiviewCompleteApplyBarCode.FieldDescFlexField_PubDescSeg37] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCompleteApplyBarCode.FieldDescFlexField_PubDescSeg37);
			}
			set{
				this[this.uiviewCompleteApplyBarCode.FieldDescFlexField_PubDescSeg37] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg38
		{
			get{
				//object value = this[this.uiviewCompleteApplyBarCode.FieldDescFlexField_PubDescSeg38] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCompleteApplyBarCode.FieldDescFlexField_PubDescSeg38);
			}
			set{
				this[this.uiviewCompleteApplyBarCode.FieldDescFlexField_PubDescSeg38] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg39
		{
			get{
				//object value = this[this.uiviewCompleteApplyBarCode.FieldDescFlexField_PubDescSeg39] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCompleteApplyBarCode.FieldDescFlexField_PubDescSeg39);
			}
			set{
				this[this.uiviewCompleteApplyBarCode.FieldDescFlexField_PubDescSeg39] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg40
		{
			get{
				//object value = this[this.uiviewCompleteApplyBarCode.FieldDescFlexField_PubDescSeg40] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCompleteApplyBarCode.FieldDescFlexField_PubDescSeg40);
			}
			set{
				this[this.uiviewCompleteApplyBarCode.FieldDescFlexField_PubDescSeg40] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg41
		{
			get{
				//object value = this[this.uiviewCompleteApplyBarCode.FieldDescFlexField_PubDescSeg41] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCompleteApplyBarCode.FieldDescFlexField_PubDescSeg41);
			}
			set{
				this[this.uiviewCompleteApplyBarCode.FieldDescFlexField_PubDescSeg41] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg42
		{
			get{
				//object value = this[this.uiviewCompleteApplyBarCode.FieldDescFlexField_PubDescSeg42] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCompleteApplyBarCode.FieldDescFlexField_PubDescSeg42);
			}
			set{
				this[this.uiviewCompleteApplyBarCode.FieldDescFlexField_PubDescSeg42] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg43
		{
			get{
				//object value = this[this.uiviewCompleteApplyBarCode.FieldDescFlexField_PubDescSeg43] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCompleteApplyBarCode.FieldDescFlexField_PubDescSeg43);
			}
			set{
				this[this.uiviewCompleteApplyBarCode.FieldDescFlexField_PubDescSeg43] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg44
		{
			get{
				//object value = this[this.uiviewCompleteApplyBarCode.FieldDescFlexField_PubDescSeg44] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCompleteApplyBarCode.FieldDescFlexField_PubDescSeg44);
			}
			set{
				this[this.uiviewCompleteApplyBarCode.FieldDescFlexField_PubDescSeg44] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg45
		{
			get{
				//object value = this[this.uiviewCompleteApplyBarCode.FieldDescFlexField_PubDescSeg45] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCompleteApplyBarCode.FieldDescFlexField_PubDescSeg45);
			}
			set{
				this[this.uiviewCompleteApplyBarCode.FieldDescFlexField_PubDescSeg45] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg46
		{
			get{
				//object value = this[this.uiviewCompleteApplyBarCode.FieldDescFlexField_PubDescSeg46] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCompleteApplyBarCode.FieldDescFlexField_PubDescSeg46);
			}
			set{
				this[this.uiviewCompleteApplyBarCode.FieldDescFlexField_PubDescSeg46] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg47
		{
			get{
				//object value = this[this.uiviewCompleteApplyBarCode.FieldDescFlexField_PubDescSeg47] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCompleteApplyBarCode.FieldDescFlexField_PubDescSeg47);
			}
			set{
				this[this.uiviewCompleteApplyBarCode.FieldDescFlexField_PubDescSeg47] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg48
		{
			get{
				//object value = this[this.uiviewCompleteApplyBarCode.FieldDescFlexField_PubDescSeg48] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCompleteApplyBarCode.FieldDescFlexField_PubDescSeg48);
			}
			set{
				this[this.uiviewCompleteApplyBarCode.FieldDescFlexField_PubDescSeg48] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg49
		{
			get{
				//object value = this[this.uiviewCompleteApplyBarCode.FieldDescFlexField_PubDescSeg49] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCompleteApplyBarCode.FieldDescFlexField_PubDescSeg49);
			}
			set{
				this[this.uiviewCompleteApplyBarCode.FieldDescFlexField_PubDescSeg49] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg50
		{
			get{
				//object value = this[this.uiviewCompleteApplyBarCode.FieldDescFlexField_PubDescSeg50] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCompleteApplyBarCode.FieldDescFlexField_PubDescSeg50);
			}
			set{
				this[this.uiviewCompleteApplyBarCode.FieldDescFlexField_PubDescSeg50] = value;
			}
		}
		
		
		public  String DescFlexField_ContextValue
		{
			get{
				//object value = this[this.uiviewCompleteApplyBarCode.FieldDescFlexField_ContextValue] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCompleteApplyBarCode.FieldDescFlexField_ContextValue);
			}
			set{
				this[this.uiviewCompleteApplyBarCode.FieldDescFlexField_ContextValue] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg1
		{
			get{
				//object value = this[this.uiviewCompleteApplyBarCode.FieldDescFlexField_PrivateDescSeg1] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCompleteApplyBarCode.FieldDescFlexField_PrivateDescSeg1);
			}
			set{
				this[this.uiviewCompleteApplyBarCode.FieldDescFlexField_PrivateDescSeg1] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg2
		{
			get{
				//object value = this[this.uiviewCompleteApplyBarCode.FieldDescFlexField_PrivateDescSeg2] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCompleteApplyBarCode.FieldDescFlexField_PrivateDescSeg2);
			}
			set{
				this[this.uiviewCompleteApplyBarCode.FieldDescFlexField_PrivateDescSeg2] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg3
		{
			get{
				//object value = this[this.uiviewCompleteApplyBarCode.FieldDescFlexField_PrivateDescSeg3] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCompleteApplyBarCode.FieldDescFlexField_PrivateDescSeg3);
			}
			set{
				this[this.uiviewCompleteApplyBarCode.FieldDescFlexField_PrivateDescSeg3] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg4
		{
			get{
				//object value = this[this.uiviewCompleteApplyBarCode.FieldDescFlexField_PrivateDescSeg4] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCompleteApplyBarCode.FieldDescFlexField_PrivateDescSeg4);
			}
			set{
				this[this.uiviewCompleteApplyBarCode.FieldDescFlexField_PrivateDescSeg4] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg5
		{
			get{
				//object value = this[this.uiviewCompleteApplyBarCode.FieldDescFlexField_PrivateDescSeg5] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCompleteApplyBarCode.FieldDescFlexField_PrivateDescSeg5);
			}
			set{
				this[this.uiviewCompleteApplyBarCode.FieldDescFlexField_PrivateDescSeg5] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg6
		{
			get{
				//object value = this[this.uiviewCompleteApplyBarCode.FieldDescFlexField_PrivateDescSeg6] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCompleteApplyBarCode.FieldDescFlexField_PrivateDescSeg6);
			}
			set{
				this[this.uiviewCompleteApplyBarCode.FieldDescFlexField_PrivateDescSeg6] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg7
		{
			get{
				//object value = this[this.uiviewCompleteApplyBarCode.FieldDescFlexField_PrivateDescSeg7] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCompleteApplyBarCode.FieldDescFlexField_PrivateDescSeg7);
			}
			set{
				this[this.uiviewCompleteApplyBarCode.FieldDescFlexField_PrivateDescSeg7] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg8
		{
			get{
				//object value = this[this.uiviewCompleteApplyBarCode.FieldDescFlexField_PrivateDescSeg8] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCompleteApplyBarCode.FieldDescFlexField_PrivateDescSeg8);
			}
			set{
				this[this.uiviewCompleteApplyBarCode.FieldDescFlexField_PrivateDescSeg8] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg9
		{
			get{
				//object value = this[this.uiviewCompleteApplyBarCode.FieldDescFlexField_PrivateDescSeg9] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCompleteApplyBarCode.FieldDescFlexField_PrivateDescSeg9);
			}
			set{
				this[this.uiviewCompleteApplyBarCode.FieldDescFlexField_PrivateDescSeg9] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg10
		{
			get{
				//object value = this[this.uiviewCompleteApplyBarCode.FieldDescFlexField_PrivateDescSeg10] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCompleteApplyBarCode.FieldDescFlexField_PrivateDescSeg10);
			}
			set{
				this[this.uiviewCompleteApplyBarCode.FieldDescFlexField_PrivateDescSeg10] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg11
		{
			get{
				//object value = this[this.uiviewCompleteApplyBarCode.FieldDescFlexField_PrivateDescSeg11] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCompleteApplyBarCode.FieldDescFlexField_PrivateDescSeg11);
			}
			set{
				this[this.uiviewCompleteApplyBarCode.FieldDescFlexField_PrivateDescSeg11] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg12
		{
			get{
				//object value = this[this.uiviewCompleteApplyBarCode.FieldDescFlexField_PrivateDescSeg12] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCompleteApplyBarCode.FieldDescFlexField_PrivateDescSeg12);
			}
			set{
				this[this.uiviewCompleteApplyBarCode.FieldDescFlexField_PrivateDescSeg12] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg13
		{
			get{
				//object value = this[this.uiviewCompleteApplyBarCode.FieldDescFlexField_PrivateDescSeg13] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCompleteApplyBarCode.FieldDescFlexField_PrivateDescSeg13);
			}
			set{
				this[this.uiviewCompleteApplyBarCode.FieldDescFlexField_PrivateDescSeg13] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg14
		{
			get{
				//object value = this[this.uiviewCompleteApplyBarCode.FieldDescFlexField_PrivateDescSeg14] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCompleteApplyBarCode.FieldDescFlexField_PrivateDescSeg14);
			}
			set{
				this[this.uiviewCompleteApplyBarCode.FieldDescFlexField_PrivateDescSeg14] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg15
		{
			get{
				//object value = this[this.uiviewCompleteApplyBarCode.FieldDescFlexField_PrivateDescSeg15] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCompleteApplyBarCode.FieldDescFlexField_PrivateDescSeg15);
			}
			set{
				this[this.uiviewCompleteApplyBarCode.FieldDescFlexField_PrivateDescSeg15] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg16
		{
			get{
				//object value = this[this.uiviewCompleteApplyBarCode.FieldDescFlexField_PrivateDescSeg16] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCompleteApplyBarCode.FieldDescFlexField_PrivateDescSeg16);
			}
			set{
				this[this.uiviewCompleteApplyBarCode.FieldDescFlexField_PrivateDescSeg16] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg17
		{
			get{
				//object value = this[this.uiviewCompleteApplyBarCode.FieldDescFlexField_PrivateDescSeg17] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCompleteApplyBarCode.FieldDescFlexField_PrivateDescSeg17);
			}
			set{
				this[this.uiviewCompleteApplyBarCode.FieldDescFlexField_PrivateDescSeg17] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg18
		{
			get{
				//object value = this[this.uiviewCompleteApplyBarCode.FieldDescFlexField_PrivateDescSeg18] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCompleteApplyBarCode.FieldDescFlexField_PrivateDescSeg18);
			}
			set{
				this[this.uiviewCompleteApplyBarCode.FieldDescFlexField_PrivateDescSeg18] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg19
		{
			get{
				//object value = this[this.uiviewCompleteApplyBarCode.FieldDescFlexField_PrivateDescSeg19] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCompleteApplyBarCode.FieldDescFlexField_PrivateDescSeg19);
			}
			set{
				this[this.uiviewCompleteApplyBarCode.FieldDescFlexField_PrivateDescSeg19] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg20
		{
			get{
				//object value = this[this.uiviewCompleteApplyBarCode.FieldDescFlexField_PrivateDescSeg20] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCompleteApplyBarCode.FieldDescFlexField_PrivateDescSeg20);
			}
			set{
				this[this.uiviewCompleteApplyBarCode.FieldDescFlexField_PrivateDescSeg20] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg21
		{
			get{
				//object value = this[this.uiviewCompleteApplyBarCode.FieldDescFlexField_PrivateDescSeg21] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCompleteApplyBarCode.FieldDescFlexField_PrivateDescSeg21);
			}
			set{
				this[this.uiviewCompleteApplyBarCode.FieldDescFlexField_PrivateDescSeg21] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg22
		{
			get{
				//object value = this[this.uiviewCompleteApplyBarCode.FieldDescFlexField_PrivateDescSeg22] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCompleteApplyBarCode.FieldDescFlexField_PrivateDescSeg22);
			}
			set{
				this[this.uiviewCompleteApplyBarCode.FieldDescFlexField_PrivateDescSeg22] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg23
		{
			get{
				//object value = this[this.uiviewCompleteApplyBarCode.FieldDescFlexField_PrivateDescSeg23] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCompleteApplyBarCode.FieldDescFlexField_PrivateDescSeg23);
			}
			set{
				this[this.uiviewCompleteApplyBarCode.FieldDescFlexField_PrivateDescSeg23] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg24
		{
			get{
				//object value = this[this.uiviewCompleteApplyBarCode.FieldDescFlexField_PrivateDescSeg24] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCompleteApplyBarCode.FieldDescFlexField_PrivateDescSeg24);
			}
			set{
				this[this.uiviewCompleteApplyBarCode.FieldDescFlexField_PrivateDescSeg24] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg25
		{
			get{
				//object value = this[this.uiviewCompleteApplyBarCode.FieldDescFlexField_PrivateDescSeg25] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCompleteApplyBarCode.FieldDescFlexField_PrivateDescSeg25);
			}
			set{
				this[this.uiviewCompleteApplyBarCode.FieldDescFlexField_PrivateDescSeg25] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg26
		{
			get{
				//object value = this[this.uiviewCompleteApplyBarCode.FieldDescFlexField_PrivateDescSeg26] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCompleteApplyBarCode.FieldDescFlexField_PrivateDescSeg26);
			}
			set{
				this[this.uiviewCompleteApplyBarCode.FieldDescFlexField_PrivateDescSeg26] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg27
		{
			get{
				//object value = this[this.uiviewCompleteApplyBarCode.FieldDescFlexField_PrivateDescSeg27] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCompleteApplyBarCode.FieldDescFlexField_PrivateDescSeg27);
			}
			set{
				this[this.uiviewCompleteApplyBarCode.FieldDescFlexField_PrivateDescSeg27] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg28
		{
			get{
				//object value = this[this.uiviewCompleteApplyBarCode.FieldDescFlexField_PrivateDescSeg28] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCompleteApplyBarCode.FieldDescFlexField_PrivateDescSeg28);
			}
			set{
				this[this.uiviewCompleteApplyBarCode.FieldDescFlexField_PrivateDescSeg28] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg29
		{
			get{
				//object value = this[this.uiviewCompleteApplyBarCode.FieldDescFlexField_PrivateDescSeg29] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCompleteApplyBarCode.FieldDescFlexField_PrivateDescSeg29);
			}
			set{
				this[this.uiviewCompleteApplyBarCode.FieldDescFlexField_PrivateDescSeg29] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg30
		{
			get{
				//object value = this[this.uiviewCompleteApplyBarCode.FieldDescFlexField_PrivateDescSeg30] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCompleteApplyBarCode.FieldDescFlexField_PrivateDescSeg30);
			}
			set{
				this[this.uiviewCompleteApplyBarCode.FieldDescFlexField_PrivateDescSeg30] = value;
			}
		}
		
		
		public  String DescFlexField_CombineName
		{
			get{
				//object value = this[this.uiviewCompleteApplyBarCode.FieldDescFlexField_CombineName] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCompleteApplyBarCode.FieldDescFlexField_CombineName);
			}
			set{
				this[this.uiviewCompleteApplyBarCode.FieldDescFlexField_CombineName] = value;
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
		
		
		public  DateTime? PrintedOn
		{
			get{
				//object value = this[this.uiviewCompleteApplyBarCode.FieldPrintedOn] ;
				//return (DateTime?)value;
				return GetValue<DateTime?>(this.uiviewCompleteApplyBarCode.FieldPrintedOn);
			}
			set{
				this[this.uiviewCompleteApplyBarCode.FieldPrintedOn] = value;
			}
		}
		
		
		public  String PrintedBy
		{
			get{
				//object value = this[this.uiviewCompleteApplyBarCode.FieldPrintedBy] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCompleteApplyBarCode.FieldPrintedBy);
			}
			set{
				this[this.uiviewCompleteApplyBarCode.FieldPrintedBy] = value;
			}
		}
		
		
		public  String Item_SPECS
		{
			get{
				//object value = this[this.uiviewCompleteApplyBarCode.FieldItem_SPECS] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCompleteApplyBarCode.FieldItem_SPECS);
			}
			set{
				this[this.uiviewCompleteApplyBarCode.FieldItem_SPECS] = value;
			}
		}
		
		
		public  String Item_DescFlexField_PrivateDescSeg1
		{
			get{
				//object value = this[this.uiviewCompleteApplyBarCode.FieldItem_DescFlexField_PrivateDescSeg1] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCompleteApplyBarCode.FieldItem_DescFlexField_PrivateDescSeg1);
			}
			set{
				this[this.uiviewCompleteApplyBarCode.FieldItem_DescFlexField_PrivateDescSeg1] = value;
			}
		}
		
		
		public  Int32? Qty
		{
			get{
				//object value = this[this.uiviewCompleteApplyBarCode.FieldQty] ;
				//return (Int32?)value;
				return GetValue<Int32?>(this.uiviewCompleteApplyBarCode.FieldQty);
			}
			set{
				this[this.uiviewCompleteApplyBarCode.FieldQty] = value;
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