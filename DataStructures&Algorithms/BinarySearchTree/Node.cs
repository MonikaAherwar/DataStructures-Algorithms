using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures_Algorithms.BinarySearchTree
{
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
