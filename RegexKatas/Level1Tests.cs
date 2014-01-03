using System.Text.RegularExpressions;
using Xunit;

namespace RegexKatas
{
    public class Level1Tests
    {
        public const string TestVar1 = "Mozilla/4.0 (compatible; MSIE 7.0; Windows NT 6.0)";
        public const string TestVar2 = "Mozilla/4.75 (Windows; U; Windows NT 5.1; en-US; rv:1.8.1.14) Gecko/20080404 Firefox/2.0.0.14";
        public const string TestVar3 = "Mozilla/NoVersion (compatible; MSIE 6.5; Windows NT 5.5)";

        /// <summary>
        /// Find mozilla version number without explicitly matching on it (eg don't check for the text '4.75').
        /// </summary>
        [Fact]
        public static void Test1()
        {
            const string regex = @"(put answer here)";
            const int captureGroup = 0; // use to configure which capture group your answer is in

            var m1 = Regex.Match(TestVar1, regex); 
            var m2 = Regex.Match(TestVar2, regex);
            var m3 = Regex.Match(TestVar3, regex);

            Assert.True(m1.Success && m1.Groups[captureGroup].Value.Equals("4.0"));
            Assert.True(m2.Success && m2.Groups[captureGroup].Value.Equals("4.75"));
            Assert.False(m3.Success);
        }

        /// <summary>
        /// Find Windows NT version number without explicitly matching on it (eg don't check for the text '6.0').
        /// </summary>
        [Fact]
        public static void Test2()
        {
            const string regex = @"(put answer here)";
            const int captureGroup = 0;

            var m1 = Regex.Match(TestVar1, regex);
            var m2 = Regex.Match(TestVar2, regex);
            var m3 = Regex.Match(TestVar3, regex);

            Assert.True(m1.Success && m1.Groups[captureGroup].Value.Equals("6.0"));
            Assert.True(m2.Success && m2.Groups[captureGroup].Value.Equals("5.1"));
            Assert.True(m3.Success && m3.Groups[captureGroup].Value.Equals("5.5"));
        }
    }
}
