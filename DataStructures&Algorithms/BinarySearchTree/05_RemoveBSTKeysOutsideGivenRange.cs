using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures_Algorithms.BinarySearchTree
{
    internal class _05_RemoveBSTKeysOutsideGivenRange
    {
        public Node RemoveBSTKeysOutsideRange(Node root, int min, int max)
        {
            if(root == null) return null;

            root.Left = RemoveBSTKeysOutsideRange(root.Left, min, max);

            root.Right = RemoveBSTKeysOutsideRange(root.Right, min, max);

            if (root.Key < min)
            {
                root = root.Right;
            }
            else if (root.Key > max)
            {
                root = root.Left;
            }

            return root;
        }
    }
}
