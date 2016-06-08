using System;
using NUnit.Framework;

namespace TrimExtensions.Tests {
    [TestFixture]
    public class TrimTest {
        [TestCase ("ab;cd;ef", ";", ExpectedResult = "ab")]
        public string TestTrimAfterFirstOf(string source, string delimiter) {
            var actual = source.TrimAfterFirstOf (delimiter);
            return actual;
        }

        [TestCase ("ab;cd;ef", ";", ExpectedResult = "ab;cd")]
        public string TestTrimAfterLastOf(string source, string delimiter) {
            var actual = source.TrimAfterLastOf (delimiter);
            return actual;
        }

        [TestCase ("ab;cd;ef", ";", ExpectedResult = "cd;ef")]
        public string TestTrimBeforeFirstOf(string source, string delimiter) {
            var actual = source.TrimBeforeFirstOf (delimiter);
            return actual;
        }

        [TestCase ("ab;cd;ef", ";", ExpectedResult = "ef")]
        public string TestTrimBeforeLastOf(string source, string delimiter) {
            var actual = source.TrimBeforeLastOf (delimiter);
            return actual;
        }
    }
}
