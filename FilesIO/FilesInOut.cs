using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilesIO
{
    internal class FileInpOut
    {
        // Osztályváltozók
        private string fileName;
        private FileMode fileMode;
        private FileAccess fileAccess;
        private FileStream fs;
        private StreamReader sr;


        public FileInpOut()
        {
            setFileName();  // Fájl nevének bekérése
            setFileMode();  // Megnyitás módjának bekérése
            setFileAccess();    // Hozzáférés módjának beállítása
        }

        private void setFileName()
        {
            Console.WriteLine("Adja meg a fájl nevét kiterjesztés nélkül:");
            this.fileName = Console.ReadLine() + ".txt";
        }

        private void setFileMode()
        {
            bool ismet;
            string s;

            Console.WriteLine("Adja meg a műveletet:");
            Console.WriteLine("     cr:  Create");      // Létrehoz egy új fájlt, ha már létezik, a tartalmát kitörli.
            Console.WriteLine("     crn: CreateNew");   // Mint előbb, de ha már létezik a fájl, akkor kivételt dob.
            Console.WriteLine("     o:   Open");        // Megnyit egy fájlt, ha nem létezik, kivételt dob.
            Console.WriteLine("     oc:  OpenOrCreate");    // Mint előbb, de ha nem létezik, akkor létrehozza a fájlt.
            Console.WriteLine("     a:   Append");      // Megnyit egy fájlt és automatikusan a végére áll. Ha nem létezik, létrehozza.
            Console.WriteLine("     t:   Truncate");    // Megnyit egy létező fájlt és törli a tartalmát.  Ebben a módban a fájl  tartalmát nem lehet olvasni (egyébként kivételt dob).

            do
            {
                ismet = false;
                s = Console.ReadLine().ToLower().Trim();
                switch (s)
                {
                    case "cr": fileMode = FileMode.Create; break;
                    case "crn": fileMode = FileMode.CreateNew; break;
                    case "o": fileMode = FileMode.Open; break;
                    case "oc": fileMode = FileMode.OpenOrCreate; break;
                    case "a": fileMode = FileMode.Append; break;
                    case "t": fileMode = FileMode.Truncate; break;
                    default:
                        Console.WriteLine("Hibás adat! Ismételje meg!");
                        ismet = true;
                        break;
                }
            } while (ismet);
        }

        private void setFileAccess()
        {
            bool ismet;
            string s;

            Console.WriteLine("Adja meg a fájl hozzáférést:");
            Console.WriteLine("     r:  Olvasás");
            Console.WriteLine("     w:  Írás");
            Console.WriteLine("     rw: Olvasás és írás");

            do
            {
                ismet = false;
                s = Console.ReadLine().ToLower().Trim();
                switch (s)
                {
                    case "r": fileAccess = FileAccess.Read; break;
                    case "w": fileAccess = FileAccess.Write; break;
                    case "rw": fileAccess = FileAccess.ReadWrite; break;
                    default:
                        Console.WriteLine("Hibás adat! Ismételje meg!");
                        ismet = true;
                        break;
                }
            } while (ismet);
        }

        public StreamReader getFile()
        {
            this.fs = new FileStream(this.fileName, this.fileMode, this.fileAccess);
            this.sr = new StreamReader(fs);
            return sr;
        }

        public void closeFile()
        {
            if (this.sr != null) this.sr.Close();
            if (this.fs != null) this.fs.Close();
        }

    }
}