using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using PDAClient.Utils;
using PDAClient.Entities;
using PDAClient.PDAService;
using Symbol.Barcode2;

namespace PDAClient.Forms
{
    public partial class ScanShipBarCodeForm : BaseForm
    {
        #region �����

        private ShipBarCodeDataSet dataSet = new ShipBarCodeDataSet();
        private ShipBarCodeDataSet.ShipBarCodeRow mainRow = null;
        private IScan scanManager = null;
        private TabOrderManager tabOrderManager = new TabOrderManager();
        private ShipPlanDocDTO[] docInfoArray = null;
        
        #endregion

        #region �ؼ��¼�

        public ScanShipBarCodeForm()
        {
            InitializeComponent();
            // ��ʼ��ɨ���豸
            scanManager = ScanFactory.CreateScan();
            scanManager.Init();
            scanManager.AttachScanNotify(ScanNotifyHandler);
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (dataSet.ShipBarCode.Rows.Count == 0)
                return;

            btnSubmit.Enabled = false;
            try
            {
                // ���÷����ύ����
                ServiceAgent.AddShipBarCode(dataSet.ToImportDTOs());
                // ����������ɺ����³�ʼ��UI
                ClearData();
                // ��ʾ����
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

        private void ScanShipBarCodeForm_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            // ��ʼ������
            ClearData();
            // ��ʾ����
            ShowRowCount();

            this.dataGrid1.DataSource = this.dataSet.ShipBarCode;
            // ����tab˳��
            BuildTabOrder(true);
        }

        void ScanNotifyHandler(ScanDataCollection scancollection)
        {
            ScanData scanData = scancollection.GetFirst;
            if (scanData.Result == Results.SUCCESS)
            {
                if (txtDocNo.Focused)  //ɨ�赥��
                {
                    txtDocNo.Text = scanData.Text;
                    ScanDocNo();
                }
                else  //ɨ������
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

        private void ScanShipBarCodeForm_Closing(object sender, CancelEventArgs e)
        {
            if (dataSet.ShipBarCode.Rows.Count == 0)
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
            lblRowCount.Text = "����:" + this.dataSet.ShipBarCode.Count;
        }

        /// <summary>
        /// ��ʼ������
        /// </summary>
        private void ClearData()
        {
            txtDocNo.Text = "";
            txtBarCode.Text = "";
            txtInfo.Text = "";

            dataSet.ShipBarCode.Clear();
            docInfoArray = null;
            mainRow = null;
        }

        /// <summary>
        /// ɨ�赥��
        /// </summary>
        private void ScanDocNo()
        {
            try
            {
                string barcode = txtDocNo.Text.Trim();
                if (string.IsNullOrEmpty(barcode)) return;

                BuildTabOrder(true);
                tabOrderManager.Reset();
                if (dataSet.ShipBarCode.Rows.Count > 0 && MessageBox.Show("����δ�ύ�������룬�Ƿ�ȷ������¼������ƻ����ţ�", "ȷ������ɨ��", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) != DialogResult.OK)
                {
                    tabOrderManager.Next();
                    return;
                }

                txtBarCode.Text = "";
                txtInfo.Text = "";
                dataSet.ShipBarCode.Clear();
                mainRow = null;

                docInfoArray = ServiceAgent.Agent.QueryShipPlanDocInfo(PDAContext.LoginOrgID, barcode);
                if (docInfoArray == null || docInfoArray.Length == 0)
                {
                    throw new PDAException(txtDocNo, "û���ҵ��������Ӧ�����ƻ���Ϣ���߸ó����ƻ����Ѿ���ȫ���⣡");
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
        /// ɨ������
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
                    throw new PDAException(txtDocNo, "����¼������ƻ����Ż���ɨ������ƻ�������");
                }

                BuildTabOrder(false);
                tabOrderManager.Reset();
                BarCodeInfoDTO dto = ServiceAgent.Agent.QueryBarCodeInfo(PDAContext.LoginOrgID, barcode);
                if(dto == null)
                    throw new PDAException(txtBarCode, "û���ҵ������������Ʒ��Ϣ��");

                ShipPlanDocDTO docDTO = MatchCompleteApplyDocDTO(dto);
                if (docDTO == null)
                    throw new PDAException(txtBarCode, "������û��ƥ�䵽�����ƻ���Ϣ����¼������볬���ó����ƻ�����");
                mainRow = dataSet.ShipBarCode.AddNewRow(dto, docDTO.ShipPlanID, docDTO.ShipPlanLineID);

                ShowInfo();
                // ��ʾ����
                ShowRowCount();
                // ���㶨λ�����һ��
                this.dataGrid1.Focus();
                this.dataGrid1.CurrentRowIndex = this.dataSet.ShipBarCode.Count - 1;
                // ��ת����һ���ؼ�
                tabOrderManager.Next();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ExceptionParser.ParseError(ex));
                tabOrderManager.DealException(ex);
            }
        }

        /// <summary>
        /// ƥ������ƻ���Ϣ
        /// </summary>
        /// <param name="dto"></param>
        /// <returns></returns>
        private ShipPlanDocDTO MatchCompleteApplyDocDTO(BarCodeInfoDTO dto)
        {
            if (docInfoArray == null || docInfoArray.Length == 0) return null;
            List<ShipPlanDocDTO> matchedDTOs = new List<ShipPlanDocDTO>();
            foreach (ShipPlanDocDTO docDTO in docInfoArray)
            {
                //������Ʒ+�γ�ƥ��
                if (docDTO.ItemID == dto.ItemID && docDTO.SegLength == dto.ActualLength)
                    matchedDTOs.Add(docDTO);
            }

            if (matchedDTOs.Count == 0)
                throw new PDAException(txtBarCode, "������û��ƥ�䵽�����ƻ���Ϣ");

            //ͳ���Ѿ�¼�������
            Dictionary<long, int> inputedDict = new Dictionary<long, int>();
            foreach (ShipBarCodeDataSet.ShipBarCodeRow barCodeRow in dataSet.ShipBarCode)
            {
                if(barCodeRow.BarCode == dto.BarCode)
                    throw new PDAException(txtBarCode, string.Format("����{0}�Ѿ�ɨ�裬�������ظ�ɨ��", dto.BarCode));

                if (!inputedDict.ContainsKey(barCodeRow.ShipPlanLineID))
                    inputedDict.Add(barCodeRow.ShipPlanLineID, 0);
                inputedDict[barCodeRow.ShipPlanLineID] += 1;

            }

            foreach (ShipPlanDocDTO docDTO in matchedDTOs)
            {
                int inputedCount = (inputedDict.ContainsKey(docDTO.ShipPlanLineID) ? inputedDict[docDTO.ShipPlanLineID] : 0);
                if (inputedCount < docDTO.Count)
                    return docDTO;
            }

            throw new PDAException(txtBarCode, string.Format("����{0}��Ӧ��Ʒ¼��������ѳ��������ƻ��������������������ɨ��", dto.BarCode));
        }

        /// <summary>
        /// ��ʾ�����Ϣ
        /// </summary>
        private void ShowInfo()
        {
            StringBuilder builder = new StringBuilder();
            if (docInfoArray != null && docInfoArray.Length > 0)
            {
                builder.Append("�����ƻ���Ϣ��");
                foreach (ShipPlanDocDTO docDTO in docInfoArray)
                {
                    builder.Append(docDTO.ItemCode + " " + docDTO.Count + "��");
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

        #region tab˳��

        /// <summary>
        /// ����tab˳��
        /// </summary>
        private void BuildTabOrder(Boolean containDocNo)
        {
            tabOrderManager.clearTriggers();
            List<TabOrderTrigger> triggers = new List<TabOrderTrigger>();
            if(containDocNo)
                tabOrderManager.AddTrigger(new TabOrderTrigger(txtDocNo, null));
            tabOrderManager.AddTrigger(new TabOrderTrigger(txtBarCode, null));
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