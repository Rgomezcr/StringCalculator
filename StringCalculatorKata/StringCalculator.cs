using System;
using System.Linq;

namespace StringCalculatorKata
{
    public class StringCalculator
    {
        public int Add(string number)
        {
            if (string.IsNullOrEmpty(number))
                return 0;
            if (!number.Contains(',')) return Int32.Parse(number);
            
            var numbers = number.Split(',');

            return numbers.Sum(numberString => Int32.Parse(numberString));
        }
    }
}