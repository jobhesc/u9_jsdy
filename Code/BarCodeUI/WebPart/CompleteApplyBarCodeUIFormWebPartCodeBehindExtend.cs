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
using UFIDA.U9.UI.PDHelper;



/***********************************************************************************************
 * Form ID: 
 * UIFactory Auto Generator 
 ***********************************************************************************************/
namespace UFIDA.U9.Cust.JSDY.CompleteApplyBarCodeUIModel
{
    public partial class CompleteApplyBarCodeUIFormWebPart
    {
        #region Custome eventBind

        private CompleteApplyBarCodeRecord FocusedRecord
        {
            get { return this.Model.CompleteApplyBarCode.FocusedRecord; }
        }

        private void BtnOk_Click_Extend(object sender, EventArgs e)
        {
            this.Model.ClearErrorMessage();
            //获取条码基础部分
            GetBaseBarCodeProxy getBaseBarCode = new GetBaseBarCodeProxy();
            getBaseBarCode.ItemCode = this.FocusedRecord.Item_Code;
            getBaseBarCode.SegLength = this.FocusedRecord.ActualLength;
            getBaseBarCode.BusinessDate = this.FocusedRecord.BusinessDate;
            getBaseBarCode.OperatorCode = this.FocusedRecord.Operators_Code;
            string baseBarCode = getBaseBarCode.Do();
            //获取流水号
            GetBarCodeFlowNoProxy getFlowNo = new GetBarCodeFlowNoProxy();
            getFlowNo.BaseBarCode = baseBarCode;
            int flowNo = getFlowNo.Do();

            //设置条码
            this.FocusedRecord.BarCode = string.Format("{0}{1:000}", baseBarCode, flowNo);

            int qty = this.FocusedRecord.Qty ?? 0;
            if (qty <= 0)
            {
                IUIRecord record = this.FocusedRecord;
                this.Model.ErrorMessage.SetErrorMessage(ref record, this.Model.CompleteApplyBarCode.FieldQty.Name, "盘数必须大于0");
                return;
            }

            for (int i = 0; i < qty - 1; i++)
            {
                CompleteApplyBarCodeRecord newRecord = this.Model.CompleteApplyBarCode.AddNewUIRecord();
                this.FocusedRecord.CopyTo(newRecord);
                newRecord.BarCode = string.Format("{0}{1:000}", baseBarCode, ++flowNo);
                newRecord.DataRecordState = DataRowState.Added;
            }

            this.Action.CommonAction.Save();
            BtnOk_Click_DefaultImpl(sender, e);
            if (!this.Model.ErrorMessage.hasErrorMessage)
            {
                this.CurrentState["RefreshData"] = true;
                this.CloseDialog(true);
            }
        }

		#region 自定义数据初始化加载和数据收集
		private void OnLoadData_Extend(object sender)
		{
            if (this.Model.CompleteApplyBarCode.RecordCount == 0)
                this.Model.CompleteApplyBarCode.AddNewUIRecord();
            this.Model.CompleteApplyBarCode.FocusedRecord = (CompleteApplyBarCodeRecord)this.Model.CompleteApplyBarCode[0];
			//OnLoadData_DefaultImpl(sender);
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
            //取消按钮
            BtnClose.IsClientClose = true;

            //启用个性化
            UFIDA.U9.UI.PDHelper.PersonalizationHelper.SetPersonalizationEnable(this, true);
            //弹性域
            UFIDA.U9.UI.PDHelper.FlexFieldHelper.SetDescFlexField(this.FlexFieldPicker0, this.Model.CompleteApplyBarCode);
        }
        
        public void AfterEventBind()
        {
        }
        
		public void BeforeUIModelBinding()
		{

		}

		public void AfterUIModelBinding()
		{


		}


        #endregion
		
        #endregion
		
    }
}