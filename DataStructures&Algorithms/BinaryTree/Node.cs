using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures_Algorithms.BinaryTree
{
    // Class containing left and right child
    // of current node and key value

    internal class Node
    {
        internal int Key;
        internal Node Left;
        internal Node Right;

        public Node(int item)
        {
            Key = item;
            Left = Right = null;
        }
    }
}
