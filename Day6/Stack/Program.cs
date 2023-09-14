using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    public class Program
    {
        static void Main(string[] args)
        {


            {
                MinStack minStack = new MinStack();
                minStack.Push(7);
                minStack.Push(3);
                minStack.Push(5);
                minStack.Push(2);
               minStack.Push(7);

                Console.WriteLine("Minimum element in the stack: " + minStack.min()); 

                minStack.Pop();
                minStack.Pop();
                minStack.Pop();

                Console.WriteLine("Minimum element in the stack after popping: " + minStack.min());
            }
        }







    }
}

