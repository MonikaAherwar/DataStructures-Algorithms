using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures_Algorithms.DP.UnboundedKnapsack
{
    // FIND MINIMUM NUMBER OF WAYS TO GET THE SUM FROM GIVEN COINS

    internal class _04_CoinChange_II
    {
        //**********
        // Top Down
        //**********

        // n = 3
        // sum = 5
        //int[,] t = new dp[n+1, sum+1]; 
        int[,] t = DP_Helper.FillDefault(m: 4, n: 6);
        public int CoinChange(int[] coin, int sum, int n)
        {
            int k;

            // When sum = 0, mimimum coins = 0
            for (k = 0; k <= n; k++)
            {
                t[k, 0] = Int32.MaxValue - 1;
            }

            // When n = 0, minimum coins = 0
            for(k =0; k <= sum; k++)
            {
                t[0, k] = 0;
            }

            // Choise Diagram
            for (int i = 0; i <= n; i++)
            {
                for (int j = 0; j <= sum; j++)
                {
                    if (coin[i - 1] <= j)
                    {
                        // if we include current, 
                        // then total ways for ith element = 1 + total ways when we inlcude current with sum = sum - arr[i-1]
                        t[i, j] = Math.Min( 1 + t[i, j - coin[i - 1]], t[i - 1, j]);
                    }
                    else
                    {
                        t[i, j] = t[i - 1, j];
                    }
                }
            }

            return t[n, sum];
        }
    }
}
