using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzbuzzApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FizzBuzz fizzBuzz = new FizzBuzz();
            for (int i = 1; i <= 21; i++)
            {
                Console.WriteLine(fizzBuzz.GetFizzyBuzz(i));
            }
        }
    }
}
