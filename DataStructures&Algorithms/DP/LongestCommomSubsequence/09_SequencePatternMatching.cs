using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures_Algorithms.DP.LongestCommomSubsequence
{
    internal class _09_SequencePatternMatching
    {
        // X: AXY
        // Y: ADXCPY
        // Problem: Does X lies in Y
        // OP: True
        public bool SequencePatternMatching(String X, String Y, int m, int n)
        {
            int lcs = _01_LongestCommomSubsequence.LongestCommomSubsequence_TopDown(X, Y, m, n);    

            if(lcs == Math.Min(m, n))
                return true;

            return false;
        }
    }
}
