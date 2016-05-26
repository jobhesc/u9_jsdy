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

        //����������Ҫ��Win32 API�ȼ��������������� 
        [DllImport("coredll.dll")] // ����һ��ϵͳ��Χ���ȼ�
        public static extern bool RegisterHotKey(IntPtr hWnd, int id, uint fsModifiers, Keys vk);

        [DllImport("coredll.dll")] // ��ϵͳ��ע���ȼ� 
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
