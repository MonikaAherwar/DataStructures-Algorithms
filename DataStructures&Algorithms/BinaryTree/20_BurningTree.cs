using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataStructures_Algorithms.BinaryTree
{
    internal class _20_BurningTree
    {

        //          12
        //        /    \
        //      13      10
        //            /    \
        //           14    15
        //          / \    / \
        //         21 24  22 23
    
        static Dictionary<Node, List<Node>> map = new Dictionary<Node, List<Node>>();
        public int BurningTree(Node root, Node burningNode)
        {
            if(root == null) return 0;
            CreateGraph(root, null);

            if (!map.ContainsKey(burningNode))
            {
                throw new Exception("Target node does not found");
            }

            Queue<Node> queue = new Queue<Node>();
            HashSet<Node> visited = new HashSet<Node>();
            queue.Enqueue(burningNode);
            visited.Add(burningNode);
            int count = 0;

            while(queue.Count > 0)
            {
                count++;
                int size = queue.Count;
                for(int i = 0; i < size; i++)
                {
                    Node node = queue.Dequeue();
                    Console.WriteLine(node.Key);

                    // Push all the related nodes to queue for current node
                    // Left, Right, Parent
                    foreach (var temp in map[node])
                    {
                        if (!visited.Contains(temp))
                        {
                            queue.Enqueue(temp);
                            visited.Add(temp);
                        } 
                    }  
                }
            }

            // No os steps required to burn the whole tree
            // And count = 3, staring from 14
            // step 0: 14
            // step 1: 21 24 10
            // step 2: 15 12
            // step 3: 22 23 13
            return count - 1; 
         }

        
        private void CreateGraph(Node root, Node parent)
        {
            if (root == null) return;

            if (!map.ContainsKey(root))
            {
                List<Node> list = new List<Node>();
                map[root] = list;
                
                if(parent != null)
                {
                    map[root].Add(parent);
                    map[parent].Add(root);
                }              
            }
            
            CreateGraph(root.Left, root);
            CreateGraph(root.Right, root);
        }
    }
}
