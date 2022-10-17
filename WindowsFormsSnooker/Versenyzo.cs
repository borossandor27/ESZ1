using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsSnooker
{
    internal class Versenyzo
    {
        readonly int helyezes;
        readonly string nev;
        string orszag;
        decimal nyeremeny;

        public int Helyezes => helyezes;

        public string Nev => nev;

        public string Orszag { get => orszag; set => orszag = value; }
        public decimal Nyeremeny { 
            get => nyeremeny;
            set
            {
                if (value > 0)
                {
                    nyeremeny = value;
                }
                else
                {
                    throw new ArgumentException("Nyeremény nem lehet negatív");
                }
            }
        }

        public Versenyzo(int helyezes, string nev, string orszag, decimal nyeremeny)
        {
            this.helyezes = helyezes;
            this.nev = nev;
            Orszag = orszag;
            Nyeremeny = nyeremeny;
        }
    }
}
