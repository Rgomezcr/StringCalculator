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
        
        [Fact]
        public void CalculateSumForTwo()
        {
            StringCalculator stringCalculator = new();
            
            int actual = stringCalculator.Add("2");
            
            Assert.Equal(2, actual);
        }
        
        [Fact]
        public void CalculateSumForThree()
        {
            StringCalculator stringCalculator = new();
            
            int actual = stringCalculator.Add("3");
            
            Assert.Equal(3, actual);
        } 
        
    }
}