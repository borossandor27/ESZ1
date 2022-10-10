using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormstagdiBefizetes
{
    internal class Ugyfel
    {
        readonly int id;
        readonly string name;

        public Ugyfel(int id, string name)
        {
            this.id = id;
            this.name = name;
        }

        public int Id => id;

        public string Name => name;
        public override string ToString()
        {
            return this.name;
        }
    }
}
