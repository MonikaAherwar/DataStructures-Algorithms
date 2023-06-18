using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures_Algorithms.LinkedList
{
    internal class _07_Rearrage
    {
        public Node RearrangeEvenOdd(Node head)
        {
            if (head == null) return null;
            Node even_head = new Node(-1);
            Node odd_head = new Node(1);
            Node even = even_head;
            Node odd = odd_head;
            Node curr = head;

            while(curr != null)
            {
                if(curr.data % 2 == 0)
                {
                    even.next = curr;
                    even = even.next;
                }
                else 
                { 
                    odd.next = curr;
                    odd = odd.next;
                }

                curr = curr.next;
            }

            even_head = even_head.next;
            odd_head = odd_head.next;

            if(odd_head != null && even_head != null)
            {
                odd.next = even_head;
                return odd_head;
            }
                
            // If any of the above list head is null then 
            // original list does contains same type of numbers
            // either even or odd
            // Hence return the original list
            return head;
        }
    }
}
