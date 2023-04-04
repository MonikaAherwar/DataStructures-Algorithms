using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures_Algorithms.DP
{
    internal class _02_SubsetSumProblem
    {

        //*********
        // Memoised
        //*********

        // n = 4
        // sum = 7
        //int[,] t = new dp[n+1, W+1]; 

        bool[,] t = new bool[5, 8];
        public bool SubsetSum_TopDown(int[] arr, int sum, int n)
        {
            for (int k = 0; k < sum; k++)
            {
                t[0, k] = false;
            }

            for (int k = 0; k < n; k++)
            {
                t[k, 0] = true;
            }

            for(int i=1; i <n; i++)
            {
                for(int j = 1; j<sum; j++)
                {
                    if (arr[i-1] < j)
                    {
                        t[i, j] = t[i - 1, j - arr[i - 1]] || t[i - 1, j];
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
