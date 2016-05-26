using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using PDAClient.Utils;
using PDAClient.Forms;
using PDAClient.Entities;

namespace PDAClient
{
    public partial class MainForm : BaseForm
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void miChangePassword_Click(object sender, EventArgs e)
        {
            using (ChangePasswordForm f = new ChangePasswordForm())
            {
                f.ShowDialog();
            }
        }

        private void miReset_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (LoginForm f = new LoginForm())
            {
                LoginInfoDataSet.Instance.Reset();
                if (f.ShowDialog() == DialogResult.OK)
                {
                    this.Show();
                    SetStatus();
                }
                else
                    this.Close();
            }
        }

        private void miClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            this.Text = "�������ϵͳ(" + VersionHelper.GetCurrVersion() + ")";

            SetStatus();

            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new EventHandler(timer1_Tick);
        }

        private void SetStatus()
        {
            this.sbMain.Text = string.Format("������:{0} | �û�:{1}", OptionsDataSet.Instance.Host, PDAContext.LoginUserName);
        }

        void timer1_Tick(object sender, EventArgs e)
        {
            this.timer1.Enabled = false;
            DoCheckUpdate();
        }

        private void miOptions_Click(object sender, EventArgs e)
        {
            using (SysOptionsForm f = new SysOptionsForm())
            {
                f.ShowDialog();
                SetStatus();
            }
        }

        protected override void RegisterHotKey()
        {
            HotKeyRegister.Register(Keys.F1); // �����ȼ����ּ�'F1'
            HotKeyRegister.Register(Keys.F2); // �����ȼ����ּ�'F2' 
            HotKeyRegister.Register(Keys.F3); // �����ȼ����ּ�'F3' 
            base.RegisterHotKey();
        }

        public override void ProcessHotkey(Keys hotKey)
        {
            switch (hotKey)
            {
                case Keys.F1:  
                    btnScanAssemblyBarCode_Click(null, null);
                    break;
                case Keys.F2:
                    btnScanShipBarCode_Click(null, null);
                    break;
                case Keys.F3:
                    btnScanCheckBarCode_Click(null, null);
                    break;
            }
            base.ProcessHotkey(hotKey);
        }

        private void MainForm_Closing(object sender, CancelEventArgs e)
        {
            e.Cancel = (MessageBox.Show("�Ƿ�ȷ���ر�ϵͳ��", "�ر�ȷ��", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) != DialogResult.OK);
        }

        private void btnScanAssemblyBarCode_Click(object sender, EventArgs e)
        {
            DoCheckUpdate();
            using (ScanCompleteApplyBarCodeForm f = new ScanCompleteApplyBarCodeForm())
            {
                f.ShowDialog();
            }
        }

        private void btnScanShipBarCode_Click(object sender, EventArgs e)
        {
            DoCheckUpdate();
            using (ScanShipBarCodeForm f = new ScanShipBarCodeForm())
            {
                f.ShowDialog();
            }
        }

        private void btnScanCheckBarCode_Click(object sender, EventArgs e)
        {
            DoCheckUpdate();
            using (ScanInvCheckBarCodeForm f = new ScanInvCheckBarCodeForm())
            {
                f.ShowDialog();
            }
        }

        private void DoCheckUpdate()
        {
            if (!isCheckUpdate) return;

            try
            {
                // ���°汾
                VersionHelper.CheckUpdate(OptionsDataSet.Instance.ServerBaseUrl);
                isCheckUpdate = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ExceptionParser.ParseError(ex));
            }
        }

        private bool isCheckUpdate = true;

        private void miUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (VersionHelper.IsNeedUpdate())
                {
                    VersionHelper.CheckUpdate(OptionsDataSet.Instance.ServerBaseUrl);
                }
                else
                {
                    MessageBox.Show("Ŀǰ�Ѿ������°汾������Ҫ���£�");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ExceptionParser.ParseError(ex));
            }
        }

    }
}