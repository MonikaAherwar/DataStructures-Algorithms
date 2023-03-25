using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures_Algorithms.BinarySearchTree
{
    internal class _02_ArrayToBST
    {
        public Node CreateBalancedBinaryTreeFromSortedArray(int[] arr, int start, int end) {

            Node node = null;
            if(start > end) return node;

            //if (n == 1) return new Node(arr[start]);

            if(start <= end)
            {
                int mid = start + (end - start) / 2;

                node = new Node(arr[mid]);

                node.Left = CreateBalancedBinaryTreeFromSortedArray(arr, start, mid - 1);
                node.Right = CreateBalancedBinaryTreeFromSortedArray(arr, mid + 1, end);

            }

            return node;
        }
    }
}
