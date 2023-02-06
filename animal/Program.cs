using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace animal
{
    internal class Program
    {
        enum Animal { Cat = 2, Dog = 5, Tiger, Wolf };

        static void Main(string[] args)
        {
            Animal a = Animal.Cat;
            Animal b = Animal.Tiger;

            // Értéktípusú változók nulla értéke.

            int c = 0;
            string s = "";

            //Nullázható érték típusú változó deklarálása.
            int? x= null;


            if(a != b)
            {
                Console.WriteLine("Macska indexe {0}", (int)Animal.Cat);
                Console.WriteLine("Kutya indexe {0}", (int)Animal.Dog);
                Console.WriteLine("Farkas indexe {0}", (int)Animal.Wolf);
            }
            Console.ReadKey();
        }
    }
}
