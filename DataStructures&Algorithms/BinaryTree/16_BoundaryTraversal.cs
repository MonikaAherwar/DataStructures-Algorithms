using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures_Algorithms.BinaryTree
{
    internal class _16_BoundaryTraversal
    {
        List<int> ans = new List<int>();

        public void BoundaryTraversal(Node root)
        {
            if (root == null)
            {
                throw new ArgumentNullException("Tree is Empty");
            }

            ans.Add(root.Key);

            LeftTreeTraversal(root.Left);
            LeafTraversal(root.Left);
            LeafTraversal(root.Right);
            RightTreeTraversal(root.Right);
        }

        private void LeftTreeTraversal(Node root)
        {
            // Either move to left or right
            // When left == null then move to right  
            if(root.Left != null)
            {
                ans.Add(root.Key);
                root = root.Left;
            }
            else if(root.Right != null)
            {
                ans.Add(root.Key);
                root = root.Right;
            }
        }

        private void RightTreeTraversal(Node root)
        {
            if (root.Right != null)
            {
                ans.Add(root.Key);
                root = root.Right;
            }
            else if (root.Left != null)
            {
                ans.Add(root.Key);
                root = root.Left;
            }
        }

        private void LeafTraversal(Node root)
        {
            if (root == null)
                return;

            if(root.Left == null && root.Right == null)
            {
                ans.Add(root.Key);
            }

            LeafTraversal(root.Left);
            LeafTraversal(root.Right);
        }
    }
}
