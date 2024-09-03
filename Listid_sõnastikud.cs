using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TARpv23_CSharp;

namespace C__TARpv23
{
    internal class Listid_sõnastikud
    {

        public static Dictionary<string, string> maakonnad = new Dictionary<string, string>
        {
            { "Tartu", "Tartu maakond" },
            { "Tallinn", "Harju maakond" },
            { "Pärnu", "Pärnu maakond" },
            { "Rakvere", "Lääne-Viru maakond" },
            { "Haapsalu", "Lääne maakond" }
        };

        public static void Main(string[] args)
        {

            Random random = new Random();
            Console.OutputEncoding = Encoding.UTF8;

            //Ülesanne 3
            List<Toode> tooted = new List<Toode>
            {
                new Toode("Õun", 52),
                new Toode("Banaan", 96),
                new Toode("Kanafilee", 165),
                new Toode("Riis", 130),
                new Toode("Brokkoli", 34)
            };


            int vanus;
            while (true)
            {
                Console.WriteLine("Sisestage oma vanus:");
                try
                {
                    vanus = int.Parse(Console.ReadLine());
                    if (vanus <= 0)
                    {
                        Console.WriteLine("Vanus peab olema positiivne arv. Palun proovige uuesti.");
                        continue;
                    }
                    break;
                }
                catch (Exception)
                {
                    Console.WriteLine($"Vigane sisend. Palun proovige uuesti.");
                }
            }

            Sugu sugu;
            while (true)
            {
                Console.WriteLine("Sisestage oma sugu (mees/naine):");
                string suguSisend = Console.ReadLine().ToLower();
                if (suguSisend == "mees")
                {
                    sugu = Sugu.mees;
                    break;
                }
                else if (suguSisend == "naine")
                {
                    sugu = Sugu.naine;
                    break;
                }
                else
                {
                    Console.WriteLine("Palun sisestage kehtiv sugu ('mees' või 'naine').");
                }
            }

            int pikkus;
            while (true)
            {
                Console.WriteLine("Sisestage oma pikkus (cm):");
                try
                {
                    pikkus = int.Parse(Console.ReadLine());
                    if (pikkus <= 0)
                    {
                        Console.WriteLine("Pikkus peab olema positiivne arv. Palun proovige uuesti.");
                        continue;
                    }
                    break;
                }
                catch
                {
                    Console.WriteLine($"Vigane sisend. Palun proovige uuesti.");
                }
            }

            double kaal;
            while (true)
            {
                Console.WriteLine("Sisestage oma kaal (kg):");
                try
                {
                    kaal = double.Parse(Console.ReadLine());
                    if (kaal <= 0)
                    {
                        Console.WriteLine("Kaal peab olema positiivne arv. Palun proovige uuesti.");
                        continue;
                    }
                    break;
                }
                catch
                {
                    Console.WriteLine($"Vigane sisend. Palun proovige uuesti.");
                }
            }

            double aktiivsus = 1.2;
            while (true)
            {
                Console.WriteLine("Sisestage oma aktiivsustase:");
                Console.WriteLine("1. Istuv eluviis");
                Console.WriteLine("2. Vähene aktiivsus");
                Console.WriteLine("3. Mõõdukas aktiivsus");
                Console.WriteLine("4. Kõrge aktiivsus");
                Console.WriteLine("5. Väga kõrge aktiivsus");
                try
                {
                    int aktiivsusValik = int.Parse(Console.ReadLine());
                    switch (aktiivsusValik)
                    {
                        case 1:
                            aktiivsus = 1.2;
                            break;
                        case 2:
                            aktiivsus = 1.375;
                            break;
                        case 3:
                            aktiivsus = 1.55;
                            break;
                        case 4:
                            aktiivsus = 1.725;
                            break;
                        case 5:
                            aktiivsus = 1.9;
                            break;
                        default:
                            Console.WriteLine("Valige palun number vahemikus 1 kuni 5.");
                            continue;
                    }
                    break;
                }
                catch
                {
                    Console.WriteLine($"Vigane sisend. Palun proovige uuesti.");
                }
            }


            Inimene inimene = new Inimene(vanus, sugu, pikkus, kaal, aktiivsus);


            double paevaneKalorivajadus = inimene.HB_vorrand();
            Console.WriteLine($"Teie päevane kalorivajadus on: {paevaneKalorivajadus} kcal");


            Console.WriteLine("Tooted, mida saate süüa:");
            foreach (var toode in tooted)
            {
                double maxToidukogus = paevaneKalorivajadus / toode.Kalorid * 100;
                Console.WriteLine($"{toode.ToodeNimetus}: kuni {maxToidukogus:F1} grammi päevas");
            }


            //Ülesanne 4

            while (true)
            {
                Console.WriteLine("\nValige toiming:");
                Console.WriteLine("1) Otsige pealinn maakonna järgi");
                Console.WriteLine("2) Otsige maakond pealinna järgi");
                Console.WriteLine("3) Lisage uus maakond ja pealinn");
                Console.WriteLine("4) Testige oma teadmisi");
                Console.WriteLine("5) Kuvage kõik maakonnad ja pealinnad");
                Console.WriteLine("6) Väljuge");

                string valik = Console.ReadLine();

                switch (valik)
                {
                    case "1":
                        Functions.OtsiPealinn();
                        break;
                    case "2":
                        Functions.OtsiMaakond();
                        break;
                    case "3":
                        Functions.LisaUusMaakond();
                        break;
                    case "4":
                        Functions.TestiTeadmisi();
                        break;
                    case "5":
                        Functions.KuvaMaakonnadJaPealinnad();
                        break;
                    case "6":
                        Console.WriteLine("Programmi lõpetamine.");
                        return;
                    default:
                        Console.WriteLine("Vigane valik, palun proovige uuesti.");
                        break;
                }

            }

        }
    }
}
