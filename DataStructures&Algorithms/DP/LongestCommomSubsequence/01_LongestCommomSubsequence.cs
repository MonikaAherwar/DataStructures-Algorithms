using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures_Algorithms.DP.LongestCommomSubsequence
{
    internal class _01_LongestCommomSubsequence
    {


        //***********
        // Recursive
        //***********

        public int LongestCommomSubsequence_Recursive(string X, string Y, int n, int m)
        {
            if (m == 0 || n == 0) return 0;

            var lcs = 0;
            if (X[m-1] == Y[n - 1])
            {
                lcs =  1 + LongestCommomSubsequence_Recursive(X, Y, m - 1, n - 1);
            }
            else
            {
                lcs = Math.Max(LongestCommomSubsequence_Recursive(X, Y, m - 1, n), 
                    LongestCommomSubsequence_Recursive(X, Y, m, n - 1));
            }

            return lcs;
        }


        //***********
        // Memoised
        //***********

        //m: 6
        //n: 5
        int[,] t = new int[7, 6];
        public int LongestCommomSubsequence_Memoised(string X, string Y, int n, int m)
        {
            for(int i = 0; i <= m; i++)
            {
                for(int j = 0; j <= n; j++)
                {
                    t[i, j] = -1;
                }
            }

            if (m == 0 || n == 0) return 0;

            if (t[m, n] != -1) return t[m, n];

            if (X[m - 1] == Y[n - 1])
            {
                t[m, n] = 1 + LongestCommomSubsequence_Recursive(X, Y, m - 1, n - 1);
            }
            else
            {
                t[m, n] = Math.Max(LongestCommomSubsequence_Recursive(X, Y, m - 1, n),
                    LongestCommomSubsequence_Recursive(X, Y, m, n - 1));
            }

            return t[m, n];
        }


        
    }
}
