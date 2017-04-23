using Patterns.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.StrategyViaDelegate
{
    class LogProcessor
    {
        readonly Func<List<LogEntry>> logImporter;

        public LogProcessor(Func<List<LogEntry>> logImporter)
        {
            this.logImporter = logImporter;
        }

        public void ProcessLogs()
        {
            foreach (var logEntry in logImporter.Invoke())
            {
                SaveLogEntry(logEntry);
            }
        }

        private void SaveLogEntry(LogEntry logEntry)
        {
            // Saving To Storage
        }
    }
}
