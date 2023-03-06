﻿using System;

namespace Haromszoghasab
{
    class Haromszog
    {
        private int a;
        private int b;
        private int c;
        private int terulet;
        private int kerulet;

        public Haromszog() { }
        public Haromszog(int a, int b, int c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
        public void setA(int a) { this.a = a; }
        public void setB(int b) { this.b = b; }
        public void setC(int c) { this.c = c; }
        public int getA() { return this.a; }
        public int getB() { return this.b; }
        public int getC() { return this.c; }


        public void setKerulet()
        { this.kerulet = a + b + c; }
        public int getKerulet()
        { return this.kerulet; }
        public void setTerulet()
        { this.terulet = }
        public int getTerulet()
        { return this.terulet; }
    }
    class Hhasab : Haromszog
    {
        private int m;
        private int terfogat;
        private int felszin;

        public Hhasab() : base() { }
        public Hhasab(int a, int b, int c, int m) : base(a, b, c)
        { this.m = m; }
        public void setM2(int m) { this.m = m; }
        public void setHaromszog()
        {
            base.setKerulet();
            base.setTerulet();
        }
        public void setTerfogat()
        { this.terfogat = base.getTerulet() * this.m; }
        public void setFelszin()
        { this.felszin = base.getKerulet() * this.m + 2 * base.getTerulet(); }
        public int getTerfogat() { return this.terfogat; }
        public int getFelszin() { return this.felszin; }
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
        static private void kiir(int a, int b, int c, int m)
        {
        }

    }
}
