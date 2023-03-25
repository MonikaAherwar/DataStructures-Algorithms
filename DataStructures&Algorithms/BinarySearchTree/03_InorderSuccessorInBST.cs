using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures_Algorithms.BinarySearchTree
{
    internal class _03_InorderSuccessorInBST
    {
        // O(h)
        // Can also be solved using Morris Traversal
        public Node InorderSuccessorBST(Node root, Node n1)
        {
            if(root == null)
            {
                throw new ArgumentNullException("Tree is Empty");
            }

            if(n1 == null)
            {
                throw new ArgumentNullException("target node is null");
            }

            return InorderSuccessorBSTUtil(root, n1);
        }


        private Node InorderSuccessorBSTUtil(Node root, Node n1)
        {
            if(n1.Right != null)
            {
                return GetMinValueInRightSubtree(n1.Right);
            }

            // When Right Subtree is NULL
            // Successor is present before the n1 in the tree traversal
            // Scan tree

            Node succ = null;
            Node curr = root;
            while(curr != null)
            {
                if(n1.Key < curr.Key)
                {
                    succ = curr;
                    curr = curr.Left;
                }
                else if(n1.Key > curr.Key)
                {
                    curr = curr.Right;
                }
                else
                {
                    break;
                } 
            }

            return succ;
        }

        private Node GetMinValueInRightSubtree(Node root)
        {
            Node curr = root;
            Node node = null;
            while(curr != null)
            {
                node = curr;
                curr = curr.Left;
            }

            return node;
        }
    }
}
