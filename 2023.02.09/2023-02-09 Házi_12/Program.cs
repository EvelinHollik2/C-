using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Házi_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Adj meg egy összeget: ");
            int penz = Convert.ToInt32(Console.ReadLine());
            List<int> penzfajtak = new List<int> { 20000, 10000, 5000, 2000, 1000, 500, 200, 100, 50, 20, 10, 5 };
            //int pezfajtak= new int[] {20000, 10000, 5000, 2000, 1000, 500, 200, 100, 50, 20, 10, 5};
            int cimlet_helye = 0;
            while (penz > 0)
            {
                int mennyiseg = penz / penzfajtak[cimlet_helye];
                penz = penz % penzfajtak[cimlet_helye];
                Console.WriteLine("{0} darab {1} Ft-os", mennyiseg, penzfajtak[cimlet_helye]);
                cimlet_helye++;
            }

            Console.ReadLine();
        }
    }
}