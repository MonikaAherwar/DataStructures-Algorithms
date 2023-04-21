using System;
using System.Collections.Generic;
using System.Linq;
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

        public int ShortestCommonSuperSequence_UsingLCS(string X, string Y, int m, int n)
        {

            var lcs = _01_LongestCommomSubsequence.LongestCommomSubsequence_TopDown(X, Y, m, n);
            var scs = m + n - lcs;

            return scs;

        }

        public string PrintShortestCommonSuperSequence(string X, string Y, int m, int n, int[,] t)
        {
            string s = null;
            int i = m;
            int j = n;

            while(i > 0 && j > 0)
            {
                if (X[i-1] == Y[j - 1])
                {
                    s = s + X[i - 1];
                    i--;
                    j--;
                }
                else
                {
                    if (t[i-1, j] < t[i, j - 1])
                    {
                        s = s + X[i - 1];
                        i--;
                    }
                    else
                    {
                        s = s + Y[j - 1];
                        j--;
                    }
                }
            }

            while(i > 0)
            {
                s = s + X[i - 1];
                i--;
            }

            while(j > 0)
            {
                s = s + Y[j - 1];
                j--;
            }

            s.Reverse();
            return s;
        }
    }
}
