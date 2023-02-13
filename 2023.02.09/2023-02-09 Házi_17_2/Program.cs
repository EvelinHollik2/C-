using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Házi_17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ora,
                perc,
                masodperc;

            //első időpont beolvasása
            Console.WriteLine("Add meg az órát: ");
            ora = int.Parse(Console.ReadLine());
            Console.WriteLine("Add meg a percet: ");
            perc = int.Parse(Console.ReadLine());
            Console.WriteLine("Add meg a másodpercet: ");
            masodperc = int.Parse(Console.ReadLine());

            //második időpont beolvasása
            Console.WriteLine("Add meg az órát megint: ");
            DateTime elso = new DateTime(2000, 02,02,ora, perc, masodperc);
            ora = int.Parse(Console.ReadLine());
            Console.WriteLine("Add meg a percet megint: ");
            perc = int.Parse(Console.ReadLine());
            Console.WriteLine("Add meg a másodpercet megint: ");
            masodperc = int.Parse(Console.ReadLine());
            DateTime masik = new DateTime(2000, 02, 02, ora, perc, masodperc);

            //két időpont különbsége
            TimeSpan k = elso - masik;

            //kiiratás
            Console.WriteLine(k.ToString());
            Console.ReadKey();
        }
    }
}
