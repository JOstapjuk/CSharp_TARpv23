using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__TARpv23
{
    internal class Massiivid_Kordus
    {

        public static void Main(string[] args)
        {
            Random random = new Random();
            Console.OutputEncoding = Encoding.UTF8;
            // 1* Loo  juhuslikult arvud N ja M ja sisesta massiivi arvud N'st M'ni. Trüki arvude ruudud ekraanile. N ja M arvud on vahemikus (-100,100).

            int N = random.Next(-100, 101);
            int M = random.Next(-100, 101);

            Console.WriteLine($"N: {N}, M: {M}");

            int[] arvud;
            if (N < M)
            {
                arvud = Functions.Arved_Massiiv(N, M);
            }
            else
            {
                arvud = Functions.Arved_Massiiv(M, N);
            }

            foreach (int arv in arvud)
            {
                Console.WriteLine(arv*arv);
            }

            // 2* Küsi kasutajalt viis arvu, salvesta neid massiivi ning väljasta nende summa, aritmeetiline keskmine ja korrutis.


        }
    }
}
