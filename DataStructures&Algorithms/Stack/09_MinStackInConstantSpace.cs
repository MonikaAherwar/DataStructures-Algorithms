using DataStructures_Algorithms.BinarySearch;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures_Algorithms.Stack
{
    internal class _09_MinStackInConstantSpace
    {
        //Get Min Stack in O(1) space
        //Tricky answer, view the video again if required

        Stack<int> stack = new Stack<int>();
        static int minEle = Int32.MinValue;
        public void Push(int ele)
        {
            if(stack.Count == 0)
            {
                minEle = ele;
                stack.Push(ele);
            }
            else if (ele < minEle)
            {
                int newElement = 2* stack.Peek() - minEle;
                minEle = ele;
                stack.Push(newElement);
            }
        }

        public void Pop()
        {
            if(stack.Peek() < minEle)
            {
                int newElement = 2 + minEle - stack.Peek();
                minEle = newElement;            
            }

            stack.Pop();
        }

        public int GetMin()
        {
            if (stack.Count == 0)
            {
                throw new Exception("Stack is Empty");
            }

            return minEle;
        }
    }
}
