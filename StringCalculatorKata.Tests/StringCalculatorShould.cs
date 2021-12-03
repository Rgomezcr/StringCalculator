using System;
using Xunit;

namespace StringCalculatorKata.Tests
{
    public class StringCalculatorShould
    {
        [Fact]
        public void ReturnZeroForEmptyString()
        {
            StringCalculator stringCalculator = new();
            
            int actual = stringCalculator.Add("");
            
            Assert.Equal(0, actual);
        }

        [Fact]
        public void CalculateSumForOne()
        {
            StringCalculator stringCalculator = new();
            
            int actual = stringCalculator.Add("1");
            
            Assert.Equal(1, actual);
        } 
    }
}