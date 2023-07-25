using DataStructures_Algorithms.BinarySearchTree;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace DataStructures_Algorithms.Trie
{

    
    internal class TrieNode
    {
        internal TrieNode[] node;
        internal bool isWord;

        internal TrieNode(int size)
        {
            node = new TrieNode[size];
            isWord = false;
        }
        
        internal static void Insert(TrieNode root, string word)
        {
            foreach(var ch in word)
            {
                if (root.node[ch - 'a'] == null)
                {
                    root.node[ch - 'a'] = new TrieNode(26); 
                }

                root = root.node[ch - 'a'];
            }

            root.isWord = true;
        }

        internal static bool Search(TrieNode root, string word)
        {
            foreach (var ch in word)
            {
                if (root.node[ch - 'a'] == null)
                {
                    return false;
                }
                else
                {
                    root = root.node[ch - 'a'];
                }
            }

            return root.isWord;
        }
    }
}
