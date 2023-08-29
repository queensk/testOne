using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sendMessage.Calculator
{
    public class CalculatorService
    {
        private readonly ILoggerService _loggerService;

        public CalculatorService(ILoggerService loggerService)
        {
            _loggerService = loggerService;
        }

        public int Add(int x, int y)
        {
            _loggerService.Log($"Adding {x} and {y}");
            int result = x + y;
            _loggerService.Log($"Result is {result}");
            return result;
        }
    }
}
