using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Forms;
using PDAClient.Utils;
using PDAClient.Entities;
using PDAClient.PDAService;
using Symbol.Barcode2;

namespace PDAClient.Forms
{
    public partial class ScanCompleteApplyBarCodeForm : BaseForm
    {
        #region 类变量

        private CompleteApplyBarCodeDataSet dataSet = new CompleteApplyBarCodeDataSet();
        private CompleteApplyBarCodeDataSet.CompleteApplyBarCodeRow mainRow = null;
        private IScan scanManager = null;
        private TabOrderManager tabOrderManager = new TabOrderManager();
        private CompleteApplyDocDTO[] docInfoArray = null;
        
        #endregion

        #region 控件事件

        public ScanCompleteApplyBarCodeForm()
        {
            InitializeComponent();
            // 初始化扫描设备
            scanManager = ScanFactory.CreateScan();
            scanManager.Init();
            scanManager.AttachScanNotify(ScanNotifyHandler);
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (dataSet.CompleteApplyBarCode.Rows.Count == 0)
                return;

            btnSubmit.Enabled = false;
            try
            {
                // 调用服务，提交数据
                ServiceAgent.AddCompleteApplyBarCode(dataSet.ToImportDTOs());
                // 更新数据完成后，重新初始化UI
                ClearData();
                // 显示行数
                ShowRowCount();

                BuildTabOrder(true);
                tabOrderManager.Reset();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ExceptionParser.ParseError(ex));
                tabOrderManager.DealException(ex);
            }
            finally
            {
                btnSubmit.Enabled = true;
            }
        }

        private void ScanCompleteApplyBarCodeForm_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            // 初始换界面
            ClearData();
            // 显示行数
            ShowRowCount();

            this.dataGrid1.DataSource = this.dataSet.CompleteApplyBarCode;
            // 构造tab顺序
            BuildTabOrder(true);
        }

        void ScanNotifyHandler(ScanDataCollection scancollection)
        {
            ScanData scanData = scancollection.GetFirst;
            if (scanData.Result == Results.SUCCESS)
            {
                if (txtDocNo.Focused)  //扫描单号
                {
                    txtDocNo.Text = scanData.Text;
                    ScanDocNo();
                }
                else  //扫描条码
                {
                    txtBarCode.Text = scanData.Text;
                    ScanBarCode();
                }
            }
            scanManager.StartScan();
        }

        private void txtDocNo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
                ScanDocNo();
        }

        private void txtBarCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
                ScanBarCode();
        }

        private void ScanCompleteApplyBarCodeForm_Closing(object sender, CancelEventArgs e)
        {
            if (dataSet.CompleteApplyBarCode.Rows.Count == 0)
                e.Cancel = false;
            else if (MessageBox.Show("存在未提交的条形码，是否确定关闭？", "确定关闭", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.OK)
                e.Cancel = false;
            else
                e.Cancel = true;
        }

        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            scanManager.DoDispose();
        }

        protected override void OnActivated(EventArgs e)
        {
            base.OnActivated(e);
            scanManager.StartScan();
        }

        protected override void OnDeactivate(EventArgs e)
        {
            base.OnDeactivate(e);
            scanManager.StopScan();
        }

        #endregion

        #region 数据处理

        /// <summary>
        /// 显示行数
        /// </summary>
        private void ShowRowCount()
        {
            lblRowCount.Text = "行数:" + this.dataSet.CompleteApplyBarCode.Count;
        }

        /// <summary>
        /// 初始化界面
        /// </summary>
        private void ClearData()
        {
            txtDocNo.Text = "";
            txtBarCode.Text = "";
            txtInfo.Text = "";

            dataSet.CompleteApplyBarCode.Clear();
            docInfoArray = null;
            mainRow = null;
        }

        /// <summary>
        /// 扫描单号
        /// </summary>
        private void ScanDocNo()
        {
            try
            {
                string barcode = txtDocNo.Text.Trim();
                if (string.IsNullOrEmpty(barcode)) return;

                BuildTabOrder(true);
                tabOrderManager.Reset();
                if (dataSet.CompleteApplyBarCode.Rows.Count > 0 && MessageBox.Show("存在未提交的条形码，是否确定重新录入申报单？", "确定重新扫单", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) != DialogResult.OK)
                {
                    tabOrderManager.Next();
                    return;
                }

                txtBarCode.Text = "";
                txtInfo.Text = "";
                dataSet.CompleteApplyBarCode.Clear();
                mainRow = null;

                docInfoArray = ServiceAgent.Agent.QueryCompleteApplyDocInfo(PDAContext.LoginOrgID, barcode);
                if (docInfoArray == null || docInfoArray.Length == 0)
                {
                    throw new PDAException(txtDocNo, "没有找到该条码对应申报单信息或者该申报单已经完全入库！");
                }
                ShowInfo();
                tabOrderManager.Next();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ExceptionParser.ParseError(ex));
                tabOrderManager.DealException(ex);
            }
        }

        /// <summary>
        /// 扫描条码
        /// </summary>
        private void ScanBarCode()
        {
            try
            {
                string barcode = txtBarCode.Text.Trim();
                if (string.IsNullOrEmpty(barcode)) return;

                if (docInfoArray == null || docInfoArray.Length == 0)
                {
                    BuildTabOrder(true);
                    throw new PDAException(txtDocNo, "请先录入申报单号或者扫描申报单条码");
                }

                BuildTabOrder(false);
                tabOrderManager.Reset();
                BarCodeInfoDTO dto = ServiceAgent.Agent.QueryBarCodeInfo(PDAContext.LoginOrgID, barcode);
                if(dto == null)
                    throw new PDAException(txtBarCode, "没有找到该条形码的料品信息！");

                CompleteApplyDocDTO docDTO = MatchCompleteApplyDocDTO(dto);
                if (docDTO == null)
                    throw new PDAException(txtBarCode, "该条码没有匹配到申报单信息或者录入的条码超过该申报单！");
                mainRow = dataSet.CompleteApplyBarCode.AddNewRow(dto, docDTO.MoDocNo, docDTO.CompleteApplyDocID, docDTO.CompleteApplyLineID);

                ShowInfo();
                // 显示行数
                ShowRowCount();
                // 焦点定位到最后一行
                this.dataGrid1.Focus();
                this.dataGrid1.CurrentRowIndex = this.dataSet.CompleteApplyBarCode.Count - 1;
                // 跳转到下一个控件
                tabOrderManager.Next();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ExceptionParser.ParseError(ex));
                tabOrderManager.DealException(ex);
            }
        }

        /// <summary>
        /// 匹配完工申报信息
        /// </summary>
        /// <param name="dto"></param>
        /// <returns></returns>
        private CompleteApplyDocDTO MatchCompleteApplyDocDTO(BarCodeInfoDTO dto)
        {
            if (docInfoArray == null || docInfoArray.Length == 0) return null;
            List<CompleteApplyDocDTO> matchedDTOs = new List<CompleteApplyDocDTO>();
            foreach (CompleteApplyDocDTO docDTO in docInfoArray)
            {
                //按照料品+段长匹配
                if (docDTO.ItemID == dto.ItemID && docDTO.SegLength == dto.ActualLength)
                    matchedDTOs.Add(docDTO);
            }

            if (matchedDTOs.Count == 0)
                throw new PDAException(txtBarCode, "该条码没有匹配到申报单信息");

            //统计已经录入的盘数
            Dictionary<long, int> inputedDict = new Dictionary<long, int>();
            foreach (CompleteApplyBarCodeDataSet.CompleteApplyBarCodeRow barCodeRow in dataSet.CompleteApplyBarCode)
            {
                if(barCodeRow.BarCode == dto.BarCode)
                    throw new PDAException(txtBarCode, string.Format("条码{0}已经扫描，不允许重复扫描", dto.BarCode));

                if (!inputedDict.ContainsKey(barCodeRow.CompleteApplyDocLineID))
                    inputedDict.Add(barCodeRow.CompleteApplyDocLineID, 0);
                inputedDict[barCodeRow.CompleteApplyDocLineID] += 1;

            }

            foreach (CompleteApplyDocDTO docDTO in matchedDTOs)
            {
                int inputedCount = (inputedDict.ContainsKey(docDTO.CompleteApplyLineID) ? inputedDict[docDTO.CompleteApplyLineID] : 0);
                if (inputedCount < docDTO.Count)
                    return docDTO;
            }

            throw new PDAException(txtBarCode, string.Format("条码{0}对应料品录入的数量已超过申报单所允许的数量，不允许扫描", dto.BarCode));
        }

        /// <summary>
        /// 显示相关信息
        /// </summary>
        private void ShowInfo()
        {
            StringBuilder builder = new StringBuilder();
            if (docInfoArray != null && docInfoArray.Length > 0)
            {
                builder.Append("申报单信息：");
                foreach (CompleteApplyDocDTO docDTO in docInfoArray)
                {
                    builder.Append(docDTO.MoDocNo + " " + docDTO.Count + "盘");
                    builder.Append(",");
                }
                builder = builder.Remove(builder.Length - 1, 1);
                builder.Append("\r\n");
            }
            if (mainRow != null)
            {
                builder.Append(mainRow.ToString());
            }
            txtInfo.Text = builder.ToString();
        }

        #endregion

        #region tab顺序

        /// <summary>
        /// 构造tab顺序
        /// </summary>
        private void BuildTabOrder(Boolean containDocNo)
        {
            tabOrderManager.clearTriggers();
            List<TabOrderTrigger> triggers = new List<TabOrderTrigger>();
            if(containDocNo)
                tabOrderManager.AddTrigger(new TabOrderTrigger(txtDocNo, null));
            tabOrderManager.AddTrigger(new TabOrderTrigger(txtBarCode, null));
            tabOrderManager.Kind = TabOrderKind.循环;
            tabOrderManager.Reset();
        }

        #endregion

        #region 热键

        protected override void RegisterHotKey()
        {
            HotKeyRegister.Register(Keys.F10);
            HotKeyRegister.Register(Keys.Enter);

            base.RegisterHotKey();
        }

        public override void ProcessHotkey(Keys hotKey)
        {
            if (hotKey == Keys.F10)
                tabOrderManager.Next();
            if (hotKey == Keys.Enter)
                btnSubmit_Click(null, null);
            base.ProcessHotkey(hotKey);
        }

        #endregion


    }
}