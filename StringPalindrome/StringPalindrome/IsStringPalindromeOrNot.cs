using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringPalindrome
{
    class IsStringPalindromeOrNot
    {
        internal static bool IsStrPalindrome(string str)
        {
            // Flag to indicate whether the given string is palindrome or not
            bool isPalindrome = true;

            // Left index and right index variables
            int l, r;

            // initialize with respective values
            l = 0; r = str.Length - 1;

            // This loop will run n/2 times where n is the length of the given string
            while(l <= r)
            {
                if(str[l] == str[r])
                {
                    // Moving left index to right by step 1
                    l++;
                    // Moving right index to left by step 1
                    r--;
                }
                else
                {
                    // Identified a char difference
                    isPalindrome = false;
                    break;
                }
            }

            // Return the outcome as boolean
            return isPalindrome;            
        }
    }
}
