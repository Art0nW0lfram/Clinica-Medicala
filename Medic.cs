using System;

namespace ClinicaMedicala
{
    public class Medic : Persoana
    {
        public string Specializare { get; set; }

        public Medic(string nume, int varsta, string telefon, string specializare)
            : base(nume, varsta, telefon)
        {
            Specializare = specializare;
        }

        public override void AfiseazaInformatii()
        {
            base.AfiseazaInformatii();
            Console.WriteLine($"Specializare: {Specializare}");
        }
    }
}