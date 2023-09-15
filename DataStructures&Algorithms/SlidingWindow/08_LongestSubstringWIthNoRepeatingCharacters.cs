using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures_Algorithms.SlidingWindow
{
    internal class LongestSubstringWIthNoRepeatingCharacters
    {
        int maxLength = 0;

        public int LongestSubstring(string str)
        {

            int i = 0;
            int j = 0;
            int n = str.Length;
            int count = 0;
            Dictionary<char, int> dict = new Dictionary<char, int>();

            while (j < n)
            {

                if (!dict.ContainsKey(str[j]))
                {
                    dict.Add(str[j], 1);
                    count++;
                }
                else
                {
                    dict[str[j]]++;
                }

                if (count == j - i + 1)
                {
                    maxLength = Math.Max(maxLength, j - i + 1);
                }
                else if (count < j - i + 1)
                {
                    while (count < j - i + 1)
                    {
                        dict[str[i]]--;
                        if (dict[str[i]] == 0)
                        {
                            count--;
                            dict.Remove(str[i]);
                        }
                        i++;
                    }
                }

                j++;
            }

            return maxLength;
        }
    }
}
