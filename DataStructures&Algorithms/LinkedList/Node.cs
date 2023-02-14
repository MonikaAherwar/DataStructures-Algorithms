using DataStructures_Algorithms.SlidingWindow;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures_Algorithms.LinkedList
{
    internal class Node
    {
        internal int data;
        internal Node next;

        internal Node(int item) 
        { 
            this.data = item;
            this.next = null;
        }
    }

    internal class NodeWithRight
    {
        internal int data;
        internal NodeWithRight next;
        internal NodeWithRight right;

        internal NodeWithRight(int item)
        {
            this.data = item;
            next = null;
            right = null;
        }
    }

    internal class NodeWithRandom
    {
        internal int data;
        internal NodeWithRandom next;
        internal NodeWithRandom random;

        internal NodeWithRandom(int item)
        {
            this.data = item;
            next = null;
            random = null;
        }
    }
}
