/*
 * ���ļ������⹦�ܣ���˴��������������
 * */
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace PDAClient.Utils
{
    /// <summary>
    /// �����л�������
    /// </summary>
    public class InputSwitcher
    {
        public static void Switch(params TextBox[] textBoxs)
        {
            if (textBoxs == null || textBoxs.Length == 0) return;

            foreach (TextBox textBox in textBoxs)
            {
                textBox.GotFocus += new EventHandler(textBox_GotFocus);
                textBox.LostFocus += new EventHandler(textBox_LostFocus);
            }
        }

        static void textBox_LostFocus(object sender, EventArgs e)
        {
            InputMethod.HideInput();
        }

        static void textBox_GotFocus(object sender, EventArgs e)
        {
            InputMethod.SwitchInput();
        }
    }

    /// <summary>
    /// ���뷨������
    /// </summary>
    public class InputMethod
    {

        private static Microsoft.WindowsCE.Forms.InputPanel inpPanel = new Microsoft.WindowsCE.Forms.InputPanel();
        private static int count;
        /// <summary>
        /// ��ǰ���
        /// </summary>
        private static int curpan = 0;

        static InputMethod()
        {
            count = inpPanel.InputMethods.Count;
            curpan = inpPanel.InputMethods.IndexOf(inpPanel.CurrentInputMethod);
        }        

        /// <summary>
        /// �������뷨
        /// </summary>
        public static void HideInput()
        {
            if (inpPanel.Enabled)
            {
                inpPanel.Enabled = false;
                curpan = 0;
            }
        }

        /// <summary>
        /// �л����뷨
        /// </summary>
        public static void SwitchInput()
        {

            if (!inpPanel.Enabled)
            {                
                inpPanel.CurrentInputMethod = inpPanel.InputMethods[curpan++];
                if (!inpPanel.Enabled) inpPanel.Enabled = true;
            }
            else
            {
                if (curpan == count)
                {
                    inpPanel.Enabled = false;
                    curpan = 0;
                }
                else
                {
                    inpPanel.CurrentInputMethod = inpPanel.InputMethods[curpan++];
                    if (!inpPanel.Enabled) inpPanel.Enabled = true;
                }
            }
            if (curpan > count) curpan = 0;

        }
    }
}
