using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures_Algorithms.DP.LongestCommomSubsequence
{
    internal class _04_ShortestCommonSuperSequence
    {

        public int ShortestCommonSuperSequence(string X, string Y, int m, int n)
        {
            int[,] t = new int[m + 1, n + 1];

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
                        t[i, j] = 1 + t[i - 1, j - 1];
                    }
                    else
                    {
                        t[i, j] = 1+ Math.Min(t[i, j - 1], t[i - 1, j]);
                    }
                }
            }

            return t[m, n];
        }


    }
}
