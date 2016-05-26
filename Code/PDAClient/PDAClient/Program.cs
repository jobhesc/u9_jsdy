using System;
using System.Collections.Generic;
using System.Windows.Forms;
using PDAClient.Utils;
using PDAClient.Forms;
using PDAClient.Entities;
using System.Threading;
using System.Diagnostics;

namespace PDAClient
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [MTAThread]
        static void Main()
        {
            IntPtr hMutex = Win32API.CreateMutex(null, false, "Futureproduct");
            if (Win32API.GetLastError() == Win32API.ERROR_ALREADY_EXISTS)
            {
                Win32API.ReleaseMutex(hMutex);
                return;
            }

            // 初始化热键注册类
            HotKeyRegister.Init();
            try
            {
                // 初始化版本
                OptionsDataSet.Instance.InitOption();

                using (LoginForm loginForm = new LoginForm())
                {
                    if (loginForm.ShowDialog() == DialogResult.OK)
                    {
                        Application.Run(new MainForm());
                    }
                }
            }
            finally
            {
                // 销毁热键注册类
                HotKeyRegister.Dispose();
            }
        }

    }
}