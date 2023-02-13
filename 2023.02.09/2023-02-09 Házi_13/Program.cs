using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Házi_13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float osszeg;
            Console.Write("Add meg a dinnye átmérőjét:");
            float d = float.Parse(Console.ReadLine());
            Console.Write("Hány dinnyét szeretnél? ");
            int db = int.Parse(Console.ReadLine());
            osszeg = (float)((((d * Math.PI) * 2) + 60) * db) / 100;
            Console.WriteLine("A dinnyének ennyi méret szalagra lesz szüksége: {0}", osszeg);
            Console.ReadKey();
        }
    }
}