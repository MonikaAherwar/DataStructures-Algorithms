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
            //TestTrie();   
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

        private static void TestTrie()
        {
            _01_LongestPrefixString l = new _01_LongestPrefixString();
            string[] strs = { "flower", "flow", "flight" };
            var ans = l.LongestPrefixString(strs);
            Console.WriteLine(ans);
        }
    }
}
