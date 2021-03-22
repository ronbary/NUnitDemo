using System;
using System.Collections.Generic;
using System.Text;

namespace NUnitDemo
{
    class CheckPalindrome
    {


        public bool IsPalindrom(string input)
        {
            bool result = false;

            char[] inputArray = input.ToCharArray();

            Array.Reverse(inputArray);

            string strReversed = new string(inputArray);

            result = strReversed.Equals(input, StringComparison.OrdinalIgnoreCase);

            return result;
        }


    }
}
