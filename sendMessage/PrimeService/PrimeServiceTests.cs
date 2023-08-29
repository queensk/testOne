using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrimeService.Function
{
    public class PrimeServiceFunction
    {
        // function to return True if number is prime
        public bool IsPrime(int number)
        {
            // check if number is prime
            if (number <= 1)
            {
                return false;
            }
            else if (number == 2)
            {
                return true;
            }
            else if (number % 2 == 0)
            {
                return false;
            }
            else
            {
                int limit = (int)Math.Sqrt(number);
                for (int i = 3; i <= limit; i += 2)
                {
                    if (number % i == 0)
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}