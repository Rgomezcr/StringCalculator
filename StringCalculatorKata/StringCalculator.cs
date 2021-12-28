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
            
            var numbers = new string[number.Length];
            
            if(number.StartsWith("//"))    
            {
                string delimiter = number.Substring(2, 1);
                string operationNumbers = number.Substring(4, number.Length - 4);
                numbers = operationNumbers.Split(delimiter, StringSplitOptions.RemoveEmptyEntries);
            }

            if (!number.Contains(',') && !number.StartsWith("//"))
                numbers[0] = number;
            
            if(!number.StartsWith("//"))
                numbers = number.Split(new char[] { ',', '\n' }, StringSplitOptions.RemoveEmptyEntries);
            
            foreach (var t in numbers)
            {
                if (Int32.Parse(t) < 0)
                {
                    throw new ArgumentOutOfRangeException($"Negatives not allowed {t}");
                }
            }
            return numbers.Sum(numberString => Int32.Parse(numberString));
        }
    }
}