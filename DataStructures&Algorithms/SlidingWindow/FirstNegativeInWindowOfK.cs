using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures_Algorithms.SlidingWindow
{
    internal class FirstNegativeInWindowOfK
    {
        List<int> negatives = new List<int>();
        public List<int> FirstNegativeNumber(int[] arr, int k) {

            int i = 0;
            int j = 0;
            int n = arr.Length;
            Queue<int> queue = new Queue<int>();

            while (j < n) {

                if (arr[j] < 0)
                {
                    queue.Enqueue(arr[j]);
                }

                if (j - i + 1 < k)
                {
                    j++;
                }
                else if (j - i + 1 == k) {

                    int negativeNumInCurrentWindow = queue.Count == 0 ? 0 : queue.Peek();
                    negatives.Add(negativeNumInCurrentWindow);

                    if (queue.Peek() == arr[j]) { 
                        queue.Dequeue();
                    }

                    i++;
                    j++;
                }
            }

            return negatives;
        }
    }
}
