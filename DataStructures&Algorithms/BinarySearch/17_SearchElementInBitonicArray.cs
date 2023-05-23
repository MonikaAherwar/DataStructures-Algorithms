using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures_Algorithms.BinarySearch
{
    internal class _17_SearchElementInBitonicArray
    {

        // Binary Search on concept
        public int SearchElementInBitonicArray(int[] arr, int ele) {

            int n = arr.Length;
            int start = 0;
            int end = n - 1;

            if (n == 0)
            {
                throw new ArgumentException("Array is empty");
            }

            int peakIndex = _15_FindPeakElement.FindPeakElementIndex(arr);
            if (peakIndex == -1)
                throw new ArgumentException("No Peak Element. Hence we can find an element using binary search");

            int elementIndexInFirstHalfArray = _01_BinarySearch.BinarySearchAlgorithm(arr, ele, start, peakIndex-1);
            int elementIndexInSecondHalfArray = _02_BinarySearchInReverseArray.BinarySearchAlgorithmInReverseSortedArray(arr, ele, start, peakIndex-1);

            return elementIndexInFirstHalfArray != -1 ? elementIndexInFirstHalfArray : elementIndexInSecondHalfArray;         
        }
    }
}
