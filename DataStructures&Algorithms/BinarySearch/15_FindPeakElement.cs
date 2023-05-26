using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures_Algorithms.BinarySearch
{
    internal class _15_FindPeakElement
    {

        // Binary Search on concept
        public static int FindPeakElementIndex(int[] arr) {

            int n = arr.Length;
            int start = 0;
            int end = n - 1;
            int index = -1;

            if (n == 0)
            {
                throw new ArgumentException("Array is empty");
            }

            while (start < end)
            {

                int mid = start + ((end - start) / 2);

                if (mid == 0 && arr[mid] >= arr[mid + 1])
                {
                    index = mid;
                    break;
                }
                else if( mid == n-1 && arr[mid] >= arr[mid - 1])
                {
                    index = mid;
                    break;
                }
                else if (arr[mid] > arr[mid -1] && arr[mid] > arr[mid + 1])
                {
                    index = mid;
                    break;
                }
                else if (arr[mid-1] > arr[mid])
                {
                    end = mid - 1;
                }
                else
                {
                    start = mid + 1;
                }
            }

            return index;
        }
    }
}
