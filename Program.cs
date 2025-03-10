using System;

namespace ClinicaMedicala
{
    class Program
    {
        static void Main(string[] args)
        {
            // Vectori de obiecte
            Pacient[] pacienti = new Pacient[100];
            Consultatie[] consultatii = new Consultatie[100];
            int numarPacienti = 0;
            int numarConsultatii = 0;

            // Un medic predefinit pentru simplitate
            Medic medic = new Medic("Dr. Andrei Ionescu", 45, "0722-123-456", "Cardiologie");

            while (true)
            {
                Console.WriteLine("\nMeniu:");
                Console.WriteLine("1. Adaugă pacient (citire de la tastatură)");
                Console.WriteLine("2. Adaugă consultatie (citire de la tastatură)");
                Console.WriteLine("3. Afisează toti pacientii");
                Console.WriteLine("4. Afisează toate consultatiile");
                Console.WriteLine("5. Caută pacient după nume");
                Console.WriteLine("6. Iesire");

                Console.Write("Alege o opțiune: ");
                string optiune = Console.ReadLine();

                switch (optiune)
                {
                    case "1":
                        // Citire pacient de la tastatură și salvare în vector
                        Console.Write("Introdu ID-ul pacientului: ");
                        int id = int.Parse(Console.ReadLine());

                        Console.Write("Introdu numele pacientului: ");
                        string nume = Console.ReadLine();

                        Console.Write("Introdu vârsta pacientului: ");
                        int varsta = int.Parse(Console.ReadLine());

                        Console.Write("Introdu telefonul pacientului: ");
                        string telefon = Console.ReadLine();

                        pacienti[numarPacienti] = new Pacient(id, nume, varsta, telefon);
                        numarPacienti++;
                        Console.WriteLine("Pacient adăugat cu succes!");
                        break;

                    case "2":
                        // Citire consultație de la tastatură și salvare în vector
                        Console.Write("Introdu ID-ul pacientului pentru consultație: ");
                        int idPacient = int.Parse(Console.ReadLine());

                        // Căutare pacient în vector
                        Pacient pacientGasit = null;
                        for (int i = 0; i < numarPacienti; i++)
                        {
                            if (pacienti[i].Id == idPacient)
                            {
                                pacientGasit = pacienti[i];
                                break;
                            }
                        }

                        if (pacientGasit != null)
                        {
                            Console.Write("Introdu data consultației (dd/MM/yyyy HH:mm): ");
                            DateTime data = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", null);
                            consultatii[numarConsultatii] = new Consultatie(pacientGasit, medic, data);
                            numarConsultatii++;
                            Console.WriteLine("Consultație adăugată cu succes!");
                        }
                        else
                        {
                            Console.WriteLine("Pacientul cu ID-ul specificat nu a fost găsit.");
                        }
                        break;

                    case "3":
                        // Afișare vector pacienți
                        if (numarPacienti == 0)
                        {
                            Console.WriteLine("Nu există pacienți în vector.");
                        }
                        else
                        {
                            Console.WriteLine("Lista pacienților:");
                            for (int i = 0; i < numarPacienti; i++)
                            {
                                pacienti[i].AfiseazaInformatii();
                                Console.WriteLine("-------------------");
                            }
                        }
                        break;

                    case "4":
                        // Afișare vector consultații
                        if (numarConsultatii == 0)
                        {
                            Console.WriteLine("Nu există consultații în vector.");
                        }
                        else
                        {
                            Console.WriteLine("Lista consultațiilor:");
                            for (int i = 0; i < numarConsultatii; i++)
                            {
                                consultatii[i].AfiseazaDetalii();
                                Console.WriteLine("-------------------");
                            }
                        }
                        break;

                    case "5":
                        // Căutare pacient după nume
                        Console.Write("Introdu numele pacientului de căutat: ");
                        string numeCautat = Console.ReadLine();

                        bool gasit = false;
                        for (int i = 0; i < numarPacienti; i++)
                        {
                            if (pacienti[i].Nume.Equals(numeCautat, StringComparison.OrdinalIgnoreCase))
                            {
                                Console.WriteLine("Pacient găsit:");
                                pacienti[i].AfiseazaInformatii();
                                gasit = true;
                                break;
                            }
                        }
                        if (!gasit)
                        {
                            Console.WriteLine("Pacientul nu a fost găsit.");
                        }
                        break;

                    case "6":
                        Console.WriteLine("La revedere!");
                        return;

                    default:
                        Console.WriteLine("Opțiune invalidă. Încearcă din nou.");
                        break;
                }
            }
        }
    }
}