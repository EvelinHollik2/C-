using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CimletekOOP
{
    public class Cimletek2
    {
        public string penz { get; }
        public int cimlet_hely { get; }

        public Cimletek2(string penzz, int cimlet)
        {
            penz = penzz;
            cimlet_hely = cimlet;
        }
    }

    public class Penz
    {
        private readonly List<Cimletek2> penzek;

        public Penz()
        {
            penzek = new List<Cimletek2>
            {
                new Cimletek2("20000 Ft", 20000),
                new Cimletek2("10000 Ft", 10000),
                new Cimletek2("5000 Ft", 5000),
                new Cimletek2("2000 Ft", 2000),
                new Cimletek2("1000 Ft", 1000),
                new Cimletek2("500 Ft", 500),
                new Cimletek2("200 Ft", 200),
                new Cimletek2("100 Ft", 100),
                new Cimletek2("50 Ft", 50),
                new Cimletek2("20 Ft", 20),
                new Cimletek2("10 Ft", 10),
                new Cimletek2("5 Ft", 5),
            };
        }

        public List<Cimletek2> getCimlet_hely()
        {
            return penzek;
        }

        public string setCimlet_hely(int osszeg)
        {
            string cimlet = null;
            int maradék = osszeg;
            foreach (var pénznem in penzek)
            {
                if (maradék >= pénznem.cimlet_hely)
                {
                    int darab = maradék / pénznem.cimlet_hely;
                    maradék %= pénznem.cimlet_hely;
                    if (darab > 0)
                    {
                        cimlet += $"{darab} x {pénznem.penz}\n";
                    }
                }
            }
            return cimlet;
        }
    }
}