using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringPalindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            //SubStrPalindromeAlgo1.FindSubStrPalindromes("google");

            //SubStrPalindromeAlgo1.FindSubStrPalindromes("abracadabra");

            LngPalindromicSubStr.BruteForceOne.FindLongestPalindromicSubString("google");
            LngPalindromicSubStr.BruteForceTwo.
                ("google");

            //Console.WriteLine("Is MadaM is palindrome: " + IsStringPalindromeOrNot.IsStrPalindrome("MadaM"));

            Console.WriteLine("\n\nPlease press any key to exit...");
            Console.ReadKey();
        }
    }
}
