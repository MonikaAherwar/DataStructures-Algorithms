using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures_Algorithms.LinkedList
{
    internal class _02_ReverseAlinkedList
    {
        public static Node ReverseLinkedList(Node head)
        {
            Node prev = null;
            while(head != null)
            {
                Node curr = head;
                head = head.next;
                curr.next = prev;
                prev = curr;                
            }

            return prev;
        }
    }
}
