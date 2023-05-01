using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures_Algorithms.Stack
{
    internal class _01_NGR_NextGreaterElementInRight
    {

        // Nearest Largest Element
        public List<int> NGR(int[] arr)
        {
            int n = arr.Length;

            if(n == 0)
            {
                throw new ArgumentException("Array is Empty");
            }

            List<int> result = new List<int>();
            Stack<int> stack = new Stack<int>();

            for(int i = n-1; i >= 0; i--)
            {
                if (stack.Count == 0)
                {
                    result.Add(-1);
                }
                else if (stack.Peek() > arr[i])
                {
                    result.Add(stack.Peek());
                }
                else
                {
                    while(stack.Count > 0 && stack.Peek() <= arr[i])
                    {
                        stack.Pop();
                    }

                    if(stack.Count == 0)
                    {
                        result.Add(-1);
                    }
                    else
                    {
                        result.Add(stack.Peek());
                    }
                }

                stack.Push(arr[i]);
            }

            //Reverse the List
            result.Reverse();
            return result;
        }

    }
}
