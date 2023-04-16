using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures_Algorithms.DP.UnboundedKnapsack
{
    internal class _03_CoinChange_I
    {
        // FIND MAXIMUM NUMBER OF WAYS TO GET THE SUM FROM GIVEN COINS

        //**********
        // Top Down
        //**********

        // n = 3
        // sum = 5
        //int[,] t = new dp[n+1, sum+1]; 
        int[,] t = DP_Helper.FillDefault(m: 4, n: 6);
        public int CoinChange(int[] coin, int sum, int n)
        {
            int k = 0;

            // When sum = 0;
            for(k = 0; k <= n; k++)
            {
                t[k, 0] = 1;
            }

            // When n = 0;
            for(k =0; k <= sum; k++)
            {
                t[0, k] = 0;
            }

            //Choise Digram
            for(int i = 0; i <= n; i++)
            {
                for(int j = 0; j<= sum; j++)
                {
                    if (coin[i-1] <= j)
                    {
                        t[i, j] = t[i, j - coin[i - 1]] + t[i - 1, j];
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
