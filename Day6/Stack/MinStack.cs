using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    public class MinStack
    {
       public Stack<int>stack=new Stack<int>();
       public  Stack<int>minStack=new Stack<int>();
        public void Push(int i)
        {
            stack.Push(i);
            if (stack.Count == 1)
            {
                minStack.Push(i);

            }
            if (minStack.Peek() >= i)
            {
                minStack.Push(i);
            }
        }

        public void Pop()
        {
            if(stack.Peek() == minStack.Peek())
            {
                minStack.Pop();
            }
            stack.Pop();
        }

        public int min()
        {
            return minStack.Peek();
        }





         





        }

       

    }

