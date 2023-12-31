﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures_Algorithms.DP
{
    internal class _04_CountOfSubsetsForGivenSum
    {

        //*********
        // Top Down
        //*********

        // n = 4
        // sum = 7
        // int[,] t = new t[n+1, W+1]; 

        static int[,] t = new int[5, 8];
        public static int CountSubsetForGivenSum(int[] arr, int sum, int n)
        {
            int k;

            // When n = 0
            for (k = 0; k <= sum; k++)
            {
                t[0, k] = 0;
            }

            // When sum = 0
            for (k = 0; k <= n; k++)
            {
                t[k, 0] = 1;
            }

            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= sum; j++)
                {
                    // When current value is less than sum
                    if (arr[i - 1] < j)
                    {
                        t[i, j] = t[i - 1, j - arr[i - 1]] + t[i - 1, j];
                    }
                    // When current value is more than sum
                    else
                    {
                        t[i, j] = t[i - 1, j];
                    }
                }
            }

            // Return the last value
            return t[n, sum];
        }
    }
}
