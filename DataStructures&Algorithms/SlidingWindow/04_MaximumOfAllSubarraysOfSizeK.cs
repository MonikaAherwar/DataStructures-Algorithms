using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures_Algorithms.SlidingWindow
{
    internal class MaximumOfAllSubarraysOfSizeK
    {
        List<int> maximums = new List<int>();
        public List<int> MaximumOfSubarrays(int[] arr, int k)
        {
            if (arr.Length == 0) {
                throw new Exception("Array is Empty");
            }

            if (k <= 0) { 
                throw new Exception("Invalid window size");
            }

            //Sliding Window Code

            int i = 0;
            int j = 0;
            int n = arr.Length;

            // Queue<int> queue1 = new Queue<int>()
            // Since normal queue will not work, 
            // We will use double sided linked list.
            LinkedList<int> queue = new LinkedList<int>();

            while (j < n)
            {
                while(queue.Count > 0 && queue.Last.Value < arr[j])
                {
                    queue.RemoveLast();
                }
                    
                queue.AddLast(arr[j]);

                if (j - i + 1 < k)
                {
                    j++;
                }
                else if (j - i + 1 == k)
                {

                    int maximumInCurrentWindow = queue.First.Value;
                    maximums.Add(maximumInCurrentWindow);

                    if (maximumInCurrentWindow == arr[i])
                    {
                        queue.RemoveFirst();
                    }

                    i++;
                    j++;
                }
            }

            return maximums;
        }
    }
}
