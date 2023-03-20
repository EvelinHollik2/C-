using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PonHatOOP
{
    internal class PonHat
    {
        private int[] pontok;
        public static string[] jegyek = { "elégtelen", "elégséges", "közepes", "jó", "jeles" };
        private int pont = 0;

        public PonHat(int p) { this.pontok = p; }


        public PonHat getPont() { return jegyek[pont = -1];}

        public void szamitas()
        {
            setPont();
        }

        private void setPont()
        {
            for (int i = 0; i < pontok.GetLength(0); i++)

                if (this.pont >= 0 && this.pont < 50) pont = 1;
                if (this.pont >= 50 && this.pont < 65) pont = 2;
                if (this.pont >= 65 && this.pont < 80) pont = 3;
                if (this.pont >= 80 && this.pont < 90) pont = 4;
                if (this.pont >= 90 && this.pont < 100) pont = 5;
        }
    }
}