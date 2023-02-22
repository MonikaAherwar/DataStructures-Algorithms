using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures_Algorithms.LinkedList
{
    internal class _10_IntersectionY
    {
        public Node Intersection(Node list1, Node list2)
        {
            if (list1 == null || list2 == null) return null;

            Node curr1 = list1;
            Node curr2 = list2;

            int count_list1 = 0;
            int count_list2 = 0;

            while (curr1 != null)
            {
                curr1 = curr1.next;
                count_list1++;
            }

            while (curr2 != null)
            {
                curr2 = curr2.next;
                count_list2++;
            }

            int diff = Math.Abs(count_list2 - count_list1);
            if(count_list1 > count_list2)
            {
                while(diff > 0)
                {
                    curr1 = curr1.next;
                }
            }
            else
            {
                while (diff > 0)
                {
                    curr2 = curr2.next;
                }
            }

            while(curr1 != curr2)
            {
                curr1 = curr1.next;
                curr2 = curr2.next;
            }

            return curr1;
        }
    }
}
