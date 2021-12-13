using System;
using Xunit;

namespace StringCalculatorKata.Tests
{
    public class StringCalculatorShould
    {
        [Fact]
        public void ReturnZeroForEmptyString()
        {
            StringCalculator stringCalculator = new ();
            
            int actual = stringCalculator.Add("");
            
            Assert.Equal(0, actual);
        }

        [Theory]
        [InlineData("1",1)]
        [InlineData("2",2)]
        [InlineData("3",3)]
        [InlineData("4",4)]
        [InlineData("10",10)]
        [InlineData("100",100)]
        public void CalculateSumForOneNumber(string input, int expected)
        {
            StringCalculator stringCalculator = new ();
            
            int actual = stringCalculator.Add(input);
            
            Assert.Equal(expected, actual);
        } 
        
        [Theory]
        [InlineData("0,1", 1)]
        [InlineData("0,2", 2)]
        [InlineData("0,3", 3)]
        [InlineData("0,10", 10)]
        [InlineData("0,11", 11)]
        [InlineData("0,12", 12)]
        [InlineData("0,100", 100)]
        [InlineData("0,101", 101)]
        [InlineData("0,102", 102)]
        public void CalculateSumForZeroAndNumber(string numbers, int expected)
        {
            StringCalculator stringCalculator = new ();
            
            int actual = stringCalculator.Add(numbers);
            
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("1,0", 1)]
        [InlineData("2,0", 2)]
        [InlineData("3,0", 3)]
        [InlineData("1,1", 2)]
        [InlineData("1,2", 3)]
        [InlineData("2,2", 4)]
        [InlineData("10,1", 11)]
        [InlineData("2,10", 12)]
        [InlineData("10,10", 20)]
        [InlineData("11,11", 22)]
        public void CalculateSumForTwoNumbers(string input, int expected)
        {
            StringCalculator stringCalculator = new ();
            
            int actual = stringCalculator.Add(input);
            
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void CalculateSumForOneAndTwoNumbersMore()
        {
            StringCalculator stringCalculator = new();
            
            int actual = stringCalculator.Add("1,1,1");
            
            Assert.Equal(3, actual);
        } 
        
        [Fact]
        public void CalculateSumForTwoAndTwoNumbersMore()
        {
            StringCalculator stringCalculator = new();
            
            int actual = stringCalculator.Add("2,1,1");
            
            Assert.Equal(4, actual);
        } 
        
    }
}