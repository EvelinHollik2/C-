using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hofok_oop
{
    struct NapiAdat
    {
        public string honap; // Hónap neve
        public int nap; // Nap sorszáma
        public int hofok; // Napi hőmérséklet
    }

    struct HaviAdat
    {
        public string honap; // Hónap neve
        public int hofok; // Havi átlaghőmérséklete
    }
    internal class Hofokszamitas
    {
        // Osztályváltozó
        private int[,] adat = null; //Hőfokok tárolására
        private int[] haviAtlag = new int[12]; //Havi átlaghőfokok
        private NapiAdat napiMax, /*Legmagasabb hőmérsékletű nap adatai*/ napiMin /*Legkisebb hőmérséketű nap adatai*/;
        private HaviAdat haviMax, /*Legmagasabb átlaghőmérsékletű havi adatai*/ haviMin /*Legkisebb átlaghőmérséketű havi adatai*/;
        private NapiAdat[] otMinusz = new NapiAdat[5]; //Az öt minuszosnak a tömbje

        static string[] honapok = { "január", "február", "március", "április", "május", "június", "július", "augusztus", "szeptember", "október", "november", "december" };

        // Konstruktor
        public Hofokszamitas(int[,]p) { this.adat = p; }
        
        //Eredményeket átadó metódusok
        public NapiAdat getNapiMin() { return napiMin; }
        public NapiAdat getNapiMax() { return napiMax; }
        public HaviAdat getHaviMin() { return haviMin; }
        public HaviAdat getHaviMax() { return haviMax; }
        public NapiAdat[] getOtMinusz() { return otMinusz; }

        // Számítások
        public void szamitas()
        {
            // Legmelegebb és leghidegebb napok kiszámítása
            setNapiMaxMin();

            // Legmelegebb és leghidegebb átlaghőmérsékletű hónapok kiszámítása
            setHaviAtlag();
            setHaviMaxMin();

            //Folyamatos 5 minuszos nap kiszámítsa
            //setOtMinusz();
        }

        private void setHaviAtlag()
        {
            int osszeg = 0; //Gyűjtés

            for (int i = 0; i < adat.GetLength(0); i++) //hónapok ciklusa
            {
                osszeg = 0;
                for (int j = 0; j < adat.GetLength(1); j++) //napok ciklusa
                {
                    osszeg += adat[i, j];

                    this.haviAtlag[i] = osszeg / adat.GetLength(1);
                }
            }
        }

        private void setOtMinusz()
        {
            int mDb = 0; //Ezzel számolom, hogy hanyadik mínuszos napon tartunk
            for (int i = 0; i < adat.GetLength(0); i++) //hónapok ciklusa
            {
                for (int j = 0; j < adat.GetLength(1); j++) //napok ciklusa
                {
                    if (this.adat[i,j] < 0)
                    {
                        this.otMinusz[mDb].honap = honapok[i];
                        this.otMinusz[mDb].nap = j + 1;
                        this.otMinusz[mDb].hofok = this.adat[i,j];
                        mDb++;
                    } 
                    else
                    {
                        for (int k = 0; k < mDb + 1; k++)
                        {
                            this.otMinusz[k].honap = String.Empty;
                            this.otMinusz[k].nap = 0;
                            this.otMinusz[k].hofok = 0; 
                        } 
                        mDb = 0;
                    }
                }
            }
        }

        private void setHaviMaxMin()
        {
            int max = int.MaxValue;
            int maxInd = 0;
            int min = int.MaxValue;
            int minInd = 0;
            for (int i = 0; i < this.haviAtlag.Length; i++)
            {
                if (this.haviAtlag[i] > max)
                {
                    max = this.haviAtlag[i];
                    maxInd = i;
                } else if (this.haviAtlag[i] < min)
                {
                    min = this.haviAtlag[i];
                    minInd = i;
                }
            }
            this.haviMax.hofok = max;
            this.haviMax.honap = honapok[maxInd];

            this.haviMin.hofok = min;
            this.haviMin.honap = honapok[minInd];

        }


        private void setNapiMaxMin()
        {
            int max = int.MinValue;
            int maxI = 0;
            int maxJ = 0;

            for (int i = 0; i < adat.GetLength(0); i++)
                for (int j = 0; j < adat.GetLength(1); j++)
                    if (this.adat[i,j]> max)
                    {
                        max = this.adat[i, j];
                        maxI = i;
                        maxJ = j;
                    }
            //Eredményn átadása a tömbnek
            this.napiMax.honap = honapok[maxI];
            this.napiMax.nap = maxJ + 1; //Mivel 0. nap nincs a hónapban, ezért növelem
            this.napiMax.hofok = max;

            //napi min
            int min = int.MaxValue;
            int minI = 0;
            int minJ = 0;
            for (int i = 0; i < adat.GetLength(0); i++)
                for (int j = 0; j < adat.GetLength(1); j++)
                    if (this.adat[i, j] < min)
                    {
                        min = this.adat[i, j];
                        minI = i;
                        minJ = j;
                    }
            this.napiMin.honap = honapok[minI];
            this.napiMin.nap = minJ + 1;
            this.napiMin.hofok = min;

        }
    }
}
