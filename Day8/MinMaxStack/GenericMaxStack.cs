using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinMaxStack
{
    public class GenericMaxStack<T> where T : IComparable<T>
    {
        //generic_way
        private Stack<T> stack = new Stack<T>();
        private Stack<T> maxStack = new Stack<T>();
        public void Push(T item)
        {
            stack.Push(item);
            if (maxStack.Count == 0 || item.CompareTo(maxStack.Peek()) >= 0)
            {
                maxStack.Push(item);
            }
        }

        public T Pop()
        {
            if (stack.Count == 0)
            {
                throw new InvalidOperationException("Stack is empty");
            }
            T item = stack.Pop();
            if (item.CompareTo(maxStack.Peek()) == 0)
            {
                maxStack.Pop();
            }
            return item;
        }

        public T Max()
        {
            if (maxStack.Count == 0)
            {
                throw new InvalidOperationException("Stack is empty");
            }
            return maxStack.Peek();
        }

        public T Peek()
        {
            if (stack.Count == 0)
            {
                throw new InvalidOperationException("Stack is empty");
            }
            return stack.Peek();
        }

    }
}
