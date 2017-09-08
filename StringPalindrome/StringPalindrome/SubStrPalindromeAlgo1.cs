using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringPalindrome
{
    class SubStrPalindromeAlgo1
    {
        internal static void FindSubStrPalindromes(string str)
        {
            int n = str.Length;
            List<string> lstOfPalindromes = new List<string>();

            for (int i = 0; i < n; i++)
            {
                // Find all odd length palindrome with str[i] as mid point
                Exapand(str, i, i, ref lstOfPalindromes);

                // Find all even length palindrome with str[i] and str[i+1] as its mid point
                Exapand(str, i, i + 1, ref lstOfPalindromes);
            }

            Console.WriteLine("Count: " + lstOfPalindromes.Count);

            // Print the list of possible sub string palindromes
            foreach (var s in lstOfPalindromes)
            {
                Console.WriteLine(s);
            }
        }

        private static void Exapand(string str, int low, int high, ref List<string> lstOfPalindromes)
        {
            while (low >= 0 && high < str.Length && str[low] == str[high])
            {
                // Add the current palindrome into the list if it is not added already
                var pal = str.Substring(low, high - low + 1);
                if (!lstOfPalindromes.Contains(pal))
                {
                    lstOfPalindromes.Add(pal);
                }

                // Expand in both the directions
                low--; high++;
            }
        }
    }
}
