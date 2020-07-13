using System.Diagnostics;

namespace MiniParduotuve2
{
    interface IPreke
    {
        int Id { get; }

        string Pavadinimas { get; set; }
        double Kaina { get; set; }
        bool Prieinama { get; set; }

        char Dydis { get; set; }

    }

    public class Preke : IPreke
    {
        public int Id { get; set; }

        public string Pavadinimas { get; set; }
        public double Kaina { get; set; }
        public bool Prieinama { get; set; }
        public char Dydis { get; set; }

        public Preke(int id, string pavadinimas, double kaina, bool prieinama, char dydis)
        {
            Id = id;
            Pavadinimas = pavadinimas;
            Kaina = kaina;
            Prieinama = prieinama;
            Dydis = dydis;



        }
    }
}
