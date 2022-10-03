using PalindromeExercise;
using System;
using System.Net.Security;
using Xunit;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("Level", true)]
        [InlineData("Madam", true)]
        [InlineData("Madams", false)]
        public void Test1(string a, bool expected)
        {
            WordSmith obj = new WordSmith();
          var actual =  obj.isAPalindrome(a);
            Assert.Equal(expected, actual);
        }
    }
}
