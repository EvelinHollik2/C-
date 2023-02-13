using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stringekk_példa_4_módosítás
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = "smallstring";
            char[] chs = new char[] { 's', 'g' };
            Console.WriteLine(s.Replace('s', 'l')); // lmallltring
            Console.WriteLine(s.Trim(chs)); // mallstrin
            Console.WriteLine(s.Insert(0, "one")); // onesmallstring
            Console.WriteLine(s.Remove(0, 2)); // allstring
            Console.WriteLine(s.Substring(0, 3)); // sma
            Console.WriteLine(s.ToUpper()); // SMALLSTRING
            Console.WriteLine(s.ToLower()); // smallstring
            Console.ReadKey();
        }
    }
}