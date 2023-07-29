using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;

namespace DataStructures_Algorithms.Trie
{
    public class Trie
    {
        internal TrieNodeDictionary root;

        internal Trie()
        {
            root = new TrieNodeDictionary();
        }

        internal void Insert(string word)
        {
            var curr = root;
            foreach(var ch in word)
            {
                if (!curr.node.ContainsKey(ch))
                {
                    curr.node.Add(ch, new TrieNodeDictionary());
                }
                curr = curr.node[ch];
            }
            curr.isWord = true;
        }

        internal bool Search(string word)
        {
            var curr = root;    
            foreach(var ch in word)
            {
                if (!curr.node.ContainsKey(ch))
                {
                    return false;
                }
                else
                {
                    curr = curr.node[ch];
                }
            }

            return curr.isWord;
        }
    }

    internal class TrieNodeDictionary
    {
        internal Dictionary<char, TrieNodeDictionary> node;
        internal bool isWord;

        internal TrieNodeDictionary()
        {
            node = new Dictionary<char, TrieNodeDictionary>();
            isWord = false;
        }
    }
}
