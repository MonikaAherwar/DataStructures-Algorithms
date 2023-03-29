using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures_Algorithms.BinarySearchTree
{
    internal class _08_PreorderTraversalAndBST
    {
        int preIndex = 0;
        public bool canRepresentBST(int[] arr, int N)
        {
            // code here
            int min = Int32.MinValue, max = Int32.MaxValue;

            buildBST_helper(N, arr, min, max);

            return preIndex == N;
        }

        // We are actually not building any tree
        private void buildBST_helper(int n, int[] pre, int min, int max)
        {
            if (preIndex >= n)
                return;

            if (min <= pre[preIndex] && pre[preIndex] <= max)
            {
                // build node
                int rootData = pre[preIndex];
                preIndex++;

                // build left subtree
                buildBST_helper(n, pre, min, rootData);

                // build right subtree
                buildBST_helper(n, pre, rootData, max);
            }
            // else
            // return NULL;
        }
    }
}
