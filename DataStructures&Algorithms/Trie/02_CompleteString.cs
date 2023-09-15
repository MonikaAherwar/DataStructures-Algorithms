using DataStructures_Algorithms.SortingAlgorithms;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures_Algorithms.Trie
{
    internal class _02_CompleteString
    {
        TrieNodeCompleteString root;

        _02_CompleteString()
        {
            root = new TrieNodeCompleteString(26);
        }

        internal void Insert(string word)
        {
            var curr = root;
            foreach (var ch in word)
            {
                if (curr.node[ch - 'a'] == null)
                {
                    curr.node[ch - 'a'] = new TrieNodeCompleteString(26);
                }

                curr = curr.node[ch - 'a'];
            }

            curr.isWord = true;
        }

        internal bool Search(string word)
        {
            var curr = root;
            foreach (var ch in word)
            {
                if (curr.node[ch - 'a'] == null)
                {
                    return false;
                }
                else
                {
                    curr = curr.node[ch - 'a'];
                }
            }

            return curr.isWord;
        }

        internal string CompleteString(string[] strs)
        {
            string completeString = null;
            foreach (var str in strs)
            {
                var isAllPrefixes = AllPrefixes(str);
                
                if (isAllPrefixes)
                {
                    if (completeString.Length < str.Length)
                    {
                        completeString = str;
                    }
                    else if (completeString.Length == str.Length)
                    {
                        // return sorted order
                    }
                }
            }

            return completeString;
        }

        private bool AllPrefixes(string word)
        {
            var curr = root;
            foreach (var ch in word)
            {
                if (root.node[ch - 'a'] == null)
                {
                    return false;
                }
                else
                {
                    if (!curr.isWord)
                    {
                        return false;
                    }
                }
                curr = curr.node[ch - 'a'];
            }

            return true;
        }

    }

    internal class TrieNodeCompleteString 
    {
        internal TrieNodeCompleteString[] node;
        internal bool isWord;

        internal TrieNodeCompleteString(int size)
        {
            node = new TrieNodeCompleteString[size];
            isWord = false;
        }
    }

}
