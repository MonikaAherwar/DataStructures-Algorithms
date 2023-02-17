using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace DataStructures_Algorithms.LinkedList
{
    internal class _05_FindMiddleElement
    {
        public static Node MiddleElement(Node head)
        {
            if(head == null) return null;
            Node slow = head;
            Node fast = head;

            while(fast.next != null && fast.next.next != null)
            {
                slow = slow.next;
                fast = fast.next?.next;
            }

            return slow;
        }
    }
}
