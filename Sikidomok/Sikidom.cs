using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sikidomok
{
    abstract class Sikidom
    {
        string nev;
        public string Nev { get => nev; set => nev = value; }
        abstract public double Kerulet { get; }
        abstract public double Terulet { get; }

        protected Sikidom()
        {
            
        }
    }
}
