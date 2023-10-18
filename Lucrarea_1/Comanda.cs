using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lucrarea_1
{
    internal class Comanda
    { 
            public Contact Contact { get; }
            public List<Produs> ListaProduse { get; }

            public Comanda(Contact contact, List<Produs> listaProduse)
            {
                Contact = contact;
                ListaProduse = listaProduse;
            }
        }

    }

