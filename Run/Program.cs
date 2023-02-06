using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Run
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (args.Length != 0)
            {
                Console.WriteLine("Ezt a paramétert kaptam: {0}", args[0]);
            }
            else
            {
                Console.WriteLine("Nins megadva paraméter");
            }
            Console.ReadKey();
        }
    }
}
