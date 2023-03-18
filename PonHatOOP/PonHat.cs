using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PonHatOOP
{
    struct Dolg
    {
        public int pnt;
        public int er;
    }
    internal class PonHat
    {
        private int[] adat = null;
        private int pont;
        private int jegy1;
        private int jegy2;
        private int jegy3;
        private int jegy4;
        private int jegy5;
        private Dolg DolgPont;

        PonHat(int[] p) { this.adat = p; }
        public Dolg getPont() { return DolgPont; }

        public void szamitas()
        {
            setPont();
        }

        private void setPont()
        {
            for (int i = 0; i < adat.GetLength(0); i++)
           
                if (pont<50)
                {
                    pont = jegy1;
                }
                if (pont>=50)
                {
                    pont = jegy2;
                }
                if (pont>=65)
                {
                    pont = jegy3;
                }
                if (pont>=80)
                {
                    pont = jegy4;
                }
                if (pont>=90)
                {
                    pont = jegy5;
                }
        }
    }
}
