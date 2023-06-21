using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Text;

namespace DataStructures_Algorithms.BinarySearch
{
    internal class _09_FindFloorOfElementInSortedArray
    {

        public int FindFloorElement(int[] arr, int ele) {

            int n = arr.Length;
            int start = 0;
            int end = n - 1;
            int floor = -1;

            if (n == 0)
            {
                throw new ArgumentException("Array is empty");
            }

            while (start < end)
            {

                int mid = start + ((end - start) / 2);

                if (arr[mid] == ele)
                {
                    floor = mid;
                    return floor;
                }
                else if (ele < arr[mid])
                {
                    end = mid - 1;
                }
                else if (ele > arr[mid])
                {
                    floor = mid;
                    start = mid + 1;
                }
            }

            if(floor == -1)
                throw new Exception("Element not found in the given array");

            return floor;
        }
    }
}
