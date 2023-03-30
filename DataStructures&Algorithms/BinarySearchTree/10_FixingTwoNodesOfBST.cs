using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Text;

namespace DataStructures_Algorithms.BinarySearchTree
{
    internal class _10_FixingTwoNodesOfBST
    {
        public void FixNodes(Node root)
        {
            if(root == null)
            {
                throw new ArgumentNullException("Tree is Empty");
            }

            Node node1 = null;
            Node node2 = null;

            BST_Traversal(root, Int32.MaxValue, Int32.MinValue, node1, node2);

            if(node1 != null && node2 != null)
            {
                //Swap node1 and node2
            }
            else
            {
                throw new Exception("No two nodes exist");
            }
        }

        private void BST_Traversal(Node root, int min, int max, Node node1, Node node2)
        {
            if (root == null) return;

            //If key is out of range
            if(root.Key < min && root.Key > max) 
            {
                if (node1 == null) node1 = root;
                if (node2 == null) node2 = root;
            }

            BST_Traversal(root.Left, min, root.Key, node1, node2);
            BST_Traversal(root.Right, root.Key, max, node1, node2);
        }
    }
}
