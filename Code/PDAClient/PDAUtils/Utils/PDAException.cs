using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace PDAClient.Utils
{
    public class PDAException : Exception
    {
        public PDAException(Control c, string message)
            : base(message)
        {
            this.control = c;
        }

        public PDAException(string message)
            : base(message)
        { }

        private Control control = null;

        public Control Control
        {
            get { return control; }
            set { control = value; }
        }
    }
}
