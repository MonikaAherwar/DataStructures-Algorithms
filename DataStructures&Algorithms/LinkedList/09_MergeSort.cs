using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace DataStructures_Algorithms.LinkedList
{
    internal class _09_MergeSort
    {
        public Node MergeSort(Node head)
        {
            // Base case : if head is null
            if (head == null || head.next == null)
            {
                return head;
            }

            // get the middle of the list
            Node mid = GetMiddle(head);
            Node nextofmiddle = mid.next;

            // set the next of middle Node to null
            mid.next = null;

            // Apply mergeSort on left list
            Node left = MergeSort(head);

            // Apply mergeSort on right list
            Node right = MergeSort(nextofmiddle);

            // Merge the left and right lists
            Node sortedlist = _01_MergeTwoSortedLinkedList.Merge(left, right);
            return sortedlist;
        }

        // Utility function to get the
        // middle of the linked list
        Node GetMiddle(Node head)
        {
            // Base case
            if (head == null)
                return head;
            Node fastptr = head.next;
            Node slowptr = head;

            // Move fastptr by two and slow ptr by one
            // Finally slowptr will point to middle Node
            while (fastptr != null)
            {
                fastptr = fastptr.next;
                if (fastptr != null)
                {
                    slowptr = slowptr.next;
                    fastptr = fastptr.next;
                }
            }
            return slowptr;
        }

    }
}
