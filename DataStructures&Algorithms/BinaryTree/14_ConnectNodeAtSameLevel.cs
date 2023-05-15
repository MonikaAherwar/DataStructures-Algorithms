using DataStructures_Algorithms.SlidingWindow;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures_Algorithms.BinaryTree
{
    internal class _14_ConnectNodeAtSameLevel
    {
        public void ConnectNodeAtSameLevel(NodeWithNext root)
        {
            if (root == null)
            {
                throw new ArgumentNullException("Tree is Empty");
            }

            Queue<NodeWithNext> queue = new Queue<NodeWithNext>();
            queue.Enqueue(root);

            while (queue.Count > 0)
            {
                int size = queue.Count;
                NodeWithNext prev = queue.Peek();

                for(int i = 0; i < size; i++)
                {
                    NodeWithNext node = queue.Dequeue();
                    if (i == 0)
                        prev = node;
                    else
                    {
                        prev.Next = node;
                        prev = node;
                    }
                }
            }

            // Print Tree
            // Return Tree
        }
    }

    internal class NodeWithNext : Node {
       
        internal Node Next;

        NodeWithNext(int item) : base (item)
        {
            this.Next = null;
        }
    }
}
