using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BenchmarkDotNet.Attributes;
using sendMessage.Models;

namespace tests
{
        [MemoryDiagnoser]
        public class EmailValidatorBenchmark
        {
            private readonly string _sampleEmail;

            public EmailValidatorBenchmark()
            {
                _sampleEmail = "tony.stark@example.net";
            }

            [Benchmark]
            public bool TestIsValidEmail()
            {
                return User.IsValidEmail(_sampleEmail);
            }

            [Benchmark]
            public bool TestIsValidEmailRegex()
            {
                return User.IsValidEmailClass(_sampleEmail);
            }
        }
}