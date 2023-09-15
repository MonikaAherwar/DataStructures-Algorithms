using System;
using System.Collections.Generic;
using System.Globalization;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace DataStructures_Algorithms.Trie
{
    internal class _03_DistictSubstrings
    {
        private TrieNodeDIstictSubString root;

        _03_DistictSubstrings()
        {
            root = new TrieNodeDIstictSubString(26);
        }

        internal int GetCountOfDistictSubStrings(string word)
        {
            int count = 0;

            for(int i = 0; i < word.Length; i++)
            {

                string str = word.Substring(i);
                var curr = root;
                foreach (var ch in word)
                {
                    if (curr.node[ch - 'a'] == null)
                    {
                        count++;
                        curr.node[ch - 'a'] = new TrieNodeDIstictSubString(26);
                    }

                    curr = curr.node[ch - 'a'];
                }
            }
            

            return count + 1;
        }
    }

     class TrieNodeDIstictSubString
     {
        internal TrieNodeDIstictSubString[] node;
        internal bool isWord;

        internal TrieNodeDIstictSubString(int size)
        {
            node = new TrieNodeDIstictSubString[size];
            isWord = false;
        }
    }
}
