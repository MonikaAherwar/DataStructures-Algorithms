using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures_Algorithms.LinkedList
{
    internal class _11_RotateByKPlaces
    {
        public Node RotateByK(Node head, int k)
        {
            if(head == null) return null;

            Node prev = null;
            Node curr = head;
            while (k > 0 && curr != null)
            {
                Node temp = curr.next;
                curr.next = prev;
                prev = curr;
                curr = temp;
                k--;
            }

            head.next = RotateByK(curr, k);
            return prev;
        }
    }
}
