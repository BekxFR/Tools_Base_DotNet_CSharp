using Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Utils;

namespace Models
{
    public partial class LogWindow : Form, ILogger
    {
        public LogWriter logWriter;
        public LogWindow()
        {
            InitializeComponent();

            logWriter = new LogWriter(this.logPrinter1);
        }

        public void LogInfo(string message)
        {
            logWriter?.LogInfo(message);
        }

        public void LogWarning(string message)
        {
            logWriter?.LogWarning(message);
        }

        public void LogError(string message)
        {
            logWriter?.LogError(message);
        }
    }
}
