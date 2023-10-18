using Lucrarea_1;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Introduceti informatii pentru comanda:");

        Console.Write("Nume: ");
        string nume = Console.ReadLine();

        Console.Write("Prenume: ");
        string prenume = Console.ReadLine();

        Console.Write("Nr. Telefon: ");
        string nrTelefon = Console.ReadLine();

        Console.Write("Adresa: ");
        string adresa = Console.ReadLine();

        Contact contact = new Contact(nume, prenume, nrTelefon, adresa);

        List<Produs> listaProduse = new List<Produs>();

        while (true)
        {
            Console.Write("Introduceti codul produsului (sau 'exit' pentru a finaliza): ");
            string codProdus = Console.ReadLine();

            if (codProdus.ToLower() == "exit")
            {
                break;
            }

            Console.Write("Cantitate: ");
            double cantitate = double.Parse(Console.ReadLine());

            Console.Write("Unitate de masura (unitati sau kg): ");
            string unitateDeMasura = Console.ReadLine();

            Produs produs = new Produs(codProdus, cantitate, unitateDeMasura);
            listaProduse.Add(produs);
        }

        Comanda comanda = new Comanda(contact, listaProduse);

        Console.WriteLine("Comanda creată cu succes:");
        Console.WriteLine("Contact: " + comanda.Contact.Nume + " " + comanda.Contact.Prenume);
        Console.WriteLine("Nr. Telefon: " + comanda.Contact.NrTelefon);
        Console.WriteLine("Adresa: " + comanda.Contact.Adresa);
        Console.WriteLine("Produse:");

        foreach (var produs in comanda.ListaProduse)
        {
            Console.WriteLine("Cod Produs: " + produs.CodProdus);
            Console.WriteLine("Cantitate: " + produs.Cantitate + " " + produs.Cantitate);
        }
    }
}