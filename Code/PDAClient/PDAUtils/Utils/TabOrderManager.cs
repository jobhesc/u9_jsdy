using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace PDAClient.Utils
{
    /// <summary>
    /// Tab˳�������
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
        /// ��ת����һ���ؼ�
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
        /// ��ת��ĳ���ؼ�
        /// </summary>
        /// <param name="control"></param>
        public void GoTo(Control control, bool triggerEvent)
        {
            int index = IndexOf(control);
            if (index < 0)
                throw new Exception("�ؼ���tab�������в����ڣ�");

            currIndex = index;
            GoTo(currIndex, triggerEvent);
        }

        /// <summary>
        /// ����
        /// </summary>
        public TabOrderKind Kind
        {
            get { return kind; }
            set { kind = value; }
        }

        /// <summary>
        /// �����쳣
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
                if (kind == TabOrderKind.ѭ��)
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
        private TabOrderKind kind = TabOrderKind.˳��;

    }

    public enum TabOrderKind
    {
        ˳��,
        ѭ��
    }

    /// <summary>
    /// tab������
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
        /// �ؼ�
        /// </summary>
        public Control Control
        {
            get { return control; }
            set { control = value; }
        }

        /// <summary>
        /// �ؼ��ص�����
        /// </summary>
        internal ControlEvent ControlEvent
        {
            get { return controlEvent; }
            set { controlEvent = value; }
        }
    }

    public delegate void ControlEvent(object sender, EventArgs e);
}
