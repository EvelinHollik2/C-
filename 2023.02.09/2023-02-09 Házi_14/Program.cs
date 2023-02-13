using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Házi_14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float a, b, T, cs, TT;
            Console.WriteLine("Add meg a terület szélességét és a magasságát:");
            a = float.Parse(Console.ReadLine());
            b = float.Parse(Console.ReadLine());
            T = a * b;
            cs = (float)(T / (0.2 * 0.2));
            TT = (float) (cs * 1.1);
            Console.WriteLine(TT);
            Console.ReadKey();
        }
    }
}