using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace new_prog
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //tömb deklarálása
            int hossz = 10; //tömb mérete
            int alsoHatar = 10, //generált számok alsó határa
                felsoHatar = 1000; //generált számok felső határa

            int[] tomb = new int[hossz];
            Random rnd= new Random();

            for (int i = 0; i < tomb.Length; i++)
            {
                tomb[i] = rnd.Next(alsoHatar, felsoHatar);
            }
            //Tömb kiiratása
            for (int i = 0; i < tomb.Length; i++)
                Console.WriteLine(tomb[i]);

            //tömb kiiratása máshogy
            foreach (int i in tomb)
                Console.WriteLine(i);


            Console.ReadKey();
        }
    }
}
