using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MsmqTransactionProcessor.Helpers
{
    public static class Logger
    {
        private static readonly string logFile = "logs.txt";

        public static void Log(string message)
        {
            var entry = $"{DateTime.Now:yyyy-MM-dd HH:mm:ss} - {message}";
            Console.WriteLine(entry);
            File.AppendAllText(logFile, entry + Environment.NewLine);
        }
    }
}