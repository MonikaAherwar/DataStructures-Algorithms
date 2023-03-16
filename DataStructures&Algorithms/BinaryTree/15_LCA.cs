using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures_Algorithms.BinaryTree
{
    internal class _15_LCA
    {
        bool found1 = false;
        bool found2 = false;

        public Node LCA(Node root, int n1, int n2)
        {
            Node tree = LCAUtil(root, n1, n2);

            if(found1 && found2){
                return tree;
            }
            else
            {
                return null;
            }
        }

        public Node LCAUtil(Node root, int n1, int n2)
        {
            if (root == null)
                return null;

            Node temp = null;

            if(root.Key == n1)
            {
                found1 = true;
                temp = root;
            }

            if(root.Key == n2)
            {
                found2 = true;
                temp = root;
            }

            Node left = LCAUtil(root.Left, n1, n2);
            Node right = LCAUtil(root.Right, n1, n2);

            if (temp != null)
                return temp;
             
            if(left != null && right != null)
            {
                return root;
            }

            return left != null ? left : right;
        }
    }
}