using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace DataStructures_Algorithms.BinarySearch
{
    internal class _07_FindElementInRotatedArray
    {
        public int FindElementInRotatedArray(int[] arr, int ele) { 
            
            int n = arr.Length;
            int start = 0;
            int end = n - 1;

            if (n == 0) {
                throw new ArgumentException("Array is empty");
            }

            // When array is not rotated
            if (arr[start] <= arr[end])
               return _01_BinarySearch.BinarySearchAlgorithm(arr, ele);

            int pivot = _06_NumberOfTimesSortedArrayIsRotated.PivotInRotatedArray(arr, rightRotatedArray: true);

            if (ele >= arr[start] && ele <= arr[pivot - 1])
                return _01_BinarySearch.BinarySearchAlgorithm(arr, ele, start, pivot - 1);
            else
                return _01_BinarySearch.BinarySearchAlgorithm(arr, ele, pivot, end);
        }

        
    }
}
