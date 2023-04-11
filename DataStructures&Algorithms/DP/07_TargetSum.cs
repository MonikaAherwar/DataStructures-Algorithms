using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures_Algorithms.DP
{
    internal class _07_TargetSum
    {
        public int TargetSum(int[] arr, int sum, int n)
        {

            // Problem is reduded to CountSubsetWithGivenDiff
            int diff = sum;
            var count = _06_CountSubsetWithGivenDiff.CountSubsetWithGivenDiff(arr, n, diff);
            return count;
        }
    }
}
