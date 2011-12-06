using System;
using NUnit.Framework;

namespace ConsoleApplication.Tests
{
    [TestFixture]
    class ProgramTest
    {
        [Test]
        public void Main_returns_CorrectResult()
        {
            String[] args = null;
            Assert.That(ConsoleApplication.Program.Main(args),Is.EqualTo(1));
        }
    }
}
