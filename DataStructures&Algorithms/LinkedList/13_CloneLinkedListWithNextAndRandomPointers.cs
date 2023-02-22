using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Channels;

namespace DataStructures_Algorithms.LinkedList
{
    internal class _13_CloneLinkedListWithNextAndRandomPointers
    {
        public NodeWithRandom Clone(NodeWithRandom head)
        {
            if (head == null) return null;
      
            NodeWithRandom curr = head;
            while (curr != null)
            {
                NodeWithRandom node = new NodeWithRandom(curr.data);
                node.next = curr.next;
                curr.next = node;
                curr= node.next;
            }

            curr = head;
            while(curr != null)
            {
                if (curr.random != null)
                    curr.next.random = curr.random.next;

                curr = curr.next.next;
            }

            curr = head;
            NodeWithRandom clone_head = head.next;
            NodeWithRandom clone_curr = clone_head;
            while(clone_curr.next != null)
            {
                curr.next = curr.next.next;
                clone_curr.next = clone_curr.next.next;
                curr = curr.next;
                clone_curr = clone_curr.next;
            }

            curr.next = null;
            clone_curr.next= null;

            return clone_head;
        }
    }
}
