using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures_Algorithms.DP
{
    internal class _05_MinimumSubsetSum
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

        bool[,] t = new bool[5, 8];
        public int MinimumSubsetSum(int[] arr, int n)
        {
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                sum += arr[i];
            }

            // Call Subset sum problem code for total sum: sum
            // Save the boolean matrix generated out of it: t
            _02_SubsetSumProblem.SubsetSum_TopDown(arr, sum, n);

            // Let say SubsetSum_TopDown return: t[n+1, sum+1];
            // Create the possible sum array from t
            List<int> sum_list = new List<int>();
            for(int j = 0; j <= sum/2; j++)
            {
                if (t[n, j] == true)
                {
                    sum_list.Add(j);
                }
            }

            // Calculate the minimum value from expression
            // (Range - 2*S1 == MINIMUM_VALUE)
            // Range = sum of all the elements
            // S1 = sum of subset 1
            int min = Int32.MaxValue;
            foreach(var s in sum_list)
            {
                min = Math.Min(min, sum - 2 * s);
            }

            return min;
        }
    }
}
