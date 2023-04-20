using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilesIO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FileInpOut f = new FileInpOut();

            using (StreamReader sr = f.getFile())
            {
                // Dolgozunk a fájllal
                // Egészet kiolvassa
                string s = sr.ReadToEnd();
                Console.WriteLine(s);

                Console.WriteLine();    // Emelünk egy üres sort

                // Soronként olvas
                while (!sr.EndOfStream) // s != null
                {
                    s = sr.ReadLine();
                    Console.WriteLine(s);
                }

            }

            f.closeFile();

            Console.ReadKey();
        }
    }
}