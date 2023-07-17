using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures_Algorithms.SlidingWindow
{
    internal class MinimumWindowSubstringWithKCharacters
    {
        int minLength = 0;

        public int MinimumWindowSubstring(string str1, string str2) {

            if (str1.Length == 0 || str2.Length == 0) {
                throw new ArgumentException("Invalid string");
            }

            int i = 0;
            int j = 0;
            int n = str1.Length;
            Dictionary<char, int> dict = new Dictionary<char, int>();
            dict = CreateMapForCharacterCount(str2);
            int count = dict.Count;

            while (j < n) {

                if (dict.ContainsKey(str1[j]))
                {
                    dict[str1[j]]--;
                    if (dict[str1[j]] == 0) count--;
                }

                if (count == 0) {

                    while (count == 0) {
                        minLength = Math.Min(minLength, j - i + 1);

                        if (dict.ContainsKey(str1[i]))
                        {
                            dict[str1[i]]++;
                            if (dict[str1[i]] == 1) count++;
                        }
                        i++;
                    }
                    j++;
                }
            }

            return minLength;
        }

        // Helper Method to calculate character count map in str2
        public static Dictionary<char, int> CreateMapForCharacterCount(string str)
        {

            Dictionary<char, int> dict = new Dictionary<char, int>();

            foreach (char c in str)
            {
                if (!dict.ContainsKey(c))
                {
                    dict.Add(c, 1);
                }
                else
                {
                    dict[c] = dict[c] + 1;
                }
            }

            return dict;
        }
    }
}
