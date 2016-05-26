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
            // 添加热键宿主
            HotKeyRegister.PushHost(this);
            // 注册热键
            RegisterHotKey();
        }

        protected override void OnDeactivate(EventArgs e)
        {
            base.OnDeactivate(e);
            this.isActivated = false;
            // 删除热键宿主
            HotKeyRegister.PopHost();
        }

        private bool isActivated = false;

        /// <summary>
        /// 注册热键
        /// </summary>
        protected virtual void RegisterHotKey()
        {
            HotKeyRegister.Register(Keys.Escape); // 注册热键'Esc'
        }

        #region IHotKeyHost 成员

        public virtual void ProcessHotkey(Keys hotKey)
        {
            // 按下按钮ESC，关闭窗体
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