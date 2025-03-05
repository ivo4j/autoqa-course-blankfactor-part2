using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitTestsPart2Lecture2
{
    internal class StringUtils
    {

        public string ReverseString(string input)
        {
            if (input == null)
            {
                throw new ArgumentNullException("The input is null");
            }
            char[] charArray = input.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}
