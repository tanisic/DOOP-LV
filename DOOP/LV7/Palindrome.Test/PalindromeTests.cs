using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
namespace Palindrome.Test
{   [TestFixture]
    public class PalindromeTests
    {
        Palindrome palindrome = new Palindrome();
        [TestCase("racecar")]
        [TestCase("refer")]
        public void ConvertToPalindrome_WhenLowerLetterPalindrome_ReturnPalindrome(string input)
        {
            String expected = input;
            String actual = palindrome.ConvertToPalindrome(input);
            Assert.AreEqual(expected, actual);
        }
        [TestCase("cars")]
        [TestCase("notpalindrome")]
        public void ConvertToPalindrome_NotPalindrome_ReturnPalindrome(string input)
        {
            String expected = input;
            string actual = palindrome.ConvertToPalindrome(input);
            Assert.AreEqual(expected, actual);
        }
        [TestCase("")]
        public void ConvertToPalindrome_EmptyString_ReturnArgumentException(string input)
        {
            
            Assert.Throws<ArgumentException>(() => palindrome.ConvertToPalindrome(input));
        }
        [TestCase("race   car")]
        [TestCase("ref   e  r")]
        public void ConvertToPalindrome_PalindromeWithWhiteSpaces_ReturnPalindrome(string input)
        {
            String expected = input;
            String actual = palindrome.ConvertToPalindrome(input);
            Assert.AreEqual(expected, actual);
        }
        [TestCase("RacE   cAr")]
        [TestCase("rEf   E  R")]
        public void ConvertToPalindrome_PalindromeWithWhiteSpacesAndUpperCase_ReturnPalindrome(string input)
        {
            String expected = input;
            String actual = palindrome.ConvertToPalindrome(input);
            Assert.AreEqual(expected, actual);
        }

    }
}
