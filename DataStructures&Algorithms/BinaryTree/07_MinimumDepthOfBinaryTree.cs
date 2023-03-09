using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures_Algorithms.BinaryTree
{
    internal class _07_MinimumDepthOfBinaryTree
    {
        int minDepth = Int32.MaxValue;

        // Top Bottom approach
        public void GetMinimumDepth(Node root, int currDepth)
        {
            if (root == null)
                minDepth = 0;

            // Leaf Node
            if (root.Left == null && root.Right == null)
            {
                minDepth = Math.Min(minDepth, currDepth);
            }

            GetMinimumDepth(root.Left, currDepth + 1);
            GetMinimumDepth(root.Right, currDepth + 1);
        }

        // Bottom to top 
        public int GetMinimumDepth2(Node root)
        {
            if (root == null)
                return 0;

            // Leaf Node
            if (root.Left == null && root.Right == null)
            {
                return 1;
            }

            int l = 0; 
            int r = 0;

            if(root.Left != null)
                l = GetMinimumDepth2(root.Left);
            if(root.Right != null)
                r = GetMinimumDepth2(root.Right);

            return Math.Min(l, r) + 1;
        }
    }
}
