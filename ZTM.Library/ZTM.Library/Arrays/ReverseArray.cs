using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZTM.Library.Arrays
{
    public class ReverseArray
    {
        public string ReverseString(string input)
        {
            char[] chars = input.ToCharArray();

            char[] reversed = new char[chars.Length];

            for (int i = 0; i < chars.Length; i++)
            {
                reversed[i] = chars[chars.Length - i - 1];
            }
            return new string(reversed);            
        }
    }
}
