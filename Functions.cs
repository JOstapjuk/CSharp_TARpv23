using System;
using System.Collections.Generic;
using System.Linq;
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
        public static int Arvuta(string funktsioon ,int arv1, int arv2)
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
        public static double StringToDouble()
    }
}
