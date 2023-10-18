using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lucrarea_1
{
    internal class Contact
    {

            public string Nume { get; }
            public string Prenume { get; }
            public string NrTelefon { get; }
            public string Adresa { get; }

            public Contact(string nume, string prenume, string nrTelefon, string adresa)
            {
                Nume = nume;
                Prenume = prenume;
                NrTelefon = nrTelefon;
                Adresa = adresa;
            }
        }

    
}
