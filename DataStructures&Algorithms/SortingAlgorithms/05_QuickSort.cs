using DataStructures_Algorithms.SlidingWindow;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Text;

namespace DataStructures_Algorithms.SortingAlgorithms
{
    internal class QuickSort
    {

        // O(NLogN)
        // In Place
        // Not Stable
        public void MergeSortAlgorithm(int[] arr)
        {
            int n = arr.Length;
            if (n == 0)
            {
                throw new ArgumentException("Array is Empty");
            }

            QuickSortAlgorithmHelper(arr, 0, n - 1);
        }

        private void QuickSortAlgorithmHelper(int[] arr, int lo, int hi)
        {
            if (lo < hi)
            {
                int pivot = Partition(arr, lo, hi);
                QuickSortAlgorithmHelper(arr, lo, pivot - 1);
                QuickSortAlgorithmHelper(arr, pivot + 1, hi);
            }
        }

        private int Partition(int[] arr, int lo, int hi)
        {
            int pivot = arr[hi];         
            int i = lo - 1;

            for (int j = lo; j < hi -1; j++)
            {
                if (arr[j] < pivot)
                {
                    i++;
                    Swap(arr, i, j);
                }
            }

            // Swap i+1 with hi;
            Swap(arr, i + 1, hi);

            return i + 1;
        }

        private void Swap(int[] arr, int i, int j)
        {
            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;         
        }
    }
}
