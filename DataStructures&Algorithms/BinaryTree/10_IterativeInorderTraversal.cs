using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures_Algorithms.BinaryTree
{
    internal class _10_IterativeInorderTraversal
    {

        // Using one stack
        public void IterativeInOrder(Node root)       
        {

            if(root == null)
            {
                throw new ArgumentNullException("Tree is Empty");
            }

            Stack<Node> stack = new Stack<Node>();
            List<int> ans = new List<int>();
            
            Node curr = root;

            while (stack.Count != 0 && curr != null)
            {
                while(curr != null)
                {
                    stack.Push(curr);
                    curr = curr.Left;
                }

                curr = stack.Pop();
                ans.Add(curr.Key);

                curr = curr.Right;
            }
            
            // Print List: ans
            // return ans;
        }
    }
}
