using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures_Algorithms.LinkedList
{
    internal class _04_AddTwoNumbers
    {
        public Node AddTwoNumbers(Node n1, Node n2)
        {
            Node n1_reversed = _02_ReverseAlinkedList.ReverseLinkedList(n1);
            Node n2_reversed = _02_ReverseAlinkedList.ReverseLinkedList(n2);
            Node curr = new Node(-1);

            int sum = 0;
            int carry = 0;
            while(n1_reversed != null && n2_reversed != null)
            {
                sum = n1_reversed.data + n2_reversed.data + carry;
                carry = sum / 10;
                sum = sum % 10;

                curr.next = new Node(sum);
                curr = curr.next;
                n1_reversed = n1_reversed.next;
                n2_reversed = n2_reversed.next;
            }

            if (n1_reversed != null)
            {
                sum = n1_reversed.data + carry;
                carry = sum / 10;
                sum = sum % 10;

                curr.next = new Node(sum);
                curr = curr.next;
                n1_reversed = n1_reversed.next;
            }
            else { 
                // for n2
            }

            if(carry == 1)
            {
                curr.next = new Node(1);
                curr = curr.next;
            }

            Node head = _02_ReverseAlinkedList.ReverseLinkedList(curr);
            return head;
        }

    }
}
