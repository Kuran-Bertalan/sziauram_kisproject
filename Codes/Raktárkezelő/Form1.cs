using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace Raktárkezelő
{
    public partial class Form1 : Form
    {
        public List<Termekek> termek = new List<Termekek>();

        public Form1()
        {
            InitializeComponent();

            fajlBeolvas("termekek_Kiir.txt");
            dataGridView1.DataSource = termek;

        }

        public void fajlBeolvas(string beolv)
        {
            StreamReader sr = new StreamReader(beolv);
            string[] atmenet;
            while (!sr.EndOfStream)
            {
                atmenet = sr.ReadLine().Split(';');
                termek.Add(new Termekek(atmenet[0], atmenet[1], (Termekek.Kategoria)Enum.Parse(typeof(Termekek.Kategoria), atmenet[2]), Convert.ToInt32(atmenet[3])));
            }
            sr.Close();
        }

        public void fajlKiir(string kiir)
        {
            StreamWriter sw = new StreamWriter("termekek_Kiir.txt");
            foreach (var item in termek)
            {
                sw.WriteLine("{0};{1};{2};{3}", item.TermekAzonosito, item.Nev, item.Kateg, item.DB);
            }
            sw.Close();
        }
      
        public void listaUjraToltes()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = termek;

        }
        public void listahozAdas(Termekek t)
        {
            termek.Add(t);
        }

        public void termekTorlese()
        {
            termek.RemoveAt(dataGridView1.SelectedRows[0].Index);
            listaUjraToltes();
        }

        private void termékTörlésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Biztosan törlöd a terméket?", "Termék törlése", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.No)
            {
                //Do nothing
            }
            else if (dialogResult == DialogResult.Yes)
            {
                termekTorlese();
                listaUjraToltes();
                fajlKiir("termekek_Kiir.txt");
            }
        }
        public void TermekKivitele()
        {
            int kivon = Convert.ToInt32(terKivitText.Text);
            if (kivon > termek[dataGridView1.SelectedRows[0].Index].DB)
            {
                MessageBox.Show("Nincs ennyi termék a raktárban!", "Termék Kivitele");
            }
            else
            {
                for (int i = 0; i < termek.Count; i++)
                {
                    if (dataGridView1.SelectedRows[0].Index == i)
                    {
                        termek[i].DB -= kivon;
                        break;
                    }
                }
            }
        }
        private void terKivitButt_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Biztosan ki szeretné vinni a terméket?", "Termék Kivitele", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.No)
            {
                //Do nothing
            }
            else if (dialogResult == DialogResult.Yes)
            {

                TermekKivitele();
                listaUjraToltes();
                fajlKiir("termekek_Kiir.txt");
                terKivitText = null;
            }
        }

        public void TermekBevitele()
        {
            // int hozzad = Convert.ToInt32(terhozzAD.Text);

            for (int i = 0; i < termek.Count; i++)
            {
                if (dataGridView1.SelectedRows[0].Index == i)
                {
                    termek[i].DB += Convert.ToInt32(terhozzAD.Text);
                    break;
                }
            }


        }
        private void terhozzadButt_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Biztosan hozzá adja a termékeket?", "Termék bevitel", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.No)
            {
                //Do nothing
            }
            else if (dialogResult == DialogResult.Yes)
            {

                TermekBevitele();
                listaUjraToltes();
                fajlKiir("termekek_Kiir.txt");
                terhozzAD = null;
            }
        }

        private void termékHozzáadásToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Termekhozzaadas th = new Termekhozzaadas();
            th.ShowDialog();
        }
    }
}
