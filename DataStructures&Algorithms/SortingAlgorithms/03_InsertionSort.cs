using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures_Algorithms.SortingAlgorithms
{
    internal class InsertionSort
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

            for(int i = 1; i < n; i++)
            {
                int key = arr[i];
                int j = i - 1;

                while (j >= 0 && arr[j] > key)
                {
                    arr[j + 1] = arr[j];
                    j--;
                }

                arr[j+1] = key;
            }
        }
    }
}
