using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures_Algorithms.BinaryTree
{
    internal class _05_DiameterOfBinaryTee
    {
        internal int diameter = 0;
        public int DiameterOfBinaryTree(Node root)
        {
            int diameter = 0;
            Height(root, ref diameter);
            return diameter;
        }

        private int Height(Node root, ref int diameter)
        {
            if (root == null) 
                return 0;

            var left_height = Height(root.Left, ref diameter);
            var right_height = Height(root.Right, ref diameter);
            var current_height = 1 + Math.Max(left_height, right_height);

            int diameterWhenCurrentNodeIsIncluded = left_height + right_height + 1;
            diameter = Math.Max(diameter, diameterWhenCurrentNodeIsIncluded);

            return current_height;
        }
    }
}
