using DataStructures_Algorithms.SlidingWindow;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures_Algorithms.Stack
{
    internal class _07_MaximumAreaOfRectangleInBinaryMatrix
    {
        public int MaximumAreaOfRectangleInBinaryMatrix(int[,] arr)
        {

            int rows = arr.GetLength(0);
            int cols = arr.GetLength(1);

            if (rows == 0 || cols == 0)
            {
                throw new ArgumentException("Array is Empty");
            }

            int[] mah_array = new int[cols];
            int mah_area = 0;
            int max_mah_area = 0;

            for(int i=0; i< rows; i++)
            {
                for(int j=0; j<cols; j++)
                {
                    if (arr[i, j] == 0)
                    {
                        mah_array[j] = 0;
                    }
                    else
                    {
                        mah_array[j] = mah_array[j] + arr[i, j];
                    }
                    
                }

                mah_area = _06_MaximumAreaOfHistogram.MaximumAreaOfHistogram(mah_array);
                max_mah_area = Math.Max(max_mah_area, mah_area);
            }

            return max_mah_area;
        }
    }
}
