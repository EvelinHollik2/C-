using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace házi_minimum_és_maximum_keresés
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //érték megadás
            int min = 1000;
            int max = -1;
            int minIdx = 0;
            int maxIdx = 0;
            for (int i = 0; i < 30; ++i)
            {
                if (array[i] < min)
                {
                    min = array[i];
                    minIdx = i;
                }
                if (array[i] > max)
                {
                    max = array[i];
                    maxIdx = i;
                }
            }
            Console.ReadKey();
        }
    }
}
