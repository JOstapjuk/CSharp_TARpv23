using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TARpv23_CSharp
{
    public enum Sugu
    {
        mees,
        naine
    }
    internal class Inimene
    {
        public string Nimi { get; set; }
        public int Vanus { get; set; }
        public Sugu Sugu { get; set; }
        public int Pikkus { get; set; }
        public double Kaal { get; set; }
        public double Aktiivsus { get; set; }
        public Inimene() { }
        public Inimene(string nimi)
        {
            Nimi = nimi;
        }
        public Inimene(string nimi, int vanus = 2)
        {
            Nimi = nimi;
            Vanus = vanus;
        }
        public Inimene(string nimi, int vanus, Sugu sugu)
        {
            Nimi = nimi;
            Vanus = vanus;
            Sugu = sugu;
        }
        public Inimene(int vanus, Sugu sugu, int pikkus, double kaal, double aktiivsus)
        {
            Vanus = vanus;
            Sugu = sugu;
            Pikkus = pikkus;
            Kaal = kaal;
            Aktiivsus = aktiivsus;
        }

        public double HB_vorrand()
        {
            double SBI = 0;
            if (Sugu == Sugu.mees)
            {
                SBI = 66 + (13.7 * Kaal) + (5 * Pikkus) - (6.8 * Vanus);
            }
            else
            {
                SBI = 655 + (9.6 * Kaal) + (1.8 * Pikkus) - (4.7 * Vanus);
            }
            return SBI * Aktiivsus;
        }
    }
}
