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
        #region �����

        private InvCheckBarCodeDataSet dataSet = new InvCheckBarCodeDataSet();
        private InvCheckBarCodeDataSet.InvCheckBarCodeRow mainInvCheckRow = null;
        private IScan scanManager = null;
        private TabOrderManager tabOrderManager = null;

        #endregion

        #region �ؼ��¼�

        public ScanInvCheckBarCodeForm()
        {
            InitializeComponent();
            // ��ʼ��ɨ���豸
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
                // ���÷����ύ����
                ServiceAgent.AddInvCheckBarCodes(dataSet.ToImportDTOs());
                // ����������ɺ����³�ʼ��UI
                ClearData();
                // ��ʾ����
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
            // ��ʼ������
            ClearData();
            // ��ʾ����
            ShowRowCount();

            this.dataGrid1.DataSource = this.dataSet.InvCheckBarCode;
            // ����tab˳��
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
            else if (MessageBox.Show("����δ�ύ�������룬�Ƿ�ȷ���رգ�", "ȷ���ر�", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.OK)
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

        #region ���ݴ���

        /// <summary>
        /// ��ʾ����
        /// </summary>
        private void ShowRowCount()
        {
            lblRowCount.Text = "����:" + this.dataSet.InvCheckBarCode.Count;
        }

        /// <summary>
        /// ��ʼ������
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
        /// ɨ������
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
                    throw new PDAException(txtBarCode, "û���ҵ������������Ʒ��Ϣ��");
                // ��Ʒ��Ϣ
                txtInfo.Text = mainInvCheckRow.ToString();
                // ��ʾ����
                ShowRowCount();
                // ���㶨λ�����һ��
                this.dataGrid1.Focus();
                this.dataGrid1.CurrentRowIndex = this.dataSet.InvCheckBarCode.Count - 1;
                // ��ת����һ���ؼ�
                tabOrderManager.Next();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ExceptionParser.ParseError(ex));
                tabOrderManager.DealException(ex);
            }
        }

        #endregion

        #region tab˳��

        /// <summary>
        /// ����tab˳��
        /// </summary>
        private void BuildTabOrder()
        {
            List<TabOrderTrigger> triggers = new List<TabOrderTrigger>();
            triggers.Add(new TabOrderTrigger(txtBarCode, null));
            tabOrderManager = new TabOrderManager(triggers);
            tabOrderManager.Kind = TabOrderKind.ѭ��;
            tabOrderManager.Reset();
        }

        #endregion

        #region �ȼ�

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