using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures_Algorithms.DP.LongestCommomSubsequence
{
    internal class _01_LongestCommomSubsequence
    {
        // X: String X
        // Y: String Y
        // n: no. of elements in X
        // m: no. of elements in Y

        //***********
        // Recursive
        //***********

        public int LongestCommomSubsequence_Recursive(string X, string Y, int n, int m)
        {
            // Base Condition
            if (m == 0 || n == 0) return 0;

            // Choice Diagram
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

            // Base Condition
            if (m == 0 || n == 0) return 0;

            // DP 
            if (t[m, n] != -1) return t[m, n];

            // Choice Diagram
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


        //***********
        // Top Down
        //***********
        public static int LongestCommomSubsequence_TopDown(string X, string Y, int n, int m)
        {
            int[,] t = new int[m + 1, n + 1];

            // Base Condition

            int k;
            for(k = 0; k <= m; k++)
            {
                t[k, 0] = 0;
            }

            for (k = 0; k <= n; k++)
            {
                t[0, k] = 0;
            }

            //Choise diagram

            for(int i = 1; i <= m; i++)
            {
                for(int j = 1; j <= n; j++)
                {
                    if (X[i-1] == Y[j - 1])
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
        }
    }
}
