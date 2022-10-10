using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormstagdiBefizetes
{
    public partial class FormBefizetes : Form
    {
        Ugyfel kivalasztottUgyfel=null;
        public FormBefizetes()
        {
            InitializeComponent();
        }

        private void FormBefizetes_Load(object sender, EventArgs e)
        {
            if (Program.formNyito.listBox_Ugyfelek.SelectedIndex < 0)
            {
                MessageBox.Show("Nincs kiválasztott ügyfél!");
            }
            kivalasztottUgyfel = (Ugyfel)Program.formNyito.listBox_Ugyfelek.SelectedItem;
            textBox_UgyfelNeve.Text = kivalasztottUgyfel.Name;
            this.Text = kivalasztottUgyfel.Name + " tagdíj befizetése";
        }

        private void button_Insert_Click(object sender, EventArgs e)
        {
            Program.formNyito.SQLcommand.CommandText = $"INSERT INTO `befiz`(`azon`, `datum`, `osszeg`) VALUES ('{kivalasztottUgyfel.Id}','{DateTime.Now.ToString("yyyyy-MM-d H:m:s")}','{numericUpDown_Befizetes.Value}')";
            try
            {
                if (Program.formNyito.SQLcommand.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Sikeres rögzítés!");
                }
                else
                {
                    MessageBox.Show("Sikertelen rögzítés!");
                }
            }
            catch (MySqlException ex)
            {

                MessageBox.Show(ex.Message);
            }
            this.Close();
        }
    }
}
