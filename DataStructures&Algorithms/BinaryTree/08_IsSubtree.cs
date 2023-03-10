using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures_Algorithms.BinaryTree
{
    internal class _08_IsSubtree
    {
        public bool IsSubtree(Node t1, Node t2)
        {
            if (t1 == null)
                return false;

            if (t2 == null)
                return true;

            if (t1.Key == t2.Key)
            {
                return _06_IsIdenticalTree.IsIdentical(t1, t2);
            }

            return IsSubtree(t1.Left, t2) || IsSubtree(t1.Right, t2);          
        }
    }
}
