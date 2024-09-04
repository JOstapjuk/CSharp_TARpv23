using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace C__TARpv23
{
    public class Functions
    {
        public static void Tere(string nimi)
        {
            Console.WriteLine("Tere kallis {0}", nimi);
        }

        public static int Liitmine(int arv1, int arv2)
        {
            return arv1 + arv2;
        }

        // Loo Arvuta() funktsioon mis sõltub 3 paraametrist: tehe, arv1,arv2 Kasuta if konstruktsioon
        public static int Arvuta(string funktsioon, int arv1, int arv2)
        {
            if (funktsioon == "+")
            {
                return arv1 + arv2;
            }
            else if (funktsioon == "-")
            {
                return arv1 - arv2;
            }
            else if (funktsioon == "*")
            {
                return arv1 * arv2;
            }
            else
            {
                return arv1 / arv2;
            }
        }

        public static string kõrguseKategooria(int pikkus, string sugu)
        {
            string kategooriaFun;
            if (sugu == "M")
            {
                if (pikkus <= 165) kategooriaFun = "lühike";
                else if (pikkus >= 170 && pikkus <= 185) kategooriaFun = "keskmeline";
                else kategooriaFun = "pikk";
            }
            else
            {
                if (pikkus <= 155) kategooriaFun = "lühike";
                else if (pikkus >= 160 && pikkus <= 175) kategooriaFun = "keskmeline";
                else kategooriaFun = "pikk";
            }
            return kategooriaFun;
        }


        // peeva number --> peeva nimetus
        public static string Paevad(int nr)
        {
            string paev;
            switch (nr)
            {
                case 1: paev = "Esmaspäev"; break;
                case 2: paev = "Teisipäev"; break;
                case 3: paev = "Kolmapäev"; break;
                case 4: paev = "Neljapäev"; break;
                case 5: paev = "Reede"; break;
                case 6: paev = "Laupäev"; break;
                case 7: paev = "Pühapäev"; break;
                default:
                    paev = "Ei saa määrata";
                    break;
            }
            return paev;
        }



        public static int[] Arved_Massiiv(int N, int M)
        {
            int arv;
            int[] arvud= new int[M-N];
            for (int i = 0; i < arvud.Length; i++)
            {
                arv = N;
                arvud[i] = arv;
                N++;
            }
            return arvud;
        }

        public static int Summa(int[] massiiv)
        {
            int sum = 0;
            foreach (int num in massiiv)
            {
                sum += num;
            }
            return sum;
        }

        public static double Keskmine(int[] massiiv)
        {
            int SummaKokku = Summa(massiiv);
            return (double)SummaKokku / massiiv.Length;
        }

        public static int Korrutis(int[] massiiv)
        {
            int result = 1;
            foreach (int num in massiiv)
            {
                result *= num;
            }
            return result;
        }

        //----------------------------------------Ülesanne 4------------------------------------
        // Otsib etteantud maakonnanime alusel pealinna
        // võttes andmeid sõnastikust "maakonnad"
        public static void OtsiPealinn(Dictionary<string, string> maakonnad)
        {
            Console.WriteLine("Sisestage maakonna nimi:");
            string maakond = Console.ReadLine();
            bool leitud = false;

            foreach (KeyValuePair<string, string> paar in maakonnad)
            {
                if (paar.Value.ToLower() == maakond.ToLower())
                {
                    Console.WriteLine($"Maakonna '{maakond}' pealinn on {paar.Key}.");
                    leitud = true;
                    break;
                }
            }
            if (!leitud)
            {
                Console.WriteLine($"Maakonda '{maakond}' ei leitud.");
            }
        }

        //Otsib etteantud pealinna nime alusel maakonda
        public static void OtsiMaakond(Dictionary<string, string> maakonnad)
        {
            Console.WriteLine("Sisestage pealinna nimi:");
            string pealinn = Console.ReadLine();
            if (maakonnad.ContainsKey(pealinn))
            {
                Console.WriteLine($"Pealinna '{pealinn}' maakond on {maakonnad[pealinn]}.");
            }
            else
            {
                Console.WriteLine($"Pealinna '{pealinn}' ei leitud.");
            }
        }

        //Lisab sõnastikku uue maakonna ja pealinna, ka kontrollida, kui pealinn on juba sõnastikus
        public static void LisaUusMaakond(Dictionary<string, string> maakonnad)
        {
            Console.WriteLine("Sisestage uus maakonna nimi:");
            string uusMaakond = Console.ReadLine();
            Console.WriteLine("Sisestage uus pealinna nimi:");
            string uusPealinn = Console.ReadLine();

            if (maakonnad.ContainsKey(uusPealinn))
            {
                Console.WriteLine("See pealinn on juba olemas. Proovige uuesti.");
            }
            else
            {
                maakonnad.Add(uusPealinn, uusMaakond);
                Console.WriteLine($"Maakond '{uusMaakond}' ja pealinn '{uusPealinn}' lisati edukalt.");
            }
        }

        // Katsetab kasutaja teadmisi, esitades küsimusi maakondade ja pealinnade kohta.
        public static void TestiTeadmisi(Dictionary<string, string> maakonnad)
        {
            int õiged = 0;
            int valed = 0;
            Random random = new Random();

            List<string> pealinnad = new List<string>(maakonnad.Keys);

            for (int i = 0; i < 5; i++)
            {
                string juhuslikPealinn = pealinnad[random.Next(pealinnad.Count)];
                Console.WriteLine($"Milline on maakond pealinnale '{juhuslikPealinn}'?");
                string vastus = Console.ReadLine();

                if (vastus.ToLower() == maakonnad[juhuslikPealinn].ToLower())
                {
                    Console.WriteLine("Õige!");
                    õiged++;
                }
                else
                {
                    Console.WriteLine($"Vale! Õige vastus on {maakonnad[juhuslikPealinn]}.");
                    valed++;
                }
            }

            double tulemus = ((double)õiged / (õiged + valed)) * 100;
            Console.WriteLine($"\nTeie tulemus on: {tulemus}% (Õiged: {õiged}, Valed: {valed})");
        }

        //Kuvab kõik maakonnad ja nende pealinnad.
        public static void KuvaMaakonnadJaPealinnad(Dictionary<string, string> maakonnad)
        {
            Console.WriteLine("\nKõik maakonnad ja pealinnad:");
            foreach (KeyValuePair<string, string> paar in maakonnad)
            {
                Console.WriteLine($"Pealinn: {paar.Key}   Maakond: {paar.Value}");
            }
        }

        //------------------------------------------Ülesanne 5--------------------------------------------

        //Otsib inimest(tema nime) e-posti järgi
        public static void OtsiEmail(Dictionary<string, string> inimised)
        {
            Console.WriteLine("Sisestage e-posti aadress:");
            string email = Console.ReadLine();

            bool leitud = false;
            foreach (KeyValuePair<string, string> paar in inimised)
            {
                if (paar.Value == email)
                {
                    Console.WriteLine($"E-posti aadress '{email}' kuulub {paar.Key}");
                    leitud = true;
                    break;
                }
            }

            if (!leitud)
            {
                Console.WriteLine($"E-posti aadressi '{email}' ei leitud");
            }
        }

        //Lisab sõnastikku uue kasutaja, kontrollides olemasolevaid kasutajanimesid ja e-posti aadresse.
        public static void LisaKasutaja(Dictionary<string, string> inimised)
        {
            Console.WriteLine("Sisestage uus kasutaja nimi:");
            string nimi = Console.ReadLine();
            Console.WriteLine("Sisestage uus e-posti aadress:");
            string email = Console.ReadLine();

            if (inimised.ContainsKey(nimi))
            {
                Console.WriteLine("See nimi on juba olemas.");
            }
            else if (inimised.ContainsValue(email))
            {
                Console.WriteLine("See e-posti aadress on juba olemas.");
            }
            else
            {
                inimised.Add(nimi, email);
                Console.WriteLine($"Kasutaja '{nimi}' lisati edukalt.");
            }
        }

        //Uuendab olemasoleva kasutaja e-posti aadressi.
        public static void UuendaKasutaja(Dictionary<string, string> inimised)
        {
            Console.WriteLine("Sisestage kasutaja nimi, keda soovite uuendada:");
            string nimi = Console.ReadLine();

            if (inimised.ContainsKey(nimi))
            {
                Console.WriteLine("Sisestage uus e-posti aadress:");
                string newEmail = Console.ReadLine();
                inimised[nimi] = newEmail;
                Console.WriteLine($"Kasutaja '{nimi}' e-posti aadress uuendati edukalt.");
            }
            else
            {
                Console.WriteLine($"Kasutajat '{nimi}' ei leitud.");
            }
        }

        // Kustutab kasutaja sõnastikust "Inimised" kasutajanime põhjal.
        public static void KustutaKasutaja(Dictionary<string, string> inimised)
        {
            Console.WriteLine("Sisestage kasutaja nimi, keda soovite kustutada:");
            string nimi = Console.ReadLine();

            if (inimised.ContainsKey(nimi))
            {
                inimised.Remove(nimi);
                Console.WriteLine($"Kasutaja '{nimi}' kustutati edukalt.");
            }
            else
            {
                Console.WriteLine($"Kasutajat '{nimi}' ei leitud.");
            }
        }

        // Loetleb kõiki kasutajaid ja nende e-posti aadresse.
        public static void LoetleKasutajad(Dictionary<string, string> inimised)
        {
            Console.WriteLine("\nKõik kasutajad:");
            foreach (KeyValuePair<string, string> pair in inimised)
            {
                Console.WriteLine($"{pair.Key}: {pair.Value}");
            }
        }


    }
}
 
