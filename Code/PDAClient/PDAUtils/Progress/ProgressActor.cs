using System;

using System.Collections.Generic;
using System.Text;
using PDAClient.Progress;
using System.Windows.Forms;
using System.Drawing;
using PDAClient.Utils;

namespace PDAUtils.Progress
{
    /// <summary>
    /// 进度窗体管理类
    /// </summary>
    public class ProgressActor
    {
        ProgressForm progress = new ProgressForm();

        public void Init(int maxValue)
        {
            progress.progressBar1.Minimum = 0;
            progress.progressBar1.Maximum = maxValue;
            progress.progressBar1.Value = 0;

            Application.DoEvents();
        }

        /// <summary>
        /// 显示进度
        /// </summary>
        public void Show()
        {
            // 居中显示
            UIHelper.SetFormToCenter(progress);

            progress.Show();
        }

        /// <summary>
        /// 隐藏进度
        /// </summary>
        public void Hide()
        {
            progress.Hide();
        }

        /// <summary>
        /// 进度提示
        /// </summary>
        public string ProgressHint
        {
            get { return progress.txtInfo.Text; }
            set { progress.txtInfo.Text = value; }
        }

        /// <summary>
        /// 设置进度
        /// </summary>
        /// <param name="value"></param>
        public void SetProgress(int value)
        {
            progress.progressBar1.Value = value;
            Application.DoEvents();
        }
    }
}
