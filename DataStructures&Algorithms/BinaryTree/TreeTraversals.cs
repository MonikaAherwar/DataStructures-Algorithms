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

        
    }
}
