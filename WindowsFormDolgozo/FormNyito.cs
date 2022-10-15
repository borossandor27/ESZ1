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
    public partial class FormNyito : Form
    {
        public FormNyito()
        {
            InitializeComponent();
        }

        private void FormNyito_Load(object sender, EventArgs e)
        {
            listBoxUpdate();
        }
        void listBoxUpdate()
        {
            listBox_Dolgozok.Items.Clear();
            foreach (Dolgozo item in Program.adatbazis.osszesDolgozo())
            {
                listBox_Dolgozok.Items.Add(item);
            }
        }

        private void button_Insert_Click(object sender, EventArgs e)
        {
           Form_Dolgozo form_Dolgozo=new Form_Dolgozo("insert");
            form_Dolgozo.ShowDialog();
        }

        private void FormNyito_Activated(object sender, EventArgs e)
        {
            listBoxUpdate();
            
        }

        private void button_Frissit_Click(object sender, EventArgs e)
        {
            listBoxUpdate();
        }

        private void button_Update_Click(object sender, EventArgs e)
        {
            if (listBox_Dolgozok.SelectedIndex<0)
            {
                MessageBox.Show("Nincs kiválasztott!");
                return;
            }
            Form_Dolgozo form_Dolgozo = new Form_Dolgozo( "update");
            form_Dolgozo.ShowDialog();
        }

        private void Kattintott(object sender, EventArgs e)
        {
            MessageBox.Show("valahova a Formra kattintott");
        }
    }
}
