using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Text;

namespace DataStructures_Algorithms.SortingAlgorithms
{
    internal class MergeSort
    {
        // O(NLogN)
        // Not In Place
        // Stable
        public void MergeSortAlgorithm(int[] arr)
        {
            int n = arr.Length;
            if (n == 0)
            {
                throw new ArgumentException("Array is Empty");
            }

            MergeSortAlgorithmHelper(arr, 0, n - 1);
        }

        private void MergeSortAlgorithmHelper(int[] arr, int lo, int hi)
        {
            if(lo < hi)
            {
                int mid = lo + (hi - lo) / 2;
              
                MergeSortAlgorithmHelper(arr, lo, mid);
                MergeSortAlgorithmHelper(arr, mid + 1, hi);
                Merge(arr, lo, hi, mid);
            }
        }

        private void Merge(int[] arr, int lo, int hi, int mid)
        {
            int n1 = mid - lo + 1;
            int n2 = hi - mid;

            int[] L1 = new int[n1];
            int[] L2 = new int[n2];

            int i = 0;
            //Copy First half of the array to Array 1: L1
            for(i = 0; i < n1; i++)
            {
                L1[i] = arr[lo + i];
            }

            //Copy Second Half of the array to Array 2: L2
            for(i = 0; i< n2; i++)
            {
                L2[i] = arr[mid+1 + i];
            }

            // Merge Code
            MergeHelper(arr, L1, L2, n1, n2, lo);
            
        }

        //Helper Code to Merge two arrays L1 and L2
        //Of size n1 and n2 respectively
        //And update the original array: arr
        //where staring index of 'arr' array is 'lo'
        private void MergeHelper(int[] arr, int[] L1, int[] L2, int n1, int n2, int lo)
        {
            int i = 0;
            int j = 0;
            int k = lo;

            while (i < n1 && j < n2)
            {
                if (L1[i] <= L2[j])
                {
                    arr[k] = L1[i];
                    i++;
                }
                else
                {
                    arr[k] = L2[j];
                    j++;
                }
                k++;
            }

            while (i < n1)
            {
                arr[k] = L1[i];
                i++;
                k++;
            }

            while (j < n2)
            {
                arr[k] = L2[j];
                j++;
                k++;
            }
        }
    }
}
