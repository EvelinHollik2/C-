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
            int sor = 10; //sorok száma
            int oszlop = 10; //oszlopok száma
            int alsoHatar = 10, //generált számok alsó határa
                felsoHatar = 1000; //generált számok felső határa

            int[,] tomb = new int[sor, oszlop];
            Random rnd = new Random();


            //tömb feltöltése véletlen számokkal
            for (int i = 0; i < tomb.GetLength(0); i++)
            {
                for (int j = 0; j < tomb.GetLength(1); j++)
                tomb[i, j] = rnd.Next(alsoHatar, felsoHatar);
            }

            //Tömb kiiratása
            for (int i = 0; i < tomb.GetLength(0); i++)
            {
                for (int j = 0;j < tomb.GetLength(1); j++)
                    Console.Write(tomb[i,j] + ", "); 

                //sor végé soremelés
                Console.WriteLine();
            }

            //tömb kiiratása máshogy
            Console.WriteLine("Kiiratás foreach-csel");
            foreach (int i in tomb)
                Console.Write(i + ",");


            Console.ReadKey();
        }
    }
}
