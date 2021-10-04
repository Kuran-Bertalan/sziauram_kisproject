﻿using System;
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
    }
}
