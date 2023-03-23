using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CsempezesOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Csempe c1= new Csempe();
            Console.WriteLine("Add meg a terület szélességét");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Add meg a terület magasságát");
            int b = Convert.ToInt32(Console.ReadLine());
            c1.setAdat(a);
            c1.setAdat(b);

            Console.ReadLine();
        }
    }
}
