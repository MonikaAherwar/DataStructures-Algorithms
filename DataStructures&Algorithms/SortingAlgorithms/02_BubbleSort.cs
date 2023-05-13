using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures_Algorithms.SortingAlgorithms
{
    internal class BubbleSort
    {

        // O(N^2)
        // In Place
        // Stable
        public void BubbleSortAlgorithm(int[] arr)
        {
            int n = arr.Length;
            if (n == 0)
            {
                throw new ArgumentException("Array is Empty");
            }

            bool swapped;
            for(int i = 0; i < n; i++)
            {
                swapped = false;
                for(int j = 0; j < n-i-1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        //Swap
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                        swapped = true;
                    }
                }

                if (!swapped)
                    break;
            }        
        }
    }
}
