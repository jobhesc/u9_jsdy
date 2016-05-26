using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using PDAClient.Utils;
using PDAClient.Entities;

namespace PDAClient.Forms
{
    public partial class SysOptionsForm : BaseForm
    {
        public SysOptionsForm()
        {
            InitializeComponent();
        }

        private void SysOptionsForm_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            txtServiceUrl.Text = OptionsDataSet.Instance.Host;
            txtTimeout.Text = OptionsDataSet.Instance.ConnTimeout.ToString();
            txtMaxConnCount.Text = OptionsDataSet.Instance.MaxConnCount.ToString();

            BuildTabOrder();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            btnOK.Enabled = false;
            try
            {
                OptionsDataSet.Instance.Host = txtServiceUrl.Text;
                OptionsDataSet.Instance.ConnTimeout = DataHelper.ToInt(txtTimeout);
                OptionsDataSet.Instance.MaxConnCount = DataHelper.ToInt(txtMaxConnCount);
                // 测试连接
                ServiceAgent.TestConn();
                OptionsDataSet.Instance.Save();

                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ExceptionParser.ParseError(ex));
                OptionsDataSet.Instance.Rollback();
                tabOrderManager.DealException(ex);
            }
            finally
            {
                btnOK.Enabled = true;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        /// <summary>
        /// 构造tab顺序
        /// </summary>
        private void BuildTabOrder()
        {
            List<TabOrderTrigger> triggers = new List<TabOrderTrigger>();
            triggers.Add(new TabOrderTrigger(txtServiceUrl, null));
            triggers.Add(new TabOrderTrigger(txtTimeout, null));
            triggers.Add(new TabOrderTrigger(txtMaxConnCount, null));
            triggers.Add(new TabOrderTrigger(btnOK, btnOK_Click));
            tabOrderManager = new TabOrderManager(triggers);
            tabOrderManager.Reset();
        }

        private TabOrderManager tabOrderManager = null;

        #region 热键

        protected override void RegisterHotKey()
        {
            HotKeyRegister.Register(TabOrderManager.TabOrderKey);
            base.RegisterHotKey();
        }

        public override void ProcessHotkey(Keys hotKey)
        {
            if (hotKey == TabOrderManager.TabOrderKey)
                tabOrderManager.Next();
            base.ProcessHotkey(hotKey);
        }

        #endregion
    }
}