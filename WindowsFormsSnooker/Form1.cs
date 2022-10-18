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

namespace WindowsFormsSnooker
{
    public partial class Form1 : Form
    {
        MySqlConnection connection = null;
        MySqlCommand command = null;
        List<Versenyzo> versenyzok = new List<Versenyzo>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MySqlConnectionStringBuilder sb = new MySqlConnectionStringBuilder();
            sb.Server = "127.0.0.1";
            sb.UserID = "root";
            sb.Password = "";
            sb.Database = "snooker";
            connection = new MySqlConnection(sb.ConnectionString);
 
            OszlopokMeghatarozasa();
            VersenyzokBeolvasasa();
            AdattablatFrissit();
        }

        private void VersenyzokBeolvasasa()
        {
            versenyzok.Clear();
            try
            {
                connection.Open();
                command = connection.CreateCommand();
                command.CommandText = "SELECT `Helyezes`,`Nev`,`Orszag`,`Nyeremeny` FROM `snooker` WHERE 1";
                using (MySqlDataReader dr = command.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        try
                        {
                            versenyzok.Add(new Versenyzo(dr.GetInt32("Helyezes"), dr.GetString("Nev"), dr.GetString("Orszag"), dr.GetDecimal("nyeremeny")));
                        }
                        catch (ArgumentException ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                }
                connection.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                Environment.Exit(0);
            }
        }

        private void AdattablatFrissit()
        {
            dataGridView_Versenyzok.Rows.Clear();
            foreach (Versenyzo item in versenyzok)
            {
                int sorszam = dataGridView_Versenyzok.Rows.Add();//-- létrehozzuk a sort és letároljuk a sorszámát 
                DataGridViewRow sor = dataGridView_Versenyzok.Rows[sorszam];
                sor.Cells["helyezes"].Value = item.Helyezes;
                sor.Cells["nev"].Value = item.Nev;
                sor.Cells["orszag"].Value = item.Orszag;
                sor.Cells["nyeremeny"].Value = item.Nyeremeny;
            }

        }

        private void OszlopokMeghatarozasa()
        {
            //-- a táblázat általános tulajdonságai
            dataGridView_Versenyzok.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView_Versenyzok.MultiSelect = false;
            dataGridView_Versenyzok.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView_Versenyzok.EnableHeadersVisualStyles = false;
            dataGridView_Versenyzok.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView_Versenyzok.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 97, 0);
            dataGridView_Versenyzok.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView_Versenyzok.ColumnHeadersDefaultCellStyle.Padding = new Padding(0, 5, 0, 5);
            dataGridView_Versenyzok.RowTemplate.DefaultCellStyle.Padding = new Padding(0, 1, 0, 1);

            //-- Oszlopok tulajdonságainak a beállítása
            //-- 1. oszlop
            DataGridViewColumn col_Helyezes = new DataGridViewColumn();
            {
                col_Helyezes.Name = "helyezes"; //-- cella azonosításhoz
                col_Helyezes.HeaderText = "Helyezés"; //-- felhasználónak jelezzük a tartalmat
                col_Helyezes.CellTemplate = new DataGridViewTextBoxCell();
                col_Helyezes.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            }

            dataGridView_Versenyzok.Columns.Add(col_Helyezes);

            //-- 2. oszlop
            DataGridViewColumn col_Nev = new DataGridViewColumn();
            {
                col_Nev.Name = "nev"; //-- cella azonosításhoz
                col_Nev.HeaderText = "Név"; //-- felhasználónak jelezzük a tartalmat
                col_Nev.CellTemplate = new DataGridViewTextBoxCell();
                col_Nev.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            }
            dataGridView_Versenyzok.Columns.Add(col_Nev);

            //-- 3. oszlop
            DataGridViewColumn col_Orszag = new DataGridViewColumn();
            {
                col_Orszag.Name = "orszag"; //-- cella azonosításhoz
                col_Orszag.HeaderText = "Ország"; //-- felhasználónak jelezzük a tartalmat
                col_Orszag.CellTemplate = new DataGridViewTextBoxCell();
                col_Orszag.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            }
            dataGridView_Versenyzok.Columns.Add(col_Orszag);

            //-- 4. oszlop
            DataGridViewColumn col_Nyeremeny = new DataGridViewColumn();
            {
                col_Nyeremeny.Name = "Nyeremeny"; //-- cella azonosításhoz
                col_Nyeremeny.HeaderText = "Nyeremény"; //-- felhasználónak jelezzük a tartalmat
                col_Nyeremeny.ValueType = typeof(int);
                col_Nyeremeny.CellTemplate = new DataGridViewTextBoxCell();
                col_Nyeremeny.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                col_Nyeremeny.DefaultCellStyle.Format = "c0"; //-- currency 0 tizedessel
            }
            dataGridView_Versenyzok.Columns.Add(col_Nyeremeny);


        }

        private void dataGridView_Versenyzok_SelectionChanged(object sender, EventArgs e)
        {
            //-- belekattintott a táblázatba
            if (dataGridView_Versenyzok.SelectedRows.Count==0)
            {
                return;
            }
            DataGridViewRow kivalasztottSor = dataGridView_Versenyzok.SelectedRows[0];
            if (kivalasztottSor.Cells["helyezes"].Value != null)
            {
                textBox_helyezes.Text = kivalasztottSor.Cells["helyezes"].Value.ToString();
                textBoxNev.Text = kivalasztottSor.Cells["nev"].Value.ToString();
                comboBox_Orszag.Text = kivalasztottSor.Cells["orszag"].Value.ToString();
                numericUpDown_Nyeremeny.Value = decimal.Parse(kivalasztottSor.Cells["nyeremeny"].Value.ToString());

            }
        }

        private void button_Update_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                command.Parameters.Clear();
                //-- parancsot meghatározzuk ---
                command.CommandText = "UPDATE `snooker` SET `Nyeremeny`=@osszeg WHERE `Helyezes`= @id;";
                //-- végrehajtáshoz szükséges adatokat átadjuk ---
                command.Parameters.AddWithValue("@id", textBox_helyezes.Text);
                decimal nyeremeny = numericUpDown_Nyeremeny.Value;
                command.Parameters.AddWithValue("@osszeg", nyeremeny.ToString());
                if (command.ExecuteNonQuery()==1)
                {
                    //-- visszajelzés a felhasználónak -----------
                    MessageBox.Show("A nyeremény módosítása megtörtént!");
                    textBox_helyezes.Text = "";
                    textBoxNev.Text = "";
                    comboBox_Orszag.Text = "";
                    numericUpDown_Nyeremeny.Value = numericUpDown_Nyeremeny.Minimum;
                }
                else
                {
                    MessageBox.Show("Sikertelen!");
                }
                connection.Close();
            }
            catch (MySqlException ex)
            {

                MessageBox.Show(ex.Message);
            }
            VersenyzokBeolvasasa();
            AdattablatFrissit();
        }
        /***
         * Fejléc cellára kattintva az adott oszlop tartalma alapján sorba rendezi a táblázatot
         */
        private void dataGridView_Versenyzok_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            this.dataGridView_Versenyzok.Sort(this.dataGridView_Versenyzok.Columns[e.ColumnIndex], ListSortDirection.Ascending);
        }
    }
}
