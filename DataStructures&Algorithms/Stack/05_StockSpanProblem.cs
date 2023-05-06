using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures_Algorithms.Stack
{
    internal class _05_StockSpanProblem
    {
        // Return all the staock which are
        // Consecutive Smaller or equal before current stock
        // IP: 100 80 60 70 60 75 85
        // OP: -1  1  1  2  1  4  6

        public List<int> StockSpanProblem(int[] stocks) 
        {

            int n = stocks.Length;

            if (n == 0)
            {
                throw new ArgumentException("Array is Empty");
            }

            List<int> result = new List<int>();
            Stack<StockDetails> stack = new Stack<StockDetails>();

            for(int i=0; i < n; i++)
            {
                if(stack.Count == 0)
                {
                    result.Add(1);
                }
                else if(stack.Peek().stockValue > stocks[i])
                {
                    result.Add(stack.Peek().stockIndex - i);
                }
                else
                {
                    while(stack.Count > 0 && stack.Peek().stockValue <= stocks[i])
                    {
                        stack.Pop();
                    }

                    if(stack.Count == 0)
                    {
                        result.Add(1);
                    }
                    else
                    {
                        result.Add(stack.Peek().stockIndex - i);
                    }
                }

                stack.Push(new StockDetails { stockValue = stocks[i], stockIndex = i });
            }

            return result;
        }

        internal class StockDetails
        {
            internal int stockValue;
            internal int stockIndex;
        }
    }
}
