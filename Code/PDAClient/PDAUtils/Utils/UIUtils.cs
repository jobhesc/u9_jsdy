using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace PDAClient.Utils
{
    public class UIHelper
    {
        public static void WaitBegin()
        {
            count++;
            Cursor.Current = Cursors.WaitCursor;
        }

        public static void WaitEnd()
        {
            count--;
            if (count == 0)
                Cursor.Current = Cursors.Default;
            if (count < 0)
                count = 0;
        }

        /// <summary>
        /// 把窗体显示在屏幕中间
        /// </summary>
        /// <param name="form"></param>
        public static void SetFormToCenter(Form form)
        {
            System.Drawing.Point point = new System.Drawing.Point();
            point.X = (Screen.PrimaryScreen.Bounds.Width - form.Width) / 2;
            point.Y = (Screen.PrimaryScreen.Bounds.Height - form.Height) / 2;
            form.Location = point;
        }

        private static int Point(int p)
        {
            throw new NotImplementedException();
        }

        private static int count = 0;
    }
}
