using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Microsoft.WindowsCE.Forms;

namespace PDAClient.Utils
{
    /// <summary>
    /// �ȼ������ӿ�
    /// </summary>
    public interface IHotKeyHost
    {
        bool IsActivated();
        /// <summary>
        /// �����ȼ��¼�
        /// </summary>
        void ProcessHotkey(Keys hotKey);
    }

    /// <summary>
    /// �ȼ�ע����
    /// </summary>
    public class HotKeyRegister
    {
        private static Stack<IHotKeyHost> hotKeyHosts = new Stack<IHotKeyHost>();
        private static Dictionary<Keys, List<IHotKeyHost>> hotKeyDict = new Dictionary<Keys, List<IHotKeyHost>>();
        private static MessageHost msgHost = null;

        public static void Init()
        {
            if (msgHost == null)
                msgHost = new MessageHost();
            hotKeyHosts.Clear();
            hotKeyDict.Clear();
        }

        public static void Dispose()
        {
            if (msgHost != null)
            {
                foreach (Keys key in hotKeyDict.Keys)
                {
                    // ����ϵͳAPIȡ��ע���ȼ��������ֵ���ɾ�����ȼ�
                    Win32API.UnregisterHotKey(msgHost.Hwnd, (int)key);
                }
                msgHost.Dispose();
            }

            hotKeyHosts.Clear();
            hotKeyDict.Clear();
        }

        /// <summary>
        /// ����ȼ�����
        /// </summary>
        /// <param name="hotKeyHost"></param>
        public static void PushHost(IHotKeyHost hotKeyHost)
        {
            if (hotKeyHost == null) return;
            hotKeyHosts.Push(hotKeyHost);
        }

        /// <summary>
        /// ɾ���ȼ�����
        /// </summary>
        public static void PopHost()
        {
            if (msgHost == null)
                throw new ArgumentException("MessageWindow Ϊ�գ���Ҫ��ִ��Init()������");

            if (hotKeyHosts.Count == 0) return;
            IHotKeyHost hotKeyHost = hotKeyHosts.Pop();

            List<Keys> delKeys = new List<Keys>();
            foreach (Keys key in hotKeyDict.Keys)
            {
                if (hotKeyDict[key].Contains(hotKeyHost))
                    hotKeyDict[key].Remove(hotKeyHost);
                if (hotKeyDict[key].Count == 0)
                {
                    // ����ϵͳAPIȡ��ע���ȼ��������ֵ���ɾ�����ȼ�
                    Win32API.UnregisterHotKey(msgHost.Hwnd, (int)key);
                    delKeys.Add(key);
                }
            }
            foreach (Keys key in delKeys)
                hotKeyDict.Remove(key);
        }

        /// <summary>
        /// ע���ȼ�
        /// </summary>
        /// <param name="vk"></param>
        public static void Register(Keys vk)
        {
            if (msgHost == null)
                throw new ArgumentException("MessageWindow Ϊ�գ���Ҫ��ִ��Init()������");
            if (hotKeyHosts.Count == 0)
                throw new Exception("�ȼ�����ջΪ���쳣��");

            IHotKeyHost hotKeyHost = hotKeyHosts.Peek();
            if (!hotKeyDict.ContainsKey(vk))
            {
                // ����ϵͳAPIע���ȼ�
                Win32API.RegisterHotKey(msgHost.Hwnd, (int)vk, 0, vk);
                hotKeyDict.Add(vk, new List<IHotKeyHost>());
            }
            hotKeyDict[vk].Add(hotKeyHost);
        }

        /// <summary>
        /// ��ǰ�ȼ�����
        /// </summary>
        public static IHotKeyHost CurrentHost
        {
            get
            {
                if (hotKeyHosts.Count == 0) return null;
                return hotKeyHosts.Peek();
            }
        }
    }

    /// <summary>
    /// ��Ϣ������
    /// </summary>
    class MessageHost : MessageWindow
    {
        private const int WM_HOTKEY = 0x0312; // ���m.Msg��ֵΪ0x0312��ô��ʾ�û��������ȼ�

        /// <summary>
        /// ����Windows��Ϣ
        /// </summary>
        /// <param name="m"></param>
        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case WM_HOTKEY:
                    IHotKeyHost hotKey = HotKeyRegister.CurrentHost;
                    if (hotKey != null && hotKey.IsActivated())
                        hotKey.ProcessHotkey((Keys)int.Parse(m.WParam.ToString()));
                    break;
            }
            // ��ϵͳ��Ϣ�����Ը����WndProc 
            base.WndProc(ref m);
        }
    }
}
