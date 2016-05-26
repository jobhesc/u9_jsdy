


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
 * Form ID:1230c62c-36d0-49da-b9d8-00dcafb3e6b6 
 * Form Name:WhQohQueryUIForm
 * UIFactory Auto Generator
 ***********************************************************************************************/
namespace UFIDA.U9.Cust.JSDY.WhQohQueryUIModel
{
	[FormRegister("UFIDA.U9.Cust.JSDY.BarCodeUI","UFIDA.U9.Cust.JSDY.WhQohQueryUIModel.WhQohQueryUIFormWebPart", "UFIDA.U9.Cust.JSDY.BarCodeUI.WebPart", "1230c62c-36d0-49da-b9d8-00dcafb3e6b6","WebPart", "True", 992, 504)] 
	///insert into aspnet_Parts (SysVersion, Path, ClassName, [Assembly], FormId) values (0, 'UFIDA.U9.Cust.JSDY.BarCodeUI', 'UFIDA.U9.Cust.JSDY.WhQohQueryUIModel.WhQohQueryUIFormWebPart', 'UFIDA.U9.Cust.JSDY.BarCodeUI.WebPart', '1230c62c-36d0-49da-b9d8-00dcafb3e6b6')
	///<siteMapNode url="~/erp/simple.aspx?lnk=1230c62c-36d0-49da-b9d8-00dcafb3e6b6" title="WhQohQueryUIForm"/>
    public partial class WhQohQueryUIFormWebPart : UFSoft.UBF.UI.FormProcess.BaseWebForm
    {
		#region Page Controller/Code Behind
        private static readonly ILogger logger = LoggerManager.GetLogger(typeof(WhQohQueryUIFormWebPart));
        private string assemblyName = System.Reflection.Assembly.GetExecutingAssembly().FullName;
        //private string displayNamePostfix = "displayName";

		#region 强类型化基类属性.
		public new WhQohQueryUIModelAction Action
		{
			get { return (WhQohQueryUIModelAction)base.Action; }
			set { base.Action = value; }
		}
		WhQohQueryUIModelModel _uimodel=null;
		public new WhQohQueryUIModelModel Model
		{
			get 
			{
			     if(_uimodel == null){
			          _uimodel = new WhQohQueryUIModelModel();
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
                this.Model = value as WhQohQueryUIModelModel;
            }
        }
		#endregion 
		public FormAdjust adjust;
        #region variable declaration
        IUFCard Card0;
        IUFButton BtnClose;
        IUFCard Card3;
        IUFDataGrid DataGrid1;
		UpdatePanel updatePanel;
		HiddenField wpFindID;
		IUFContainer topLevelPanel;     
        IUFSeparator SeparatorInFavorites;
        IUFButton BtnDefaultValues;
        #endregion
        
        #region constructor
        public WhQohQueryUIFormWebPart()
        {
            FormID = "1230c62c-36d0-49da-b9d8-00dcafb3e6b6";
            IsAutoSize = bool.Parse("False");
        }
        #endregion


	
            
	//获取档案版型结果: 

        #region eventBind and databind
        private void EventBind()
        {
			//事件绑定模板

	
			//Grid控件的分页事件				
			((UFWebDataGridAdapter)this.DataGrid1).GridMakePageEventHandler += new GridMakePageDelegate(UFGridDataGrid1_GridMakePageEventHandler);
             //Grid控件的客户化筛选，定位事件
            ((UFWebDataGridAdapter)this.DataGrid1).GridCustomFilterHandler += new GridCustomFilterDelegate(UFGridDataGrid1_GridCustomFilterHandler);

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
					this.Model = new WhQohQueryUIModelModel();
				}
				OnLoadConsumer(new InParameterModel[]{},new InParameterModel[]{});
				OnLoadData(this);
				this.IsDataBinding = true ; //加载完数据要绑定一次.目前加这.
			}
			else
			{
				//去除.已经移入到OnInit()中.
				//this.Model = (WhQohQueryUIModelModel)this.CurrentState[this.TaskId.ToString()];
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
            this.Action = new WhQohQueryUIModelAction(this);
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
            IUFContainer _panel = UIControlBuilder.BuildTopLevelContainer(this,"WhQohQueryUIForm",true,992,504);
            CommonBuilder.ContainerGridLayoutPropBuilder(_panel, 1, 3, 0, 10, 0, 0, 0, 5);
			InitViewBindingContainer(this, _panel,  null, "", "", null, 1, "");
			UIControlBuilder.BuildContainerGridLayout(_panel, 10,new GridColumnDef[]{new GridColumnDef(992,bool.Parse("False")),},new GridRowDef[]{new GridRowDef(1,bool.Parse("False")),new GridRowDef(448,bool.Parse("False")),new GridRowDef(25,bool.Parse("True")),});
            //???还有用么?
            topLevelPanel = _panel;    
            
            UIControlBuilder.BuildCommonControls(this,ref updatePanel,ref wpFindID);
            





	
			_BuilderControl_Card0(_panel);

		
			UIControlBuilder.BuilderUFControl(this.Card0, "3");		


	
			_BuilderControl_Card3(_panel);

		
			UIControlBuilder.BuilderUFControl(this.Card3, "2");		



		
     
			
			
            EventBind();
            AfterCreateChildControls();
            
        }        







	                   
        private IUFCard _BuilderControl_Card0(IUFContainer container)
        {
            IUFCard _UFCard = UIControlBuilder.BuildCard(container,"Card0",false,"FunctionBar", true, true, "3","","8fdef067-ea19-488d-a46d-af0cc35a1b99");
			CommonBuilder.GridLayoutPropBuilder(container, _UFCard, 992, 25, 0, 2, 1, 1, "100");
            CommonBuilder.ContainerGridLayoutPropBuilder(_UFCard, 17, 1, 0, 5, 10, 3, 10, 2);
			InitViewBindingContainer(this, _UFCard,  null, "", "", null, 1, "");
			UIControlBuilder.BuildContainerGridLayout(_UFCard, 5,new GridColumnDef[]{new GridColumnDef(80,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(80,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(80,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(80,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(80,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(80,bool.Parse("True")),new GridColumnDef(114,bool.Parse("True")),new GridColumnDef(157,bool.Parse("False")),new GridColumnDef(80,bool.Parse("False")),new GridColumnDef(10,bool.Parse("False")),new GridColumnDef(80,bool.Parse("True")),new GridColumnDef(1,bool.Parse("False")),},new GridRowDef[]{new GridRowDef(20,bool.Parse("True")),});
            this.Card0 = _UFCard;

            ///foreach UFCard下的所有控件，增加到此容器





				this.BtnClose = UIControlBuilder.BuilderUFButton(_UFCard, true, "BtnClose", true, true, 80, 20, 15, 0, 1, 1, "100","", this.Model.ElementID,"",false,"921ad206-7b89-4f37-b3be-d9517a2846eb","","921ad206-7b89-4f37-b3be-d9517a2846eb");
	

		
			UIControlBuilder.BuilderUFControl(this.BtnClose, "0");		



	

            
            container.Controls.Add(_UFCard);
            return _UFCard;
        }

	                   
        private IUFCard _BuilderControl_Card3(IUFContainer container)
        {
            IUFCard _UFCard = UIControlBuilder.BuildCard(container,"Card3",false,"none", true, true, "2","","62336e07-4593-41fa-a362-159d64761221");
			CommonBuilder.GridLayoutPropBuilder(container, _UFCard, 992, 448, 0, 1, 1, 1, "100");
            CommonBuilder.ContainerGridLayoutPropBuilder(_UFCard, 2, 2, 0, 5, 10, 0, 10, 0);
			InitViewBindingContainer(this, _UFCard,  null, "", "", null, 1, "");
			UIControlBuilder.BuildContainerGridLayout(_UFCard, 5,new GridColumnDef[]{new GridColumnDef(971,bool.Parse("True")),new GridColumnDef(1,bool.Parse("False")),},new GridRowDef[]{new GridRowDef(442,bool.Parse("True")),new GridRowDef(1,bool.Parse("False")),});
            this.Card3 = _UFCard;

            ///foreach UFCard下的所有控件，增加到此容器





	
			_BuilderControl_DataGrid1(_UFCard);

		
			UIControlBuilder.BuilderUFControl(this.DataGrid1, "1");		



	

            
            container.Controls.Add(_UFCard);
            return _UFCard;
        }

				





       
        private void _BuilderControl_DataGrid1(IUFContainer container)
        {
            IUFDataGrid _UFGrid = UIControlBuilder.BuildGridControl("DataGrid1", UFSoft.UBF.UI.ControlModel.EditStatus.Browse, true, true,true,true,true,true,18,false, false) ;
  			UIControlBuilder.BuilderUFControl(_UFGrid, "True", "True", "1");
			CommonBuilder.GridLayoutPropBuilder(container, _UFGrid, 971, 448, 0, 0, 1, 2, "100");
			InitViewBindingContainer(this, _UFGrid,  this.Model.QueryResultView, "QueryResultView", "", null, 18, "");
			((UFSoft.UBF.UI.WebControlAdapter.UFWebDataGridAdapter)_UFGrid).PagingStrategy=UFSoft.UBF.UI.ControlModel.GridPagingStrategy.Auto;
			_UFGrid.AllowSelectAllPage=false;
			((UFSoft.UBF.UI.WebControls.UFGrid)_UFGrid).IsSumAllData=false;
		        ((UFSoft.UBF.UI.WebControls.UFGrid)_UFGrid).IsSumSelectedData=false;
            this.DataGrid1 = _UFGrid;
            container.Controls.Add(_UFGrid);



			IUFDataGridColumn column ;
			GridColumn gridColumn ;
	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"ID0","NumberColumnModel", "", 0,this.Model.QueryResultView.Fields["ID"]/*ID*/,"ID", true, false, true, false, false, false, 7, 100, "",true, false,"","bd23db22-cec0-4810-892d-56c5a8a5c48e","bd23db22-cec0-4810-892d-56c5a8a5c48e","e0aeda4f-90c2-417d-88cc-ed12ae9bc767");
			GridControlBuilder.GridNumberColumnBuilder((IUFNumberColumn)column, NumbericType.Numberic, 79228162514264337593543950335m, -79228162514264337593543950335m, null, null, null, null
			,true,"",false,"1","1");
	  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"ItemCode0","TextBoxColumnModel", "", 0,this.Model.QueryResultView.Fields["ItemCode"]/*ItemCode*/,"ItemCode", false, true, true, false, false, true, 0, 200, "50",true, false,"","04608a9a-4967-43b7-bbc8-a50dc4b07445","04608a9a-4967-43b7-bbc8-a50dc4b07445","e2be7bf3-1ad0-4f33-b513-1732d3f82764");
         
			GridControlBuilder.GridTextBoxColumnBuilder((IUFTextBoxColumn)column,"",TextAlign.Left, false,"",false,"1","1","50") ;          
	  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"ItemName0","TextBoxColumnModel", "", 0,this.Model.QueryResultView.Fields["ItemName"]/*ItemName*/,"ItemName", false, true, true, false, false, true, 0, 100, "50",true, false,"","91e031ef-341d-403a-bc51-e9c777dbf70d","91e031ef-341d-403a-bc51-e9c777dbf70d","10fd88ac-1df1-4096-8557-d9f2efd9ad23");
         
			GridControlBuilder.GridTextBoxColumnBuilder((IUFTextBoxColumn)column,"",TextAlign.Left, false,"",false,"1","1","50") ;          
	  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"Wh0","TextBoxColumnModel", "", 0,this.Model.QueryResultView.Fields["Wh"]/*Wh*/,"Wh", false, true, true, false, false, true, 0, 100, "50",true, false,"","ac8283b3-01f5-41dd-8746-c510a51571af","ac8283b3-01f5-41dd-8746-c510a51571af","0cf67924-4bd6-4cc4-a7dd-2648c30401da");
         
			GridControlBuilder.GridTextBoxColumnBuilder((IUFTextBoxColumn)column,"",TextAlign.Left, false,"",false,"1","1","50") ;          
	  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"Lot0","TextBoxColumnModel", "", 0,this.Model.QueryResultView.Fields["Lot"]/*Lot*/,"Lot", false, true, true, false, false, true, 0, 150, "50",true, false,"","d80bd22e-9afc-4026-a057-fe9b62eea3f1","d80bd22e-9afc-4026-a057-fe9b62eea3f1","782fd3c8-4001-4bbb-a4d7-0f3ff3dc6e91");
         
			GridControlBuilder.GridTextBoxColumnBuilder((IUFTextBoxColumn)column,"",TextAlign.Left, false,"",false,"1","1","50") ;          
	  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"SegLength0","NumberColumnModel", "", 0,this.Model.QueryResultView.Fields["SegLength"]/*SegLength*/,"SegLength", false, true, true, false, false, true, 2, 100, "10.0",true, false,"","ddaf03b4-3ad0-4bcb-908b-e7a8bdef0506","ddaf03b4-3ad0-4bcb-908b-e7a8bdef0506","e25a81cc-a089-41b3-9cf6-cbcf67839516");
			GridControlBuilder.GridNumberColumnBuilder((IUFNumberColumn)column, NumbericType.Numberic, 79228162514264337593543950335m, -79228162514264337593543950335m, null, null, null, null
			,true,"",false,"1","1");
	  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"StoreQty0","NumberColumnModel", "", 0,this.Model.QueryResultView.Fields["StoreQty"]/*StoreQty*/,"StoreQty", false, true, true, false, false, true, 8, 100, "18.0",true, false,"","18766b44-b2a2-49c3-97e0-a04ec0bf188f","18766b44-b2a2-49c3-97e0-a04ec0bf188f","106be3e7-44ed-4c61-9b51-31ca598604cd");
			GridControlBuilder.GridNumberColumnBuilder((IUFNumberColumn)column, NumbericType.Numberic, 79228162514264337593543950335m, -79228162514264337593543950335m, this.Model.QueryResultView.FieldUOM_Precision/*UOM_Precision*/, this.Model.QueryResultView.FieldUOM_RoundValue/*UOM_RoundValue*/, this.Model.QueryResultView.FieldUOM_RoundType/*UOM_RoundType*/, null
			,true,"",false,"1","1");
	  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"UOM0","TextBoxColumnModel", "", 0,this.Model.QueryResultView.Fields["UOM"]/*UOM*/,"UOM", false, true, true, false, false, true, 0, 100, "50",true, false,"","d1656cf6-0ddb-47a8-948f-ef57d35245c7","d1656cf6-0ddb-47a8-948f-ef57d35245c7","64fe8041-37a2-485d-8726-6231018545c5");
         
			GridControlBuilder.GridTextBoxColumnBuilder((IUFTextBoxColumn)column,"",TextAlign.Left, false,"",false,"1","1","50") ;          
	  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"UOM_RoundValue0","NumberColumnModel", "", 0,this.Model.QueryResultView.Fields["UOM_RoundValue"]/*UOM_RoundValue*/,"UOM_RoundValue", false, false, true, false, false, true, 2, 100, "10.0",true, false,"","1980cbcd-8670-4b36-93f0-d4c7d2b35b92","1980cbcd-8670-4b36-93f0-d4c7d2b35b92","4bf15325-9e36-4b06-915b-ee62277439db");
			GridControlBuilder.GridNumberColumnBuilder((IUFNumberColumn)column, NumbericType.Numberic, 79228162514264337593543950335m, -79228162514264337593543950335m, null, null, null, null
			,true,"",false,"1","1");
	  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"UOM_RoundType0","NumberColumnModel", "", 0,this.Model.QueryResultView.Fields["UOM_RoundType"]/*UOM_RoundType*/,"UOM_RoundType", false, false, true, false, false, true, 2, 100, "10.0",true, false,"","a9128ff4-706d-4d37-b343-2962451eff33","a9128ff4-706d-4d37-b343-2962451eff33","fe891fb4-5a1b-4042-ab54-c98d0fd43db6");
			GridControlBuilder.GridNumberColumnBuilder((IUFNumberColumn)column, NumbericType.Numberic, 79228162514264337593543950335m, -79228162514264337593543950335m, null, null, null, null
			,true,"",false,"1","1");
	  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"UOM_Precision0","NumberColumnModel", "", 0,this.Model.QueryResultView.Fields["UOM_Precision"]/*UOM_Precision*/,"UOM_Precision", false, false, true, false, false, true, 2, 100, "10.0",true, false,"","440f9ef3-6b40-46ce-8963-bf783cb18899","440f9ef3-6b40-46ce-8963-bf783cb18899","fed5f14f-f2f2-43e8-bd20-f4648ecd16d8");
			GridControlBuilder.GridNumberColumnBuilder((IUFNumberColumn)column, NumbericType.Numberic, 79228162514264337593543950335m, -79228162514264337593543950335m, null, null, null, null
			,true,"",false,"1","1");
	  
		 
        }





		#endregion
		

	}
}
