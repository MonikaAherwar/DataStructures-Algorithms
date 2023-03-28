using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures_Algorithms.BinarySearchTree
{
    internal class _06_PairWithGivenTargetSum
    {

        // Time: O(N)
        // Space: O(N)

        List<int> list = new List<int>();
        public bool PairWithGivenSum(Node root, int sum)
        {
            if (root == null) return false;

            Inorder(root);

            if(list.Count < 2)
            {
                throw new Exception("No pair exist");
            }
            var set = new HashSet<int>();
            foreach (int i in list)
            {
                if (set.Contains(sum - i))
                {
                    return true;
                }
                else
                {
                    set.Add(i);
                }
            }

            return false;
        }

        private void Inorder(Node root) {

            if (root == null) return;

            Inorder(root.Left);
            list.Add(root.Key);
            Inorder(root.Right);

        }
    }
}
