using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormstagdiBefizetes
{
    public partial class FormNyito : Form
    {
        public MySqlConnection connection = null;
        public MySqlCommand SQLcommand = null;
        public FormNyito()
        {
            InitializeComponent();
        }

        private void FormNyito_Load(object sender, EventArgs e)
        {
            MySqlConnectionStringBuilder sb = new MySqlConnectionStringBuilder();
            sb.Clear();
            sb.Server = "localhost";
            sb.UserID = "root";
            sb.Password = "";
            sb.Database = "tagdij";
            sb.Port = 3306;
            connection = new MySqlConnection(sb.ConnectionString);
            try
            {
                connection.Open();
                SQLcommand = connection.CreateCommand();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message+Environment.NewLine+"A program leáll!");
                Environment.Exit(0);
            }
            UgyfelListaUpdate();

        }

        private void UgyfelListaUpdate()
        {
            listBox_Ugyfelek.Items.Clear();
            SQLcommand.CommandText = "SELECT ugyfel.azon, ugyfel.nev FROM ugyfel; ";
            using (MySqlDataReader dr = SQLcommand.ExecuteReader())
             {
               while (dr.Read())
                {
                    listBox_Ugyfelek.Items.Add(new Ugyfel(dr.GetInt32("azon"), dr.GetString("nev")));
                }
            }
        }

        private void befizetésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.formBefizetes.ShowDialog();
        }
    }
}
