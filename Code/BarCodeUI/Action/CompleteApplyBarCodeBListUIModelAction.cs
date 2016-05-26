/**************************************************************
 * Description:
 * CompleteApplyBarCodeBListUIModelAction.cs
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

namespace UFIDA.U9.Cust.JSDY.CompleteApplyBarCodeBListUIModel
{
	public partial class CompleteApplyBarCodeBListUIModelAction : BaseAction
	{
		private static readonly ILogger logger = LoggerManager.GetLogger(typeof(CompleteApplyBarCodeBListUIModelAction));
		//强类型化基类Model属性.
		public new CompleteApplyBarCodeBListUIModelModel CurrentModel 
		{
			get {
				return (CompleteApplyBarCodeBListUIModelModel)base.CurrentModel;
			}
			set {
				base.CurrentModel = value ;
			}
		}
		
		public CompleteApplyBarCodeBListUIModelAction(IPart part) : base(part)
		{
		}
		//Model参数的构造,用于测试用例.
		public CompleteApplyBarCodeBListUIModelAction(CompleteApplyBarCodeBListUIModelModel model) : base(model)
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
		public void OnNew(object sender, UIActionEventArgs e)
		{
			//调用基类委托..
			this.InvokeAction(sender,e,this.OnNew_Extend);
		}
		private void OnNew_DefaultImpl(object sender, UIActionEventArgs e)
		{
	  
	 

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

			BEQueryStrategyImpl beQryStrategyImpl = new BEQueryStrategyImpl(this.CurrentState, "UFIDA.U9.Cust.JSDY.BarCode.CompleteApplyBarCode", "5bcf32d5-7335-4742-8cb4-07ff1e648728", UIGrid.UIView, UIGrid, 1);

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
			BEQueryStrategyImpl beQryStrategyImpl = new BEQueryStrategyImpl(this.CurrentState, "UFIDA.U9.Cust.JSDY.BarCode.CompleteApplyBarCode", "5bcf32d5-7335-4742-8cb4-07ff1e648728", UIGrid.UIView, UIGrid, 1);
			beQryStrategyImpl.QueryComponentXMLCompressed = @"7b0HYBxJliUmL23Ke39K9UrX4HShCIBgEyTYkEAQ7MGIzeaS7B1pRyMpqyqBymVWZV1mFkDM7Z28
995777333nvvvfe6O51OJ/ff/z9cZmQBbPbOStrJniGAqsgfP358Hz8ifo1f89f4NX6N/5se/MTz
6+GXf/63ffx7vFuU6WVeN0W1/Oyj3fHOR2m+nFazYnnx2Ufr9nz74KPf4+jxT6zz+vqkWqyqZb5s
02L22Uf7D7L84Hxnsn2wuzvd3r//8P72ZPf+7va9Tw/OH3y6P509OJh9lC6zRf7ZR3izzNv8eLUq
r59k9Uk1y3+ivv4onRXNqsyuX9zQKm+mdbFqGcWP0nlervCTkXpzvaJXnxdNqx989erss4/uT6bn
9/Zm97cf3Lt3f3v/wf7e9sF0sr+98+D8fDf/dP/gwd6Btn9dretp/mxdloLFV8/Onh6Pv3o4Plk3
7fg7r5/+PmPFZRxD8KP0q7OfLPKrp3V2Ibjgt69WH6Wv8vOz5Xn1vMpm8sVJNp3nHx09fpI1xRRf
CR13H+QH9x8cbE8nO7vb+58+3NnO7u/c355+Or2XP5jsHeyc7xk6dgg2SBnq+k31NufPXlVV+5Sa
nVTLNn/X/mRWrvnVZ0XZ5vWbbPKTRVNMSvrsTb2m4ZxU5Xqx7H/+uqrb/qcC5fTdKlvOnueXefnZ
R/cMjO6ngND97C6R46VSisnxcGc/P3i4e779cPLgwfb+wf5sO5s9nG5n+fnk4f37s8n+g+n7kuNl
Xf10Pm3Pnnp/vMzaOf588vKszRfy1ZOXX67yOsPr8sHTN1+ab44viPGflqX3F0F6d42/aRBfnfmD
yO9PJ9OHDz/d3t87yLf3H957uD3Z393fntzLs4N70+z+g8n9b3IQX519QaxYmpHsHkx3zh/s7RMj
Pci297Ode9sP9/Yfbt87P5/uPNjZuXdv5wFeelbVC/POp/t59uDTfH+b+HGPUN67t31wj0awO7t3
P/90b/Jwdv+B6wgv7E2z2XT30+3Jwx3qZLJzsD25f0B/3ps+2Mnuffrp/U/vM2me5ufZumxPsiZX
3hemaYK/mG7T+we7O/uT6fbs3j2a/PvnD7YP9nc+3d7Js4f7u+c56RWrU6z8BeT7L/78v/g///v/
kv/yL/qDB+l4t9/t/u7kYLo/I/Wwlx8Qz52Ttnj44P52/uDg4aek3vZnu/umW9Cr2+ef8Wf/53/q
xg7vhsM2FGEpob/lF0bl09n984wkYPv+/oQ4Z5p9SpxP9L03ne7f3/10Z3Lv/vk3QAGvx/MHO7Pd
2d4e9bhPPU7uf7r9MH+4uz35dPLpzoMH1O8Dy6sY/DjWJ1HgT/w7b9khDfDTh/nsHnHKAXHa5Jzk
4kGeb396L8v3H9D8Z9M86BB9dDokev/nf9Iff8sOP52RPOzcO9g+yHeJq2ZkpCY0zu29fG96foBv
Mju9x9N2nZXP8+VFO+/2+Tf8Bf/1n/2H/9d/+j/4n/89f8Ute8728umDbDoFbR9Sz/cyou3uwXa+
n3/6MNudTPb3bM9fZPVbMrrxrv+kP+q/+Iv+vv/qb/yD/4u/6I/8L/+yv+e9cPg0m+3uzoi+k08P
7pF92ZluT0iXbu8+uLd/8PD+JJvuWoX6ZN0Uy7xpnmZtj+J/wx/3n/+df/l/+af9rf/FH/OX/xd/
5l/+X/x5f+Et+5/uTPbuzR7sbH+6u09+Qn4/2z44n9F038/v70737x083N8x/Yv6reomymR/6R/0
X/81f9x//if/Wf/l3/dn3J6988nD3Sz/dLb94CEZ1f3pLk3+vd2dbdLA5w+mM2Bmh/9Fvqi6w/7L
/sj/4m/9q27Z18MHWXaPnJ/tnV0I7+xhvp3tkwHY+fTg0/vZ+b3zDHpXObt5WRdkkWfdDv/Ov+W/
+KP/1P/8j/+bbtnnp9n5dPLpHtTwvXPSXTmJ7/79g+2d2fTBg2xn//79Tx+aPrXHL5ddynKH/8Wf
+Xf813/m33bLbrPd83v3ZpO97d0dmLlZNiMh3jvY3nvwcO/hp3vn+/fyTzvdPun6e9Ltf/b3/D23
7PMge3i+d296sD3bOSBPKZ9NSJrIwJ0/2CfDcX/v3u7E9qnk/W6drYinoh3/53/Zn/Gf/3F/+H/1
l/7hpDFvz080jbMJidI2WVJC4mCX5vjefka2L5+dZ3m2QzY2GPhJtV62cYL/dX/xf/Gnb5znu11L
YT9gY3o3dMuPfsNf40fPj54fPT96es//Aw==";
		    
			BeforeGetQryModel_Extend(beQryStrategyImpl);
		    
			CaseModel caseModel = beQryStrategyImpl.GetQryModel();
		    
			AfterGetQueryModel_Extend(caseModel);
		    
			QryService.SetCaseModelToSession((BaseWebForm)(this.CurrentPart), caseModel);
		}
        
        
         #endregion
         

	}
}
