using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures_Algorithms.BinaryTree
{
    internal class _17_SumTree
    {
        bool IsSumTree = true;
        public void SumTree(Node root)
        {
            if(root == null)
            {
                throw new ArgumentNullException("Tree is Empty");
            }

            int sum = SumTreeUtil(root);
            if (IsSumTree)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }

        public int SumTreeUtil(Node root)
        {
            if (root == null)
            {
                return 0;
            }


            int left;
            int right;

            left = SumTreeUtil(root.Left);
            if (left == -1) return -1;

            right = SumTreeUtil(root.Right);
            if (right == -1) return -1;

            //If leaft node
            if ((root.Left == null && root.Right == null))
                return root.Key;

            // If a node that is not leaf
            if (left + right == root.Key)
                return left + right + root.Key;

            return -1;          
        }
    }
}
