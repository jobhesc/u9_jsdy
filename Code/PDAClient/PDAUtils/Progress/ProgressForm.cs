using System;

using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PDAClient.Progress
{
    partial class ProgressForm : Form
    {
        public ProgressForm()
        {
            InitializeComponent();
        }

        public void Init(int maxValue)
        {
            this.progressBar1.Minimum = 0;
            this.progressBar1.Maximum = maxValue;
            this.progressBar1.Value = 0;

            Application.DoEvents();
        }

        /// <summary>
        /// 进度提示
        /// </summary>
        public string ProgressHint
        {
            get { return this.txtInfo.Text; }
            set { this.txtInfo.Text = value; }
        }

        /// <summary>
        /// 设置进度
        /// </summary>
        /// <param name="value"></param>
        public void SetProgress(int value)
        {
            this.progressBar1.Value = value;
            Application.DoEvents();
        }
    }
}