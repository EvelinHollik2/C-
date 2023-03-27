using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szigetek__OOP_
{
    internal class Szigetszamolas
    {
        // osztályváltozók
        int islandCount = 0;
        int maxIslandLength = 0;
        int i = 0;
        string data = string.Empty;
        
        //konstruktorok
        public Szigetszamolas() { }
        public Szigetszamolas(string data) 
        {
            this.data = data;
        }

        //metódusok
        public void setData(string data) { this.data = data;}
        public string getData() { return this.data;}

        public int getIslandCount() { return islandCount; }
        public int getMaxIslandLength() { return maxIslandLength; }

        public void Szamol()
        {
            while (i < this.data.Length)
            {
                if (this.data[i] == '1')
                {
                    ++this.islandCount;
                    int j = i;
                    int tmp = 0; //sziget beljesét gyűjti
                    while (j < this.data.Length && this.data[j] == '1')
                    {
                        ++j;
                        ++tmp;
                    }
                    i = j;
                    if (tmp > this.maxIslandLength) { this.maxIslandLength = tmp; }
                }
                else
                {
                    ++i;
                }
            }

        }

    }
}
