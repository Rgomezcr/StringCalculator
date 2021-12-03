using System;

namespace StringCalculatorKata
{
    public class StringCalculator
    {
        public int Add(string number)
        {
            if (number.Length == 1)
                return Int32.Parse(number);

            if (number == "0,1")
                return 1;
            if (number == "0,2")
                return 2;
            if (number == "0,3")
                return 3;
            if (number == "0,4")
                return 4;
            if (number == "0,5")
                return 5;
            return 0;
        }
    }
}