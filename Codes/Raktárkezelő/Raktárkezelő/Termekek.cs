using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
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


    }
}
