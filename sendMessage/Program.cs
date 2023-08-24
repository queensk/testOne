// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
using sendMessage.CurrencyConverter;
using BenchmarkDotNet.Running;
using sendMessage.test;

class Program
{
    CurrencyConverterUsdToEur currencyConverter = new CurrencyConverterUsdToEur();

    static void Main(string[] args)
    {
        Console.Title = "Email address validation performance testing";
        var summary = BenchmarkRunner.Run<EmailValidatorBenchmark>();
        Console.ReadLine();
    }
}