using System;

namespace ClinicaMedicala
{
    public class Pacient : Persoana
    {
        public int Id { get; set; }

        public Pacient(int id, string nume, int varsta, string telefon)
            : base(nume, varsta, telefon)
        {
            Id = id;
        }

        public override void AfiseazaInformatii()
        {
            Console.WriteLine($"ID: {Id}");
            base.AfiseazaInformatii();
        }
    }
}