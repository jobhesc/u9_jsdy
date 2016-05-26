using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using PDAClient.PDAService;
using PDAClient.Utils;

namespace PDAClient.Forms
{
    public partial class ChangePasswordForm : BaseForm
    {
        public ChangePasswordForm()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ServiceAgent.Agent.LoginValidate(PDAContext.LoginUserCode, txtOldPassword.Text))
                {
                    MessageBox.Show("旧密码不正确，请重新输入！", "校验失败");
                    txtOldPassword.Focus();
                    txtOldPassword.SelectAll();
                    return;
                }

                if (txtNewPassword.Text != txtNewPassword2.Text)
                {
                    MessageBox.Show("两次输入的新密码不相同！", "校验失败");
                    txtNewPassword.Focus();
                    txtNewPassword.SelectAll();
                    return;
                }

                ServiceAgent.Agent.ChangePassword(PDAContext.LoginUserCode, txtNewPassword2.Text);
                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ExceptionParser.ParseError(ex));
            }
        }

        #region 热键

        protected override void RegisterHotKey()
        {
            HotKeyRegister.Register(Keys.Enter);
            base.RegisterHotKey();
        }

        public override void ProcessHotkey(Keys hotKey)
        {
            if (hotKey == Keys.Enter)
                btnOK_Click(null, null);
            base.ProcessHotkey(hotKey);
        }

        #endregion
    }
}