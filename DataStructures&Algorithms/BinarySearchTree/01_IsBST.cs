using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace DataStructures_Algorithms.BinarySearchTree
{
    internal class _01_IsBST
    {
        public bool IsBST(Node root)
        {
            return IsBSTUtil(root, Int32.MinValue, Int32.MaxValue);            
        }

        public bool IsBSTUtil(Node root, int min , int max)
        {
            if(root == null) return true;

            if(root.Key > max || root.Key < min)
            {
                return false;
            }

            bool left = IsBSTUtil(root.Left, min, root.Key);
            bool right = IsBSTUtil(root.Right, root.Key, max);

            return left && right;
        }
    }
}
