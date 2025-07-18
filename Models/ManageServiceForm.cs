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
    public partial class ManageServiceForm : Form
    {
        private readonly LogWriter _logWriter;
        private LogWindow _logWindow;
        private StyledButton StartButton => this.dualButtonPanel1.styledButton1;
        private StyledButton StopButton => this.dualButtonPanel1.styledButton2;
        private StyledButton InstallButton => this.dualButtonPanel2.styledButton1;
        private StyledButton UninstallButton => this.dualButtonPanel2.styledButton2;

        public ManageServiceForm()
        {
            InitializeComponent();
            ComposantsSettings();
            _logWriter = new LogWriter(this.logPrinter);
            _logWriter?.LogInfo("Application Service Manager started successfully.");
        }

        #region Gestion des composants
        private void ComposantsSettings()
        {
            StartButton.Text = "Start";
            StopButton.Text = "Stop";
            InstallButton.Text = "Install Service";
            UninstallButton.Text = "Uninstall Service";

            StartButton.Click += Start_Click;
            StopButton.Click += Stop_Click;
            InstallButton.Click += Install_Click;
            UninstallButton.Click += Uninstall_Click;
        }
        #endregion

        #region Gestion de la fenêtre Logger
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            _logWindow = new LogWindow();
            _logWindow.Show();
            _logWindow.LogInfo("Window Logger started successfully.");
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            _logWindow?.Close();
        }
        #endregion

        #region Méthodes d'événements
        private void Start_Click(object sender, EventArgs e)
        {
            // Logique pour démarrer
            _logWriter?.LogInfo("Service started successfully.");
            _logWindow.LogInfo("WL Service started successfully.");
        }

        private void Stop_Click(object sender, EventArgs e)
        {
            // Logique pour arrêter
        }

        private void Install_Click(object sender, EventArgs e)
        {
            // Logique pour installer le service
            MessageBox.Show("Service installed successfully.");
        }

        private void Uninstall_Click(object sender, EventArgs e)
        {
            // Logique pour désinstaller le service
            MessageBox.Show("Service uninstalled successfully.");
        }
        #endregion
    }
}
