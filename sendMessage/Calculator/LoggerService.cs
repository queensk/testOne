using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sendMessage.Calculator
{
    public class LoggerService : ILoggerService
    {
        private readonly string _filePath;

        public LoggerService(string filePath)
        {
            _filePath = filePath;
        }

        public void Log(string message)
        {
            using (var writer = new StreamWriter(_filePath, true))
            {
                writer.WriteLine($"{DateTime.Now}: {message}");
            }
        }
    }
}