using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sendMessage.Calculator
{
    public class CalculatorFunction
    {
        public int Add(int firstNumber, int secondNumber)
        {
            return firstNumber + secondNumber;
        }

        public int Subtract(int firstNumber, int secondNumber)
        {
            return firstNumber - secondNumber;
        }

        public int Multiply(int firstNumber, int secondNumber)
        {
            return firstNumber * secondNumber;
        }

        public int Divide(int firstNumber, int secondNumber)
        {
            if (secondNumber == 0)
            {
                throw new DivideByZeroException();
            }

            return firstNumber / secondNumber;
        }
    }
}