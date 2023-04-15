using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures_Algorithms.DP.UnboundedKnapsack
{
    internal class _01_UnboundedKnapsack
    {

        //**********
        // Top Down
        //**********

        // n = 4
        // W = 7
        //int[,] dp = new dp[n+1, W+1]; 
        int[,] dp = DP_Helper.FillDefault(m: 5, n: 8);
        public int UnboundedKnapsack(int[] val, int[] wt, int W, int n)
        {
            //Base condition
            int i;
            int j;
            for (i = 0; i < n + 1; i++)
            {
                for (j = 0; j < W + 1; j++)
                {
                    if (i == 0 || j == 0)
                    {
                        dp[i, j] = 0;
                    }
                }
            }

            //Choise Diagram

            for (i = 1; i < n + 1; i++)
            {
                for (j = 1; j < W + 1; j++)
                {
                    if (wt[i - 1] < W)
                    {
                        // The only change between 01 Knapsack and Unbounded knapsack
                        dp[i, j] = Math.Max(val[i - 1] + dp[i, j - wt[i - 1]], dp[i - 1, j]);
                    }
                    else
                    {
                        dp[i, j] = dp[i - 1, j];
                    }
                }
            }

            return dp[n, W];
        }
    }
}
