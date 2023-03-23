using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsempezesOOP
{
    internal class Csempe
    {
        private float adat;
        private float a;
        private float b;
        private float cs;
        private float T; 
        private float TT;

        public Csempe() { }
        public Csempe(float adat) 
        {
            this.adat = adat;
        }
        public float getAdat() 
        {
            return this.adat;
        }
        public void setAdat(float adat)
        {
            this.adat = adat;
            T = a * b;
            cs = (float)(T / (0.2 * 0.2));
            TT = (float)(cs * 1.1);
            Console.WriteLine(TT);

        }

    }
}
