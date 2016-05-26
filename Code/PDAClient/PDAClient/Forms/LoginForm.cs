using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using PDAClient.PDAService;
using PDAClient.Utils;
using PDAClient.Entities;

namespace PDAClient.Forms
{
    public partial class LoginForm : BaseForm
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string user = txtUser.Text.Trim();
            string password = txtPassword.Text;
            
            if (string.IsNullOrEmpty(user))
            {
                MessageBox.Show("用户名不能为空！", "登陆失败");
                return;
            }

            if (cbOrgList.SelectedIndex < 0)
            {
                MessageBox.Show("组织不能为空！", "登陆失败");
                return;
            }

            btnLogin.Enabled = false;
            try
            {
                if (ServiceAgent.Agent.LoginValidate(user, txtPassword.Text))
                {
                    UserInfoDTO userInfoDTO = ServiceAgent.Agent.QueryUserInfo(user);

                    PDAContext.LoginUserID = userInfoDTO.UserID;
                    PDAContext.LoginUserCode = userInfoDTO.UserCode;
                    PDAContext.LoginUserName = userInfoDTO.UserName;

                    PDAContext.LoginOrgID = orgDict[cbOrgList.SelectedIndex].OrgID;
                    PDAContext.LoginOrgName = orgDict[cbOrgList.SelectedIndex].OrgName;

                    PDAContext.LoginDateTime = DateTime.Now;
                    // 保存登录信息
                    LoginInfoDataSet.Instance.Save(cbSavePassword.Checked, txtPassword.Text);

                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("用户名密码不正确！", "登陆失败");
                    tabOrderManager.GoTo(txtPassword);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ExceptionParser.ParseError(ex));
            }
            finally
            {
                btnLogin.Enabled = true;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            txtUser.Text = LoginInfoDataSet.Instance.CurrentInfo.LastLoginUser;
            txtPassword.Text = LoginInfoDataSet.Instance.CurrentInfo.LastPassword;
            cbSavePassword.Checked = LoginInfoDataSet.Instance.CurrentInfo.IsSavePassword;
            
            // 装载组织信息
            LoadOrgList(txtUser.Text);
            // 构造tab顺序
            BuildTabOrder();
            // 窗体居中
            UIHelper.SetFormToCenter(this);
        }

        private void txtUser_LostFocus(object sender, EventArgs e)
        {
            LoadOrgList(txtUser.Text);
        }

        private void llOptions_Click(object sender, EventArgs e)
        {
            using (SysOptionsForm f = new SysOptionsForm())
            {
                if (f.ShowDialog() == DialogResult.OK)
                {
                    oldUser = string.Empty;
                    LoadOrgList(txtUser.Text);
                }
            }
        }

        private int GetOrgInfoIndex(long orgID)
        {
            if (orgDict.Count == 0) return -1;
            foreach (int key in orgDict.Keys)
                if (orgDict[key].OrgID == orgID)
                    return key;
            return -1;
        }

        /// <summary>
        /// 构造tab顺序
        /// </summary>
        private void BuildTabOrder()
        {
            List<TabOrderTrigger> triggers = new List<TabOrderTrigger>();
            triggers.Add(new TabOrderTrigger(txtUser, null));
            triggers.Add(new TabOrderTrigger(cbOrgList, null));
            triggers.Add(new TabOrderTrigger(txtPassword, null));
            triggers.Add(new TabOrderTrigger(btnLogin, btnLogin_Click));
            tabOrderManager = new TabOrderManager(triggers);
            tabOrderManager.Reset();
        }

        /// <summary>
        /// 装载组织信息
        /// </summary>
        private void LoadOrgList(string user)
        {
            if (user == this.oldUser) return;
            this.oldUser = user;

            cbOrgList.Items.Clear();
            orgDict.Clear();

            try
            {
                OrgInfoDTO[] orgInfos = ServiceAgent.Agent.QueryOrgInfo(user);
                if (orgInfos == null || orgInfos.Length == 0) return;
                foreach (OrgInfoDTO orgInfo in orgInfos)
                    orgDict.Add(cbOrgList.Items.Add(orgInfo.OrgName), orgInfo);

                int selectedIndex = GetOrgInfoIndex(LoginInfoDataSet.Instance.CurrentInfo.LastLoginOrgID);
                if (orgDict.Count > 0)
                {
                    if (selectedIndex < 0)
                        cbOrgList.SelectedIndex = 0;
                    else
                        cbOrgList.SelectedIndex = selectedIndex;
                }
                else
                    cbOrgList.SelectedIndex = -1;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ExceptionParser.ParseError(ex));
            }
        }

        private string oldUser = string.Empty;
        private Dictionary<int, OrgInfoDTO> orgDict = new Dictionary<int, OrgInfoDTO>();
        private TabOrderManager tabOrderManager = null;

        #region 热键

        protected override void RegisterHotKey()
        {
            HotKeyRegister.Register(TabOrderManager.TabOrderKey);
            HotKeyRegister.Register(Keys.F10);
            base.RegisterHotKey();
        }

        public override void ProcessHotkey(Keys hotKey)
        {
            if (hotKey == TabOrderManager.TabOrderKey)
                tabOrderManager.Next();
            else if (hotKey == Keys.F10)
                llOptions_Click(null, null);
            base.ProcessHotkey(hotKey);
        }

        #endregion

    }
}