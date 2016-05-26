using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace PDAClient.Utils
{
    /// <summary>
    /// Tab顺序管理类
    /// </summary>
    public class TabOrderManager
    {
        public static Keys TabOrderKey = Keys.Enter;

        public TabOrderManager(List<TabOrderTrigger> triggers)
        {
            this.triggers = triggers;
            foreach(TabOrderTrigger trigger in triggers)
                trigger.Control.GotFocus += new EventHandler(Control_GotFocus);
        }

        public TabOrderManager()
        {
            triggers = new List<TabOrderTrigger>();
        }

        public void AddTrigger(TabOrderTrigger trigger)
        {
            triggers.Add(trigger);
            trigger.Control.GotFocus += new EventHandler(Control_GotFocus);
        }

        public void clearTriggers()
        {
            foreach (TabOrderTrigger trigger in triggers)
                trigger.Control.GotFocus -= new EventHandler(Control_GotFocus);
            triggers.Clear();
        }

        void Control_GotFocus(object sender, EventArgs e)
        {
            Control control = sender as Control;
            GoTo(control);
        }

        public void Reset()
        {
            currIndex = 0;
            GoTo(currIndex, false);
        }

        /// <summary>
        /// 跳转到下一个控件
        /// </summary>
        public void Next()
        {
            currIndex++;
            GoTo(currIndex, true);
        }


        public void GoTo(Control control)
        {
            GoTo(control, false);
        }

        /// <summary>
        /// 跳转到某个控件
        /// </summary>
        /// <param name="control"></param>
        public void GoTo(Control control, bool triggerEvent)
        {
            int index = IndexOf(control);
            if (index < 0)
                throw new Exception("控件在tab管理器中不存在！");

            currIndex = index;
            GoTo(currIndex, triggerEvent);
        }

        /// <summary>
        /// 类型
        /// </summary>
        public TabOrderKind Kind
        {
            get { return kind; }
            set { kind = value; }
        }

        /// <summary>
        /// 处理异常
        /// </summary>
        /// <param name="ex"></param>
        public void DealException(Exception ex)
        {
            if (ex is PDAException)
            {
                PDAException px = ex as PDAException;
                if (px.Control != null)
                    this.GoTo(px.Control);
            }
        }

        private void GoTo(int index, bool triggeEvent)
        {
            if (index > triggers.Count - 1)
            {
                if (kind == TabOrderKind.循环)
                {
                    currIndex = 0;
                    index = 0;
                }
                else
                {
                    currIndex = index = triggers.Count - 1;
                }
            }

            Control currControl = triggers[index].Control;
            currControl.Focus();
            if (currControl is TextBox)
                (currControl as TextBox).SelectAll();

            if (triggers[index].ControlEvent != null && triggeEvent)
                triggers[index].ControlEvent(currControl, new EventArgs());
        }

        private int IndexOf(Control control)
        {
            for (int i = 0; i < triggers.Count; i++)
                if (triggers[i].Control == control)
                    return i;
            return -1;
        }

        private List<TabOrderTrigger> triggers = null;
        private int currIndex = 0;
        private TabOrderKind kind = TabOrderKind.顺序;

    }

    public enum TabOrderKind
    {
        顺序,
        循环
    }

    /// <summary>
    /// tab触发类
    /// </summary>
    public class TabOrderTrigger
    {
        public TabOrderTrigger(Control control, ControlEvent controlEvent)
        {
            this.control = control;
            this.controlEvent = controlEvent;
        }

        private Control control = null;
        private ControlEvent controlEvent = null;

        /// <summary>
        /// 控件
        /// </summary>
        public Control Control
        {
            get { return control; }
            set { control = value; }
        }

        /// <summary>
        /// 控件回调方法
        /// </summary>
        internal ControlEvent ControlEvent
        {
            get { return controlEvent; }
            set { controlEvent = value; }
        }
    }

    public delegate void ControlEvent(object sender, EventArgs e);
}
