using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures_Algorithms.BinaryTree
{
    internal class _11_IterativeorPostoderTraversal
    {
        // Using two stack
        // Or we can use one stack or one list
        // As I used below.
        // Instead of list, we can  use another stack
        // To reverse the output.
        public void IterativePostOrderUsingTwoStacks(Node root)
        {

            if (root == null)
            {
                throw new ArgumentNullException("Tree is Empty");
            }

            Stack<Node> stack = new Stack<Node>();
            List<int> ans = new List<int>();

            Node curr = root;
            stack.Push(curr);

            while (stack.Count != 0 && curr != null)
            {
                curr = stack.Pop();
                ans.Add(curr.Key);

                if(curr.Left != null)
                    stack.Push(curr.Left);

                if(curr.Right != null)
                    stack.Push(curr.Right);
            }

            ans.Reverse();
            // print ans
        }


        // Using one stack
        public void IterativePostOrderUsingOneStacks(Node root)
        {

            if (root == null)
            {
                throw new ArgumentNullException("Tree is Empty");
            }

            Stack<Node> stack = new Stack<Node>();
            List<int> ans = new List<int>();

            Node curr = root;

            while (stack.Count != 0 || curr != null)
            {

                if(curr != null)
                {
                    stack.Push((Node)curr);
                    curr = curr.Left;
                }
                else
                {
                    Node temp = stack.Peek().Right;

                    // If right node exist
                    if(temp != null)
                    {
                        curr = temp;
                    }
                    // When right node does not exist
                    else
                    {
                        Node node = stack.Pop();
                        ans.Add(node.Key);

                        // If current temporary element is right of stack's top most element
                        // That means we have already traversed left tree completely
                        // ans last traversed node (temporray) was also traversed
                        // that means, next answers = stack.Peek();
                        while(stack.Count > 0 && stack.Peek().Right == temp)
                        {
                            temp = stack.Pop();
                            ans.Add(temp.Key);
                        }
                    }
                }
            }

            // Print ans
            // return ans;

        }
    }
}
