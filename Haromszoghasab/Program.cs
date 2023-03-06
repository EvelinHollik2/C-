using System;

namespace Haromszoghasab
{
    class Haromszog
    {
        private double a;
        private double b;
        private double c;
        private double terulet;
        private double kerulet;

        public Haromszog() { }
        public Haromszog(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
        public void setA(double a) { this.a = a; }
        public void setB(double b) { this.b = b; }
        public void setC(double c) { this.c = c; }
        public double getA() { return this.a; }
        public double getB() { return this.b; }
        public double getC() { return this.c; }


        public void setKerulet()
        { this.kerulet = a + b + c; }
        public double getKerulet()
        { return this.kerulet; }
        public void setTerulet()
        { 
            double s = (this.a + this.b + this.c) / 2;
            this.terulet = Math.Round(Math.Sqrt(s * (s - this.a) * (s - this.b) * (s - this.c)), 2);
        }
        public double getTerulet()
        { return this.terulet; }
    }

    class Hhasab : Haromszog
    {
        private double m;
        private double terfogat;
        private double felszin;

        public Hhasab() : base() { }
        public Hhasab(double a, double b, double c, double m) : base(a, b, c)
        { this.m = m; }
        public void setM2(double m) { this.m = m; }
        public void setHaromszog()
        {
            base.setKerulet();
            base.setTerulet();
        }
        public void setTerfogat()
        { this.terfogat = base.getTerulet() * this.m; }
        public void setFelszin()
        { this.felszin = base.getKerulet() * this.m + 2 * base.getTerulet(); }
        public double getTerfogat() { return this.terfogat; }
        public double getFelszin() { return this.felszin; }
    }

    internal class Program
    {
        enum nyomtat { oldal, kerter, osszes }
        static void Main(string[] args)
        {

            Haromszog h1 = new Haromszog();
            kiir(h1, nyomtat.oldal);

            h1.setA(3);
            h1.setB(5);
            h1.setC(6);

            kiir(h1, nyomtat.oldal);
            h1.setTerulet();
            h1.setKerulet();
            kiir(h1, nyomtat.kerter);

            Console.WriteLine();
            Console.WriteLine("hasáb példa");
            Hhasab h2 = new Hhasab();
            h2.setHaromszog();
            h2.setTerfogat();
            h2.setFelszin();

            Console.WriteLine($"Felszín:{h2.getFelszin()}, Térfogat:{h2.getTerfogat()}");

            Console.ReadKey();
        }

        static private void kiir(Haromszog obj, nyomtat v)
        {
            if (v == nyomtat.oldal)
            {
                Console.WriteLine($"A h1 háromszög oldalai: a={obj.getA()}, b = {obj.getB()}, c={obj.getC()}");
            }
            else
                Console.WriteLine($"A h1 háromszög területe ={obj.getTerulet()}, kerület = {obj.getKerulet()}");

        }
        static private void kiir(double a, double b, double c, double m)
        {
        }

    }
}
