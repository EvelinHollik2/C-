using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testtomeg_index
{
    struct TTomegOOP
    {
        public double magassag;
        public double suly;
        public double BMI;
    }
    internal class TestTomeg
    {
        private int[,] adat = null;
        private TTomegOOP magass, su, bm;

        public TestTomeg(int[,] p) { this.adat = p; }

        public TTomegOOP getMagass() { return magass; }
        public TTomegOOP getSu() { return su; }
        public TTomegOOP getBm() { return bm; }

        public void szamitas()
        {
            setMagass();
            setSu();
            setBm();
        }
        private void setMagass()
        {
            double magass = Convert.ToDouble(Console.ReadLine()) / 100;
        }
        private void setSu()
        {
            double su = Convert.ToDouble(Console.ReadLine());
        }

        private void setBm()
        {
            double bm = Math.Round(this.su / Math.Pow(this.magass, 2), 1);
        }

    }
}
