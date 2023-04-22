using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataStructures_Algorithms.DP.LongestCommomSubsequence
{
    internal class _06_LongestPalindromicSubstring
    {
        // X = agbcba
        // OP: 5
        public static int LongestPalindromicSubstring(string X, int m)
        {
            string Y = X.Reverse().ToString();
            int n = m;

            int lcs = _01_LongestCommomSubsequence.LongestCommomSubsequence_TopDown(X, Y, m, n);

            return lcs;
        }
    }
}
