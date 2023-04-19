using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures_Algorithms.DP.LongestCommomSubsequence
{
    internal class _02_LongestCommonSubstring
    {
        // X: String X
        // Y: String Y
        // n: no. of elements in X
        // m: no. of elements in Y

        //***********
        // Top Down
        //***********
        public int LongestCommomSubstring(string X, string Y, int n, int m)
        {
            int[,] t = new int[m + 1, n + 1];

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
                    if (X[i - 1] == Y[j - 1])
                    {
                        t[i, j] = 1 + t[i - 1, j - 1];
                    }
                    else
                    {
                        t[i, j] = 0 ;
                    }
                }
            }

            return t[m, n];
        }
    }
}
