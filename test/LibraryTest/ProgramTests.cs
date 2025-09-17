using Library;
using NUnit.Framework;

namespace LibraryTest
{
    public class Tests
    {
        [Test]
        [TestCase("abcde", "bcdef", ExpectedResult = 5)]
        [TestCase("abcde", "abcde", ExpectedResult = 0)]
        [TestCase("strong", "strung", ExpectedResult = 1)]
        public static int FixedTest(string str1, string str2)
        {
            return Program.HammingDistance(str1, str2);
        }
    }
}