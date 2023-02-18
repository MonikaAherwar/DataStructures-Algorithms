using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures_Algorithms.LinkedList
{
    internal class _06_CheckIfLinkedListIsPalindrome
    {
        public bool IsPalindrome(Node head)
        {
            Node mid = _05_FindMiddleElement.MiddleElement(head);
            Node mid_reverse = _02_ReverseAlinkedList.ReverseLinkedList(mid.next);

            bool isPalindrome = true;
            while(mid != null && mid_reverse != null)
            {
                if(mid.data != mid_reverse.data)
                {
                    isPalindrome = false;
                    break;
                }
            }

            mid.next = _02_ReverseAlinkedList.ReverseLinkedList(mid_reverse);
            return isPalindrome;
        }
    }
}
