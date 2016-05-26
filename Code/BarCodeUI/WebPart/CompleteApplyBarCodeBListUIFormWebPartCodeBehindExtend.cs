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
using System.Collections.Generic;
using UFSoft.UBF.ExportService;
using UFIDA.U9.UI.Commands;
using UFIDA.U9.Cust.JSDY.BarCode.Proxy;
using UFIDA.U9.UI.PDHelper;
using UFIDA.U9.Cust.JSDY.BarCode;



/***********************************************************************************************
 * Form ID: 
 * UIFactory Auto Generator 
 ***********************************************************************************************/
namespace UFIDA.U9.Cust.JSDY.CompleteApplyBarCodeBListUIModel
{
    public partial class CompleteApplyBarCodeBListUIFormWebPart
    {
        #region Custome eventBind
		 
				//BtnNew_Click...
		private void BtnNew_Click_Extend(object sender, EventArgs  e)
		{
			//调用模版提供的默认实现.--默认实现可能会调用相应的Action.
            ShowModalDialog("11b5454e-5e56-4c3e-9f96-e30a4f194977", "完工申报条码生成", "630", "375", "", null, false, true, false);
		
			BtnNew_Click_DefaultImpl(sender,e);
		}	
		 
				//BtnDelete_Click...
		private void BtnDelete_Click_Extend(object sender, EventArgs  e)
		{
			//调用模版提供的默认实现.--默认实现可能会调用相应的Action.
			
		
			BtnDelete_Click_DefaultImpl(sender,e);
		}	
		 
				//BtnOutPut_Click...
		private void BtnOutPut_Click_Extend(object sender, EventArgs  e)
		{
			//调用模版提供的默认实现.--默认实现可能会调用相应的Action.
			
		
			BtnOutPut_Click_DefaultImpl(sender,e);
		}	
		 
				//BtnPrint_Click...
		private void BtnPrint_Click_Extend(object sender, EventArgs  e)
		{
			//调用模版提供的默认实现.--默认实现可能会调用相应的Action.
			
		
			BtnPrint_Click_DefaultImpl(sender,e);
		}

        private void BtnPrintBarCode_Click_Extend(object sender, EventArgs e)
        {
            this.Model.ClearErrorMessage();
            IList<IUIRecord> selectedRecords = this.Model.CompleteApplyBarCode.Cache.GetSelectRecord();
            if (selectedRecords == null || selectedRecords.Count == 0)
            {
                IUIModel model = this.Model;
                this.Model.ErrorMessage.SetErrorMessage(ref model, "没有选择需要打印条码的记录！");
                return;
            }

            bool checkFail = false;
            foreach (CompleteApplyBarCodeRecord selectedRecord in selectedRecords)
            {
                //打印外包装允许可以打印条码2次，否则只能允许打印1次
                if (((selectedRecord.IsPrintWrapper ?? false) && selectedRecord.PrintCount >= 2) || (!(selectedRecord.IsPrintWrapper ?? false) && selectedRecord.PrintCount >= 1))
                {
                    IUIRecord record = selectedRecord;
                    string errorMessage = string.Format("条码{0}已经超出打印次数，不允许打印", selectedRecord.BarCode);
                    this.Model.ErrorMessage.SetErrorMessage(ref record, "", errorMessage);
                    checkFail = true;
                }
            }
            if (checkFail) return;

            UIActionEventArgs args = new UIActionEventArgs();
            IExportSettings settings = ExportServiceFactory.GetInstance().CreateExportSettingsObject();
            settings.PrintTemplateCatalogType = printTemplateCatalogType;
            settings.UserDataCallBack = DataCallBackHandle;
            // 打印完成委托
            settings.OnFinished = new FinishCallBackHandle(FinishCallBackHandle);
            args.Tag = settings;

            CommandFactory.DoCommand("OnPrint", this.Action, sender, args);
            
            BtnPrintBarCode_Click_DefaultImpl(sender, e);
        }
			

		//DDLCase_TextChanged...
		private void DDLCase_TextChanged_Extend(object sender, EventArgs  e)
		{
			//调用模版提供的默认实现.--默认实现可能会调用相应的Action.
			
		
			DDLCase_TextChanged_DefaultImpl(sender,e);
		}	
		 
				//OnLookCase_Click...
		private void OnLookCase_Click_Extend(object sender, EventArgs  e)
		{
			//调用模版提供的默认实现.--默认实现可能会调用相应的Action.
			
		
			OnLookCase_Click_DefaultImpl(sender,e);
		}

		
            
            
            

		#region 自定义数据初始化加载和数据收集
		private void OnLoadData_Extend(object sender)
		{	
			OnLoadData_DefaultImpl(sender);
		}
		private void OnDataCollect_Extend(object sender)
		{	
			OnDataCollect_DefaultImpl(sender);
		}
		#endregion  

        #region 自己扩展 Extended Event handler 
		public void AfterOnLoad()
		{
			
			AfterOnLoad_Qry_DefaultImpl();//BE列表自动产生的代码
	    
		}

        public void AfterCreateChildControls()
        {
									
			AfterCreateChildControls_Qry_DefaultImpl();//BE列表自动产生的代码
		

		
        }
        
        public void AfterEventBind()
        {
        }
        
		public void BeforeUIModelBinding()
		{
            if (this.CurrentState["RefreshData"] != null)
            {
                this.CurrentState["RefreshData"] = null;
                this.Action.NavigateAction.Refresh(null);
            }
								
		}

		public void AfterUIModelBinding()
		{
									
			AfterUIModelBinding_Qry_DefaultImpl();//BE列表自动产生的代码
		

		}


        #endregion

        #region 打印数据

        public void FinishCallBackHandle(object sender, FinishCallEventArgs args)
        {
            if (args.ExportStatus == ExportStatus.Sucess)
            {
                ExecuteSqlProxy proxy = new ExecuteSqlProxy();
                proxy.Sql = string.Format(@"
update Cust_CompleteApplyBarCode set PrintedBy='{0}', PrintedOn='{1}', IsPrinted=1, PrintCount=PrintCount+1
where ID in ({2})", PDContext.Current.UserName, DateTime.Now, string.Join(",", GetPrintBarCodeIDs().ToArray()));
                proxy.Do();

                this.Model.CompleteApplyBarCode.PageStrategy.PageBuffer.Clear();
                UIRuntimeHelper.Instance.ClearCache(this.Model.CompleteApplyBarCode);
                this.Action.NavigateAction.Refresh(null);
            }
        }


        // 打印模版分类
        private readonly string printTemplateCatalogType = "UFIDA.U9.Cust.JSDY.BarCode.CompleteApplyBarCode";

        private List<string> GetPrintBarCodeIDs()
        { 
            IList<IUIRecord> selectedRecords = this.Model.CompleteApplyBarCode.Cache.GetSelectRecord();
            List<string> ids = new List<string>();
            foreach (IUIRecord selectedRecord in selectedRecords)
            {
                string id = selectedRecord["ID"].ToString();
                if (!ids.Contains(id))
                {
                    ids.Add(id);
                }
            }
            return ids;
        }

        private void DataCallBackHandle(object sender, DataCallBackEventArgs args)
        {
            DataSet dataSet = new DataSet();
            DataTable table = new DataTable();
            dataSet.Tables.Add(table);
            // 构建表的列
            BuildTableColumns(table);

            GetCompleteApplyBarCodePrintDataProxy getProxy = new GetCompleteApplyBarCodePrintDataProxy();
            getProxy.CompleteApplyBarCodeIDs = GetPrintBarCodeIDs();
            List<CompleteApplyBarCodeDTOData> barCodeDTOs = getProxy.Do();

            if (barCodeDTOs != null && barCodeDTOs.Count > 0)
            {
                foreach (CompleteApplyBarCodeDTOData barCodeDTO in barCodeDTOs)
                {
                    DataRow dataRow = table.NewRow();
                    dataRow["BarCodeID"] = barCodeDTO.BarCodeID;
                    dataRow["BarCode"] = barCodeDTO.BarCode;
                    dataRow["ItemID"] = barCodeDTO.ItemID;
                    dataRow["ItemCode"] = barCodeDTO.ItemCode;
                    dataRow["ItemName"] = barCodeDTO.ItemName;
                    dataRow["ItemSPECS"] = barCodeDTO.ItemSPECS;
                    dataRow["OperatorsID"] = barCodeDTO.OperatorsID;
                    dataRow["OperatorsCode"] = barCodeDTO.OperatorsCode;
                    dataRow["OperatorsName"] = barCodeDTO.OperatorsName;
                    dataRow["ActualLength"] = barCodeDTO.ActualLength;
                    dataRow["MarkingLength"] = barCodeDTO.MarkingLength;
                    table.Rows.Add(dataRow);
                }
            }

            args.ReturnData = dataSet;
        }

        /// <summary>
        /// 构建表的列
        /// </summary>
        /// <param name="table"></param>
        private void BuildTableColumns(DataTable table)
        {
            table.Columns.Clear();
            table.Columns.Add("BarCodeID", typeof(long));
            table.Columns.Add("BarCode");
            table.Columns.Add("ItemID", typeof(long));
            table.Columns.Add("ItemCode");
            table.Columns.Add("ItemName");
            table.Columns.Add("ItemSPECS");
            table.Columns.Add("OperatorsID", typeof(long));
            table.Columns.Add("OperatorsCode");
            table.Columns.Add("OperatorsName");
            table.Columns.Add("ActualLength", typeof(int));
            table.Columns.Add("MarkingLength", typeof(int));
        }

        #endregion

        #endregion
		
    }
}