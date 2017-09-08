using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringPalindrome.LngPalindromicSubStr
{
    class BruteForceTwo
    {
        internal static void LongestPalindrome(string s)
        {
            int start = 0, end = 0;
            for (int i = 0; i < s.Length; i++)
            {
                int len1 = ExpandAroundCenter(s, i, i);
                int len2 = ExpandAroundCenter(s, i, i + 1);
                int len = Math.Max(len1, len2);
                if (len > end - start)
                {
                    start = i - (len - 1) / 2;
                    end = i + len / 2;
                }
            }

            Console.WriteLine("Longest paplindromic sub string: " + s.Substring(start, end + 1));
        }

        private static int ExpandAroundCenter(string s, int left, int right)
        {
            int l = left, r = right;
            while (l >= 0 && r < s.Length && s[l] == s[r])
            {
                l--;
                r++;
            }
            return r - l - 1;
        }
    }
}
