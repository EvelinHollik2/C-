using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csomagolo_ceg
{
    internal class csomagoloOOP
    {
        private double osszeg;
        private double atmero;
        private double db;
        private double pi = 3.14;

        public csomagoloOOP() { }
        public csomagoloOOP(double osszeg)
        { 
            this.osszeg = osszeg;
        }

        public double getOsszeg()
        {
            return this.osszeg;
        }



        public void setOsszeg(double osszeg)
        {
            this.osszeg = osszeg;
            if (true)
            {
                osszeg = (float) ((((atmero* pi) * 2) + 60) * db) / 100;
            }
        }


    }
}
