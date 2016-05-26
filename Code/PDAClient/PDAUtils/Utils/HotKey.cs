using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Microsoft.WindowsCE.Forms;

namespace PDAClient.Utils
{
    /// <summary>
    /// 热键宿主接口
    /// </summary>
    public interface IHotKeyHost
    {
        bool IsActivated();
        /// <summary>
        /// 处理热键事件
        /// </summary>
        void ProcessHotkey(Keys hotKey);
    }

    /// <summary>
    /// 热键注册类
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
                    // 调用系统API取消注册热键，并从字典中删除该热键
                    Win32API.UnregisterHotKey(msgHost.Hwnd, (int)key);
                }
                msgHost.Dispose();
            }

            hotKeyHosts.Clear();
            hotKeyDict.Clear();
        }

        /// <summary>
        /// 添加热键宿主
        /// </summary>
        /// <param name="hotKeyHost"></param>
        public static void PushHost(IHotKeyHost hotKeyHost)
        {
            if (hotKeyHost == null) return;
            hotKeyHosts.Push(hotKeyHost);
        }

        /// <summary>
        /// 删除热键宿主
        /// </summary>
        public static void PopHost()
        {
            if (msgHost == null)
                throw new ArgumentException("MessageWindow 为空，需要先执行Init()方法！");

            if (hotKeyHosts.Count == 0) return;
            IHotKeyHost hotKeyHost = hotKeyHosts.Pop();

            List<Keys> delKeys = new List<Keys>();
            foreach (Keys key in hotKeyDict.Keys)
            {
                if (hotKeyDict[key].Contains(hotKeyHost))
                    hotKeyDict[key].Remove(hotKeyHost);
                if (hotKeyDict[key].Count == 0)
                {
                    // 调用系统API取消注册热键，并从字典中删除该热键
                    Win32API.UnregisterHotKey(msgHost.Hwnd, (int)key);
                    delKeys.Add(key);
                }
            }
            foreach (Keys key in delKeys)
                hotKeyDict.Remove(key);
        }

        /// <summary>
        /// 注册热键
        /// </summary>
        /// <param name="vk"></param>
        public static void Register(Keys vk)
        {
            if (msgHost == null)
                throw new ArgumentException("MessageWindow 为空，需要先执行Init()方法！");
            if (hotKeyHosts.Count == 0)
                throw new Exception("热键宿主栈为空异常！");

            IHotKeyHost hotKeyHost = hotKeyHosts.Peek();
            if (!hotKeyDict.ContainsKey(vk))
            {
                // 调用系统API注册热键
                Win32API.RegisterHotKey(msgHost.Hwnd, (int)vk, 0, vk);
                hotKeyDict.Add(vk, new List<IHotKeyHost>());
            }
            hotKeyDict[vk].Add(hotKeyHost);
        }

        /// <summary>
        /// 当前热键宿主
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
    /// 消息窗口类
    /// </summary>
    class MessageHost : MessageWindow
    {
        private const int WM_HOTKEY = 0x0312; // 如果m.Msg的值为0x0312那么表示用户按下了热键

        /// <summary>
        /// 监视Windows消息
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
            // 将系统消息传递自父类的WndProc 
            base.WndProc(ref m);
        }
    }
}
