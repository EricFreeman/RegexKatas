using System.Text.RegularExpressions;
using Xunit;

namespace RegexKatas
{
    public class Level3Tests
    {
        public const string TestVar1 = "fjd3IR9";
        public const string TestVar2 = "ghdfj32";
        public const string TestVar3 = "DSJKHD23";
        public const string TestVar4 = "dsF43";
        public const string TestVar5 = "4fdg5FJ3";
        public const string TestVar6 = "DHSJdhjsU";

        /// <summary>
        /// Find all the passwords that are at least six letters and contain all of the following: 
        /// lowercase letter, uppercase letter, and a number
        /// </summary>
        [Fact]
        public static void Test1()
        {
            const string regex = @"(put answer here)";

            var m1 = Regex.Match(TestVar1, regex);
            var m2 = Regex.Match(TestVar2, regex);
            var m3 = Regex.Match(TestVar3, regex);
            var m4 = Regex.Match(TestVar4, regex);
            var m5 = Regex.Match(TestVar5, regex);
            var m6 = Regex.Match(TestVar5, regex);

            Assert.True(m1.Success && m5.Success);
            Assert.False(m2.Success && m3.Success && m4.Success && m6.Success);
        }

        /// <summary>
        /// --------------------------------------------------------------------------------------------------
        /// Only the following test variables will be used for the remainder of Level 3:
        /// </summary>

        public const string TestVar7 = "USD100";
        public const string TestVar8 = "USD57";
        public const string TestVar9 = "JPY384";
        public const string TestVar10 = "USD";

        /// <summary>
        /// Find all the USD money
        /// *WARNING* Most online regex evaluators don't allow for variable length look behinds but .NET's *DOES*
        /// </summary>
        [Fact]
        public static void Test2()
        {
            const string regex = @"(put answer here)";
            const int captureGroup = 0;

            var m1 = Regex.Match(TestVar7, regex);
            var m2 = Regex.Match(TestVar8, regex);
            var m3 = Regex.Match(TestVar9, regex);
            var m4 = Regex.Match(TestVar10, regex);

            Assert.True(m1.Success && m1.Groups[captureGroup].Value.Equals("100"));
            Assert.True(m2.Success && m2.Groups[captureGroup].Value.Equals("57"));
            Assert.False(m3.Success && m4.Success);
        }

        /// <summary>
        /// Find USD that isn't followed by any amount
        /// </summary>
        [Fact]
        public static void Test3()
        {
            const string regex = @"(put answer here)";
            const int captureGroup = 0;

            var m1 = Regex.Match(TestVar7, regex);
            var m2 = Regex.Match(TestVar8, regex);
            var m3 = Regex.Match(TestVar9, regex);
            var m4 = Regex.Match(TestVar10, regex);

            Assert.True(m4.Success && m4.Groups[captureGroup].Value.Equals("USD"));
            Assert.False(m1.Success && m2.Success && m3.Success);
        }
    }
}
