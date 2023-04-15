using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures_Algorithms.DP.UnboundedKnapsack
{
    internal class _02_RodCutting
    {

        //**********
        // Top Down
        //**********

        // n = 8
        // L = 8
        //int[,] dp = new dp[n+1, W+1]; 
        int[,] t = DP_Helper.FillDefault(m: 9, n: 9);
        public int RodCutting(int[] length, int[] price, int L, int n)
        {
            int k;
            for(k =0; k <= n; k++)
            {
                t[k, 0] = 0;
            }

            for(k = 0; k <= L; k++)
            {
                t[0, k] = 0;
            }

            //Choice diagram

            for(int i =0; i <= n; i++)
            {
                for(int j = 0; j <= L; j++)
                {
                    if (length[i-1] <= j)
                    {
                        t[i, j] = Math.Max(price[i - 1] + t[i, j - length[i - 1]], t[i - 1, j]);
                    }
                    else
                    {
                        t[i, j] = t[i - 1, j];
                    }
                }
            }

            return t[n, L];
        }
    }
}
