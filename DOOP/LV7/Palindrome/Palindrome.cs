using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Palindrome
{
    public class Palindrome
    { //1. zadatak (popravak)
        public string ConvertToPalindrome(string value)
        {
            if (value == "" || value == string.Empty)
                throw new ArgumentException();

            string filteredString = value.ToLower();
            char[] array = filteredString.ToCharArray();
            for(int i = 0; i< array.Length;i++)
            {
                if(!char.IsLetterOrDigit(array[i]))
                {
                    array[i] = ' ';
                }
            }              
            Array.Reverse(array);
            string output = new string(array).Replace(" ", "");
            if (output == value)
                return output;
            else return value;
        }
    }
}
