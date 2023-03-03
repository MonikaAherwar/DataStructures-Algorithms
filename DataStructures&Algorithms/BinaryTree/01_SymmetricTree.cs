using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Text;

namespace DataStructures_Algorithms.BinaryTree
{
    internal class _01_SymmetricTree
    {
        public bool IsSymmetricTree(Node root)
        {
            return IsSymmetricTreeHelper(root, root);
        }

        private bool IsSymmetricTreeHelper(Node node1, Node node2)
        {

            if (node1 == null && node2 == null)
                return true;
            else if(node1 == null || node2 == null)
                return false;

            // When node1 != null && node2 != null
            return (node1.Key == node2.Key)
                && IsSymmetricTreeHelper(node1.Left, node2.Right)
                && IsSymmetricTreeHelper(node1.Right, node2.Left);
        }
    }
}
