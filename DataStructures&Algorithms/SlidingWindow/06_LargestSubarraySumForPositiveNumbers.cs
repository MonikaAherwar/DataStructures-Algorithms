using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures_Algorithms.SlidingWindow
{
    internal class LargestSubarraySumForPositiveNumbers
    {
        int windowSize = 0;

        public int LargestSubarraySum(int[] arr, int sum) {

            int currSum = 0;
            int i = 0;
            int j = 0;
            int n = arr.Length;

            while (j < n) { 
                
                currSum += arr[j];

                if (currSum < sum)
                {
                    j++;
                }
                else if (currSum == sum)
                {
                    windowSize = Math.Max(windowSize, currSum);
                    j++;
                }
                else if (currSum > sum) {
                    while (currSum > sum) {
                        sum = sum - arr[i];
                        i++;
                    }
                    j++;
                }
            }
            
            return windowSize;
        }
    }
}
