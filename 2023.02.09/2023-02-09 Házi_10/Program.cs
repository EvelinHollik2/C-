using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Házi_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Add meg a hiányzások számát :");
            int x = int.Parse(Console.ReadLine());
            int a = 10;
            int b = 20;
            int c = 30;
            int d = 40;

            Console.WriteLine("Add meg a születési dátumodat: ");

            if (x >= a & x < b)
            {
                Console.WriteLine("Figyelmeztetésben részerül");
            }
            if (x >= b & x < c)
            {
                Console.WriteLine("Osztályfőnöki intőben részerül");
            }
            if (x >= c & x < d)
            {
                Console.WriteLine("Igazgatói megrovásban részerül");
            }
            if (x >= d)
            {
                Console.WriteLine("Felfüggesztésben részerül");
            }

            Console.ReadKey();
        }
    }
}