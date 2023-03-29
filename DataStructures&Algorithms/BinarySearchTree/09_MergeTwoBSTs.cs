using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures_Algorithms.BinarySearchTree
{
    internal class _09_MergeTwoBSTs
    {
        List<int> list = new List<int>();
        public Node MergeTwoBSTs(Node root1, Node root2)
        {
            if (root1 == null) return root2;

            if (root2 == null) return root1;

            // May be later
        }
    }
}
