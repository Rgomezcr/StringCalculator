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
            if(number.StartsWith("//"))    
            {
                string delimiter = number.Substring(2, 1);
                string operationNumbers = number.Substring(4, number.Length - 4);
                var numbersOperation = operationNumbers.Split(delimiter, StringSplitOptions.RemoveEmptyEntries);
                return numbersOperation.Sum(stringNumber => Int32.Parse(stringNumber));
            }
            
            if (!number.Contains(',')) return Int32.Parse(number);

            var numbers = number.Split(new char[] { ',', '\n' }, StringSplitOptions.RemoveEmptyEntries);

            return numbers.Sum(numberString => Int32.Parse(numberString));
        }
    }
}