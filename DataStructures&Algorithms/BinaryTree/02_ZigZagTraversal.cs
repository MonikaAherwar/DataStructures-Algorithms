using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures_Algorithms.BinaryTree
{
    internal class _02_ZigZagTraversal
    {
        public void ZigZagTraversal(Node root)
        {

            //Using two Stacks
            ZigZagTraversalUsingTwoStacks(root);

            //Using one queue
            ZigZagTraversalUsingTwoStacks(root);
        }

        public void ZigZagTraversalUsingTwoStacks(Node root)
        {
            if(root == null) {
                throw new ArgumentNullException("Tree is Empty");
            }

            Stack<Node> stack1 = new Stack<Node>();
            Stack<Node> stack2 = new Stack<Node>();
            List<int> ans = new List<int>();
            stack1.Push(root);

            while(stack1.Count != 0 || stack2.Count!= 0)
            {
                while(stack1.Count != 0)
                {
                    Node node = stack1.Pop();
                    ans.Add(node.Key);
                    stack2.Push(node.Left);
                    stack2.Push(node.Right);
                }

                while(stack2.Count != 0)
                {
                    Node node = stack2.Pop();
                    ans.Add(node.Key);
                    stack2.Push(node.Right);
                    stack2.Push(node.Left);
                }
            }

            //Print Answer
            //return  ans;
        }

        public void ZigZagTraversalUsingOneQueue(Node root)
        {

            if (root == null)
            {
                throw new ArgumentNullException("Tree is Empty");
            }

            Queue<Node> q = new Queue<Node>();
            List<int> ans = new List<int>();
            List<int> level = new List<int>();
            bool reverse = false;

            q.Enqueue(root);

            while (q.Count != 0)
            {
                int size = q.Count;

                for(int i =0; i < size; i++)
                {
                    Node node = q.Dequeue();
                    level.Add(node.Key);

                    if(node.Left != null)
                        q.Enqueue(node.Left);
                    if (node.Right != null)
                        q.Enqueue(node.Right);  
                }

                if (reverse)
                {
                    level.Reverse();
                    ans.AddRange(level);
                    level.Clear();
                }

                reverse = !reverse;
            }

            // Print Traversal
            // return ans;
        }
    }
}
