using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures_Algorithms.BinarySearch
{
    internal class _16_FindMaximumInBitonicArray
    {

        // Binary Search on concept
        public int FindMaximumElementArrayInBitonicArray(int[] arr) {

            int n = arr.Length;

            if (n == 0)
            {
                throw new ArgumentException("Array is empty");
            }

            int peakIndex = _15_FindPeakElement.FindPeakElementIndex(arr);

            return peakIndex >= 0 ? arr[peakIndex] : -1;
        }
    }
}
