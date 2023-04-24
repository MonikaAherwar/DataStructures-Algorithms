using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures_Algorithms.DP.LongestCommomSubsequence
{
    internal class _07_MinimumDeletionToMakeAstringPalindrome
    {
        public static int MinimumDeletion(string X, int m)
        {
            int longestPalindromeSubstring = _06_LongestPalindromicSubstring.LongestPalindromicSubstring(X, m);
            int minDeletion = m - longestPalindromeSubstring;
            return minDeletion;
        }
    }
}
