using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures_Algorithms.DP.LongestCommomSubsequence
{
    internal class _05_MinimumInsertionAndDeletion
    {
        public int MinimumInsertionAndDeletion(string X, string Y, int m, int n)
        {
            int lcs = _01_LongestCommomSubsequence.LongestCommomSubsequence_TopDown(X, Y, m, n);
            int deletion = m - lcs;
            int insertion = n - lcs;

            return insertion + deletion;
        }
    }
}
