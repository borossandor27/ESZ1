using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormDolgozo
{
    internal class Dolgozo
    {
        readonly ulong id;
        string nev;
        DateTime szuletett;
        decimal fizetes;

        public Dolgozo(ulong id, string nev, DateTime szuletett, decimal fizetes)
        {
            this.id = id;
            this.Nev = nev;
            this.Szuletett = szuletett;
            this.Fizetes = fizetes;
        }

        public ulong Id { get => id; }
        public string Nev { get => nev; set => nev = value; }
        public DateTime Szuletett { get => szuletett; set => szuletett = value; }
        public decimal Fizetes { get => fizetes; set => fizetes = value; }

        public override string ToString()
        {
            return nev;
        }
    }
}
