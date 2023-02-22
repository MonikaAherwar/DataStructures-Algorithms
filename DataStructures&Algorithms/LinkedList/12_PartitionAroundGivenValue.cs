using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures_Algorithms.LinkedList
{
    internal class _12_PartitionAroundGivenValue
    {
        public Node Partition(Node head, int key)
        {
            if(head == null) return null;

            Node left_head = new Node(-1);
            Node right_head = new Node(-1);
            Node left = left_head;
            Node right = right_head;
            Node curr = head;

            while(curr != null)
            {
                if(curr.data <= key)
                {
                    left.next = curr;
                    left = curr;
                }
                else
                {
                    right.next = curr;
                    right = curr;
                }
                curr = curr.next;
            }

            if(left != null && right != null)
            {
                left_head.next = right_head.next;
                return left_head;
            }
            
            return head;
        }
    }
}
