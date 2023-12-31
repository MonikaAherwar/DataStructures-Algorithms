﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures_Algorithms.DP
{
    internal class DP_Helper
    {
        public static int[,] FillDefault(int[,] dp)
        {
            int m = dp.GetLength(0);
            int n = dp.GetLength(1);

            for(int i = 0; i < m; i++)
            {
                for(int j = 0; j < n; j++)
                {
                    dp[i, j] = -1;
                }
            }

            return dp;
        }

        public static int[,] FillDefault(int m , int n)
        {
            int[,] dp = new int[m, n];

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    dp[i, j] = -1;
                }
            }

            return dp;
        }
    }
}
