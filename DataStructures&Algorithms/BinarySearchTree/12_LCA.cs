using DataStructures_Algorithms.SlidingWindow;
using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Text;

namespace DataStructures_Algorithms.BinarySearchTree
{
    internal class _12_LCA
    {
        bool found1 = false;
        bool found2 = false ;
        public Node LCA(Node root, Node p, Node q)
        {
            if (root == null) return null;

            if (root.Key > p.Key && root.Key > q.Key)
                return LCA(root.Left, p, q);

            if (root.Key < p.Key && root.Key < q.Key)
                return LCA(root.Right, p, q);

            return root;
        }
    }
}
