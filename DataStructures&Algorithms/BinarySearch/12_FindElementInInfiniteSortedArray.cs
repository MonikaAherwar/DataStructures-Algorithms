using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures_Algorithms.BinarySearch
{
    internal class _12_FindElementInInfiniteSortedArray
    { 
        public static int FindElementInInfiniteSortedArray(int[] arr, int ele) { 
                      
            int start = 0;
            int end = start+1;

            while(ele > arr[end])
            {
                start = end;
                end = end * 2;
            }

            return _01_BinarySearch.BinarySearchAlgorithm(arr, ele, start, end);
            
        }
    }
}
