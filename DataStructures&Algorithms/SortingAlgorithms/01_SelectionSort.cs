using DataStructures_Algorithms.SlidingWindow;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures_Algorithms.SortingAlgorithms
{
    internal class SelectionSort
    {
        // O(N^2)
        // In Place
        // Not Stable
        public void SelectionSortAlgorithm(int[] arr)
        {
            int n = arr.Length;
            if(n == 0)
            {
                throw new ArgumentException("Array is Empty");
            }

            for(int i = 0; i < n; i++)
            {
                int min_Index = i;
                for(int j = i+1; j < n; j++)
                {
                    if (arr[j] < arr[min_Index])
                    {
                        min_Index = j;                     
                    }
                }  
                
                //Swap
                int temp = arr[i];
                arr[i] = arr[min_Index];
                arr[min_Index] = temp;
            }
        }


        // O(N^2)
        // In Place
        // Not Stable
        public void SelectionSortAlgorithm_Stable(int[] arr)
        {
            int n = arr.Length;
            if (n == 0)
            {
                throw new ArgumentException("Array is Empty");
            }

            for (int i = 0; i < n; i++)
            {
                int min_Index = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (arr[j] < arr[min_Index])
                    {
                        min_Index = j;
                    }
                }

                // Instead swap the min element with index i
                // We will slide the elements from i to min index
                // This will maintain the order of elements 
                // Hence stable

                int min_ele = arr[min_Index];
                for (int k = min_Index; k > i; k--)
                {
                    arr[k] = arr[k - 1];
                }

                arr[i] = min_ele;
            }
        }
    }
}
