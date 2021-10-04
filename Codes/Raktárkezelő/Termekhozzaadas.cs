using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Raktárkezelő
{
    public partial class Termekhozzaadas : Form
    {
        Form1 f1 = (Form1)Application.OpenForms["form1"];
        public Termekhozzaadas()
        {
            InitializeComponent();
            foreach (var item in Enum.GetValues(typeof(Termekek.Kategoria)))
            {
                termekKat.Items.Add(item);
            }
        }


        private void termHozzadButt_Click_1(object sender, EventArgs e)
        {
            bool vanE = true;
            foreach (var item in f1.termek)
            {
                if (item.TermekAzonosito == termAz.Text)
                {
                    MessageBox.Show("Nem lehet két ugyanolyan termékazonosító!!");
                    vanE = false;
                }
            }
            if (vanE)
            {

                Termekek ter = new Termekek(termAz.Text, termNev.Text, (Termekek.Kategoria)termekKat.SelectedItem, Convert.ToInt32(termekDb.Text));
                f1.listahozAdas(ter);
                f1.listaUjraToltes();

                f1.fajlKiir("termekek_Kiir.txt");

                this.Close();

            }
        }
    }
}
