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
        public void CalculateSumForZeroAndOne()
        {
            StringCalculator stringCalculator = new ();
            
            int actual = stringCalculator.Add("0,1");
            
            Assert.Equal(1, actual);
        } 
        
        [Fact]
        public void CalculateSumForZeroAndTwo()
        {
            StringCalculator stringCalculator = new ();
            
            int actual = stringCalculator.Add("0,2");
            
            Assert.Equal(2, actual);
        } 
        
        [Fact]
        public void CalculateSumForZeroAndThree()
        {
            StringCalculator stringCalculator = new ();
            
            int actual = stringCalculator.Add("0,3");
            
            Assert.Equal(3, actual);
        } 
        
        [Fact]
        public void CalculateSumForZeroAndFour()
        {
            StringCalculator stringCalculator = new ();
            
            int actual = stringCalculator.Add("0,4");
            
            Assert.Equal(4, actual);
        } 
        
        [Fact]
        public void CalculateSumForZeroAndFive()
        {
            StringCalculator stringCalculator = new ();
            
            int actual = stringCalculator.Add("0,5");
            
            Assert.Equal(5, actual);
        }

        [Fact]
        public void CalculateSumForZeroAndTen()
        {
            StringCalculator stringCalculator = new ();
            
            int actual = stringCalculator.Add("0,10");
            
            Assert.Equal(10, actual);
        } 
        
        [Fact]
        public void CalculateSumForZeroAndEleven()
        {
            StringCalculator stringCalculator = new ();
            
            int actual = stringCalculator.Add("0,11");
            
            Assert.Equal(11, actual);
        } 
        
        [Fact]
        public void CalculateSumForZeroAndTwelve()
        {
            StringCalculator stringCalculator = new ();
            
            int actual = stringCalculator.Add("0,12");
            
            Assert.Equal(12, actual);
        } 
        
        [Fact]
        public void CalculateSumForZeroAndthirteen()
        {
            StringCalculator stringCalculator = new ();
            
            int actual = stringCalculator.Add("0,13");
            
            Assert.Equal(13, actual);
        } 
    }
}