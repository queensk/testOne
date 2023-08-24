using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BenchmarkDotNet.Running;


namespace tests
{
    public class Program
    {
        public static void performanceTest()
        {
            
            Console.Title = "Email address validation performance testing";
            var summary = BenchmarkRunner.Run<EmailValidatorBenchmark>();
            Console.ReadLine();
        }
    }
}