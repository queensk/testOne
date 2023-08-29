using System;
using System.IO;
using NUnit.Framework;

// This namespace contains test cases for the File class
namespace FileText
{
    [SetUpFixture]
    public class FileTextSetupFixture
    {
        [OneTimeSetUp]
        public void RunBeforeAnyTests()
        {
            File.WriteAllText("test.txt", "Hello, World!");
        }

        [OneTimeTearDown]
        public void RunAfterAnyTests()
        {
            File.Delete("test.txt");
        }
    }

    [TestFixture]
    public class FileTests
    {
        [SetUp]
        public void Setup()
        {
            Console.WriteLine("Setup");
        }

        [TearDown]
        public void TearDown()
        {
            Console.WriteLine("TearDown");
        }

        [Test]
        public void Exists_Should_Return_True()
        {
            bool result = File.Exists("test.txt");
            Assert.IsTrue(result);
        }

        [Test]
        public void ReadAllText_Should_Return_Content()
        {
            string result = File.ReadAllText("test.txt");
            Assert.That(result, Is.EqualTo("Hello, World!"));
        }
    }
}
