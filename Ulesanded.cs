using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__TARpv23
{
    internal class Ulesanded
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            // Küsi ristkülikukujulise toa seinte pikkused ning arvuta põranda pindala. Küsi kasutajalt remondi tegemise soov, kui ta on positiivne, siis küsi kui palju maksab ruutmeeter ja leia põranda vahetamise hind
            Console.Write("Sisesta toa laiuse (m): ");
            double laius = Convert.ToDouble(Console.ReadLine());

            Console.Write("Sisesta toa kõrguse (m): ");
            double kõrgus = Convert.ToDouble(Console.ReadLine());

            double Pindala = laius * kõrgus;

            Console.WriteLine($"Põranda pindala: {Pindala} m²");

            Console.Write("Palun sisestage põranda vahetamise hind ühe ruutmeetri kohta (€): ");
            double Hind = Convert.ToDouble(Console.ReadLine());

            double kogumaksumus = Pindala * Hind;

            Console.WriteLine($"Põranda vahetus maksab: {kogumaksumus} eurot.");

            //------------------------------------------------------------

            //Leia 30% hinnasoodustusega hinna põhjal alghind



        }
    }
}
