using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures_Algorithms.Arrays
{
    internal class _01_RainWaterTrappingProblem
    {
        // IP: 0 1 0 2 1 0 1 3 2 1 2 1
        // OP: Water collected after rain
        public int RainWaterTrapping(int[] arr)
        {
            int waterCapacity = 0;
            int n = arr.Length;

            if (n == 0)
            {
                throw new ArgumentException("Array is Empty");
            }

            int[] left = new int[n];
            int[] right = new int[n];
            

            left[0] = arr[0];
            right[n-1] = arr[n-1];

            //Fill Left array
            for(int i = 1; i<n; i++)
            {
                left[i] = Math.Max(left[i - 1], arr[i]);
            }

            //Fill Right array
            for(int i = n-2; i >=0; i--)
            {
                right[i] = Math.Max(right[i + 1], arr[i]);
            }

            // Find water capacity stored after rain
            for(int i=0; i<n; i++)
            {
                waterCapacity += Math.Min(left[i], right[i]) - arr[i];
            }
                
            return waterCapacity;
        }
    }
}
