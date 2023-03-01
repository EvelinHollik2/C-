using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = "Ez egy szöveg";
            Console.Write("Kiiratás string-ként: ");
            Console.WriteLine(s);
            Console.WriteLine("Kiiratás tömb elemenként: ");
            for (int i = 0; i < s.Length; i++)
            {
                Console.Write(s[i]);

            }

            Console.ReadKey();
        }
    }
}
