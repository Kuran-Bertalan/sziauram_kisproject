using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raktárkezelő
{
    public class Termekek
    {
        private string termekAzonosito;

        public string TermekAzonosito
        {
            get { return termekAzonosito; }
            private set
            {
                if (value == null)
                    throw new Exception("Adja meg a termékazonosítót.");
                if (value.Length < 6)
                    throw new Exception("A termékazonosítónak-nak minimum 6karakter hosszunak kell lennie.");
                if (value.Length > 10)
                    throw new Exception("A termékazonosító maximum 10 karakter hosszú lehet.");
                termekAzonosito = value;
            }
        }
        private string nev;

        public string Nev
        {
            get { return nev; }
            private set
            {
                if (value == null)
                    throw new Exception("Adja meg a termék nevét.");
                if (value.Length < 3)
                    throw new Exception("Az név-nek minimum 3 karakter hosszunak kell lennie.");
                nev = value;
            }
        }

        public enum Kategoria
        {
            Ruházat,
            Zöldség_Gyümölcs,
            Tejtermékek, Pékáru,
            Hús_Hal_Felvágott,
            Alapvető_élelmiszerek,
            Fagyasztott_élelmiszerek,
            Italok,
            Alkohol,
            Háztartás,
            Szépségápolás,
            Otthon_Hobbi
        }

        private Kategoria kateg;

        public Kategoria Kateg
        {
            get { return kateg; }
            private set
            {
                kateg = value;
            }
        }

        private int db;

        public int DB
        {
            get { return db; }
            private set
            {
                if (value < 0)
                    throw new Exception("A darabszám nem lehet kissebb mint 0-a.");
                if (value > 500)
                    throw new Exception("A termék nem lehet nagyobb mint 500.");
                db = value;
            }
        }

        public Termekek(string termekAzonosito, string nev, Kategoria kateg, int dB)
        {
            TermekAzonosito = termekAzonosito;
            Nev = nev;
            Kateg = kateg;
            DB = dB;
        }
    }
}
