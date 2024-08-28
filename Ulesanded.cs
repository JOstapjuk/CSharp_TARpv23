using System.Text;

namespace C__TARpv23
{
    internal class Ulesanded
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            //// Küsi ristkülikukujulise toa seinte pikkused ning arvuta põranda pindala. Küsi kasutajalt remondi tegemise soov, kui ta on positiivne, siis küsi kui palju maksab ruutmeeter ja leia põranda vahetamise hind

            Console.Write("Sisesta toa laiuse (m): ");
            double laius = Convert.ToDouble(Console.ReadLine()); // ToDouble() - Muudab stringi väärtuse topelttäpseks ujuvpunkti numbriks.

            Console.Write("Sisesta toa kõrguse (m): ");
            double kõrgus = Convert.ToDouble(Console.ReadLine());

            double Pindala = laius * kõrgus;

            Console.WriteLine($"Põranda pindala: {Pindala} m²");

            Console.Write("Palun sisestage põranda vahetamise hind ühe ruutmeetri kohta (€): ");
            double Hind = Convert.ToDouble(Console.ReadLine());

            double kogumaksumus = Pindala * Hind;

            Console.WriteLine($"Põranda vahetus maksab: {kogumaksumus} eurot."); // $ - võimaldab meil sisestada muutujaid stringi literaalsesse ( {} )

            ////------------------------------------------------------------

            ////Leia 30% hinnasoodustusega hinna põhjal alghind

            Console.Write("Sisesta hind 30% soodustusega: ");
            double hindSoodusega = Convert.ToDouble(Console.ReadLine());

            double alghind = hindSoodusega / 0.7;

            Console.WriteLine($"Alghind oli: {alghind:F2}"); //F2 - (Fixed-point) Ümbritseb arvu sajanditeni

            //------------------------------------------------------------

            // Küsi inimeselt pikkus ja sugu ning teata, kas ta on lühike, keskmine või pikk (mitu tingimusplokki võib olla üksteise sees).

            double pikkus;
            do
            {
                Console.Write("Palun sisestage teie pikkus cm-s: ");
                if (double.TryParse(Console.ReadLine(), out pikkus)) // TryParse(... out) - Üritab stringimuutujat double'is üle kanda, out
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Vale sisend. Palun sisestage numbrid.");
                }
            } while (true); 


            string sugu;
            do
            {
                Console.Write("Palun valige oma sugu (M/Mees, N/Naine): ");
                sugu = Console.ReadLine().ToUpper(); // ToUpper - muudab sisestatud tähe suurtäheks
            } while (sugu != "M" && sugu != "N"); // kordab tsüklit kuni kasutaja kirjutab M või N

            string kategooria = Functions.kõrguseKategooria(pikkus, sugu);

            Console.WriteLine($"Te olete {kategooria} pikkus.");

            //------------------------------------------------------------
            // Kauplus

            bool piim = false;
            bool sai = false;
            bool leib = false;

            Console.WriteLine("Tere tulemast poodi");

            while (true)
            {
                Console.Write("Soovite osta piima? (j/e): ");
                string piimVastus = Console.ReadLine().ToLower();

                if (piimVastus == "j")
                {
                    piim = true;
                    break;
                }
                else if (piimVastus == "e")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Palun vastake jah või ei.");
                }
            }

            while (true)
            {
                Console.Write("Soovite osta saia? (j/e): ");
                string saiVastus = Console.ReadLine().ToLower();

                if (saiVastus == "j")
                {
                    sai = true;
                    break;
                }
                else if (saiVastus == "e")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Palun vastake jah või ei.");
                }
            }

            while (true)
            {
                Console.Write("Soovite osta leiba? (j/e): ");
                string leibVastus = Console.ReadLine().ToLower();

                if (leibVastus == "j")
                {
                    leib = true;
                    break;
                }
                else if (leibVastus == "e")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Palun vastake jah või ei.");
                }
            }
            double kogumaksumusKaup = 0;

            if (piim == true)
            {
                kogumaksumusKaup += 0.90; 
            }
            if (sai == true)
            {
                kogumaksumusKaup += 1.60; 
            }
            if (leib == true)
            {
                kogumaksumusKaup += 1.50; 
            }

            Console.WriteLine($"Kaupade maksumus saab olema:: {kogumaksumusKaup:F2} eurot");

            //------------------------------------------------------------

            // Küsi temperatuur ning teata, kas see on üle kaheksateistkümne kraadi (soovitav toasoojus talvel).
            Console.Write("Palun sisestage soojusseisund: ");
            string temperatuurSisu = Console.ReadLine();

            int temperatuur;
            bool onEdukasSisestus = int.TryParse(temperatuurSisu, out temperatuur);

            if (onEdukasSisestus && temperatuur > 18)
            {
                Console.WriteLine($"Teie sisestatud temperatuur on {temperatuur} kraadi. See on üle kaheksateistkümne kraadi.");
            }
            else
            {
                Console.WriteLine("Teie sisestatud temperatuur ei ole üle kaheksateistkümne kraadi.");
            }

        }
    }
}