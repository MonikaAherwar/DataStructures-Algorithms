using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures_Algorithms.DP
{
    internal class _03_EqualSumPartition
    {
        public bool EqualSumPartition(int[] arr, int n)
        {
            int sum = 0;
            for(int k = 0; k < n; k++)
            {
                sum += arr[k];
            }

            if (sum % 2 != 0) return false;

            return _02_SubsetSumProblem.SubsetSum_TopDown(arr, sum / 2, n);
        }
    }
}
