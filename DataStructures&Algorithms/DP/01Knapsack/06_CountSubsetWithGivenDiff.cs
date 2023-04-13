using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures_Algorithms.DP
{
    internal class _06_CountSubsetWithGivenDiff
    {

        //*********
        // Top Down
        //*********

        // n = 4
        // sum = 7
        // int[,] t = new t[n+1, sum+1]; 

        //        SUM
        //       /   \
        //     S1     S2

        static int[,] t = new int[5, 8];
        public static int CountSubsetWithGivenDiff(int[] arr, int n, int diff)
        {

            // S1 - S2 = diff;
            // S1 - (SUM - S1) = diff;
            // 2S1 - SUM = diff
            // S1 = (SUM + diff) / 2;

            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                sum += arr[i];
            }

            int s1 = (sum + diff) / 2;

            // Problem is reduced to count the subset with given sum
            return  _04_CountOfSubsetsForGivenSum.CountSubsetForGivenSum(arr, s1, n);
        }
    }
}
