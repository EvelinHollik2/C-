using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CimletekOOP
{

    internal class Cimletek
    {
        //osztályváltorók
        private int cimlet_hely; //számítások
        static int[] penz = { 5, 10, 20, 50, 100, 200, 500, 1000, 2000, 5000, 10000, 20000 }; //tömb, adatok megadása, tárolása

        //Konstruktor
        public Cimletek() { }
        
        //Eredményt átadó konstruktor
        public Cimletek(int cimlet_hely) 
        {
            this.cimlet_hely = cimlet_hely;
        }

        //Eredményeket átadó metódusok
        public int getCimletHely() 
        {
            return cimlet_hely;
        }

        //Számítás
        public void setCimletHely(int cimlet_hely)
        {
            this.cimlet_hely= cimlet_hely; 
            int val = 0; //Adat gyűjtés
            for (int i = penz.Length-1; i>=0; i--) //Számolás ciklusa
            {
                while (cimlet_hely >= penz[i])
                {
                    cimlet_hely -= penz[i];
                    val++;
                }
            }
            Console.WriteLine(val); //Kiiratom az értéket
        }
    }
}
