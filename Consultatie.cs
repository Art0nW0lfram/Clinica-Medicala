using System;

namespace ClinicaMedicala
{
    public class Consultatie
    {
        public Pacient Pacient { get; set; }
        public Medic Medic { get; set; }
        public DateTime Data { get; set; }

        public Consultatie(Pacient pacient, Medic medic, DateTime data)
        {
            Pacient = pacient;
            Medic = medic;
            Data = data;
        }

        public void AfiseazaDetalii()
        {
            Console.WriteLine($"Consultație: {Pacient.Nume} cu {Medic.Nume}");
            Console.WriteLine($"Data: {Data.ToString("dd/MM/yyyy HH:mm")}");
        }
    }
}