using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szigetek__OOP_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s;
            #region 1.példa
            if (false)
            { 
                s = "00111111011110000010101000";
                Szigetszamolas sz1 = new Szigetszamolas();
                sz1.setData(s);
                sz1.Szamol();
                Console.WriteLine($"Szigetek száma: {sz1.getIslandCount()}, a leghosszabb hossz: {sz1.getMaxIslandLength()}");
            }
            #endregion

            #region 2.példa
            if(false)
            { 
                s = "00111111011110000010101000";
                Szigetszamolas sz2 = new Szigetszamolas();
                sz2.setData(s);
                sz2.Szamol();
                Console.WriteLine($"Szigetek száma: {sz2.getIslandCount()}, a leghosszabb hossz: {sz2.getMaxIslandLength()}");
            }
            #endregion

            Console.ReadKey();
        }
    }
}
