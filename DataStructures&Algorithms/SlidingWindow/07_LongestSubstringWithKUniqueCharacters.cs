using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures_Algorithms.SlidingWindow
{
    internal class LongestSubstringWithKUniqueCharacters
    {
        int maxLength = 0;

        public int LongestSubstring(string str, int k) {

            int i = 0;
            int j = 0;
            int n = str.Length;
            int currLength = 0;
            Dictionary<char, int> dict = new Dictionary<char, int>();
                
            while (j < n) {

                if (!dict.ContainsKey(str[j]))
                {
                    dict.Add(str[j], 1);
                    currLength++; 
                }
                else
                {
                    dict[str[j]]++;
                }

                if (currLength < k)
                {
                    j++;
                }
                else if (currLength == k)
                {
                    maxLength = Math.Max(maxLength, j - i + 1);
                    j++;
                }
                else if (currLength > k) {
                    
                    while (currLength > k)
                    {
                        dict[str[i]]--;
                        if (dict[str[i]] == 0) { 
                            currLength--;
                            dict.Remove(str[i]);
                        }
                        i++; 
                    }
                    j++;
                }
            }
                
            return maxLength;
        }
    }
}
