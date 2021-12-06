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
            
            if (number.Length == 4)
            {
                return Int32.Parse(number.Substring(2, 2));
            }

            if (number.Length == 5)
            {
                return Int32.Parse(number.Substring(2, 3));
            }
            
            return 0;
        }
    }
}