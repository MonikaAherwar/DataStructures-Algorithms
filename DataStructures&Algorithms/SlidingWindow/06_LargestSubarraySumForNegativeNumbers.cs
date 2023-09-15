using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures_Algorithms.SlidingWindow
{
    internal class LargestSubarraySumForNegativeNumbers
    {
        // Problem: Find the largest window for given sum

        // Variable size sliding window
        // Works for both: 
        // 1. All positive number
        // 2. Including Negative Numbers


        int windowSize = 0;
        public int LargestSubarraySum(int[] arr, int sum)
        {
            int n = arr.Length;
            int curr_sum = 0;
            int start = 0;
            int end = -1;
            Dictionary<int, int> dict = new Dictionary<int, int>();

            for (int i = 0; i < n; i++) { 
                
                curr_sum += arr[i];

                if (curr_sum == sum)
                {
                    start = 0;
                    end = i;
                    break;
                }
                else {
                    if (!dict.ContainsKey(curr_sum))
                    {
                        dict.Add(curr_sum, i);
                    }
                    else {
                        dict[curr_sum] = i;
                    }

                    if (dict.ContainsKey(sum - curr_sum)) {
                        start = dict[sum - curr_sum] + 1;
                        end = i;
                    }
                }
            }

            if (end == -1) {
                throw new Exception("No Window Found with given sum");
            }

            windowSize = end - start + 1;
            return windowSize;
        }
    }
}
