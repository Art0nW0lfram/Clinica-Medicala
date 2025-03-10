using System;

namespace ClinicaMedicala
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creăm un medic
            Medic medic1 = new Medic("Dr. Andrei Ionescu", 45, "0722-123-456", "Cardiologie");

            // Creăm un pacient
            Pacient pacient1 = new Pacient(1, "Maria Popescu", 35, "0733-789-012");

            // Creăm o consultație
            Consultatie consultatie1 = new Consultatie(pacient1, medic1, new DateTime(2025, 3, 15, 10, 0, 0));

            // Afișăm informațiile
            Console.WriteLine("Informatii medic:");
            medic1.AfiseazaInformatii();

            Console.WriteLine("\nInformatii pacient:");
            pacient1.AfiseazaInformatii();

            Console.WriteLine("\nDetalii consultatie:");
            consultatie1.AfiseazaDetalii();

            Console.WriteLine("\nApasă Enter pentru a închide...");
            Console.ReadLine();
        }
    }
}