using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using PDAClient.Utils;
using PDAClient.Entities;
using PDAClient.PDAService;
using Symbol.Barcode2;

namespace PDAClient.Forms
{
    public partial class ScanInvCheckBarCodeForm : BaseForm
    {
        #region 类变量

        private InvCheckBarCodeDataSet dataSet = new InvCheckBarCodeDataSet();
        private InvCheckBarCodeDataSet.InvCheckBarCodeRow mainInvCheckRow = null;
        private IScan scanManager = null;
        private TabOrderManager tabOrderManager = null;

        #endregion

        #region 控件事件

        public ScanInvCheckBarCodeForm()
        {
            InitializeComponent();
            // 初始化扫描设备
            scanManager = ScanFactory.CreateScan();
            scanManager.Init();
            scanManager.AttachScanNotify(ScanNotifyHandler);
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (dataSet.InvCheckBarCode.Rows.Count == 0)
            {
                tabOrderManager.Reset();
                return;
            }

            btnSubmit.Enabled = false;
            try
            {
                // 调用服务，提交数据
                ServiceAgent.AddInvCheckBarCodes(dataSet.ToImportDTOs());
                // 更新数据完成后，重新初始化UI
                ClearData();
                // 显示行数
                ShowRowCount();

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

        private void ScanInvCheckBarCodeForm_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            // 初始换界面
            ClearData();
            // 显示行数
            ShowRowCount();

            this.dataGrid1.DataSource = this.dataSet.InvCheckBarCode;
            // 构造tab顺序
            BuildTabOrder();
        }

        void ScanNotifyHandler(ScanDataCollection scancollection)
        {
            ScanData scanData = scancollection.GetFirst;
            if (scanData.Result == Results.SUCCESS)
            {
                txtBarCode.Text = scanData.Text;
                ScanBarCode();
            }
            scanManager.StartScan();
        }

        private void txtBarCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
                ScanBarCode();
        }

        private void ScanInvCheckBarCodeForm_Closing(object sender, CancelEventArgs e)
        {
            if (dataSet.InvCheckBarCode.Rows.Count == 0)
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
            lblRowCount.Text = "行数:" + this.dataSet.InvCheckBarCode.Count;
        }

        /// <summary>
        /// 初始化界面
        /// </summary>
        private void ClearData()
        {
            InitUI();

            dataSet.InvCheckBarCode.Clear();
            mainInvCheckRow = null;
        }

        private void InitUI()
        {
            txtBarCode.Text = "";
            txtInfo.Text = "";
        }

        /// <summary>
        /// 扫描条码
        /// </summary>
        private void ScanBarCode()
        {
            try
            {
                tabOrderManager.Reset();
                string barcode = txtBarCode.Text.Trim();

                if (string.IsNullOrEmpty(barcode)) return;

                BarCodeInfoDTO dto = ServiceAgent.Agent.QueryBarCodeInfo(PDAContext.LoginOrgID, barcode);
                mainInvCheckRow = dataSet.InvCheckBarCode.AddNewRow(dto);

                if (mainInvCheckRow == null)
                    throw new PDAException(txtBarCode, "没有找到该条形码的料品信息！");
                // 料品信息
                txtInfo.Text = mainInvCheckRow.ToString();
                // 显示行数
                ShowRowCount();
                // 焦点定位到最后一行
                this.dataGrid1.Focus();
                this.dataGrid1.CurrentRowIndex = this.dataSet.InvCheckBarCode.Count - 1;
                // 跳转到下一个控件
                tabOrderManager.Next();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ExceptionParser.ParseError(ex));
                tabOrderManager.DealException(ex);
            }
        }

        #endregion

        #region tab顺序

        /// <summary>
        /// 构造tab顺序
        /// </summary>
        private void BuildTabOrder()
        {
            List<TabOrderTrigger> triggers = new List<TabOrderTrigger>();
            triggers.Add(new TabOrderTrigger(txtBarCode, null));
            tabOrderManager = new TabOrderManager(triggers);
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