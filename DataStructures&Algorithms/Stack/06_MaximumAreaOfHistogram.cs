using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures_Algorithms.Stack
{
    internal class _06_MaximumAreaOfHistogram
    {

        public static int MaximumAreaOfHistogram(int[] arr)
        {

            int n = arr.Length;

            if (n == 0)
            {
                throw new ArgumentException("Array is Empty");
            }

            List<int> left = _03_NSL_NextSmallestLeft.NSL_Helper(arr);
            List<int> right = _04_NSR_NextSmallestRight.NSR_Helper(arr);

            int width = 0;
            int curr_area = 0;
            int max_area = 0;

            for(int i = 0; i<n; i++)
            {
                width = right[i] - left[i] -1;
                curr_area = width * arr[i];
                max_area = Math.Max(max_area, curr_area);
            }

            return max_area;
        }

    }
}
