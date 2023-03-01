using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace házi_stringek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string data = "010110101010100101011110101000"; //szigetek száma 11, leghosszabb sziveg: 4
            int islandCount = 0; //szigetek száma
            int maxIslandLength = 0; //legnyasgobb sziget hossza
            int i = 0; //vízről szigetre lép
            while (i < data.Length) 
            {
                if (data[i] == '1')
                {
                    ++islandCount;
                    int j = i;
                    int tmp = 0; //sziget beljesét gyűjti
                    while (j < data.Length && data[j] == '1')
                    {
                        ++j;
                        ++tmp;
                    }
                    i = j;
                    if (tmp > maxIslandLength) { maxIslandLength = tmp; }
                }
                else
                {
                    ++i;
                }
            }
            Console.WriteLine("A leghosszabb egybefüggő szárazföld hossza: {0}", maxIslandLength);
            Console.WriteLine("Szigetek száma: {0}", islandCount);
            Console.ReadKey();
        }
    }
}