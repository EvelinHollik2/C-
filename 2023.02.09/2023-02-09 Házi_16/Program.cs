using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Házi_16
{
    internal class Program
    {
        static double szam(int osz)
        {
            Console.WriteLine(osz);
            
            return 0.0;
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Add meg hány oldal: ");
            double ere = szam(int.Parse(Console.ReadLine()));

            Console.ReadKey(); 
        }
    }
}
