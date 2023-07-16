using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures_Algorithms.SlidingWindow
{
    internal class MaximumSubarraySumKadanesAlgorithm
    {

        // Kadane's Algorithm!
        // Works for both: 
        // 1. All positive number
        // 2. Including Negative Numbers

        int max_sum = Int32.MinValue;  
        
        public int MaximumSubarraySum(int[] arr) {

            int n = arr.Length;
            int curr_sum = 0;
            bool maxSumFound = false;

            for (int i = 0; i < n; i++)
            {
                curr_sum += arr[i];

                if (curr_sum < 0)
                {
                    curr_sum = 0;
                }
                else { 
                    max_sum = Math.Max(max_sum, curr_sum);
                    maxSumFound = true;
                }
            }

            if (!maxSumFound) {
                throw new Exception("Maximum sum was not found as array contains all negative numbers");
                // Use another algorithm
                // To deal with all negative numbers 
            }

            return max_sum;
        }
    }
}
