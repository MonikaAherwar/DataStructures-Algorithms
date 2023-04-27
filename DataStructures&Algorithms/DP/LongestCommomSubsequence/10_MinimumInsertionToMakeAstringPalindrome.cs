using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures_Algorithms.DP.LongestCommomSubsequence
{
    internal class _10_MinimumInsertionToMakeAstringPalindrome
    {
        public int MinimumInsetion(String X, int m)
        {
            // No. of insertion =  No. of deletion

            int minInsetion = _07_MinimumDeletionToMakeAstringPalindrome.MinimumDeletion(X, m);
            return minInsetion;
        }
    }
}
