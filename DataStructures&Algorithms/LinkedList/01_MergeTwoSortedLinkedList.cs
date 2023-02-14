using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures_Algorithms.LinkedList
{
    internal class _01_MergeTwoSortedLinkedList
    {
        public static Node Merge(Node n1, Node n2)
        {
            Node head = new Node(-1);
            Node curr = head;

            while(n1 != null && n2 != null)
            {
                if(n1.data <= n2.data)
                {
                    curr.next = n1;
                    n1 = n1.next;
                    curr = curr.next;
                }
                else
                {
                    curr.next = n2;
                    n2 = n2.next;
                    curr = curr.next;
                }
            }

            if(n1 != null)
            {
                curr.next = n1;
            }
            else
            {
                curr.next = n2;
            }

            return head.next;
        }


        // Recursive Code
        public Node Merge_Recursive(Node A, Node B)
        {

            // Base cases
            if (A == null)
                return B;
            if (B == null)
                return A;

            // Pick either a or b, and recur
            if (A.data <= B.data)
            {
                A.next = Merge_Recursive(A.next, B);
                return A;
            }
            else
            {
                B.next = Merge_Recursive(A, B.next);
                return B;
            }
        }
    }
}
