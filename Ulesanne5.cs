using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__TARpv23
{
    internal class Ulesanne5
    {
        // kahe sõnaraamatu tegemine kasutajatele ja inimestele kes on "andmebaasis"
        public static Dictionary<string, (string parool, string rolli)> kasutajas = new Dictionary<string, (string parool, string rolli)>
        {
            { "admin", ("admin", "admin") },
            { "kasutaja", ("kasutaja", "kasutaja") }
        };

        public static Dictionary<string, string> inimised = new Dictionary<string, string>
        {
            { "Kasutaja", "kasutaja@gmail.com" },
            { "Admin", "admin@gmail.com" },
            { "Anna", "anna@gmail.com" },
            { "Jaan", "jaan@gmail.com" },
            { "Mari", "mari@gmail.com" }
        };

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            // Kasutajanime ja parooli küsimine
            Console.Write("Kasutajanimi: ");
            string kasutajaNimi = Console.ReadLine();
            Console.Write("Parool: ");
            string parool = Console.ReadLine();

            // kontrollides, kas see kasutaja on sõnastikus "Kasutajas", kui jah siis läheb valima, millist võimalust valida
            if (kasutajas.ContainsKey(kasutajaNimi) && kasutajas[kasutajaNimi].parool == parool)
            {
                string rolli = kasutajas[kasutajaNimi].rolli;
                Console.WriteLine($"Tere tulemast {kasutajaNimi}");

                while (true)
                {
                    Console.WriteLine("\nValige toiming:");
                    Console.WriteLine("1) Otsi e-posti aadressi järgi");
                    if (rolli == "admin")
                    {
                        Console.WriteLine("2) Lisa uus kasutaja");
                        Console.WriteLine("3) Uuenda olemasolevat kasutajat");
                        Console.WriteLine("4) Kustuta kasutaja");
                    }
                    Console.WriteLine("5) Loetle kõik kasutajad");
                    Console.WriteLine("6) Välju");

                    string valik = Console.ReadLine();

                    //Kui kasutaja ei ole admin siis on tal vähem võimalusi
                    switch (valik)
                    {
                        case "1":
                            Functions.OtsiEmail(inimised);
                            break;
                        case "2":
                            if (rolli == "admin")
                            {
                                Functions.LisaKasutaja(inimised);
                            }
                            else
                            {
                                Console.WriteLine("Ligipääs on suletud nendele funktsioonidele");
                            }
                            break;
                        case "3":
                            if (rolli == "admin")
                            {
                                Functions.UuendaKasutaja(inimised);
                            }
                            else
                            {
                                Console.WriteLine("Ligipääs on suletud nendele funktsioonidele");
                            }
                            break;
                        case "4":
                            if (rolli == "admin")
                            {
                                Functions.KustutaKasutaja(inimised);
                            }
                            else
                            {
                                Console.WriteLine("Ligipääs on suletud nendele funktsioonidele");
                            }
                            break;
                        case "5":
                            Functions.LoetleKasutajad(inimised);
                            break;
                        case "6":
                            Console.WriteLine("Lõpetamine");
                            return;
                        default:
                            Console.WriteLine("Vigane valik, palun proovige uuesti");
                            break;
                    }
                }
            }
            else
            {
                Console.WriteLine("Vale kasutajanimi või parool");
            }
        }
    }
}