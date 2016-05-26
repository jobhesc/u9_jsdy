


using System;
using System.Text;
using System.Collections;
using System.Xml;
using System.Data;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Resources;
using System.Reflection;
using System.Globalization;
using System.Threading;

using Telerik.WebControls;
using UFSoft.UBF.UI.WebControls;
using UFSoft.UBF.UI.WebControls.InterActionComponenet;
using UFSoft.UBF.Util.Log;
using UFSoft.UBF.Util.Context;

//using MagicAjax.UI.Controls;
using UFSoft.UBF.Report.UI.ReportView.Web;
using UFSoft.UBF.UI.WebControlAdapter;
using UFSoft.UBF.UI.FormProcess;
using UFSoft.UBF.UI.IView;
using UFSoft.UBF.UI.Engine;
using UFSoft.UBF.UI.Engine.Builder;
using UFSoft.UBF.UI.Engine.Authorization;
using UFSoft.UBF.UI.MD.Runtime;
using UFSoft.UBF.UI.ActionProcess;
using UFSoft.UBF.UI.ControlModel;
using UFSoft.UBF.UI.Controls;
using UFSoft.UBF.UI.WebControls.Association;
using UFSoft.UBF.UI.WebControls.ClientCallBack;
using System.Web.UI;
using UFSoft.UBF.UI.UIFormPersonalization;
using System.Collections.Specialized;


/***********************************************************************************************
 * Form ID:11b5454e-5e56-4c3e-9f96-e30a4f194977 
 * Form Name:CompleteApplyBarCodeUIForm
 * UIFactory Auto Generator
 ***********************************************************************************************/
namespace UFIDA.U9.Cust.JSDY.CompleteApplyBarCodeUIModel
{
	[FormRegister("UFIDA.U9.Cust.JSDY.BarCodeUI","UFIDA.U9.Cust.JSDY.CompleteApplyBarCodeUIModel.CompleteApplyBarCodeUIFormWebPart", "UFIDA.U9.Cust.JSDY.BarCodeUI.WebPart", "11b5454e-5e56-4c3e-9f96-e30a4f194977","WebPart", "True", 630, 375)] 
	///insert into aspnet_Parts (SysVersion, Path, ClassName, [Assembly], FormId) values (0, 'UFIDA.U9.Cust.JSDY.BarCodeUI', 'UFIDA.U9.Cust.JSDY.CompleteApplyBarCodeUIModel.CompleteApplyBarCodeUIFormWebPart', 'UFIDA.U9.Cust.JSDY.BarCodeUI.WebPart', '11b5454e-5e56-4c3e-9f96-e30a4f194977')
	///<siteMapNode url="~/erp/simple.aspx?lnk=11b5454e-5e56-4c3e-9f96-e30a4f194977" title="CompleteApplyBarCodeUIForm"/>
    public partial class CompleteApplyBarCodeUIFormWebPart : UFSoft.UBF.UI.FormProcess.BaseWebForm
    {
		#region Page Controller/Code Behind
        private static readonly ILogger logger = LoggerManager.GetLogger(typeof(CompleteApplyBarCodeUIFormWebPart));
        private string assemblyName = System.Reflection.Assembly.GetExecutingAssembly().FullName;
        //private string displayNamePostfix = "displayName";

		#region 强类型化基类属性.
		public new CompleteApplyBarCodeUIModelAction Action
		{
			get { return (CompleteApplyBarCodeUIModelAction)base.Action; }
			set { base.Action = value; }
		}
		CompleteApplyBarCodeUIModelModel _uimodel=null;
		public new CompleteApplyBarCodeUIModelModel Model
		{
			get 
			{
			     if(_uimodel == null){
			          _uimodel = new CompleteApplyBarCodeUIModelModel();
			     }
			     return _uimodel; 
			}
			set { _uimodel = value; }
		}
        protected override IUIModel UIModel{
            get{
                return this.Model;
            }
            set{
                this.Model = value as CompleteApplyBarCodeUIModelModel;
            }
        }
		#endregion 
		public FormAdjust adjust;
        #region variable declaration
        IUFCard Card0;
        IUFLabel lblID113;
        IUFFldNumberControl ID113;
        IUFLabel lblSysVersion101;
        IUFFldNumberControl SysVersion101;
        IUFLabel lblItem578;
        IUFFldReference Item578;
        IUFLabel lblItem_Name94;
        IUFFldTextBox Item_Name94;
        IUFLabel lblItem_SPECS155;
        IUFFldTextBox Item_SPECS155;
        IUFLabel lblItem_DescFlexField_PrivateDescSeg1124;
        IUFFldTextBox Item_DescFlexField_PrivateDescSeg1124;
        IUFLabel lblActualLength118;
        IUFFldNumberControl ActualLength118;
        IUFLabel lblBusinessDate110;
        IUFFldDatePicker BusinessDate110;
        IUFLabel lblQty116;
        IUFFldNumberControl Qty116;
        IUFLabel lblOperators118;
        IUFFldReference Operators118;
        IUFLabel lblMemo164;
        IUFFldTextBox Memo164;
        IUFFldFlexFieldPicker FlexFieldPicker0;
        IUFLabel lblIsPrintWrapper238;
        IUFFldCheckBox IsPrintWrapper238;
        IUFCard Card1;
        IUFButton BtnClose;
        IUFButton BtnOk;
		UpdatePanel updatePanel;
		HiddenField wpFindID;
		IUFContainer topLevelPanel;     
        IUFSeparator SeparatorInFavorites;
        IUFButton BtnDefaultValues;
        #endregion
        
        #region constructor
        public CompleteApplyBarCodeUIFormWebPart()
        {
            FormID = "11b5454e-5e56-4c3e-9f96-e30a4f194977";
            IsAutoSize = bool.Parse("False");
        }
        #endregion


	
            
	//获取档案版型结果: 

        #region eventBind and databind
        private void EventBind()
        {
			//事件绑定模板
				//Button控件事件
			this.BtnOk.Click += new EventHandler(BtnOk_Click);		
						

	
            AfterEventBind();
        }
        #endregion            
        
		#region override method
		protected override void OnLoad(EventArgs e)
		{
			base.OnLoad2(e);
		}
		protected override void OnLoadDataDo(EventArgs e)
		{
		    adjust.ProcessAdjustBeforeOnLoad(this);
			if (UIEngineHelper.IsDataBind(PageStatus, this))
			{
				if(this.Model==null){				        
					this.Model = new CompleteApplyBarCodeUIModelModel();
				}
				OnLoadConsumer(new InParameterModel[]{},new InParameterModel[]{});
				OnLoadData(this);
				this.IsDataBinding = true ; //加载完数据要绑定一次.目前加这.
			}
			else
			{
				//去除.已经移入到OnInit()中.
				//this.Model = (CompleteApplyBarCodeUIModelModel)this.CurrentState[this.TaskId.ToString()];
			}
			adjust.ProcessAdjustAfterOnLoadData(this);
		            AfterOnLoad();
            
            adjust.ProcessAdjustAfterOnLoad(this);
		}
		protected override void OnPreRender(EventArgs e)
		{
			base.OnPreRender2(e);
		}
        protected override void OnPreRenderDo(EventArgs e)
        {
            adjust.ProcessAdjustBeforeOnPreRender(this);
			base.OnPreRender(e);
			this.CurrentState[this.TaskId.ToString()] = this.Model;
			RegisterClearWebPartPadding();
            UFIDA.U9.UI.PDHelper.FormAuthorityHelper.SetWebPartAuthorization(this);
            
			if (IsDataBinding) //2006-9-7 可由开发人员控制
			{
				BeforeUIModelBinding();
								if(!Page.IsPostBack)
				{
					EnumTypeBinding.BindEnumControls(this);
				}
				UFIDA.U9.UI.Commands.CommandHelper.BindFlexData(this);
				adjust.ProcessAdjustBeforeDataBinding(this);
				if (this.IsOnlyDataBinding)
				{
					this.DataBinding();
				}
				adjust.ProcessAdjustAfterDataBinding(this);

				AfterUIModelBinding();
			}
			adjust.ProcessAdjustAfterOnPreRender(this);
        }
		protected override void OnInit(EventArgs e)
		{
			base.OnInit2(e);
		}
		protected override void OnInitDo(EventArgs e)
		{			 
			this.Page.InitComplete += new EventHandler(Page_InitComplete);
			WebPartBuilder.InitWebPart(this);
            this.Action = new CompleteApplyBarCodeUIModelAction(this);
            adjust = new FormAdjust();
		    CreateFormChildControls();
		}
        void Page_InitComplete(object sender, EventArgs e)
        {

            adjust.ProcessInit(this);
        }
        #endregion

      
        
        #endregion

	
		/// <summary>
        /// WebPart View
        /// </summary>
        #region view Create Contorls
        private void CreateFormChildControls()
        {
            IUFContainer _panel = UIControlBuilder.BuildTopLevelContainer(this,"CompleteApplyBarCodeUIForm",true,630,375);
            CommonBuilder.ContainerGridLayoutPropBuilder(_panel, 1, 2, 0, 10, 10, 10, 10, 10);
			InitViewBindingContainer(this, _panel,  null, "", "", null, 1, "");
			UIControlBuilder.BuildContainerGridLayout(_panel, 10,new GridColumnDef[]{new GridColumnDef(610,bool.Parse("True")),},new GridRowDef[]{new GridRowDef(320,bool.Parse("True")),new GridRowDef(25,bool.Parse("True")),});
            //???还有用么?
            topLevelPanel = _panel;    
            
            UIControlBuilder.BuildCommonControls(this,ref updatePanel,ref wpFindID);
            





	
			_BuilderControl_Card0(_panel);

		
			UIControlBuilder.BuilderUFControl(this.Card0, "1");		


	
			_BuilderControl_Card1(_panel);

		
			UIControlBuilder.BuilderUFControl(this.Card1, "2");		



		
     
			
			
            EventBind();
            AfterCreateChildControls();
            
        }        







	                   
        private IUFCard _BuilderControl_Card0(IUFContainer container)
        {
            IUFCard _UFCard = UIControlBuilder.BuildCard(container,"Card0",false,"none", true, true, "1","a40e4527-5e00-41fd-abf6-53b57a5d5a2e","f82a324a-3b73-423d-b19b-f1206fa61340");
			CommonBuilder.GridLayoutPropBuilder(container, _UFCard, 610, 320, 0, 0, 1, 1, "100");
            CommonBuilder.ContainerGridLayoutPropBuilder(_UFCard, 7, 13, 0, 5, 0, 0, 0, 0);
			InitViewBindingContainer(this, _UFCard,  this.Model.CompleteApplyBarCode, "CompleteApplyBarCode", "", null, 1, "完工申报条码档案");
			UIControlBuilder.BuildContainerGridLayout(_UFCard, 5,new GridColumnDef[]{new GridColumnDef(120,bool.Parse("True")),new GridColumnDef(5,bool.Parse("True")),new GridColumnDef(170,bool.Parse("True")),new GridColumnDef(20,bool.Parse("True")),new GridColumnDef(120,bool.Parse("True")),new GridColumnDef(5,bool.Parse("True")),new GridColumnDef(170,bool.Parse("True")),},new GridRowDef[]{new GridRowDef(20,bool.Parse("True")),new GridRowDef(20,bool.Parse("True")),new GridRowDef(20,bool.Parse("True")),new GridRowDef(20,bool.Parse("True")),new GridRowDef(20,bool.Parse("True")),new GridRowDef(20,bool.Parse("True")),new GridRowDef(20,bool.Parse("True")),new GridRowDef(20,bool.Parse("True")),new GridRowDef(20,bool.Parse("True")),new GridRowDef(20,bool.Parse("True")),new GridRowDef(20,bool.Parse("True")),new GridRowDef(20,bool.Parse("True")),new GridRowDef(20,bool.Parse("True")),});
            this.Card0 = _UFCard;

            ///foreach UFCard下的所有控件，增加到此容器





				this.lblID113 = UIControlBuilder.BuilderUFLabel(_UFCard, "lblID113", "", "False", "True", "Right", 90, 20, 0, 0, 1, 1, "100","a40e4527-5e00-41fd-abf6-53b57a5d5a2e","49d1d1bf-cdee-4491-a62a-032e1bbc0a66");


								

		
			UIControlBuilder.BuilderUFControl(this.lblID113, "1");		


				this.ID113 = UIControlBuilder.BuilderNumberControl(_UFCard, "ID113", "False", "False", "True", "Left", 7, 60, 0, 90, 20, 0, 0, 1, 1, NumbericType.Numberic, "100",79228162514264337593543950335m, -79228162514264337593543950335m
			,TextAlign.Right,0,true,false,true,"lblID113","19.0","a40e4527-5e00-41fd-abf6-53b57a5d5a2e","60403483-1984-4b1d-9a5b-846d2b571241",null,null,null, null);
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.ID113, "False", "ID", this.Model.CompleteApplyBarCode, this.Model.CompleteApplyBarCode.FieldID, "CompleteApplyBarCode");
	
		
			UIControlBuilder.BuilderUFControl(this.ID113, "2");		
		 

				this.lblSysVersion101 = UIControlBuilder.BuilderUFLabel(_UFCard, "lblSysVersion101", "", "False", "True", "Right", 90, 20, 0, 0, 1, 1, "100","a010b438-e547-420a-be2c-14aa47f6d971","7cc1b455-0384-444d-908a-aa92cf644d0c");


								

		
			UIControlBuilder.BuilderUFControl(this.lblSysVersion101, "3");		


				this.SysVersion101 = UIControlBuilder.BuilderNumberControl(_UFCard, "SysVersion101", "True", "False", "True", "Left", 7, 60, 0, 90, 20, 0, 0, 1, 1, NumbericType.Numberic, "100",79228162514264337593543950335m, -79228162514264337593543950335m
			,TextAlign.Right,0,true,false,true,"lblSysVersion101","19.0","a010b438-e547-420a-be2c-14aa47f6d971","155186a0-6d52-46ca-a1cd-b4f629a1d59d",null,null,null, null);
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.SysVersion101, "False", "SysVersion", this.Model.CompleteApplyBarCode, this.Model.CompleteApplyBarCode.FieldSysVersion, "CompleteApplyBarCode");
	
		
			UIControlBuilder.BuilderUFControl(this.SysVersion101, "4");		
		 

				this.lblItem578 = UIControlBuilder.BuilderUFLabel(_UFCard, "lblItem578", "", "True", "True", "Right", 120, 20, 0, 0, 1, 1, "100","efc89e4f-e2de-4319-a1cd-cdef95f3bbd9","85f92e21-c486-4e11-ab91-2147e795ed67");


								

		
			UIControlBuilder.BuilderUFControl(this.lblItem578, "5");		


				this.Item578 = UIControlBuilder.BuilderRefrenceControl(_UFCard,"Item578",false,true, true,170, 20, 2, 0, 1, 1, "100","13",false,false,true,"lblItem578","efc89e4f-e2de-4319-a1cd-cdef95f3bbd9","f21bde16-8b0a-433c-959e-55e4a681d418");
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.Item578, "False", "Item", this.Model.CompleteApplyBarCode, this.Model.CompleteApplyBarCode.FieldItem, "CompleteApplyBarCode");
			UIControlBuilder.SetReferenceControlRefInfo(this.Item578,"b2ccf05d-c424-4574-af1c-469aa085f418", 580,408, "Code","Code","ID", this.Model.CompleteApplyBarCode.FieldItem_Code,this.Model.CompleteApplyBarCode.FieldItem_Code);
            //foreach Reference's input filter parameter
            //foreach Reference's output set data, columnID锛屽弬鐓ц繑鍥炲垪鐨凢ieldID
			ScriptBuilder.BuildReferenceControlOuputScript(this.Item578,"Item578",new ReferenceOutputParam[]{new ReferenceOutputParam("","ID",""),new ReferenceOutputParam("","Code",""),new ReferenceOutputParam("Item_Name94","Name","Value"),new ReferenceOutputParam("Item_SPECS155","SPECS","Value"),new ReferenceOutputParam("Item_DescFlexField_PrivateDescSeg1124","DescFlexField_PrivateDescSeg1","Value"),});
				

		
			UIControlBuilder.BuilderUFControl(this.Item578, "13");		
		 

				this.lblItem_Name94 = UIControlBuilder.BuilderUFLabel(_UFCard, "lblItem_Name94", "", "True", "True", "Right", 120, 20, 0, 1, 1, 1, "100","6aa2daba-3c6d-4767-b633-99fa1e5b99a2","edaef245-3b0d-46f3-a758-3beac5e6557b");


								

		
			UIControlBuilder.BuilderUFControl(this.lblItem_Name94, "6");		


				this.Item_Name94 = UIControlBuilder.BuilderTextBox(_UFCard, "Item_Name94", "False", "True", "True", "False", "Left", 0, 60, 0, 170, 20, 2, 1, 1, 1, "False", "100"
			,"",TextBoxMode.SingleLine,TextAlign.Left, true,true,"lblItem_Name94","","255","6aa2daba-3c6d-4767-b633-99fa1e5b99a2","b22874e4-e48e-42fa-a7f3-11bafa9e0e6f");
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.Item_Name94, "False", "Item_Name", this.Model.CompleteApplyBarCode, this.Model.CompleteApplyBarCode.FieldItem_Name, "CompleteApplyBarCode");


		
			UIControlBuilder.BuilderUFControl(this.Item_Name94, "14");		
		 

				this.lblItem_SPECS155 = UIControlBuilder.BuilderUFLabel(_UFCard, "lblItem_SPECS155", "", "True", "True", "Right", 120, 20, 0, 2, 1, 1, "100","6fcbb7a9-0fa2-4f81-9f66-746feeb00979","81ff97b5-ff58-4095-aca4-556ff9d661da");


								

		
			UIControlBuilder.BuilderUFControl(this.lblItem_SPECS155, "7");		


				this.Item_SPECS155 = UIControlBuilder.BuilderTextBox(_UFCard, "Item_SPECS155", "True", "True", "True", "False", "Left", 0, 60, 0, 170, 20, 2, 2, 1, 1, "False", "100"
			,"",TextBoxMode.SingleLine,TextAlign.Left, true,true,"lblItem_SPECS155","","300","6fcbb7a9-0fa2-4f81-9f66-746feeb00979","7ab1f2d3-38da-4bd5-aa7b-7738ec2f90fe");
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.Item_SPECS155, "False", "Item_SPECS", this.Model.CompleteApplyBarCode, this.Model.CompleteApplyBarCode.FieldItem_SPECS, "CompleteApplyBarCode");


		
			UIControlBuilder.BuilderUFControl(this.Item_SPECS155, "15");		
		 

				this.lblItem_DescFlexField_PrivateDescSeg1124 = UIControlBuilder.BuilderUFLabel(_UFCard, "lblItem_DescFlexField_PrivateDescSeg1124", "", "True", "True", "Right", 120, 20, 0, 3, 1, 1, "100","e6f05870-463e-45a6-b544-e88e4c64ebfb","3a1dd517-ad64-4d07-8063-11e575f6bd0a");


								

		
			UIControlBuilder.BuilderUFControl(this.lblItem_DescFlexField_PrivateDescSeg1124, "8");		


				this.Item_DescFlexField_PrivateDescSeg1124 = UIControlBuilder.BuilderTextBox(_UFCard, "Item_DescFlexField_PrivateDescSeg1124", "True", "True", "True", "False", "Left", 0, 60, 0, 170, 20, 2, 3, 1, 1, "False", "100"
			,"",TextBoxMode.SingleLine,TextAlign.Left, true,true,"lblItem_DescFlexField_PrivateDescSeg1124","","1000","e6f05870-463e-45a6-b544-e88e4c64ebfb","1f23231b-4192-49eb-829b-2169e5f9375d");
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.Item_DescFlexField_PrivateDescSeg1124, "False", "Item_DescFlexField_PrivateDescSeg1", this.Model.CompleteApplyBarCode, this.Model.CompleteApplyBarCode.FieldItem_DescFlexField_PrivateDescSeg1, "CompleteApplyBarCode");


		
			UIControlBuilder.BuilderUFControl(this.Item_DescFlexField_PrivateDescSeg1124, "16");		
		 

				this.lblActualLength118 = UIControlBuilder.BuilderUFLabel(_UFCard, "lblActualLength118", "", "True", "True", "Right", 120, 20, 0, 4, 1, 1, "100","f13ef3bc-cfe1-4449-ab5a-44e451cbc921","0c5abdde-f770-4803-a170-bacd2ca6acad");


								

		
			UIControlBuilder.BuilderUFControl(this.lblActualLength118, "9");		


				this.ActualLength118 = UIControlBuilder.BuilderNumberControl(_UFCard, "ActualLength118", "False", "True", "True", "Left", 2, 60, 0, 170, 20, 2, 4, 1, 1, NumbericType.Numberic, "100",79228162514264337593543950335m, -79228162514264337593543950335m
			,TextAlign.Right,0,true,false,true,"lblActualLength118","10.0","f13ef3bc-cfe1-4449-ab5a-44e451cbc921","81126926-b5c8-47c9-949c-3f049a6f9838",null,null,null, null);
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.ActualLength118, "False", "ActualLength", this.Model.CompleteApplyBarCode, this.Model.CompleteApplyBarCode.FieldActualLength, "CompleteApplyBarCode");
	
		
			UIControlBuilder.BuilderUFControl(this.ActualLength118, "17");		
		 

				this.lblBusinessDate110 = UIControlBuilder.BuilderUFLabel(_UFCard, "lblBusinessDate110", "", "True", "True", "Right", 120, 20, 0, 5, 1, 1, "100","8c27c721-3992-4766-b325-82cd965083cc","f32bd1be-e86f-4bdf-a079-afb8bd192e4b");


								

		
			UIControlBuilder.BuilderUFControl(this.lblBusinessDate110, "10");		


				this.BusinessDate110 = UIControlBuilder.BuilderDatePicker(_UFCard, "BusinessDate110", false, true, true, "Date","Left", 3, 60, 0, 170, 20, 2, 5, 1, 1, "100",true,false,"lblBusinessDate110","8c27c721-3992-4766-b325-82cd965083cc","68c975ff-fb64-434a-ac0b-cbb20427f2af");
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.BusinessDate110, "False", "BusinessDate", this.Model.CompleteApplyBarCode, this.Model.CompleteApplyBarCode.FieldBusinessDate, "CompleteApplyBarCode");


		
			UIControlBuilder.BuilderUFControl(this.BusinessDate110, "18");		
		 

				this.lblQty116 = UIControlBuilder.BuilderUFLabel(_UFCard, "lblQty116", "", "True", "True", "Right", 120, 20, 0, 7, 1, 1, "100","c7fa73e0-c717-4b0c-8286-cecaa8f87b20","2012b706-7851-4826-aef4-b098cca94d7f");


								

		
			UIControlBuilder.BuilderUFControl(this.lblQty116, "12");		


				this.Qty116 = UIControlBuilder.BuilderNumberControl(_UFCard, "Qty116", "True", "True", "True", "Left", 2, 60, 0, 170, 20, 2, 7, 1, 1, NumbericType.Numberic, "100",79228162514264337593543950335m, -79228162514264337593543950335m
			,TextAlign.Right,0,true,false,true,"lblQty116","10.0","c7fa73e0-c717-4b0c-8286-cecaa8f87b20","d3eaf2d5-4c95-4588-8749-68118fe73a45",null,null,null, null);
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.Qty116, "False", "Qty", this.Model.CompleteApplyBarCode, this.Model.CompleteApplyBarCode.FieldQty, "CompleteApplyBarCode");
	
		
			UIControlBuilder.BuilderUFControl(this.Qty116, "20");		
		 

				this.lblOperators118 = UIControlBuilder.BuilderUFLabel(_UFCard, "lblOperators118", "", "True", "True", "Right", 120, 20, 4, 0, 1, 1, "100","98072be1-8c91-470a-919d-6884d6384f38","c264c1b4-eed2-49d0-9674-7989772aba01");


								

		
			UIControlBuilder.BuilderUFControl(this.lblOperators118, "21");		


				this.Operators118 = UIControlBuilder.BuilderRefrenceControl(_UFCard,"Operators118",false,true, true,170, 20, 6, 0, 1, 1, "100","23",false,false,true,"lblOperators118","98072be1-8c91-470a-919d-6884d6384f38","2a5b2d94-50fa-413a-a8e1-0694f4bb77b6");
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.Operators118, "False", "Operators", this.Model.CompleteApplyBarCode, this.Model.CompleteApplyBarCode.FieldOperators, "CompleteApplyBarCode");
			UIControlBuilder.SetReferenceControlRefInfo(this.Operators118,"e295a02e-32f3-44c1-9648-b2c189a2f18c", 580,408, "Name","Code","ID", this.Model.CompleteApplyBarCode.FieldOperators_Code,this.Model.CompleteApplyBarCode.FieldOperators_Name);
            //foreach Reference's input filter parameter
            //foreach Reference's output set data, columnID锛屽弬鐓ц繑鍥炲垪鐨凢ieldID
			ScriptBuilder.BuildReferenceControlOuputScript(this.Operators118,"Operators118",new ReferenceOutputParam[]{new ReferenceOutputParam("","ID",""),new ReferenceOutputParam("","Code",""),new ReferenceOutputParam("","Name",""),new ReferenceOutputParam("","Dept_Code",""),new ReferenceOutputParam("","Dept_Name",""),});
				

		
			UIControlBuilder.BuilderUFControl(this.Operators118, "23");		
		 

				this.lblMemo164 = UIControlBuilder.BuilderUFLabel(_UFCard, "lblMemo164", "", "True", "True", "Right", 120, 20, 4, 1, 1, 1, "100","456accbe-5afe-42fb-9e71-51b0f5db4a02","4a70e2b6-5034-4632-9b6d-545f463f2f1a");


								

		
			UIControlBuilder.BuilderUFControl(this.lblMemo164, "22");		


				this.Memo164 = UIControlBuilder.BuilderTextBox(_UFCard, "Memo164", "True", "True", "True", "True", "Left", 0, 60, 0, 170, 70, 6, 1, 1, 3, "False", "100"
			,"",TextBoxMode.MultiLine,TextAlign.Left, true,false,"lblMemo164","","1000","456accbe-5afe-42fb-9e71-51b0f5db4a02","6e13d719-f535-4e29-8022-ee3605fbb226");
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.Memo164, "False", "Memo", this.Model.CompleteApplyBarCode, this.Model.CompleteApplyBarCode.FieldMemo, "CompleteApplyBarCode");


		
			UIControlBuilder.BuilderUFControl(this.Memo164, "24");		
		 

				this.FlexFieldPicker0 = UIControlBuilder.BuilderFlexFieldPicker(_UFCard, "FlexFieldPicker0", "True", "True", "True", "Left", 0, "", '.', 60, 0, 170, 20, 6, 4, 1, 1, "100"
				,FlexFieldType.Description,false,false,"","","","c369a74d-e20e-4c52-ac65-3aee8544352f");
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.FlexFieldPicker0, "False", "", null, null, "");
			if(this.FlexFieldPicker0.FlexFieldType==FlexFieldType.Key)
			{

			}
			else
			{		
					}
								

		
			UIControlBuilder.BuilderUFControl(this.FlexFieldPicker0, "25");		
		 

				this.lblIsPrintWrapper238 = UIControlBuilder.BuilderUFLabel(_UFCard, "lblIsPrintWrapper238", "", "True", "True", "Right", 120, 20, 0, 6, 1, 1, "100","96142854-33ed-4a9b-95df-3f54181f180d","0146faeb-02c2-4895-8229-a522011104a9");


								

		
			UIControlBuilder.BuilderUFControl(this.lblIsPrintWrapper238, "25");		


				this.IsPrintWrapper238 = UIControlBuilder.BuilderUFCheckbox(_UFCard, "IsPrintWrapper238", true, true, "Left", 60, 0, 170, 20, 2, 6, 1, 1, "100",false,"lblIsPrintWrapper238","96142854-33ed-4a9b-95df-3f54181f180d","ed6ea009-7f28-4128-a3af-e08283918055");
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.IsPrintWrapper238, "False", "IsPrintWrapper", this.Model.CompleteApplyBarCode, this.Model.CompleteApplyBarCode.FieldIsPrintWrapper, "CompleteApplyBarCode");
		

		
			UIControlBuilder.BuilderUFControl(this.IsPrintWrapper238, "26");		
		 


						
			this.Item578.IsMultiOrg  = false ;
			this.lblItem578.SetMultiOrgInfo(this.Item578,false);
			
														
			this.Operators118.IsMultiOrg  = false ;
			this.lblOperators118.SetMultiOrgInfo(this.Operators118,false);
			
					

            
            container.Controls.Add(_UFCard);
            return _UFCard;
        }

				

				

	                   
        private IUFCard _BuilderControl_Card1(IUFContainer container)
        {
            IUFCard _UFCard = UIControlBuilder.BuildCard(container,"Card1",false,"FunctionBar", true, true, "2","","925602a0-a0fe-4e90-8628-d8f18877e337");
			CommonBuilder.GridLayoutPropBuilder(container, _UFCard, 610, 25, 0, 1, 1, 1, "100");
            CommonBuilder.ContainerGridLayoutPropBuilder(_UFCard, 11, 1, 0, 0, 0, 0, 10, 0);
			InitViewBindingContainer(this, _UFCard,  null, "", "", null, 1, "");
			UIControlBuilder.BuildContainerGridLayout(_UFCard, 0,new GridColumnDef[]{new GridColumnDef(80,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(80,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(80,bool.Parse("True")),new GridColumnDef(60,bool.Parse("True")),new GridColumnDef(80,bool.Parse("True")),new GridColumnDef(30,bool.Parse("True")),new GridColumnDef(80,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(80,bool.Parse("True")),},new GridRowDef[]{new GridRowDef(20,bool.Parse("True")),});
            this.Card1 = _UFCard;

            ///foreach UFCard下的所有控件，增加到此容器





				this.BtnClose = UIControlBuilder.BuilderUFButton(_UFCard, true, "BtnClose", true, true, 80, 20, 10, 0, 1, 1, "100","", this.Model.ElementID,"",false,"020a5365-8f12-4970-b8df-17ce3ae60a68","020a5365-8f12-4970-b8df-17ce3ae60a68","cfd220b2-5b20-409a-abb7-7fa3520a88e5");
	

		
			UIControlBuilder.BuilderUFControl(this.BtnClose, "2");		


				this.BtnOk = UIControlBuilder.BuilderUFButton(_UFCard, true, "BtnOk", true, true, 80, 20, 8, 0, 1, 1, "100","", this.Model.ElementID,"",false,"82330bf1-36f4-411d-808f-be064fef2b78","","82330bf1-36f4-411d-808f-be064fef2b78");
	

		
			UIControlBuilder.BuilderUFControl(this.BtnOk, "1");		



		

            
            container.Controls.Add(_UFCard);
            return _UFCard;
        }





		#endregion
		

	}
}
