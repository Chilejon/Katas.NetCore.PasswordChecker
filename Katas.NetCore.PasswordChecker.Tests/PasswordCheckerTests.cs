using Microsoft.VisualStudio.TestPlatform.CommunicationUtilities;
using Xunit;

namespace Katas.NetCore.PasswordChecker.Tests
{
    public class PasswordCheckerTests
    {
        private readonly PasswordChecker _checker = new();
        const string GoodPassword = "awoog Amooga";

        public PasswordCheckerTests() {
           _checker = new();
        }
 
        [Theory]
        [InlineData("", "Password is blank")]
        public void Checker_EmptyString_ReturnsBadMessage(string input, string outputResult)
        {
            string result = _checker.Check(input);
            Assert.Equal(outputResult, result);
        }

        [Theory]
        [InlineData("awooga", "Length is less than 8")]
        [InlineData(GoodPassword, "Password is acceptable")]

        public void Checker_StringLengthMustBeOver8Characters(string input, string outputResult)
        {
            string result = _checker.Check(input);
            Assert.Equal(outputResult, result);
        }

        [Theory]
        [InlineData("awoogamooga", "Password doesn't have any uppercase letters")]
        [InlineData(GoodPassword, "Password is acceptable")]

        public void Checker_StringMustHaveACapitalLetter(string input, string outputResult)
        {
            string result = _checker.Check(input);
            Assert.Equal(outputResult, result);
        }

        [Theory]
        [InlineData("awoogAmooga", "Password doesn't have any spaces")]
        [InlineData(GoodPassword, "Password is acceptable")]

        public void Checker_StringMustHaveSpace(string input, string outputResult)
        {
            string result = _checker.Check(input);
            Assert.Equal(outputResult, result);
        }


        // must be under 26

        // Must include a capital letter

        // must have a space

        // A colour from the rainbow

        // a special character !"£$%^&*(){}:;#~'@<,>.?

        // must include a number

        // numbers must individually add up to 25

        // must contain a roman numeral

        // roman numerals must be a multiple of 35

        // must have a 2 figure code from the periodic table e.g. li

        // can't have 2 consequtive numbers e.g. 34

        // can't have 2 consequtive letters e.g. gh

    }

}