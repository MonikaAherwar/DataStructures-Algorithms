using DataStructures_Algorithms.SlidingWindow;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures_Algorithms.DP
{
    internal class _01_01KnapSack
    {
        // wt[]: Weight array
        // val[]: value array
        // W: Total target weight
        // n: no. of elements in wt, val array

        public int _01_KnapSack_Recursive(int[] wt, int[] val, int W, int n)
        {
            if(W == 0 || n == 0)
            {
                return 0;
            }

            int value = 0;
            if (wt[n-1] <= W)
            {
                value = Math.Max(val[n - 1] + _01_KnapSack_Recursive(wt, val, W - val[n - 1], n - 1),
                    _01_KnapSack_Recursive(wt, val, W, n - 1));
            }
            else if (wt[n-1] > W)
            {
                value = _01_KnapSack_Recursive(wt, val, W, n - 1);
            }

            return value;
        }


        //*********
        // Memoised
        //*********

        int[,] t = DP_Helper.FillDefault(m: 4, n: 7);
        
        public int _01_KnapSack_Memoised(int[] wt, int[] val, int W, int n)
        {
            if (W == 0 || n == 0)
            {
                return 0;
            }

            if (t[n, W] != -1)
                return t[n, W];

            int value = 0;
            if (wt[n - 1] <= W)
            {
                value = Math.Max(val[n - 1] + _01_KnapSack_Memoised(wt, val, W - val[n - 1], n - 1),
                    _01_KnapSack_Memoised(wt, val, W, n - 1));
            }
            else if (wt[n - 1] > W)
            {
                value = _01_KnapSack_Memoised(wt, val, W, n - 1);
            }

            t[n, W] = value;
            return t[n, W];
        }

        
    }
}
