using DataStructures_Algorithms.Trie;
using System;
using System.Globalization;

namespace DataStructures_Algorithms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //InitializeTrieNode();
            //TestTrieNode();
            //
            InitializeAndTestTrie();
        }

        private static void InitializeAndTestTrie() { 
            DataStructures_Algorithms.Trie.Trie trie = new Trie.Trie();
            
            string[] strs = { "flower", "flow", "flight" };

            // Insert
            foreach (string str in strs)
            {
                trie.Insert(str);
            }

            // Search
            foreach (string str in strs)
            {
                var val = trie.Search(str);
            }
        }


        private static void InitializeTrieNode()
        {
            TrieNode root = new TrieNode(26);
            string[] strs = { "flower", "flow", "flight" };

            foreach (string str in strs)
            {
                TrieNode.Insert(root, str);
            }

            foreach (string str in strs)
            {
                var val = TrieNode.Search(root, str);
                Console.WriteLine(val);
            }
        }

        private static void TestTrieNode()
        {
            _01_LongestPrefixString l = new _01_LongestPrefixString();
            string[] strs = { "flower", "flow", "flight" };
            var ans = l.LongestPrefixString(strs);
            Console.WriteLine(ans);
        }
    }
}
