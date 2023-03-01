using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace negyszog
{
    class Negyszog
    {
        // Osztályváltozók
        private int a; // a oldal
        private int b; // b oldal
        private int terulet;
        private int kerulet;


        // Konstruktor

        public Negyszog() { }

        public Negyszog(int a, int b)
        {
            this.a = a;
            this.b = b;
        }
        public Negyszog(int a)
        {
            this.a = a;
            this.b = a;
        }
        // Metódusok
        public void setA(int a) {
            if (a > 1000)
            {
                Console.WriteLine("Az oldal nem lehet nagyobb mint 1000!");
            }
            else
            this.a = a;
        }
        public void setB(int b) { this.b = b; }

        public int getA() { return this.a; }
        public int getB() { return this.b; }

        public void setTerulet() 
        { this.terulet = this.a * this.b; }
        public int getTerulet() 
        { return this.terulet; }
        public void setKerulet() 
        { this.kerulet = 2*(this.a + this.b); }
        public int getKerulet() 
        { return this.kerulet; }
    }
    class Hasab : Negyszog
    {
        private int m;
        private int terfogat;
        private int felszin;

        // Konstruktor
        public Hasab() : base() { }
        public Hasab(int a, int b, int m) : base(a, b)
        {
            this.m = m;
        }
        //egyéb metódusok
        public void setM(int m) { this.m = m; }

        //Kiszámíttatom a szülő osztályban az adatokat
        public void setNegyszog()
        {
            base.setKerulet();
            base.setTerulet();
        }
        //a hasáb adatainak kiszámítása
        public void setTerfogat()
        {
            this.terfogat = base.getTerulet() * this.m;
        }
        public void setFelszin()
        {
            this.felszin = base.getKerulet() * this.m + 2 * base.getTerulet();
        }
        //A hasáb adatainak lekérdezése
        public double getTerfogat() { return this.terfogat; }
        public double getFelszin() { return this.felszin; }
    }


    internal class Program
    {
        enum nyomtat { oldal, kerter, osszes}
        static void Main(string[] args)
        {
            //1.példa
            Negyszog n1 = new Negyszog();

            kiir(n1, nyomtat.oldal);

            n1.setA(5);
            n1.setB(6);

            kiir(n1, nyomtat.oldal);
            n1.setTerulet();
            n1.setKerulet();
            kiir(n1, nyomtat.kerter);

            //2.példa
            Negyszog n2 = new Negyszog(6, 2);
            kiir(n2, nyomtat.oldal);
            n2.setTerulet();
            n2.setKerulet();
            kiir(n2, nyomtat.kerter);

            //3. négyzet példa
            Negyszog n3 = new Negyszog(6);
            kiir(n3, nyomtat.oldal);
            n3.setTerulet();
            n3.setKerulet();
            kiir(n3, nyomtat.kerter);

            //4. Hasáb példa
            Console.WriteLine();
            Console.WriteLine("hasáb példa");
            Hasab h1 = new Hasab(3, 6, 9);
            h1.setNegyszog();
            h1.setTerfogat();
            h1.setFelszin();

            Console.WriteLine($"Felszín:{h1.getFelszin()}, Térfogat:{h1.getTerfogat()}");

            Console.ReadKey();
        }

        //Metódus
        static private void kiir(Negyszog obj, nyomtat v)
        {
            if (v == nyomtat.oldal)
            {
            Console.WriteLine($"Az n1 négyszög oldalai: a={obj.getA()}, b = {obj.getB()}");
            }else
            Console.WriteLine($"Az n1 négyszög területe ={obj.getTerulet()}, kerület = {obj.getKerulet()}");

        }
        static private void kiir(int a, int b) 
        { 
        }
    }
}
