using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataStructures_Algorithms.DP.LongestCommomSubsequence
{
    internal class _03_PrintLongestCommonSubsequence
    {
        public string PrintLongestCommonSubsequence(string X, string Y, int m, int n, int[,] t)
        {
            string s = null;

            int i = m;
            int j = n;

            while(i > 0 && j > 0)
            {
                if (X[i-1] == Y[j-1])
                {
                    s = s + X[i - 1];
                    i--;
                    j--;
                }
                else
                {
                    if (t[i - 1, j] > t[i, j - 1])
                    {
                        i--;
                    }
                    else
                    {
                        j--;
                    }
                }
            }

            s.Reverse();
            return s;
        }
    }
}
