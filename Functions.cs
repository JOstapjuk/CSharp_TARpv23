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

    }
}
 
