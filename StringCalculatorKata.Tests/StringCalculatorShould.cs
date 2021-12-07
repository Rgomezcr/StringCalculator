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

        [Fact]
        public void CalculateSumForOne()
        {
            StringCalculator stringCalculator = new ();
            
            int actual = stringCalculator.Add("1");
            
            Assert.Equal(1, actual);
        } 
        
        [Fact]
        public void CalculateSumForTwo()
        {
            StringCalculator stringCalculator = new ();
            
            int actual = stringCalculator.Add("2");
            
            Assert.Equal(2, actual);
        }
        
        [Fact]
        public void CalculateSumForThree()
        {
            StringCalculator stringCalculator = new ();
            
            int actual = stringCalculator.Add("3");
            
            Assert.Equal(3, actual);
        } 
        
        [Fact]
        public void CalculateSumForFour()
        {
            StringCalculator stringCalculator = new ();
            
            int actual = stringCalculator.Add("4");
            
            Assert.Equal(4, actual);
        } 
        
        [Fact]
        public void CalculateSumForFive()
        {
            StringCalculator stringCalculator = new ();
            
            int actual = stringCalculator.Add("5");
            
            Assert.Equal(5, actual);
        }

        [Fact]
        public void CalculateSumForTen()
        {
            StringCalculator stringCalculator = new ();
            
            int actual = stringCalculator.Add("10");
            
            Assert.Equal(10, actual);
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
        
        [Fact]
        public void CalculateSumForOneAndNumber()
        {
            StringCalculator stringCalculator = new ();
            
            int actual = stringCalculator.Add("1,0");
            
            Assert.Equal(1, actual);
        }
        
        [Fact]
        public void CalculateSumForTwoAndNumber()
        {
            StringCalculator stringCalculator = new ();
            
            int actual = stringCalculator.Add("2,0");
            
            Assert.Equal(2, actual);
        }
        
        [Fact]
        public void CalculateSumForThreeAndNumber()
        {
            StringCalculator stringCalculator = new ();
            
            int actual = stringCalculator.Add("3,0");
            
            Assert.Equal(3, actual);
        }
        
    }
}