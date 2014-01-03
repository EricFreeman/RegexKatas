using System.Text.RegularExpressions;
using Xunit;

namespace RegexKatas
{
    public class Level2Tests
    {
        public const string TestVar ="Tech Support: (801)-555-1234";
        public const string TestVar2 = "Corporate: 1(800) 555 3332";
        public const string TestVar3 = "Manager- 801.555.2345";
        public const string TestVar4 = "HR 874-555-3256";

        /// <summary>
        /// 1) Find all the phone numbers from the four test strings using the same regex.
        /// </summary>
        [Fact]
        public static void Test1()
        {
            const string regex = @"1?\(?\d{3}\)?[\s.-]\d{3}[\s.-]\d{4}";
            const int captureGroup = 0;

            var m = Regex.Match(TestVar, regex);
            var m2 = Regex.Match(TestVar2, regex);
            var m3 = Regex.Match(TestVar3, regex);
            var m4 = Regex.Match(TestVar4, regex);

            Assert.True(m.Success && m2.Success && m3.Success && m4.Success);
            Assert.True(m.Groups[captureGroup].Value.Equals("(801)-555-1234"));
            Assert.True(m2.Groups[captureGroup].Value.Equals("1(800) 555 3332"));
            Assert.True(m3.Groups[captureGroup].Value.Equals("801.555.2345"));
            Assert.True(m4.Groups[captureGroup].Value.Equals("874-555-3256"));
        }

        /// <summary>
        /// 1) Find the contact name for all numbers with an area code of 801
        /// </summary>
        [Fact]
        public static void Test2()
        {
            const string regex = @"([\w\s]+)[\s:-]\s?.*801";
            const int captureGroup = 1;

            var m = Regex.Match(TestVar, regex);
            var m2 = Regex.Match(TestVar2, regex);
            var m3 = Regex.Match(TestVar3, regex);
            var m4 = Regex.Match(TestVar4, regex);

            Assert.True(m.Success && !m2.Success && m3.Success && !m4.Success);
            Assert.True(m.Groups[captureGroup].Value.Equals("Tech Support"));
            Assert.True(m3.Groups[captureGroup].Value.Equals("Manager"));
        }
    }
}
