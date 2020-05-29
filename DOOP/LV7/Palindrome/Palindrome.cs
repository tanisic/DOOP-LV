using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Palindrome
{
    public class Palindrome
    { //3. zadatak (refaktoriranje)
        public string ConvertToPalindrome(string value)
        {
            if (value == "" || value == string.Empty)
                throw new ArgumentException();            
            char[] array = value.ToCharArray();
            for(int i = 0; i< array.Length;i++)
            {
                if(!char.IsLetterOrDigit(array[i]))
                {
                    array[i] = ' ';
                }
            }              
            Array.Reverse(array);
            string output = new string(array).Replace(" ", "").ToLower();
            if (output == value)
                return output;
            else 
                return value;
        }
    }
}
