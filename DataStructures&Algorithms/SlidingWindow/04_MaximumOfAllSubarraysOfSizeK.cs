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
            Queue<int> queue = new Queue<int>();

            while (j < n)
            {
                while(queue.Count > 0 && queue.Peek() < arr[j])
                {
                    queue.Dequeue();
                }
                    
                queue.Enqueue(arr[j]);

                if (j - i + 1 < k)
                {
                    j++;
                }
                else if (j - i + 1 == k)
                {

                    int maximumInCurrentWindow = queue.Peek();
                    maximums.Add(maximumInCurrentWindow);

                    if (queue.Peek() == arr[i])
                    {
                        queue.Dequeue();
                    }

                    i++;
                    j++;
                }
            }

            return maximums;
        }
    }
}
