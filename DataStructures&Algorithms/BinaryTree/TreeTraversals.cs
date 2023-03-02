using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures_Algorithms.BinaryTree
{
    internal class TreeTraversals
    {

        // TREE:
        //
        //          1
        //      2       3
        //  4      5 6      7
        //
        // root = 1


        // OP: 1 2 4 5 3 6 7
        public void PreOrderTraversal(Node root)
        {
            if(root != null)
            {
                Console.WriteLine(root.Key);
                PreOrderTraversal(root.Left);
                PreOrderTraversal(root.Right);
            }
        }

        // OP: 4 2 5 1 6 3 7
        public void InOrderTraversal(Node root)
        {
            if (root != null)
            { 
                InOrderTraversal(root.Left);
                Console.WriteLine(root.Key);
                InOrderTraversal(root.Right);
            }
        }

        // OP: 4 5 2 6 7 3 1
        public void PostOrderTraversal(Node root)
        {
            if (root != null)
            {
                PostOrderTraversal(root.Left);
                PostOrderTraversal(root.Right);
                Console.WriteLine(root.Key);
            }
        }
    }
}
