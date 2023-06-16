using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures_Algorithms.BinarySearch
{
    internal class _06_NumberOfTimesSortedArrayIsRotated
    {

        // This does not handle duplicates
        public static int PivotInRotatedArray(int[] arr, int ele, bool rightRotatedArray) { 
            
            int n = arr.Length;
            int start = 0;
            int end = n - 1;
            int rotatedIndex = -1;

            if (n == 0) {
                throw new ArgumentException("Array is empty");
            }
            
            while (start < end) {

                int mid = start + ((end - start) / 2);
                int next = (mid + 1) % n;
                int prev = (mid - 1 + n) % n;

                // This consition seems like handling duplicates
                // But this does not
                if (arr[mid] <= arr[prev] && arr[mid] <= arr[next])
                {
                    rotatedIndex = mid;
                    break;
                }
                else if (arr[start] < arr[mid])
                {
                    start = mid + 1;
                }
                else if (arr[mid] < arr[end]) { 
                    end = mid - 1;
                }   
            }

            if(rotatedIndex == -1)
                throw new Exception("Element not found in the given array");

            // If array is Right Rotated
            if (rightRotatedArray)
                return rotatedIndex;
            // If array is left rotated
            else
                return n - rotatedIndex;           
        }
    }
}
