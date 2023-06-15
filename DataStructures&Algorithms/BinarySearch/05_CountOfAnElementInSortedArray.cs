using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures_Algorithms.BinarySearch
{
    internal class _05_CountOfAnElementInSortedArray
    {

        public int CountOfElement(int[] arr, int ele) {

            int count = 0;

            int first = _04_FirstOccurenceOfElement.FirstOccurence(arr, ele);
            int last = _04_LastOccurenceOfElement.LastOccurence(arr, ele);

            count = last - first + 1;

            return count;
        }  
    }
}
