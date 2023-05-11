using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace DataStructures_Algorithms.Stack
{
    internal class _08_MinStackWithExtraSpace
    {
        Stack<int> stack = new Stack<int> ();
        Stack<int> supportingStack = new Stack<int> ();

        public void Push(int ele)
        {
            if(supportingStack.Count == 0)
            {
                supportingStack.Push (ele);
            }
            else if(ele <= supportingStack.Peek())
            {
                supportingStack.Push (ele);
            }

            stack.Push (ele);
        }

        public void Pop(int ele)
        {
            if(supportingStack.Count > 0 && supportingStack.Peek() == ele)
            {
                supportingStack.Pop ();
            }

            stack.Pop ();
        }

        public int GetMin()
        {
            if(supportingStack.Count == 0)
            {
                throw new Exception("Stack is Empty");
            }

            return supportingStack.Peek();
        }
    }
}
