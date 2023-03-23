using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CimletekOOP
{

    internal class Cimletek
    {
        private int cimlet_hely;
        static int[] penz = { 5, 10, 20, 50, 100, 200, 500, 1000, 2000, 5000, 10000, 20000 };

        public Cimletek() { }

        public Cimletek(int cimlet_hely) 
        {
            this.cimlet_hely = cimlet_hely;
        }
        public int getCimletHely() 
        {
            return this.cimlet_hely;
        }

        public void setCimletHely(int cimlet_hely)
        {
            this.cimlet_hely= cimlet_hely;
            int val = 0;
            for (int i = penz.Length-1; i>=0; i--)
            {
                while (cimlet_hely >= penz[i])
                {
                    cimlet_hely -= penz[i];
                    val++;
                }
            }
            Console.WriteLine(val);
        }
    }
}
