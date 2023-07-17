using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures_Algorithms.SlidingWindow
{
    internal class MaximumSubarraySumSizeK
    {
        int max_sum = Int32.MinValue;
        internal int MaximumSubarraySum(int[] arr, int k) {

            int i = 0; 
            int j = 0; 
            int sum = 0;
            int n = arr.Length;

            while (j < n) { 
            
                sum += arr[j];

                if (j-i+1 < k)
                {
                    j++;
                }
                else if ( j-i+1 == k)
                {
                    max_sum = Math.Max(max_sum, sum);
                    sum -= arr[i];
                    i++;
                    j++;
                }
            }

            return max_sum;
        }
    }
}
