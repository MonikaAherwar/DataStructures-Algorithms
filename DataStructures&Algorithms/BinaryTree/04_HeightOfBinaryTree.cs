using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Text;

namespace DataStructures_Algorithms.BinaryTree
{
    internal class _04_HeightOfBinaryTree
    {
        public int Height(Node root)
        {
            if (root == null)
                return 0;

            int left = Height(root.Left);
            int right = Height(root.Right); 
            int height = Math.Max(left, right) + 1;
            return height;
        }
    }
}
