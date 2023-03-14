using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures_Algorithms.BinaryTree
{
    internal class _13_ConstructBinarayTreeFromPreOrderAndInorder
    {
        int preIndex = 0;
        public Node BinaryTreeFromPreorderAndInorder(int[] preorder, int[] inorder)
        {

            int n1 = preorder.Length;
            int n2 = inorder.Length;

            if (n1 != n2)
            {
                throw new ArgumentException("Invalid traversal arrays");
            }

            if(n1 == 0 && n2 == 0)
            {
                return null;
            }

            // When n1 > 0 && n2 > 0
            // Create map, work only for unique value in inorder[]
            Dictionary<int, int> dict = new Dictionary<int, int>();
            for(int i = 0; i< n2; i++)
            {
                dict.Add(inorder[i], i);
            }


            Node tree = BuildTree(preorder, inorder, dict, 0, n1-1);
            return tree;
        }

        public Node BuildTree(int[] preorder, int[] inorder, Dictionary<int, int> dict, int start, int end)
        {
            int rootValue = preorder[preIndex++];
            Node root = new Node(rootValue);
            int index = dict[inorder[rootValue]];

            if(start < end)
            {
                root.Left = BuildTree(preorder, inorder, dict, start, index - 1);
                root.Right = BuildTree(preorder, inorder, dict, index + 1, end);
            }

            return root;
        }
    }
}
