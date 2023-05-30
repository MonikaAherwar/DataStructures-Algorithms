using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures_Algorithms.BinarySearch
{
    internal class _13_FindIndexOfFirstOneInBinarySortedArray
    { 
        public static int FindIndexOfFirstOneInBinarySortedArray(int[] arr) { 
                      
            int start = 0;
            int end = start+1;
            int ele = 1;
            int index = -1;

            while(ele > arr[end])
            {
                start = end;
                end = end * 2;
            }

            while (start < end)
            {

                int mid = start + ((end - start) / 2);

                if (arr[mid] == ele)
                {
                    index = mid;
                    end = mid - 1;
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

            return index;

        }
    }
}
