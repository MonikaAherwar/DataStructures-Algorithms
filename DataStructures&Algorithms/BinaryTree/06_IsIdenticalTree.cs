using DataStructures_Algorithms.SlidingWindow;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures_Algorithms.BinaryTree
{
    internal class _06_IsIdenticalTree
    {

        public static bool IsIdentical(Node root1, Node root2)
        {
            if (root1 == null && root2 == null)
                return true;

            if (root1 == null || root2 == null)
                return false;

            // Case: When root1 != NULL && root2 != NULL
            return (root1.Key == root2.Key)
                && IsIdentical(root1.Left, root2.Left)
                && IsIdentical (root1.Right, root2.Right);
        }
    }
}
