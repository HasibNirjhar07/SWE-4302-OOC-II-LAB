using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinMaxStack
{
  
        public class MinMaxStack<T> where T : IComparable<T>
        {
            private Stack<T> _stack = new Stack<T>();
            private GenericMaxStack<T> _maxStack = new GenericMaxStack<T>();
            private GenericMaxStack<T> _minStack = new GenericMaxStack<T>();

            public void Push(T item)
            {
                _stack.Push(item);
                _maxStack.Push(item);
                _minStack.Push(item);
            }

            public T Pop()
            {
                if (_stack.Count == 0)
                {
                    throw new InvalidOperationException("Stack is empty");
                }

                _maxStack.Pop();
                _minStack.Pop();
                return _stack.Pop();
            }

            public T Max()
            {

                return _maxStack.Peek();
            }

            public T Min()
            {

                return _minStack.Peek();
            }




        }
    }

