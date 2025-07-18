using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceProcess;
using System.Windows.Forms;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace MonitoringService
{
    internal static class Program
    {
        public const string SERVICE_NAME = "MONITORINGSYSTEM";
        public const string DISPLAY_NAME = "MONITORINGSYSTEM";
        public const string SERVICE_DESCRIPTION = "Système de monitoring des services Generic";

        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                if (!Environment.UserInteractive)
                {
                    RunAsService();
                }
                else
                {
                    RunAsApplication();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur critique : {ex.Message}\n{ex.StackTrace}",
                    "Erreur",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private static void RunAsService()
        {
            ServiceBase[] ServicesToRun = { new Service1() };
            ServiceBase.Run(ServicesToRun);
        }

        private static void RunAsApplication()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new ManageServiceForm());
        }
    }
}
