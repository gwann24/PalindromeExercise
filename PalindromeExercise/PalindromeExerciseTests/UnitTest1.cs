using PalindromeExercise;
using System;
using Xunit;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("Racecar", true)]
        [InlineData("hello", false)]
        public void IsAPalindromeTest(string word, bool expected)
        { 

            //Arrange
            var helper = new WordSmith();

            //Act
            // call the Add method that is located in the Calculator class
            // and store its result in a variable named actual
            var actual = helper.IsAPalindrome(word);

            //Assert
            //throw new NotImplementedException();
            Assert.Equal(expected, actual);
        }
    }
}
