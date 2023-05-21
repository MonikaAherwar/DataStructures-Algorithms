using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures_Algorithms.BinarySearch
{
    internal class _18_SearchIn2DSortedArray
    {

        //Time complexity = Log(n) + Log(n)
        public (int, int) SearchInRowWiseColumnWiseSortedArray(int[,] arr, int ele)
        {
            int rows = arr.GetLength(0);
            int columns = arr.GetLength(1);
            int row = 0;
            int col = columns - 1;

            while((row >=0 || row < rows) && (col >= 0 || col < columns))
            {
                if (arr[row, col] == ele)
                {
                    return (row, col);
                }
                else if (ele < arr[row, col])
                {
                    col--;
                }
                else if(ele > arr[row, col])
                {
                    row++;
                }
            }

            return (-1, -1);
        }
    }
}
