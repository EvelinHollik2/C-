using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CimletekOOP
{
    internal class CimletekOOP 
    {
        static void Main(string[] args)
        {   
            Cimletek c1=new Cimletek();
            Console.WriteLine("Írjon be egy összeget: ");
            int pnz = Convert.ToInt32(Console.ReadLine());
            c1.setCimletHely(pnz);
            Console.ReadLine();

        }
    }
}
