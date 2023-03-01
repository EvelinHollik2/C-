using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kor
{
    class Kor
    {
        // Osztályváltozók
        private double r;
        private double terulet;
        private double kerulet;

        public Kor() { }

        public Kor(double r)
        {
            this.r = r;
        }

        public void setr(double r) { this.r = r; }

        public void setTerulet()
        { this.terulet = Math.Pow(r, 2) * Math.PI; }
        public double getTerulet()
        { return this.terulet; }
        public void setKerulet()
        { this.kerulet = 2 * r * Math.PI; }
        public double getKerulet()
        { return this.kerulet; }
    }
    class Henger : Kor
    {
        private double m;
        private double terfogat;
        private double felszin;

        public Henger() : base() { }
        public Henger(double r, double m) : base(r) 
        {
            this.m = m;
        }
        public void setM(int m) { this.m = m; }

        public void setKor()
        {
            base.setTerulet();
            base.setKerulet();
        }

        public void setTerfogat()
        {
            this.terfogat = base.getTerulet() * this.m;
        }
        public void setFelszin()
        {
            this.felszin = base.getKerulet() * this.m + 2 * base.getTerulet();
        }
        public double getTerfogat() { return this.terfogat; }
        public double getFelszin() { return this.felszin; }

    }
    internal class Program
    {
        enum nyomtat {osszes }
        static void Main(string[] args)
        {
            Kor k1 = new Kor();
            kiir(k1);

            k1.setr(3);
            kiir(k1);
            k1.setTerulet();
            k1.setKerulet();
            kiir(k1);
            Console.ReadKey();

            Console.WriteLine();
            Console.WriteLine("Henger példa");
            Henger k2 = new Henger(3, 5);
            k2.setKor();
            k2.setTerfogat();
            k2.setFelszin();

            Console.WriteLine($"Felszine:{k2.getFelszin()}, Térfogata:{k2.getTerfogat()}");
            Console.ReadKey();
        }
        static private void kiir(Kor obj)
        {
            Console.WriteLine($"A kör területe={obj.getTerulet()}, kerület={obj.getKerulet()}");
        }
        static private void kiir(double r)
        { 
        }
    }
}
