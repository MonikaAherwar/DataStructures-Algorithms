using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace DataStructures_Algorithms.BinarySearch
{
    internal class _14_FindMinimumDifferenceElement
    {
        public static int MinimumDifferenceElement(int[] arr, int ele) { 
            
            int n = arr.Length;
            int start = 0;
            int end = n - 1;

            if (n == 0) {
                throw new ArgumentException("Array is empty");
            }
            
            while (start < end) {

                int mid = start + ((end - start) / 2);

                if (arr[mid] == ele)
                {
                    return mid;
                }
                else if (ele < arr[mid])
                {
                    end = mid - 1;
                }
                else if (ele > arr[mid])
                {
                    start = mid + 1;
                }
            }

            int firstNearbyElementDiff = Math.Abs(arr[end] - ele);
            int secondNearbyElementDiff = Math.Abs(arr[start] - ele);
            int mimimumDiffElement = (firstNearbyElementDiff < secondNearbyElementDiff) 
                                        ? arr[end] 
                                        : arr[start];

            return mimimumDiffElement;
        }

        public static int BinarySearchAlgorithm(int[] arr, int ele, int start, int end)
        {

            int n = arr.Length;
            if (n == 0)
            {
                throw new ArgumentException("Array is empty");
            }

            while (start < end)
            {

                int mid = start + ((end - start) / 2);

                if (arr[mid] == ele)
                {
                    return mid;
                }
                else if (ele < arr[mid])
                {
                    end = mid - 1;
                }
                else if (ele > arr[mid])
                {
                    start = mid + 1;
                }
            }

            throw new Exception("Element not found in the given array");
        }
    }
}
