using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures_Algorithms.BinarySearchTree
{
    internal class _11_ConstructBST
    {
        public Node SortedArrayToBST(int[] nums)
        {

            int n = nums.Length;
            if (n == 0) return null;

            return BST(nums, 0, n - 1);
        }

        private Node BST(int[] nums, int start, int end)
        {

            if (start > end) return null;

            int mid = start + (end - start) / 2;
            var node = new Node(nums[mid]);

            node.Left = BST(nums, start, mid - 1);
            node.Right = BST(nums, mid + 1, end);

            return node;
        }
    }
}
