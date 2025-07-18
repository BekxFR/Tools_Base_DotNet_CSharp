using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Common;

namespace Models
{
    public partial class LogPrinter : UserControl, ILogDisplay
    {
        public LogPrinter()
        {
            InitializeComponent();
        }

        public void Print(string msg)
        {
            if (this.textBox1 != null && !this.textBox1.IsDisposed)
            {
                // Ensure the text box is updated on the UI thread
                if (this.textBox1.InvokeRequired)
                {
                    this.textBox1.Invoke(new Action(() => this.textBox1.AppendText(msg + Environment.NewLine)));
                }
                else
                {
                    this.textBox1.AppendText(msg + Environment.NewLine);
                }
            }
        }
    }
}
