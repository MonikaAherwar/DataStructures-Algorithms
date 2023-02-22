using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures_Algorithms.LinkedList
{
    internal class _14_FlatteningLinkedList
    {
        public NodeWithRight Flatten(NodeWithRight root)
        {
            // Base Cases
            if (root == null || root.right == null)
                return root;

            // recur for list on right
            root.right = Flatten(root.right);

            // now merge
            var root2 = MergeWithRight(root, root.right);

            // return the root
            // it will be in turn merged with its left
            return root;
        }

        private NodeWithRight MergeWithRight(NodeWithRight a, NodeWithRight b)
        {
            // if first linked list is empty then second
            // is the answer
            if (a == null)
                return b;

            // if second linked list is empty then first
            // is the result
            if (b == null)
                return a;

            // compare the data members of the two linked lists
            // and put the larger one in the result
            NodeWithRight result;

            if (a.data < b.data)
            {
                result = a;
                result.next = MergeWithRight(a.next, b);
            }

            else
            {
                result = b;
                result.next = MergeWithRight(a, b.next);
            }

            result.right = null;
            return result;
        }
    }
}
