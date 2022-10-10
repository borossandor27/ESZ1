using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sikidomok
{
    internal class Teglalap : Sikidom
    {
        readonly double oldalA, oldalB;

        public Teglalap(double oldalA, double oldalB)
        {
            this.oldalA = oldalA;
            this.oldalB = oldalB;
            base.Nev = "Téglalap";
        }

        public override double Kerulet => 2 * (oldalA + oldalB);

        public override double Terulet => oldalA * oldalB;

        public double OldalA => oldalA;

        public double OldalB => oldalB;
    }
}
