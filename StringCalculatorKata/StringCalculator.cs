using System;

namespace StringCalculatorKata
{
    public class StringCalculator
    {
        public int Add(string number)
        {

            if (number.Length == 1)
                return Int32.Parse(number);

            if(number.Length > 2)
                return Int32.Parse(number.Substring(2, number.Length - 2));
            
            return 0;
        }
    }
}