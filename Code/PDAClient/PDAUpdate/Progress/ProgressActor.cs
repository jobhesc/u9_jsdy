using System;

using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace PDAUpdate.Progress
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
            SetFormToCenter(progress);

            progress.Show();
        }

        /// <summary>
        /// 把窗体显示在屏幕中间
        /// </summary>
        /// <param name="form"></param>
        private static void SetFormToCenter(Form form)
        {
            System.Drawing.Point point = new System.Drawing.Point();
            point.X = (Screen.PrimaryScreen.Bounds.Width - form.Width) / 2;
            point.Y = (Screen.PrimaryScreen.Bounds.Height - form.Height) / 2;
            form.Location = point;
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
