using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxStack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GenericMaxStack<int> intstack = new GenericMaxStack<int>();
            intstack.Push(3);
            intstack.Push(5);
            intstack.Push(2);
            Console.WriteLine(intstack.Max());


            intstack.Push(2);
            intstack.Push(1);
            intstack.Push(2);
            intstack.Push(5);
            intstack.Pop();
            Console.WriteLine(intstack.Max());
            intstack.Pop();
            Console.WriteLine(intstack.Max());

            GenericMaxStack<double> doubleStack = new GenericMaxStack<double>();
            doubleStack.Push(49.75);
            doubleStack.Push(23.54);
            doubleStack.Push(100.00);
            doubleStack.Pop();
            Console.WriteLine(doubleStack.Max());

            GenericMaxStack<string> stringStack = new GenericMaxStack<string>();
            stringStack.Push("OOC is bad");
            stringStack.Push("Nothing to understand");
            stringStack.Push("Try hard");    
            Console.WriteLine(stringStack.Max());



            
        }
    }
}
