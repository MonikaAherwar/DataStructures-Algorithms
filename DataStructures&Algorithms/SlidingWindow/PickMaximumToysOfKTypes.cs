using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures_Algorithms.SlidingWindow
{
    internal class PickMaximumToysOfKTypes
    {
        int maxToysCount = 0;

        public int LongestSubstring(string toys, int typeOfToys)
        {

            if (toys.Length == 0) {
                throw new Exception("No toys given");
            }

            if (typeOfToys == 0)
            {
                throw new Exception("No type of toys given");
            }

            int i = 0;
            int j = 0;
            int n = toys.Length;
            int currToysLength = 0;
            Dictionary<char, int> dict = new Dictionary<char, int>();

            while (j < n)
            {

                if (!dict.ContainsKey(toys[j]))
                {
                    dict.Add(toys[j], 1);
                    currToysLength++;
                }
                else
                {
                    dict[toys[j]]++;
                }

                if (currToysLength < typeOfToys)
                {
                    j++;
                }
                else if (currToysLength == typeOfToys)
                {
                    maxToysCount = Math.Max(maxToysCount, j - i + 1);
                    j++;
                }
                else if (currToysLength > typeOfToys)
                {

                    while (currToysLength > typeOfToys)
                    {
                        dict[toys[i]]--;
                        if (dict[toys[i]] == 0)
                        {
                            currToysLength--;
                            dict.Remove(toys[i]);
                        }
                        i++;
                    }
                    j++;
                }
            }

            return maxToysCount;
        }

    }
}
