using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace PDAClient.Utils
{
    public class ThemeUtils
    {
        public static void SetTheme(Control control)
        {
            // ×ÖÌå
            //control.Font = new Font("Tahoma", 9F, FontStyle.Regular);
            // ±³¾°É«
            if (control is Button)
                control.BackColor = DarkBackColor;
            else if (control is Panel)
                control.BackColor = DarkBackColor;
            else
                control.BackColor = BackColor;

            if (control is DataGrid)
            {
                (control as DataGrid).BackgroundColor = BackColor;
                (control as DataGrid).HeaderBackColor = DarkBackColor;
                (control as DataGrid).GridLineColor = GridLineColor;
            }

            foreach (Control child in control.Controls)
            {
                SetTheme(child);
            }
        }

        public static Color GridLineColor
        {
            get { return Color.FromArgb(0xFFE13A); }
        }

        public static Color BackColor
        {
            get { return Color.FromArgb(0xFFFFAA); }
        }

        public static Color DarkBackColor
        {
            get { return Color.FromArgb(0xFFE13A); }
        }
    }
}
