using System;
using NUnit.Framework;

namespace TrimExtensions.Tests {
    [TestFixture]
    public class TrimTest {
        [TestCase ("ab;cd;ef", ";", ExpectedResult = "ab")]
        [TestCase ("ab;cd;ef", ";", true, ExpectedResult = "ab;")]
        public string TestTrimAfterFirstOf(string source, string delimiter, bool hasDelimiter = false) {
            var actual = source.TrimAfterFirstOf (delimiter, hasDelimiter);
            return actual;
        }

        [TestCase ("ab;cd;ef", ";", ExpectedResult = "ab;cd")]
        [TestCase ("ab;cd;ef", ";", true, ExpectedResult = "ab;cd;")]
        public string TestTrimAfterLastOf(string source, string delimiter, bool hasDelimiter = false) {
            var actual = source.TrimAfterLastOf (delimiter, hasDelimiter);
            return actual;
        }

        [TestCase ("ab;cd;ef", ";", ExpectedResult = "cd;ef")]
        [TestCase ("ab;cd;ef", ";", true, ExpectedResult = ";cd;ef")]
        public string TestTrimBeforeFirstOf(string source, string delimiter, bool hasDelimiter = false) {
            var actual = source.TrimBeforeFirstOf (delimiter, hasDelimiter);
            return actual;
        }

        [TestCase ("ab;cd;ef", ";", ExpectedResult = "ef")]
        [TestCase ("ab;cd;ef", ";", true, ExpectedResult = ";ef")]
        public string TestTrimBeforeLastOf(string source, string delimiter, bool hasDelimiter = false) {
            var actual = source.TrimBeforeLastOf (delimiter, hasDelimiter);
            return actual;
        }
    }
}
