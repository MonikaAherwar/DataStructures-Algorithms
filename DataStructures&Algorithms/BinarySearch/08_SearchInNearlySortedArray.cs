using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures_Algorithms.BinarySearch
{
    internal class _08_SearchInNearlySortedArray
    {
        public int SearchInNearlySortedArray(int[] arr, int ele)
        {

            int n = arr.Length;
            int start = 0;
            int end = n - 1;

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
                else if (mid != start && arr[mid - 1] == ele)
                {
                    return mid - 1;
                }
                else if (mid != end && arr[mid + 1] != ele)
                {
                    return mid + 1;
                }
                else if (ele < arr[mid])
                {
                    end = mid - 2;
                }
                else
                {
                    start = mid + 2;
                }
            }

            // Item not found
            return -1;
        }
    }
}
