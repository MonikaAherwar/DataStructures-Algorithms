using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures_Algorithms.BinarySearchTree
{
    internal class _07_UniqueBSTs
    {

        // For N = 3
        // OP: 5
        static int numberOfUniqueBST(int n)
        {

            // DP to store the number
            // of unique BST with key i
            int[] dp = new int[n + 1];

            // Base case
            dp[0] = 1;
            dp[1] = 1;

            // fill the dp table in
            // top-down approach.
            for (int i = 2; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {

                    // n-i in right * i-1 in left
                    dp[i] = dp[i] + (dp[i - j] * dp[j - 1]);
                }
            }
            return dp[n];
        }
    }
}
