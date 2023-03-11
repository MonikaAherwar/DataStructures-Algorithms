using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures_Algorithms.BinaryTree
{
    internal class _09_IterativePreorderTraversal
    {
        // With one stack

        public void IterativePreOrderByMe(Node root)
        {
            if (root == null)
            {
                throw new ArgumentNullException("Tree is Empty");
            }

            Stack<Node> stack = new Stack<Node>();
            List<int> ans = new List<int>();

            Node curr = root;
            stack.Push(root);

            while (stack.Count != 0 && curr != null)
            {
                curr = stack.Pop();
                ans.Add(curr.Key);

                if(curr.Right != null)
                    stack.Push((Node)curr.Right);

                if(curr.Left != null)
                    stack.Push((Node)curr.Left);

            }
            
            // Print ans
            // return ans;
        }


        public void IterativePreOrder_ByMe(Node root)
        {
            if (root == null)
            {
                throw new ArgumentNullException("Tree is Empty");
            }

            Stack<Node> stack = new Stack<Node>();
            List<int> ans = new List<int>();

            Node curr = root;

            while (stack.Count != 0)
            {
                ans.Add(curr.Key);

                if(curr.Right != null)
                    stack.Push(curr.Right);

                curr = curr.Left;

                if (curr == null && stack.Count > 0)
                {
                    curr = stack.Pop();
                }
            }
        }
    }
}
