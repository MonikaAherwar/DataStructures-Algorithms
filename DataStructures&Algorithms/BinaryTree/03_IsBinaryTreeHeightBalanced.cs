using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures_Algorithms.BinaryTree
{
    internal class _03_IsBinaryTreeHeightBalanced
    {
        static bool IsHeightBalanced = true;
        public void IsBinaryTreeHeightBalanced(Node root)
        {
            Height(root);

            if (IsHeightBalanced)
                Console.WriteLine("The tree is height balanced");
            else
            {
                Console.WriteLine("The tree is not height balanced");
            }
        }

        public int Height(Node root)
        {
            if (root == null)
                return 0;

            int left = Height(root.Left);
            int right = Height(root.Right);

            if(Math.Abs(left - right) > 1)
            {
                IsHeightBalanced = false;
            }

            int height = Math.Max(left, right) + 1;
            return height;
        }
    }
}
