/**************************************************************
 * Description:
 * CheckBarCodeBListUIModelAction.cs
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

namespace UFIDA.U9.Cust.JSDY.CheckBarCodeBListUIModel
{
	public partial class CheckBarCodeBListUIModelAction : BaseAction
	{
		private static readonly ILogger logger = LoggerManager.GetLogger(typeof(CheckBarCodeBListUIModelAction));
		//强类型化基类Model属性.
		public new CheckBarCodeBListUIModelModel CurrentModel 
		{
			get {
				return (CheckBarCodeBListUIModelModel)base.CurrentModel;
			}
			set {
				base.CurrentModel = value ;
			}
		}
		
		public CheckBarCodeBListUIModelAction(IPart part) : base(part)
		{
		}
		//Model参数的构造,用于测试用例.
		public CheckBarCodeBListUIModelAction(CheckBarCodeBListUIModelModel model) : base(model)
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

			BEQueryStrategyImpl beQryStrategyImpl = new BEQueryStrategyImpl(this.CurrentState, "UFIDA.U9.Cust.JSDY.BarCode.CheckBarCode", "05c71af3-17ec-47d7-a889-27e60df5a5b7", UIGrid.UIView, UIGrid, 1);

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
			BEQueryStrategyImpl beQryStrategyImpl = new BEQueryStrategyImpl(this.CurrentState, "UFIDA.U9.Cust.JSDY.BarCode.CheckBarCode", "05c71af3-17ec-47d7-a889-27e60df5a5b7", UIGrid.UIView, UIGrid, 1);
			beQryStrategyImpl.QueryComponentXMLCompressed = @"7b0HYBxJliUmL23Ke39K9UrX4HShCIBgEyTYkEAQ7MGIzeaS7B1pRyMpqyqBymVWZV1mFkDM7Z28
995777333nvvvfe6O51OJ/ff/z9cZmQBbPbOStrJniGAqsgfP358Hz8ifo1f89f4NX6N/5se/MTz
6+GXf/E3e/x7vFuU6WVeN0W1/Oyj3fHOR2m+nFazYnnx2Ufr9nz74KPf4+jxT6zz+vqkWqyqZb5s
02L22UeTbHe6c35vsj3dnX26vb+/c387+3Tv/vZ5Nr33cG8nm93b3fsoXWaL/LOPTub59O2TrD6p
ZvlP1NcfpbOiWZXZ9YuBb/NmWherllH6KJ3n5Qo/GYk31yt65XnRtPrBV6/OPvto5/70wW52fm97
90E+3d5/MHuwnR0cPNzee5B/ujM7v5/dnzzQ9q+rdT3Nn63LUnr/6tnZ0+PxVw/HJ+umHX/n9dPf
Z6y4jH3EPkq/OvvJIr96WmcXggN++2r1UfoqPz9bnlfPq2wmX5xk03n+0dHjJ1lTTPEV02u6M7uf
7812tz/dPZ9s70+n+9uTfUJxei/7dPYw33u49/DA0KtDoEGKUNdvqrc5f/aqqtqn1OykWrb5u/Yn
s3LNrz4ryjav32STnyyaYlLSZ2/qNQ3npCrXi2X/89dV3fY/FSin71bZcvY8v8zLzz66Z2B0PwWE
7md3iRwvlVJMjoe79/Lde9P72w92dogc5/d2aMbuPSSaTM739g52zvcfWva5LTle1tVP59P27Kn3
x8usnePPJy/P2nwhXz15+eUqrzO8Lh88ffOl+eb4ghj8aVl6fxGkd9f4mwbx1Zk/iPOdTx/s3KdJ
/HS2n2/v7zzItiefZg+2d6dZnj8knssm977JQXx19gWxYmlGsnN/f3Ywy7Lt+7N7+ySCk8n2QT7d
2Z7eP8gfTKa7D7O9c7z0rKoX5p3dvd37B9nk4fb+wd4e/pmR2E7ub092sp2DnXv79z89yFxH9MJs
/3zy6ex8b3t371OaqINzmqPdndn2pw/3H+4/eLiz/3BnwqR5mp9n67I9yZpceV+Ypgn+YrrtPnjw
8MG9/dn25GCXYO7t7m8/zGkck/3zg52Hk93Z/t59QzcrfwH5/os//y/+L/+iP3iQiHf7fU4P9g4+
nZGWogGdE7EeTrYnk4cPtg8+3c127s8efHrvoe0TxOp2+Gf82f/5n7qxw7vhmA05WETob/mFUdmZ
ZQef7u99ur2zs0fztvtguj3J8k+3703v7X46y/b2Jzuffujwve4e7u7T2GY723uf3r9H3VHHD6cz
Iv6nuzt7u/cOdvanD/2Rj2Md0vD/xL/zlh0+yHd29h/Q9D7c2aEOZzs76Ove9t75QxLvAzIb5w+C
DtFHp0Mi9n/+J/3xt+xwtv/g08kkn23vEq9u7987eLD98CFplN2D3fsP7z24d/9eZuf2eNqus/J5
vrxo590+/4a/4L/+s//w//pP/wf/87/nr7hlz7vn558+ODifbt/f2Xuwvf8pmaCDvfvEyfm9g/Od
/MGDyfk0sIL57Mtlp9v/8s/9s/7LP+Tv/i/+zL/jv/4z/7Zbdjt7+GDvPPv0fPvTgwl1m8/2iJln
B9ufTs+n052DycFkd7fT7ZOu2ZVu/7O/5+/ZyNRdNrYfsJjfDR2Do9/w1/jR86PnR8+Pnh89P3p+
9Py/5vl/AA==";
		    
			BeforeGetQryModel_Extend(beQryStrategyImpl);
		    
			CaseModel caseModel = beQryStrategyImpl.GetQryModel();
		    
			AfterGetQueryModel_Extend(caseModel);
		    
			QryService.SetCaseModelToSession((BaseWebForm)(this.CurrentPart), caseModel);
		}
        
        
         #endregion
         

	}
}
