using DataStructures_Algorithms.SlidingWindow;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataStructures_Algorithms.BinaryTree
{
    internal class _12_VerticalViewOfBinaryTree
    {
        public void VerticalViewOfBinaryTree(NodeWithHorizontalDistance root)
        {
            if(root == null)
            {
                throw new ArgumentNullException("Tree is Empty");
            }

            Dictionary<int, List<int>> dict = new Dictionary<int, List<int>>();
            List<int> list = new List<int>();
            Queue<NodeWithHorizontalDistance> queue = new Queue<NodeWithHorizontalDistance>();   
            
            root.HorizontalDistance = 0;
            queue.Enqueue(root);
            
            while(queue.Count > 0)
            {
                NodeWithHorizontalDistance node = queue.Dequeue();
                
                if(!dict.ContainsKey(node.HorizontalDistance)) { 
                    list = new List<int>(node.Key);
                    dict.Add(node.HorizontalDistance, list);
                }
                else
                {
                    list = dict[node.HorizontalDistance];
                    list.Add(queue.Peek().Key);
                    dict[node.HorizontalDistance] = list;
                }

                if (node.Left != null)
                    queue.Enqueue(node.Left);

                if (node.Right != null)
                    queue.Enqueue(node.Right);
            }

            List<int> ans = new List<int>();
            
            foreach(var d in dict.OrderBy(x => x.Key))
            {
                ans.AddRange(d.Value);
            }

            // Print ans
            // return ans

        }
    }

    internal class NodeWithHorizontalDistance
    {
        internal int Key;
        internal NodeWithHorizontalDistance Left;
        internal NodeWithHorizontalDistance Right;
        internal int HorizontalDistance;
    }
}
