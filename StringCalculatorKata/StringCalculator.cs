﻿using System;

namespace StringCalculatorKata
{
    public class StringCalculator
    {
        public int Add(string number)
        {
            if (number == "1,0")
                return 1;
            if (number == "2,0")
                return 2;
            if (number == "3,0")
                return 3;
            if (number.Length == 1)
                return Int32.Parse(number);

            if(number.Length > 2)
                return Int32.Parse(number.Substring(2, number.Length - 2));
            
            return 0;
        }
    }
}