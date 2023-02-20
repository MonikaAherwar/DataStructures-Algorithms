using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures_Algorithms.LinkedList
{
    internal class _08_DeletectAndRemoveLoop
    {
        public void DetectAndRemoveLoop(Node head)
        {
            if (head == null || head.next == null) return;

            Node slow = head;
            Node fast = head;

            while(slow != null && fast != null && fast.next != null)
            {
                slow = slow.next;
                fast = fast.next.next;

                if(slow == fast)
                {
                    RemoveLoop(slow, fast, head);
                }
            }
        }

        private void RemoveLoop(Node slow, Node fast,Node head)
        {
            slow = head;
            while(slow.next != fast.next)
            {
                slow = slow.next;
                fast = fast.next;
            }

            fast.next = null;
        }
    }
}
