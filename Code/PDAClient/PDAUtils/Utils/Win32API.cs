using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace PDAClient.Utils
{
    public class Win32API
    {
        public const int ERROR_ALREADY_EXISTS = 0183;

        //在主窗体需要对Win32 API热键函数进行声明： 
        [DllImport("coredll.dll")] // 定义一个系统范围的热键
        public static extern bool RegisterHotKey(IntPtr hWnd, int id, uint fsModifiers, Keys vk);

        [DllImport("coredll.dll")] // 在系统中注消热键 
        public static extern bool UnregisterHotKey(IntPtr hWnd, int id);

        [DllImport("coredll.Dll")]
        public static extern int GetLastError();

        [DllImport("coredll.Dll")]
        public static extern int ReleaseMutex(IntPtr hMutex);

        [DllImport("coredll.Dll")]
        public static extern IntPtr CreateMutex(SECURITY_ATTRIBUTES lpMutexAttributes, bool bInitialOwner, string lpName); 
        
        [StructLayout(LayoutKind.Sequential)]
        public class SECURITY_ATTRIBUTES 
        { 
            public int nLength; 
            public int lpSecurityDescriptor; 
            public int bInheritHandle;    
        }
    }
}
