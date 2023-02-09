using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Házi_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x;
            int y = 3;
            int z = 4;
            int a = 9;

            Console.WriteLine("Adj meg egy számot: ");
            x = int.Parse(Console.ReadLine());


            if (x % y == 0)
            {
                Console.WriteLine("A szám osztható 3-mal!");
            }
            else
            {
                Console.WriteLine("A szám nem osztható 3-mal!");
            }
            if (x % z == 0)
            {
                Console.WriteLine("A szám osztható 4-gyel!");
            }
            else
            {
                Console.WriteLine("A szám nem osztható 4-gyel!");
            }
            if (x % a == 0)
            {
                Console.WriteLine("A szám osztható 9-el!");
            }
            else
            {
                Console.WriteLine("A szám nem osztható 9-el!");
            }

            Console.ReadKey(); 

        }
    }
}
