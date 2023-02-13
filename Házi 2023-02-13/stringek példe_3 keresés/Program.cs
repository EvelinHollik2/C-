using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stringek_példe_3_keresés
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = "verylonglongstring";
            char[] chs = new char[] { 'y', 'z', 'o' };
            Console.WriteLine(s.IndexOf('r')); // 2
            Console.WriteLine(s.IndexOfAny(chs)); // 3
            Console.WriteLine(s.LastIndexOf('n')); // 16
            Console.WriteLine(s.LastIndexOfAny(chs)); // 9
            Console.WriteLine(s.Contains("long")); // true
            Console.ReadKey();
        }
    }
}