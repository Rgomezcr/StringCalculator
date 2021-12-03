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
            int actual = stringCalculator.add("");
            Assert.Equal(0, actual);
        }
    }
}