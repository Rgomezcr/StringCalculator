using System;

namespace StringCalculatorKata
{
    public class StringCalculator
    {
        public int Add(string number)
        {
            if (number.Length == 1)
                return Int32.Parse(number);
           
            return 0;
        }
    }
}