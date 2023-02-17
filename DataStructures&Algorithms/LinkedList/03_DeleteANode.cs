using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures_Algorithms.LinkedList
{
    internal class _03_DeleteANode
    {
        public void DeleteNodeWithHeadPointer(Node head)
        {
            int val = head.next.data;
            head.next = head.next.next;
            head.data = val;
        }
    }
}
