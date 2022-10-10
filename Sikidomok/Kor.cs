using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sikidomok
{
    internal class Kor : Sikidom
    {
        double sugar;
        double atmero;

        public double Sugar { 
            get => sugar; 
            set 
            {
                if (value<=0)
                {
                    throw new ArgumentOutOfRangeException($"{value} érték nem megengedett a kör sugarának!");
                }
                else
                {
                    sugar = value;
                }
            }  
        }
        public double Atmero { get => 2*sugar; }

        public override double Kerulet => 2 * sugar * Math.PI;

        public override double Terulet => sugar * sugar * Math.PI;

        public Kor(double sugar) 
        {
            Sugar = sugar;
            base.Nev = "Kör";
        }

    }
}
