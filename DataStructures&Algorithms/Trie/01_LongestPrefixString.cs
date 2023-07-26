using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace DataStructures_Algorithms.Trie
{
    internal class _01_LongestPrefixString
    {
        int min = Int32.MaxValue;
        public string LongestPrefixString(string[] strs)
        {

            if (strs.Length == 0)
                return null;

            TrieNode root = new TrieNode(26);

            foreach (string str in strs)
            {
                Insert_Prefix(str, root);
            }

            var prefix = strs[0].Substring(0, min);
            return prefix;
        }

        private void Insert_Prefix(string word, TrieNode root)
        {
            int count = 0;
            foreach(var ch in word)
            {
                if (root.node[ch - 'a'] == null)
                {
                    root.node[ch - 'a'] = new TrieNode(26);
                }
                else
                {
                    count++;
                }

                root = root.node[ch - 'a']; 
            }

            if (min == Int32.MaxValue)
            {
                min = word.Length;
            }
            else
            {
                min = Math.Min(min, count);
            }
        }
    }
}
