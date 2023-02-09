using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Házi_11
{
    internal class Program
    {
        static void Main(string[] args)
        {  
            Console.WriteLine("Adj meg egy számot: ");
            int x =int.Parse(Console.ReadLine());
            Console.WriteLine("Adj meg egy másik számot: ");
            int y = int.Parse(Console.ReadLine());

            int a = 0;
            int b = 0;
            int c = 0;
            
            Random random= new Random();
            Console.WriteLine("Három random szám: ", a, b, c);




            Console.ReadKey();
        }
    }
}