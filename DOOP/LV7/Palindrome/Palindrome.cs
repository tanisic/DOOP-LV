using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome
{
    public class Palindrome
    { //1. zadatak
        public string ConvertToPalindrome(string value)
        {
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
            return new string(array).Replace(" ","");
        }
    }
}
