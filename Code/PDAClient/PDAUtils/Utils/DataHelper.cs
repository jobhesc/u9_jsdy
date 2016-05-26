using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Microsoft.WindowsCE.Forms;
using System.IO;
using System.Reflection;

namespace PDAClient.Utils
{
    public class DataHelper
    {
        public static decimal ToDecimal(TextBox textBox)
        {
            string s = textBox.Text;

            if (string.IsNullOrEmpty(s)) return 0;
            try
            {
                return decimal.Parse(s);
            }
            catch
            {
                throw new PDAException(textBox, string.Format("字符串{0} 不是数值类型！", s));
            }
        }

        public static int ToInt(TextBox textBox)
        {
            string s = textBox.Text;

            if (string.IsNullOrEmpty(s)) return 0;
            try
            {
                return int.Parse(s);
            }
            catch
            {
                throw new PDAException(textBox, string.Format("字符串{0} 不是整数类型！", s));
            }
        }
    }
}
