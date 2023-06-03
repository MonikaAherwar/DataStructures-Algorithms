using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures_Algorithms.BinarySearch
{
    internal class _03_AgnosticSearch
    {
        //Agnostic Array: When sorting order is not known for the given array.
        public int BinarySearchAlgorithmInSortedArray(int[] arr, int ele) { 
            
            int n = arr.Length;

            if (n == 0) {
                throw new ArgumentException("Array is empty");
            }

            if (n == 1 && arr[0] == ele)
            {
                return 0;
            }
            else {
                throw new Exception("Element not found in the given array");
            }

            // Sorted Array
            if (arr[0] < arr[1])
            {
                return _01_BinarySearch.BinarySearchAlgorithm(arr, n);
            }
            // Reverse sorted Array
            else
            { 
                return _02_BinarySearchInReverseArray.BinarySearchAlgorithmInReverseSortedArray(arr, n);
            }
        }
    }
}
