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
        static int pnz = Convert.ToInt32(Console.ReadLine());

        public Cimletek() { }

        public Cimletek(int cimlet_hely) 
        {
            this.cimlet_hely = cimlet_hely;
        }
        public int getCimletHely() 
        {
            return this.cimlet_hely;
        }

        private void setCimletHely()
        {
            for (int i = 0; i < penz.Length; i++)
            {
                while (pnz > 0)
                {
                    int mennyiseg = this.pnz / this.penz(cimlet_hely);
                    pnz = pnz % this.penz(cimlet_hely);
                    cimlet_hely++;
                }
            }
        }
    }
}
