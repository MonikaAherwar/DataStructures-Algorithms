﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures_Algorithms.BinarySearch
{
    internal class _04_LastOccurenceOfElement
    {
        public static int LastOccurence(int[] arr, int ele) { 
            
            int n = arr.Length;
            int start = 0;
            int end = n - 1;
            int result = -1;

            if (n == 0) {
                throw new ArgumentException("Array is empty");
            }
            
            while (start < end) {

                int mid = start + ((end - start) / 2);

                if (arr[mid] == ele)
                {
                    result = mid;
                    start = mid + 1;
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

            if(result == -1)
                throw new Exception("Element not found in the given array");

            return result;
        }
    }
}
