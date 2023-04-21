using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures_Algorithms.DP.LongestCommomSubsequence
{
    internal class _05_EditDistance
    {
        public int EditDistance(string X, string Y, int m, int n)
        {
            int[,] t = new int[m + 1, n + 1];

            // Base Condition

            int k;
            for (k = 0; k <= m; k++)
            {
                t[k, 0] = k;
            }

            for (k = 0; k <= n; k++)
            {
                t[0, k] = k;
            }

            //Choise diagram

            for (int i = 1; i <= m; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    if (X[i - 1] == Y[j - 1])
                    {
                        // No addition, deletion, replacement
                        t[i, j] = t[i - 1, j - 1];
                    }
                    else
                    {
                        // Find best of it.
                        int MinInsertionDeletion = Math.Min(t[i, j - 1], t[i - 1, j]);
                        t[i, j] = 1 + Math.Min(t[i - 1, j - 1], MinInsertionDeletion);
                    }
                }
            }

            return t[m, n];
        }
    }
}
