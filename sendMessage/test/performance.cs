// using BenchmarkDotNet.Attributes;
// using sendMessage.Models;

// namespace sendMessage.test
// {
//     [MemoryDiagnoser]
//     public class EmailValidatorBenchmark
//     {
//         private readonly string _sampleEmail;

//         public EmailValidatorBenchmark()
//         {
//             _sampleEmail = "tony.stark@example.net";
//         }

//         [Benchmark]
//         public bool TestIsValidEmail()
//         {
//             return User.IsValidEmail(_sampleEmail);
//         }

//         [Benchmark]
//         public bool TestIsValidEmailRegex()
//         {
//             return User.IsValidEmailClass(_sampleEmail);
//         }
//     }
// }