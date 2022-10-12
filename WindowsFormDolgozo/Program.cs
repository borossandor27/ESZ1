using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormDolgozo
{
    internal static class Program
    {
        public static FormNyito formNyito = null;
        public static Form_Dolgozo form_Dolgozo = null;
        public static Adatbazis adatbazis = new Adatbazis();

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            formNyito = new FormNyito();    
            //form_Dolgozo = new Form_Dolgozo();
            Application.Run(formNyito);
        }
    }
}
