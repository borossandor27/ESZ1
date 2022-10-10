using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sikidomok
{
    internal class Haromszog : Sikidom
    {
        double oldalA;
        double oldalB;
        double oldalC;


        public double OldalA { 
            get => oldalA; 
            set 
            {
                if (value <=0)
                {
                    throw new ArgumentException($"\n{value} nem lehet háromszög oldalának a hossza!\n");
                }
                else
                {
                    oldalA = value;
                }
            } 
        }
        public double OldalB { get => oldalB; set => oldalB = value; }
        public double OldalC { get => oldalC; set => oldalC = value; }

        public override double Kerulet => oldalA + oldalB + oldalC;

        public override double Terulet => terulet();

        public Haromszog(double oldalA, double oldalB, double oldalC)
        {

            OldalA = oldalA;
            OldalB = oldalB;
            OldalC = oldalC;
            base.Nev = "Általános háromszög";
            if (szerkeszheto())
            {
                throw new ArgumentException($"\n{oldalA}, {oldalB}, {oldalC} oldalakkal nem szerkeszthető háromszög!\n");
            }
        }

        public Haromszog(double oldalA, double oldalB) 
        {
            //-- Egyenő oldalú háromszö
            OldalA = oldalA;
            OldalB = oldalB;
            OldalC = oldalA;
            base.Nev = "Egyenlő szárú háromszög";
        }

        public Haromszog(double oldalA) 
        {
            OldalA = oldalA;
            OldalB = oldalA;
            OldalC = oldalA;
            base.Nev = "Egyenlő oldalú háromszög";
        }

        private bool szerkeszheto()
        {
            return (oldalA > oldalB + oldalC) && (oldalB > oldalC + oldalA) && (oldalC > oldalA + oldalB);
        }


        private double terulet()
        {
            double s = (oldalA + oldalB + oldalC) / 2;
            return Math.Sqrt(s * (s - oldalA) * (s - oldalB) * (s - oldalC));
        }
    }
}
