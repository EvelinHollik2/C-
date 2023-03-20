using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PonHatOOP
{
    internal class PonHatOOP
    {
        static void Main(string[] args)
        {
            Console.WriteLine("kérem a pontszámot: ");
            int pont = int.Parse(Console.ReadLine());

            if (pont >=0 && pont>100)
            {
                Console.WriteLine("A kapott eredmény {0}. Hibás adat!", pont);
            }
            Console.ReadKey();
 

        }
    }
}