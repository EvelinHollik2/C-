using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringMetods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s1 = "Ez egy szöveg!";
            string s2 = "Ez egy szöveg!";
            string s3 = "Ez egy másik szöveg!";

            bool egyenlo = false;

            egyenlo = String.IsNullOrEmpty(s1);
            if (egyenlo)
                Console.WriteLine("Az s1 string üres");
            else
                Console.WriteLine("Az s1 string nem üres");
            
            egyenlo = String.Compare(s1, s2);

            Console.ReadKey();
        }
    }
}
