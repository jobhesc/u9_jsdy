using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using PDAClient.Utils;


namespace PDAClient.Forms
{ 
    public partial class BaseForm : Form, IHotKeyHost
    {
        public BaseForm()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            //ThemeUtils.SetTheme(this);
        }

        protected override void OnActivated(EventArgs e)
        {
            base.OnActivated(e);
            this.isActivated = true;
            // ����ȼ�����
            HotKeyRegister.PushHost(this);
            // ע���ȼ�
            RegisterHotKey();
        }

        protected override void OnDeactivate(EventArgs e)
        {
            base.OnDeactivate(e);
            this.isActivated = false;
            // ɾ���ȼ�����
            HotKeyRegister.PopHost();
        }

        private bool isActivated = false;

        /// <summary>
        /// ע���ȼ�
        /// </summary>
        protected virtual void RegisterHotKey()
        {
            HotKeyRegister.Register(Keys.Escape); // ע���ȼ�'Esc'
        }

        #region IHotKeyHost ��Ա

        public virtual void ProcessHotkey(Keys hotKey)
        {
            // ���°�ťESC���رմ���
            if (hotKey == Keys.Escape)
                this.Close();
        }

        public bool IsActivated()
        {
            return this.isActivated;
        }

        #endregion
    }
}