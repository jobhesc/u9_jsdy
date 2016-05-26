


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
using UFIDA.UBF.Query.CommonService;
using UFIDA.U9.UI.PDHelper;


/***********************************************************************************************
 * Form ID:4c36e421-ce75-46de-816b-75ea759bc266 
 * Form Name:CompleteApplyBarCodeBListUIForm
 * UIFactory Auto Generator
 ***********************************************************************************************/
namespace UFIDA.U9.Cust.JSDY.CompleteApplyBarCodeBListUIModel
{
	[FormRegister("UFIDA.U9.Cust.JSDY.BarCodeUI","UFIDA.U9.Cust.JSDY.CompleteApplyBarCodeBListUIModel.CompleteApplyBarCodeBListUIFormWebPart", "UFIDA.U9.Cust.JSDY.BarCodeUI.WebPart", "4c36e421-ce75-46de-816b-75ea759bc266","WebPart", "True", 992, 504)] 
	///insert into aspnet_Parts (SysVersion, Path, ClassName, [Assembly], FormId) values (0, 'UFIDA.U9.Cust.JSDY.BarCodeUI', 'UFIDA.U9.Cust.JSDY.CompleteApplyBarCodeBListUIModel.CompleteApplyBarCodeBListUIFormWebPart', 'UFIDA.U9.Cust.JSDY.BarCodeUI.WebPart', '4c36e421-ce75-46de-816b-75ea759bc266')
	///<siteMapNode url="~/erp/simple.aspx?lnk=4c36e421-ce75-46de-816b-75ea759bc266" title="CompleteApplyBarCodeBListUIForm"/>
    public partial class CompleteApplyBarCodeBListUIFormWebPart : UFSoft.UBF.UI.FormProcess.BaseWebForm
    {
		#region Page Controller/Code Behind
        private static readonly ILogger logger = LoggerManager.GetLogger(typeof(CompleteApplyBarCodeBListUIFormWebPart));
        private string assemblyName = System.Reflection.Assembly.GetExecutingAssembly().FullName;
        //private string displayNamePostfix = "displayName";

		#region 强类型化基类属性.
		public new CompleteApplyBarCodeBListUIModelAction Action
		{
			get { return (CompleteApplyBarCodeBListUIModelAction)base.Action; }
			set { base.Action = value; }
		}
		CompleteApplyBarCodeBListUIModelModel _uimodel=null;
		public new CompleteApplyBarCodeBListUIModelModel Model
		{
			get 
			{
			     if(_uimodel == null){
			          _uimodel = new CompleteApplyBarCodeBListUIModelModel();
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
                this.Model = value as CompleteApplyBarCodeBListUIModelModel;
            }
        }
		#endregion 
		public FormAdjust adjust;
        #region variable declaration
        IUFToolbar Toolbar1;
        IUFButton BtnNew;
        IUFButton BtnDelete;
        IUFSeparator Separator0;
        IUFButton BtnOutPut;
        IUFButton BtnPrint;
        IUFButton BtnPrintBarCode;
        IUFCard Card0;
        IUFLabel Label0;
        IUFFldDropDownList DDLCase;
        IUFButton OnLookCase;
        IUFCard Card3;
        IUFDataGrid DataGrid1;
		UpdatePanel updatePanel;
		HiddenField wpFindID;
		IUFContainer topLevelPanel;     
        IUFSeparator SeparatorInFavorites;
        IUFButton BtnDefaultValues;
        #endregion
        
        #region constructor
        public CompleteApplyBarCodeBListUIFormWebPart()
        {
            FormID = "4c36e421-ce75-46de-816b-75ea759bc266";
            IsAutoSize = bool.Parse("True");
        }
        #endregion


	
            
	//获取档案版型结果: 

        #region eventBind and databind
        private void EventBind()
        {
			//事件绑定模板
				//Button控件事件
			this.BtnNew.Click += new EventHandler(BtnNew_Click);		
						
				//Button控件事件
			this.BtnDelete.Click += new EventHandler(BtnDelete_Click);		
						
				//Button控件事件
			this.BtnOutPut.Click += new EventHandler(BtnOutPut_Click);		
						
				//Button控件事件
			this.BtnPrint.Click += new EventHandler(BtnPrint_Click);		
						
				//Button控件事件
			this.BtnPrintBarCode.Click += new EventHandler(BtnPrintBarCode_Click);		
						
							
				//Button控件事件
			this.OnLookCase.Click += new EventHandler(OnLookCase_Click);		
						


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
					this.Model = new CompleteApplyBarCodeBListUIModelModel();
				}
				OnLoadConsumer(new InParameterModel[]{},new InParameterModel[]{});
				OnLoadData(this);
				this.IsDataBinding = true ; //加载完数据要绑定一次.目前加这.
			}
			else
			{
				//去除.已经移入到OnInit()中.
				//this.Model = (CompleteApplyBarCodeBListUIModelModel)this.CurrentState[this.TaskId.ToString()];
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
            this.Action = new CompleteApplyBarCodeBListUIModelAction(this);
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
            IUFContainer _panel = UIControlBuilder.BuildTopLevelContainer(this,"CompleteApplyBarCodeBListUIForm",true,992,504);
            CommonBuilder.ContainerGridLayoutPropBuilder(_panel, 1, 3, 0, 10, 0, 0, 0, 5);
			InitViewBindingContainer(this, _panel,  null, "", "", null, 1, "");
			UIControlBuilder.BuildContainerGridLayout(_panel, 10,new GridColumnDef[]{new GridColumnDef(992,bool.Parse("False")),},new GridRowDef[]{new GridRowDef(28,bool.Parse("True")),new GridRowDef(421,bool.Parse("False")),new GridRowDef(25,bool.Parse("True")),});
            //???还有用么?
            topLevelPanel = _panel;    
            
            UIControlBuilder.BuildCommonControls(this,ref updatePanel,ref wpFindID);
            





	
			_BuilderControl_Toolbar1(_panel);

		
			UIControlBuilder.BuilderUFControl(this.Toolbar1, "1");		


	
			_BuilderControl_Card0(_panel);

		
			UIControlBuilder.BuilderUFControl(this.Card0, "3");		


	
			_BuilderControl_Card3(_panel);

		
			UIControlBuilder.BuilderUFControl(this.Card3, "2");		



			
     
			
			
            EventBind();
            AfterCreateChildControls();
            
        }        







				        
        private void _BuilderControl_Toolbar1(IUFContainer container)
        {
            IUFToolbar _Toolbar = UIControlBuilder.BuilderToolBarControl(container,"Toolbar1",true, true, "1",992, 28, 0, 0, 1, 1,"100");
            this.Toolbar1 = _Toolbar;
            
            ///foreach Toolbar下的所有控件，增加到此容器
                            this.BtnNew = UIControlBuilder.BuilderToolbarButton(_Toolbar, "True", "BtnNew", "True", "True", 35, 28,"1", "N",true,false,"19478b02-d2a9-4d7e-b7af-00070c61ff2d","19478b02-d2a9-4d7e-b7af-00070c61ff2d","bbce8ad3-43b8-4ad1-a1a5-fe7d065d4c4e");
		
            UIControlBuilder.SetButtonAccessKey(this.BtnNew);
            this.BtnNew.UIModel = this.Model.ElementID;
            this.BtnNew.Action = "OnNew";
	                            this.BtnDelete = UIControlBuilder.BuilderToolbarButton(_Toolbar, "True", "BtnDelete", "True", "True", 35, 28,"2", "R",true,false,"0467218f-229b-4954-b2d4-3c5976467f76","0467218f-229b-4954-b2d4-3c5976467f76","289163d1-2961-4791-be19-72d865a80ff7");
		
            UIControlBuilder.SetButtonAccessKey(this.BtnDelete);
            this.BtnDelete.UIModel = this.Model.ElementID;
            this.BtnDelete.Action = "OnDelete";
	                            _Toolbar.Controls.Add(new UFWebToolbarSeparatorAdapter());
			                            this.BtnOutPut = UIControlBuilder.BuilderToolbarButton(_Toolbar, "True", "BtnOutPut", "True", "True", 35, 28,"4", "O",true,false,"688fd549-5a92-49cc-8072-6d5377f6409a","688fd549-5a92-49cc-8072-6d5377f6409a","bea9082e-adc8-479b-85d6-cfdb3b85d2ce");
		
            UIControlBuilder.SetButtonAccessKey(this.BtnOutPut);
            this.BtnOutPut.UIModel = this.Model.ElementID;
            this.BtnOutPut.Action = "OnOutPut";
	                            this.BtnPrint = UIControlBuilder.BuilderToolbarButton(_Toolbar, "True", "BtnPrint", "True", "True", 35, 28,"5", "P",true,false,"27b5c615-cde5-458c-be74-833317249568","27b5c615-cde5-458c-be74-833317249568","8b059c92-9e27-4a28-a11b-b89dd66fa29b");
		
            UIControlBuilder.SetButtonAccessKey(this.BtnPrint);
            this.BtnPrint.UIModel = this.Model.ElementID;
            this.BtnPrint.Action = "OnPrint";
	                            this.BtnPrintBarCode = UIControlBuilder.BuilderToolbarButton(_Toolbar, "True", "BtnPrintBarCode", "True", "True", 67, 28,"6", "",true,false,"89db7a96-a3be-4063-ad5b-7a5f8f260978","89db7a96-a3be-4063-ad5b-7a5f8f260978","27e9b564-e6b5-41db-ac78-5df15d986ccd");
		
            UIControlBuilder.SetButtonAccessKey(this.BtnPrintBarCode);
            this.BtnPrintBarCode.UIModel = this.Model.ElementID;
            this.BtnPrintBarCode.Action = "OnPrintBarCode";
	
            
            ((UFWebToolbarAdapter)_Toolbar).RemoveControls();
        }



	                   
        private IUFCard _BuilderControl_Card0(IUFContainer container)
        {
            IUFCard _UFCard = UIControlBuilder.BuildCard(container,"Card0",false,"FunctionBar", true, true, "3","","09d465be-7210-4271-a298-30dd8252ab81");
			CommonBuilder.GridLayoutPropBuilder(container, _UFCard, 992, 25, 0, 2, 1, 1, "100");
            CommonBuilder.ContainerGridLayoutPropBuilder(_UFCard, 17, 1, 0, 5, 10, 3, 10, 2);
			InitViewBindingContainer(this, _UFCard,  null, "", "", null, 1, "");
			UIControlBuilder.BuildContainerGridLayout(_UFCard, 5,new GridColumnDef[]{new GridColumnDef(80,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(80,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(80,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(80,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(80,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(80,bool.Parse("True")),new GridColumnDef(114,bool.Parse("True")),new GridColumnDef(117,bool.Parse("False")),new GridColumnDef(80,bool.Parse("False")),new GridColumnDef(10,bool.Parse("False")),new GridColumnDef(120,bool.Parse("True")),new GridColumnDef(1,bool.Parse("False")),},new GridRowDef[]{new GridRowDef(20,bool.Parse("True")),});
            this.Card0 = _UFCard;

            ///foreach UFCard下的所有控件，增加到此容器





				this.Label0 = UIControlBuilder.BuilderUFLabel(_UFCard, "Label0", "", "True", "True", "Right", 80, 20, 13, 0, 1, 1, "100","7fb97e0d-d794-43d8-9b10-4ea28a2d6bd3","8c5198cc-5eac-4274-b6e8-ce84f7788e96");


								

		
			UIControlBuilder.BuilderUFControl(this.Label0, "2");		


		        this.DDLCase = UIControlBuilder.BuilderDropDownList(_UFCard, "DDLCase", "", true,  true, true, "Left", 0, 60, 0, 120, 20, 15, 0, 1, 1, "100",true,false,"","","dfc6492f-3980-431d-8d35-745e0a1852ac");
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.DDLCase, "False", "", null, null, "");
			EnumControlsMap.Add(this.DDLCase, _UFCard);
			this.DDLCase.ContentChanged += new EventHandler(DDLCase_TextChanged);
			this.DDLCase.AutoPostBack = true;
		

		
			UIControlBuilder.BuilderUFControl(this.DDLCase, "3");		
		 

				this.OnLookCase = UIControlBuilder.BuilderUFButton(_UFCard, true, "OnLookCase", true, true, 80, 20, 0, 0, 1, 1, "100","", this.Model.ElementID,"OnLookCase",false,"00139537-114d-4f4d-96cf-439440da9da5","00139537-114d-4f4d-96cf-439440da9da5","fc9dcf74-89af-498b-889a-08a6e20d3655");
	

		
			UIControlBuilder.BuilderUFControl(this.OnLookCase, "1");		



			

            
            container.Controls.Add(_UFCard);
            return _UFCard;
        }

	                   
        private IUFCard _BuilderControl_Card3(IUFContainer container)
        {
            IUFCard _UFCard = UIControlBuilder.BuildCard(container,"Card3",false,"none", true, true, "2","","a9ac571d-39f8-42e3-86c4-085259b0226c");
			CommonBuilder.GridLayoutPropBuilder(container, _UFCard, 992, 421, 0, 1, 1, 1, "100");
            CommonBuilder.ContainerGridLayoutPropBuilder(_UFCard, 2, 2, 0, 5, 10, 0, 10, 0);
			InitViewBindingContainer(this, _UFCard,  null, "", "", null, 1, "");
			UIControlBuilder.BuildContainerGridLayout(_UFCard, 5,new GridColumnDef[]{new GridColumnDef(971,bool.Parse("True")),new GridColumnDef(1,bool.Parse("False")),},new GridRowDef[]{new GridRowDef(415,bool.Parse("True")),new GridRowDef(1,bool.Parse("False")),});
            this.Card3 = _UFCard;

            ///foreach UFCard下的所有控件，增加到此容器





	
			_BuilderControl_DataGrid1(_UFCard);

		
			UIControlBuilder.BuilderUFControl(this.DataGrid1, "1");		



	

            
            container.Controls.Add(_UFCard);
            return _UFCard;
        }

				





       
        private void _BuilderControl_DataGrid1(IUFContainer container)
        {
            IUFDataGrid _UFGrid = UIControlBuilder.BuildGridControl("DataGrid1", UFSoft.UBF.UI.ControlModel.EditStatus.Browse, true, true,true,true,true,true,18,true, false) ;
  			UIControlBuilder.BuilderUFControl(_UFGrid, "True", "True", "1");
			CommonBuilder.GridLayoutPropBuilder(container, _UFGrid, 972, 421, 0, 0, 2, 2, "100");
			InitViewBindingContainer(this, _UFGrid,  null, "", "", null, 18, "");
			((UFSoft.UBF.UI.WebControlAdapter.UFWebDataGridAdapter)_UFGrid).PagingStrategy=UFSoft.UBF.UI.ControlModel.GridPagingStrategy.Auto;
			_UFGrid.AllowSelectAllPage=false;
			((UFSoft.UBF.UI.WebControls.UFGrid)_UFGrid).IsSumAllData=false;
		        ((UFSoft.UBF.UI.WebControls.UFGrid)_UFGrid).IsSumSelectedData=false;
            this.DataGrid1 = _UFGrid;
            container.Controls.Add(_UFGrid);



        }





		#endregion
		
		 

		  
        #region BE列表自动生成代码

		private void AfterOnLoad_Qry_DefaultImpl()
		{
			IUIModelProperty mp = this.Model.Properties[UFIDA.UBF.Query.CommonService.QuerySymbol.NeedRefresh];
			if ((mp != null && (bool)mp.Value == true) || !Page.IsPostBack)
			{
				this.Action.QueryAdjust();
				if (mp != null)
				{
					mp.Value = false;
				}
			}
			else
			{
				QryService.SetGridWidthToCase(this.CurrentState, FormID, this.DataGrid1);
			}
		}

		private void AfterCreateChildControls_Qry_DefaultImpl(string bindViewName)
		{
			QryService.GridBindView(this.DataGrid1, bindViewName);
			AttachMakePageEvent();
		}

		private void AfterCreateChildControls_Qry_DefaultImpl()
		{
			QryService.GridBindView(this.DataGrid1, Action.MainView.Name);
			AttachMakePageEvent();
		}

		private void AttachMakePageEvent()
		{
			string message = UFIDA.U9.UI.PDHelper.PDResource.GetDeleteConfirmInfo();
			PDFormMessage.ShowDelConfirmDialog(this.Page, message, "", this.BtnDelete);
			QryService.AttachMakePageEvent(this.Action, this.DataGrid1);
		}

		private void AfterUIModelBinding_Qry_DefaultImpl()
		{
			QryService.BindEnum("DDLCase", this, "5bcf32d5-7335-4742-8cb4-07ff1e648728");
		}

        #endregion
		 

	}
}
