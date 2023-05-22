using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Dolgozat_2023_05_22
{
    public struct Konyvek
    {
        public string iro;
        public int evszam;
        public string cim;
    }
    internal class Dolg
    {
        protected static string path = "..\\..\\";
        protected static string inpfile = "konyvek.csv";
        private static string outfile = "talal.txt";
        protected List<Konyvek> list = new List<Konyvek> ();

        #region Konstruktor
        public Dolg() { }
        #endregion Konstruktor
        #region Metódusok
        #region Beolvasás
        public void beolvas()
        {
            FileStream fs = new FileStream(path + inpfile, FileMode.Open, FileAccess.Read);
            using (StreamReader sr = new StreamReader(fs))
            {
                while (!sr.EndOfStream)
                    this.list.Add(convert(sr.ReadLine().Split(';')));
            }
        }
        #endregion Beolvasás
        #region Iro
        private Konyvek convert(string[] line)
        {
            Konyvek konyvek = new Konyvek ();
            konyvek.iro = line[0];
            konyvek.evszam = Convert.ToInt32(line[2]);
            konyvek.cim = line[1];

            return konyvek;
        }
        #endregion Iro
        #region Keresés
        public bool kereses(string iro)
        {
            Konyvek vane = new Konyvek ();
            vane = this.list.Find(list => list.iro == iro);
            if (vane.iro == iro)
               return true;
            return false;
        }
        #endregion Keresés
        #region kiírás
        public void kiir()
        {
            using (StreamWriter sw = new StreamWriter(new FileStream(path + outfile, FileMode.Create, FileAccess.Write), Encoding.Default))
            {
                foreach (Konyvek item in this.list)
                    sw.WriteLine(item.iro + ";" + item.evszam + ";" + item.cim);
            }
        }
        #endregion kiírás
        #endregion Metódusok

        internal class Konyv : Dolg
        {
            public Konyv() { }
            #region listazas
            public void listazas()
            {
                foreach (Konyvek item in this.list)
                {
                    Console.WriteLine($"{item.iro}; {item.evszam}; {item.cim}");
                    Console.WriteLine();
                }
            }
            #endregion listazas
        }
        #region Választás
        internal class Val : Dolg
        {
            public Val() { }
            public void valaszt(string a)
            {   


                switch (a)
                {
                    case "1":
                        using (StreamWriter sw = new StreamWriter(new FileStream(path + outfile, FileMode.Create, FileAccess.Write), Encoding.UTF8))
                        {
                            foreach (Konyvek item in this.list)
                                sw.WriteLine(item.iro);
                        }
                        break;
                    case "2":
                        using (StreamWriter sw = new StreamWriter(new FileStream(path + outfile, FileMode.Create, FileAccess.Write), Encoding.UTF8))
                        {
                            foreach (Konyvek item in this.list)
                                sw.WriteLine(item.evszam);
                        }
                        break;
                    case "3":
                        using (StreamWriter sw = new StreamWriter(new FileStream(path + outfile, FileMode.Create, FileAccess.Write), Encoding.UTF8))
                        {
                            foreach (Konyvek item in this.list)
                                sw.WriteLine(item.cim);
                        }
                        break;
                    default:
                        break;
                }
            }
        }
        #endregion Választás
    }
}
