using System;
using System.Text;
using System.Collections;
using System.Xml;
using System.Data;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Resources;
using System.Reflection;
using System.Globalization;
using System.Threading;

using Telerik.WebControls;
using UFSoft.UBF.UI.WebControls;
using UFSoft.UBF.UI.Controls;
using UFSoft.UBF.Util.Log;
using UFSoft.UBF.Util.Globalization;

using UFSoft.UBF.UI.IView;
using UFSoft.UBF.UI.Engine;
using UFSoft.UBF.UI.MD.Runtime;
using UFSoft.UBF.UI.ActionProcess;
using UFSoft.UBF.UI.WebControls.ClientCallBack;
using UFIDA.U9.Cust.JSDY.BarCode.Proxy;
using UFIDA.U9.Cust.JSDY.BarCode;
using System.Collections.Generic;



/***********************************************************************************************
 * Form ID: 
 * UIFactory Auto Generator 
 ***********************************************************************************************/
namespace UFIDA.U9.Cust.JSDY.WhQohQueryUIModel
{
    public partial class WhQohQueryUIFormWebPart
    {
        #region Custome eventBind   
            

		#region 自定义数据初始化加载和数据收集
		private void OnLoadData_Extend(object sender)
		{	
			//OnLoadData_DefaultImpl(sender);
            QueryWhQohProxy proxy = new QueryWhQohProxy();
            proxy.ItemID = this.NameValues["ItemID"].ToString();
            proxy.SegLength = this.NameValues["SegLength"].ToString();
            var whQohInfoDTOs = proxy.Do();

            if (whQohInfoDTOs != null)
            {
                whQohInfoDTOs.ForEach(whQohInfo =>
                {
                    QueryResultViewRecord record = this.Model.QueryResultView.AddNewUIRecord();
                    record.ItemCode = whQohInfo.ItemCode;
                    record.ItemName = whQohInfo.ItemName;
                    record.Wh = whQohInfo.Wh;
                    record.Lot = whQohInfo.Lot;
                    record.SegLength = whQohInfo.SegLength;
                    record.StoreQty = whQohInfo.StoreQty;
                    record.UOM = whQohInfo.UOM;
                    record.UOM_Precision = whQohInfo.UOM_Precision;
                    record.UOM_RoundType = whQohInfo.UOM_RoundType;
                    record.UOM_RoundValue = whQohInfo.UOM_RoundValue;
                });
            }

		}
		private void OnDataCollect_Extend(object sender)
		{	
			OnDataCollect_DefaultImpl(sender);
		}
		#endregion  

        #region 自己扩展 Extended Event handler 
		public void AfterOnLoad()
		{

		}

        public void AfterCreateChildControls()
        {


		
        }
        
        public void AfterEventBind()
        {
        }
        
		public void BeforeUIModelBinding()
		{

		}

		public void AfterUIModelBinding()
		{
            this.BtnClose.IsClientClose = true;
		}


        #endregion
		
        #endregion
		
    }
}