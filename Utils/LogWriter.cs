using System;
using System.Collections.Generic;
using System.IO;
using System.Configuration;
using Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utils
{

    public class LogWriter : ILogger
    {
        private readonly string _logPath;
        private readonly object _lockObject = new object();
        private readonly ILogDisplay _logDisplay;

        public LogWriter(ILogDisplay logDisplay = null)
        {
            _logDisplay = logDisplay;

            var logDirectory = ConfigurationManager.AppSettings["LogPath"] ??
                Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "logs");

            if (!Directory.Exists(logDirectory))
            {
                Directory.CreateDirectory(logDirectory);
            }

            _logPath = Path.Combine(logDirectory, $"supervision_{DateTime.Now:yyyy-MM-dd}.log");
        }

        public LogWriter()
        {
            var logDirectory = ConfigurationManager.AppSettings["LogPath"] ??
                Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "logs");

            if (!Directory.Exists(logDirectory))
            {
                Directory.CreateDirectory(logDirectory);
            }

            _logPath = Path.Combine(logDirectory, $"supervision_{DateTime.Now:yyyy-MM-dd}.log");
        }

        public void LogInfo(string message)
        {
            WriteLog("INFO", message);
        }

        public void LogWarning(string message)
        {
            WriteLog("WARNING", message);
        }

        public void LogError(string message)
        {
            WriteLog("ERROR", message);
        }

        private void WriteLog(string level, string message)
        {
            var logEntry = $"{DateTime.Now:yyyy-MM-dd HH:mm:ss} [{level}] {message}";
            lock (_lockObject)
            {
                try
                {
                    File.AppendAllText(_logPath, logEntry + Environment.NewLine);
                }
                catch
                {
                }
            }
            _logDisplay?.Print(logEntry);
        }
    }
}
