using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormstagdiBefizetes
{
    internal static class Program
    {
        public static FormBefizetes formBefizetes;
        public static FormNyito formNyito;
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            formBefizetes = new FormBefizetes();    
            formNyito = new FormNyito();
            Application.Run(formNyito);
        }
    }
}
