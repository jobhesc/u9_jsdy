/**************************************************************
 * Description:
 * ProductBarCodeBListUIModelAction.cs
 * Product: U9
 * Co.    : UFIDA Group
 * Author : Auto Generated
 * version: 2.0
 **************************************************************/
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using UFSoft.UBF.Util.Log;
using UFSoft.UBF.UI.MD.Runtime;
using UFSoft.UBF.UI.ActionProcess;
using UFSoft.UBF.UI.IView; 
using System.Data;
using UFIDA.UBF.Query.CommonService;
using UFSoft.UBF.UI.FormProcess;
using UFSoft.UBF.UI.ControlModel;
using UFIDA.UBF.Query.CommonService.QueryStrategy;
using UFIDA.UBF.Query.CaseModel;
using UFIDA.U9.UI.PDHelper;
using UFSoft.UBF.ExportService;

namespace UFIDA.U9.Cust.JSDY.ProductBarCodeBListUIModel
{
	public partial class ProductBarCodeBListUIModelAction : BaseAction
	{
		private static readonly ILogger logger = LoggerManager.GetLogger(typeof(ProductBarCodeBListUIModelAction));
		//强类型化基类Model属性.
		public new ProductBarCodeBListUIModelModel CurrentModel 
		{
			get {
				return (ProductBarCodeBListUIModelModel)base.CurrentModel;
			}
			set {
				base.CurrentModel = value ;
			}
		}
		
		public ProductBarCodeBListUIModelAction(IPart part) : base(part)
		{
		}
		//Model参数的构造,用于测试用例.
		public ProductBarCodeBListUIModelAction(ProductBarCodeBListUIModelModel model) : base(model)
		{
		}
		/// <summary>
		/// Help: 
		/// </summary>
		public void OnLookCase(object sender, UIActionEventArgs e)
		{
			//调用基类委托..
			this.InvokeAction(sender,e,this.OnLookCase_Extend);
		}
		private void OnLookCase_DefaultImpl(object sender, UIActionEventArgs e)
		{
	  
	 
			//加入{action.Name}的代码模版:.\UITpls\UICommonAction.tpl,参数:QryClick
            UFIDA.U9.UI.Commands.CommandFactory.DoCommand("QryClick",this,sender,e);

	  
		}
		/// <summary>
		/// Help: 
		/// </summary>
		public void OnCaseChanged(object sender, UIActionEventArgs e)
		{
			//调用基类委托..
			this.InvokeAction(sender,e,this.OnCaseChanged_Extend);
		}
		private void OnCaseChanged_DefaultImpl(object sender, UIActionEventArgs e)
		{
	  
	        QryService.OnCaseChangedDefault("DDLCase", this.CurrentPart);
		QueryAdjust();
	 

		}
		/// <summary>
		/// Help: 
		/// </summary>
		public void OnOutPut(object sender, UIActionEventArgs e)
		{
			//调用基类委托..
			this.InvokeAction(sender,e,this.OnOutPut_Extend);
		}
		private void OnOutPut_DefaultImpl(object sender, UIActionEventArgs e)
		{
	  
	 
			//加入{action.Name}的代码模版:.\UITpls\UICommonAction.tpl,参数:OnOutPut
            UFIDA.U9.UI.Commands.CommandFactory.DoCommand("OnOutPut",this,sender,e);

	  
		}
		/// <summary>
		/// Help: 
		/// </summary>
		public void OnPrint(object sender, UIActionEventArgs e)
		{
			//调用基类委托..
			this.InvokeAction(sender,e,this.OnPrint_Extend);
		}
		private void OnPrint_DefaultImpl(object sender, UIActionEventArgs e)
		{
	  
	 
			//加入{action.Name}的代码模版:.\UITpls\UICommonAction.tpl,参数:OnPrint
            UFIDA.U9.UI.Commands.CommandFactory.DoCommand("OnPrint",this,sender,e);

	  
		}
		/// <summary>
		/// Help: 
		/// </summary>
		public void OnDelete(object sender, UIActionEventArgs e)
		{
			//调用基类委托..
			this.InvokeAction(sender,e,this.OnDelete_Extend);
		}
		private void OnDelete_DefaultImpl(object sender, UIActionEventArgs e)
		{
	  
	 
			//加入{action.Name}的代码模版:.\UITpls\UICommonAction.tpl,参数:ListDeleteClick
            UFIDA.U9.UI.Commands.CommandFactory.DoCommand("ListDeleteClick",this,sender,e);

	  
		}
		/// <summary>
		/// Help: 
		/// </summary>
		public void OnPrintBarCode(object sender, UIActionEventArgs e)
		{
			//调用基类委托..
			this.InvokeAction(sender,e,this.OnPrintBarCode_Extend);
		}
		private void OnPrintBarCode_DefaultImpl(object sender, UIActionEventArgs e)
		{
	  
	 

		}
		#region Action的内置两个Action.
		/// <summary>
		/// Help: 数据加载(发生在Form的初始化加载时)
		/// </summary>
		public void OnLoadData(object sender, UIActionEventArgs e)
		{
			//UBF扩展处...
			this.OnLoadData_Extend(sender,e) ;
		}
		private void OnLoadData_DefaultImpl(object sender, UIActionEventArgs e)
		{
		   
		     InitCaseModel();
				}
		/// <summary>
		/// Help: 数据收集(发生在Form的CallBack或者是PostBack时)
		/// </summary>
		public void OnDataCollect(object sender, UIActionEventArgs e)
		{
			//UBF扩展处...
			this.OnDataCollect_Extend(sender,e) ;
		}
		private void OnDataCollect_DefaultImpl(object sender, UIActionEventArgs e)
		{
		    UFIDA.U9.UI.Commands.CommandFactory.DoCommand("DataCollect",this,sender,e);
		}
		#endregion
         

            
        #region BE列表自动产生的代码
        
		public void QueryAdjust()
		{
			IUFDataGrid UIGrid = this.CurrentPart.GetUFControlByName(this.CurrentPart.TopLevelContainer, "DataGrid1") as IUFDataGrid;

			BEQueryStrategyImpl beQryStrategyImpl = new BEQueryStrategyImpl(this.CurrentState, "UFIDA.U9.Cust.JSDY.BarCode.ProductBarCode", "05f353bb-cf3e-48e4-ac0e-9f10376d646b", UIGrid.UIView, UIGrid, 1);

			beQryStrategyImpl.Adjust();
		    
			AfterQryAdjust_Extend(UIGrid);

			UIGrid.UIView.CurrentFilter.OPath = CustomFilterOpath_Extend(QryService.GetDefaultOpath((BaseWebForm)(this.CurrentPart)));
			UIGrid.UIView.CurrentFilter.OrderBy = QryService.GetOrderByOpath((BaseWebForm)(this.CurrentPart));

			UIGrid.UIView.Clear();
			this.NavigateAction.FirstPage(null);

			//20090316 UBF2.9_查询_yzx_修改查询设计器的tpl_用于显示多webpart查询的IE状态栏提示信息
			QryService.ShowQueryInfoInIEStatusBar((BaseWebForm)this.CurrentPart, UIGrid.UIView);
		}

		public void InitCaseModel()
		{
			QryService.ClearSession((UFSoft.UBF.UI.FormProcess.BaseWebForm)(this.CurrentPart));
			IUFDataGrid UIGrid = this.CurrentPart.GetUFControlByName(this.CurrentPart.TopLevelContainer, "DataGrid1") as IUFDataGrid;
			BEQueryStrategyImpl beQryStrategyImpl = new BEQueryStrategyImpl(this.CurrentState, "UFIDA.U9.Cust.JSDY.BarCode.ProductBarCode", "05f353bb-cf3e-48e4-ac0e-9f10376d646b", UIGrid.UIView, UIGrid, 1);
			beQryStrategyImpl.QueryComponentXMLCompressed = @"7b0HYBxJliUmL23Ke39K9UrX4HShCIBgEyTYkEAQ7MGIzeaS7B1pRyMpqyqBymVWZV1mFkDM7Z28
995777333nvvvfe6O51OJ/ff/z9cZmQBbPbOStrJniGAqsgfP358Hz8ifo1f89f4NX6N/5se/MTz
6+GXv/+3evx7vFuU6WVeN0W1/Oyj3fHOR2m+nFazYnnx2Ufr9nz74KPf4+jxT6zz+vqkWqyqZb5s
02L22Uf7s9mn9+4d3N+ezvJPt/cPzvPtg/uT+9v3zj+d7e9mn+5n9/Y+SpfZIv/so5d1NVtP2ydZ
fVLN8p+orz9KZ0WzKrPrF4Pf5820LlYto/VROs/LFX4yIm+uV/TS86Jp9YOvXp199tHO/fN79+9N
JtvT83s5IZTvb2fTnXz74fnuzr0Hn84+3f90ou1fV+t6mj9bl6X0/9Wzs6fH468ejk/WTTv+zuun
v89YcRmHqH2UfnX2k0V+9bTOLgQL/PbV6qP0VX5+tjyvnlfZTL44yabz/KOjx0+yppjiK6ZadrB/
kD2cTbfv3Z+db+/PDva3J/fOz7cf7uznk929fOfT3fuGah0iDdKEun5Tvc35s1dV1T6lZifVss3f
tT+ZlWt+9VlRtnn9Jpv8ZNEUk5I+e1OvaTgnVbleLPufv67qtv+pQDl9t8qWs+f5ZV5+9tE9A6P7
KSB0P7tL5HiplGJy7GR7B7PJw93tycGn+9v7Ow8ebmf7D2ZEnfv79/K98/MH+5aJbksOmrGfzqft
2VPvj5dZO8efT16etflCvnry8stVXmd4XT54+uZL883xBbH507L0/iJI767xNw3iqzN/ENl0unN/
98Hudp7t723v3z+nOf303oPt8+mD++f37+2fnx9k3+Qgvjr7glixNCP5dPLpp7Pzhw+2ZzsPptv7
n356bzv79P6n2zvZ7Px+/nAyJc7CS8+qemHemX16PnnwgDhwd7I3AcoH29nk0wfbBw8ekjg/3Nmd
PXjoOqIXzvOHezsH9863H+w+JGnPdj/dPrg3y7d3P53d29vbP5/N9mR+n+bn2bpsT7ImV94XpmmC
v0SDZNnu9PzT6fZk595DIJ5vZ9Tv9vm9Tyfn093d/cmnB4ZuVv4C8v0Xf/5f/F/+RX/wIBHv9vs8
vzd5cPBwurN9b7azSwOfzEj0Hk63H+49fDD99MGD873JvukTxOp2+Gf82f/5n7qxw7vhmA05WETo
b/mFUdndne3sTXYn27uz3YPt/b0DIsTBAyLp7OHk3qf57nRvZ/Khw/e6e7h7b4/0zcPt6d7DGanH
+zTl9+8dbO/t5Q8/3T3PZg/3p/7Ix7EOafh/4t95yw7vn+/ef7Cf7W/vzIhv9ndns+1JRh1+uk+k
35t++vDh+SzoEH10OiRi/+d/0h9/yw53soN7+/cmB9sH08kDUibTyfbk/N7u9vne3v3Jg4wYe8eO
8HjarrPyeb68aOfdPv+Gv+C//rP/8P/6T/8H//O/56+4Zc8PJsQ49w8+3X6wc59Mz9692XZGkrR9
MMn2Z/newfm9/Qem5y+y+i0Z13jXf9If9V/8RX/ff/U3/sH/xV/0R/6Xf9nf8144TO89JOkhQT7Y
u09qYJdM8eThA5rfLNvJ93c+nWQ7Dw0OoviquolO8l/6B/3Xf80f95//yX/Wf/n3/Rm3Z6/swWR2
ntMc33+4S+y18+nD7YdTQuR+fkBewsOM1Lo1bK+n2fLLZbfbP/qv/S/+xD/xv/gz/47/+s/8227Z
58P7n+aT/fMH258e7OzA4mcQ5k+3H852Hp5/uj+Z7eVWgaDPJ12/Q/r8z/6ev+eWHe7v7B7MPt2Z
bu+S7tomvXpOmn6H/jnfmWR7e5/u7O9ZkX1ZF2SCZ5Fx/qn/+R//N73XOEm9T88nB6TX75O/sH9v
OiPlO5luP5juf3p+f7b/MDu3Sku7jQwV3d4w1LtddWU/YHV+N3QDj37DX+NHz4+eHz0/en70/L/8
+X8A";
		    
			BeforeGetQryModel_Extend(beQryStrategyImpl);
		    
			CaseModel caseModel = beQryStrategyImpl.GetQryModel();
		    
			AfterGetQueryModel_Extend(caseModel);
		    
			QryService.SetCaseModelToSession((BaseWebForm)(this.CurrentPart), caseModel);
		}
        
        
         #endregion
         

	}
}
