using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI
{
    class Program
    {
        static void Main(string[] args)
        {
            var palindrome = new Palindrome.Palindrome();
            Console.WriteLine(palindrome.ConvertToPalindrome("i v i!* %  %&"));
        }
    }
}
