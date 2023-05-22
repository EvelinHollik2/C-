using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dolgozat_2023_05_22
{
    internal class Program
    {
        private static Dolg Konyv;
        static void Main(string[] args)
        {
            Konyv = new Dolg();

            Konyv.beolvas();
            Konyv.kiir();
            Console.WriteLine();
            Dolg.Konyv li = new Dolg.Konyv();
            li.listazas();

            Console.WriteLine("Az kért adatot elmentettük a 'talal.csv' fájlba!");

            Console.ReadKey();
        }
    }
}
