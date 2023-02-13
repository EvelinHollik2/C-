using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace házi_buborékrendezés
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string array;
            for (int i = 1; i < array.Length; ++i)
            {
                int y = array[i];
                int j = i - 1;
                while (j > -1 && y < array[j])
                {
                    array[j + 1] = array[j];
                    --j;
                }
                array[j + 1] = y;
            }

            Console.ReadKey();
        }
    }
}
