using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace DataStructures_Algorithms.SlidingWindow
{
    internal class CountOccurencesOfAnagram
    {
        int anagramCount = 0;

        //str1 = aabaabaa
        //str2 = aaba

        public int CountOccurencesOfAnagramInAString(string str1, string str2) {

            if (str1.Length < str2.Length) {
                throw new Exception("Anagram Not Possible");
            }

            if (str2.Length == 0) { 
                throw new Exception("String 2 is empty");
            }

            Dictionary<char, int> dict = new Dictionary<char, int>();
            dict = CreateMapForCharacterCount(str2);
            int count = dict.Count;
            //SlidingWindowCode

            int i = 0;
            int j = 0;
            int n = str1.Length;
            int k = str2.Length;

            while (j < n) {

                if (dict.ContainsKey(str1[j])) {
                    dict[str1[j]]--;

                    if (dict[str1[j]] == 0) count--;
                }

                if (j - i + 1 < k) {
                    j++;
                }
                else if (j - i + 1 == k) {

                    if (count == 0) anagramCount++;

                    if (dict.ContainsKey(str1[i])) {
                        dict[str1[i]]++;

                        if (str1[i] == 1) count++;
                    }

                    i++;
                    j++;
                }
            }          
            
            return anagramCount;
        }


        // Helper Method to calculate character count map in str2
        public static Dictionary<char, int> CreateMapForCharacterCount(string str) {

            Dictionary<char, int> dict = new Dictionary<char, int>();

            foreach (char c in str)
            {
                if (!dict.ContainsKey(c))
                {
                    dict.Add(c, 1);
                }
                else {
                    dict[c] = dict[c] + 1;
                }
            }

            return dict;
        }
    }
}
