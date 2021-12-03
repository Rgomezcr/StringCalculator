using System;

namespace StringCalculatorKata
{
    public class StringCalculator
    {
        public int Add(string number)
        {
            if (number.Length == 1)
                return Int32.Parse(number);

            if (number.Length == 3)
            {
                return Int32.Parse(number.Substring(2, 1));
            }

            
            return 0;
        }
    }
}