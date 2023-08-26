using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _99_bottles
{
    public class Program
    {
        static void Main(string[] args)
        {
            int bottle;
            int.TryParse(Console.ReadLine(), out bottle);

            int temp = bottle;

            while (bottle > 1)
            {

                Console.WriteLine($"{bottle} botlles of bear on the wall, {bottle} bottles of beer");
                Console.WriteLine($"take one down and pass it around, {bottle - 1} bottles of beer on the wall");
                bottle--;
            }
            if (bottle == 1)
            {
                Console.WriteLine($"{bottle} bottle of beer on the wall, {bottle} bottle of beer");
                Console.WriteLine($"Take one down and pass it around ,no more bottles of beer on the wall");
            }
            Console.WriteLine("No more bottles of beer on the wall,no more bottles of beer");
            Console.WriteLine($"Go to the store and buy some more,{temp} bottles of beer on the wall");

        }
    }
}
