using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures_Algorithms.BinaryTree
{
    internal class _18_BinaryTreeToDoublyLinkedList
    {

        // Recursive Way

        public static Node prev = null;
        public Node head;
        public void BinaryTree2DoubleLinkedList(Node root)
        {
            if (root == null)
            {
                return;
            }

            // Recursively convert left subtree 
            BinaryTree2DoubleLinkedList(root.Left);

            // Now convert this node 
            if (prev == null)
            {
                head = root;
            }
            else
            {
                root.Left = prev;
                prev.Right = root;
            }
            prev = root;

            // Finally convert right subtree 
            BinaryTree2DoubleLinkedList(root.Right);
        }

        // Iterative way: Morris Travel
        public void BinaryTree2DoubleLinkedList_Iterative(Node root)
        {

        }

    }
}
