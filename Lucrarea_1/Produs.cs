using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lucrarea_1
{

    public class CantitateProdus
    {
        public double Cantitate { get; }
        public string UnitateDeMasura { get; }

        public CantitateProdus(double cantitate, string unitateDeMasura)
        {
            Cantitate = cantitate;
            UnitateDeMasura = unitateDeMasura;
        }
        //public string GetUnitateDeMasura()
        //{
        //    return UnitateDeMasura;
       // }
    }
    internal class Produs
    {
        public string CodProdus { get; set; }
        public CantitateProdus Cantitate { get; }


        public Produs(string codProdus, double cantitate, string unitateDeMasura)
        {
            if (!IsValidCodProdus(codProdus))
            {
                Console.WriteLine("Codul de produs trebuie să conțină doar cifre și să aibă o lungime de maximum 5 caractere. Vă rugăm să îl reintroduceți.");
                ReintroducereCodProdus();
            }

            CodProdus = codProdus;
            Cantitate = new CantitateProdus(cantitate, unitateDeMasura);
        }
        /*
        public string getUnitateDeMasura()
        {
            return unitateDeMasura;
        }
        */
        private bool IsValidCodProdus(string codProdus)
        {
            return !string.IsNullOrEmpty(codProdus) && codProdus.Length <= 5 && codProdus.All(char.IsDigit);
        }

        private void ReintroducereCodProdus()
        {
            do
            {
                Console.Write("Introduceți noul cod de produs (maximum 5 cifre): ");
                string codProdus = Console.ReadLine();

                if (IsValidCodProdus(codProdus))
                {
                    CodProdus = codProdus;
                    break;
                }
                else
                {
                    Console.WriteLine("Codul de produs trebuie să conțină doar cifre și să aibă o lungime de maximum 5 caractere. Vă rugăm să îl reintroduceți.");
                }
            } while (true);
        }
    }
}