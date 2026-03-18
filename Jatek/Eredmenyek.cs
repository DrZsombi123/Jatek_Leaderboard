using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jatek
{
    public class Eredmeny
    {
        private string nev;
        private int pont;
        private DateTime idopont;

        public DateTime Idopont => idopont;
        public int Pont => pont;
        public string Nev => nev;

        public Eredmeny(string nev, int pont)
        {
            this.nev = nev;
            this.pont = pont;
            this.idopont = DateTime.Now;
        }


        public override string ToString()
        {
            return $"Név: {nev} ;Pont: {pont}; Idő: {idopont}";
        }
    }
}
