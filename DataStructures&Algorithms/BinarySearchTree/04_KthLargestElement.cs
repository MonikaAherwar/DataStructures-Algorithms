using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace DataStructures_Algorithms.BinarySearchTree
{
    internal class _04_KthLargestElement
    {
        static int count = 0; 
        public void KthLargestElement(Node root, int k)
        {
            
            // Reverse Inorder Traversal
            // LVR --> RVL

            if(root != null && k > 0)
            {
                KthLargestElement(root.Right, k);

                count++;
                if (k == count)
                {
                    Console.WriteLine(root.Key);
                    return;
                }

                KthLargestElement(root.Left, k--);
            }
        }
    }
}
