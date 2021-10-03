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

     

       
    }
}
