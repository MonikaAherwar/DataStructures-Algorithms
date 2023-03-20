using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures_Algorithms.BinaryTree
{
    internal class _19_MaximumSumPathBetweenTwoLeafNodes
    {
        int max_sum = Int32.MinValue;
        public int MaximumSumPathBetweenTwoLeafNodes(Node root)
        {
            if (root == null)
                return 0;

            int l = MaximumSumPathBetweenTwoLeafNodes(root.Left);
            int r = MaximumSumPathBetweenTwoLeafNodes(root.Right);

            

            int sumWhenNodeIsPartOfMaxPathSum = Math.Max(Math.Max(l, r) + root.Key, root.Key);
            int sumWhenNodeIsRootOfMaxSumPath = Math.Max(sumWhenNodeIsPartOfMaxPathSum, l + r + root.Key);

            max_sum = Math.Max(max_sum, sumWhenNodeIsRootOfMaxSumPath);

            return sumWhenNodeIsPartOfMaxPathSum;         
        }
    }
}
