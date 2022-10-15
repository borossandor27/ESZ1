using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormDolgozo
{
    public partial class Form_Dolgozo : Form
    {
        string muvelet;
        private Dolgozo kivalasztottDolgozo;

        public Form_Dolgozo(string muvelet)
        {
            InitializeComponent();
            this.muvelet = muvelet;
        }       
        public Form_Dolgozo()
        {
            InitializeComponent();
        
        }

        private void Form_Dolgozo_Load(object sender, EventArgs e)
        {
            switch (muvelet)
            {
                case "insert":
                    button_Muvelet.Text = "Új dolgozó rögzítése";
                    this.Text = "Új dolgozó adatai";
                    textBox_Nev.Focus();
                    break;
                case "update":
                    kivalasztottDolgozo = (Dolgozo) Program.formNyito.listBox_Dolgozok.SelectedItem;

                    button_Muvelet.Text = $"{kivalasztottDolgozo.Nev} adatainak módosítása";
                    textBox_ID.Text = kivalasztottDolgozo.Id.ToString();
                    textBox_Nev.Text = kivalasztottDolgozo.Nev;
                    dateTimePickerSzuletett.Value = kivalasztottDolgozo.Szuletett;
                    numericUpDown_Fizetes.Value=kivalasztottDolgozo.Fizetes;
                    this.Text = $"{kivalasztottDolgozo.Nev} adatainak módosítása";
                    break;
                default:
                    break;
            }
        }

        private void button_Muvelet_Click(object sender, EventArgs e)
        {
            switch (muvelet)
            {
                case "insert":
                    ujDolgozoRogzites();
                    break;
                case "update":
                    DolgozoModositas();
                    break;
                default:
                    break;
            }
        }

        private void DolgozoModositas()
        {
            if (mezokKitoltottek())
            {
                Dolgozo uj = new Dolgozo(ulong.Parse(textBox_ID.Text), textBox_Nev.Text, dateTimePickerSzuletett.Value, numericUpDown_Fizetes.Value);
                Program.adatbazis.updateDolgozo(uj);
                MessageBox.Show("sikeres módosítás");
            }
            else
            {
                MessageBox.Show("Hiányzó adatok");
            }
            this.Close();
        }

        private void ujDolgozoRogzites()
        {
            if (mezokKitoltottek())
            {
                Dolgozo uj = new Dolgozo(0, textBox_Nev.Text, dateTimePickerSzuletett.Value, numericUpDown_Fizetes.Value);
                Program.adatbazis.ujDolgozo(uj);
                MessageBox.Show("sikeres rögzítés");
            }
            else
            {
                MessageBox.Show("Hiányzó adatok");
            }
            this.Close();
        }

        private bool mezokKitoltottek()
        {
            if (string.IsNullOrEmpty(textBox_ID.Text) && !muvelet.Equals("insert"))
            {
                return false;
            }
            if (string.IsNullOrEmpty(textBox_Nev.Text))
            {
                return false;
            }
            int kor = DateTime.Now.Year - dateTimePickerSzuletett.Value.Year;
            if (kor<14 || kor>100 )
            {
                return false;
            }
            return true;
        }
    }
}
