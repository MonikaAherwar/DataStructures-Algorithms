using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures_Algorithms.DP.LongestCommomSubsequence
{
    internal class _08_LongestRepeatingSubsequence
    {
        // IP: AABEBCDD
        // OP: 3 (ABD)

        public int LongestRepeatingSubsequence(string X, int m)
        {
            // OP: Longest Common Subsequence when i != j
            string Y = X.ToString();
            int n = m;

            int[,] t = new int[m + 1, n + 1];

            // Base Condition

            int k;
            for (k = 0; k <= m; k++)
            {
                t[k, 0] = 0;
            }

            for (k = 0; k <= n; k++)
            {
                t[0, k] = 0;
            }

            //Choise diagram

            for (int i = 1; i <= m; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    // The only change in LCS to get an answer for this problem
                    if (X[i - 1] == Y[j - 1] && i != j)
                    {
                        t[i, j] = 1 + t[i - 1, j - 1];
                    }
                    else
                    {
                        t[i, j] = Math.Max(t[i, j - 1], t[i - 1, j]);
                    }
                }
            }

            return t[m, n];


            return -1;
        }
    }
}
