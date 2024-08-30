using System;
using System.Collections;
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
            //1 * Loo  juhuslikult arvud N ja M ja sisesta massiivi arvud N'st M'ni.Trüki arvude ruudud ekraanile. N ja M arvud on vahemikus(-100,100).

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
                Console.WriteLine(arv * arv);
            }

            //// 2* Küsi kasutajalt viis arvu, salvesta neid massiivi ning väljasta nende summa, aritmeetiline keskmine ja korrutis.

            Console.WriteLine("Sisesta 5 numbrid: ");
            int[] numbers = new int[5];

            for (int i = 0; i < 5; i++)
            {
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }

            int summa = Functions.Summa(numbers);
            double keskmine = Functions.Keskmine(numbers);
            int korrutis = Functions.Korrutis(numbers);

            Console.WriteLine($"Summa: {summa}");
            Console.WriteLine($"Aritmeetiline keskmine: {keskmine:F2}");
            Console.WriteLine($"Korrutis: {korrutis}");

            //// Küsi viielt kasutajalt nimed ja vanused, salvesta nende andmeid massiivi ning väljasta summaarne vanus, aritmeetiline keskmine, vaanema ja noorema inimeste nimed ja vanused.

            string[] nimed = new string[5];
            int[] vanused = new int[5];


            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Sisesta kasutaja nimi: ");
                nimed[i] = Console.ReadLine();

                Console.Write($"Sisesta kasutaja vanus: ");
                vanused[i] = int.Parse(Console.ReadLine());
            }

            int summaarneVanus = Functions.Summa(vanused);

            double keskmineVanus = Functions.Keskmine(vanused);

            int vanimVanus = vanused[0];
            int noorimVanus = vanused[0];
            string vanimNimi = nimed[0];
            string noorimNimi = nimed[0];

            for (int i = 1; i < vanused.Length; i++)
            {
                if (vanused[i] > vanimVanus)
                {
                    vanimVanus = vanused[i];
                    vanimNimi = nimed[i];
                }
                if (vanused[i] < noorimVanus)
                {
                    noorimVanus = vanused[i];
                    noorimNimi = nimed[i];
                }
            }


            Console.WriteLine($"Summaarne vanus: {summaarneVanus}");
            Console.WriteLine($"Aritmeetiline keskmine vanus: {keskmineVanus:F2}");
            Console.WriteLine($"Vanim kasutaja: {vanimNimi}, vanus: {vanimVanus}");
            Console.WriteLine($"Noorim kasutaja: {noorimNimi}, vanus: {noorimVanus}");

            //// Ütle kasutajale "Osta elevant ära!". Senikaua korda küsimust, kuni kasutaja lõpuks ise kirjutab "elevant".

            string sisend;

            do
            {
                Console.WriteLine("Osta elevant ära!");
                sisend = Console.ReadLine();
            } while (!string.Equals(sisend, "elevant", StringComparison.OrdinalIgnoreCase));

            Console.WriteLine("Aitäh, et elevandi ostsid");

            //// Mis arv mõtles välja arvuti? Kasuta vähemalt 5 katset, et seda teada.

            int arvutiArv = random.Next(1, 50);

            int kasutajaArv;
            int katsed = 0;
            bool arvatiOigesti = false;

            Console.WriteLine("Programm on mõelnud välja arvu vahemikus 1 kuni 50, sul on 5 katset.");


            while (katsed < 5 && !arvatiOigesti)
            {
                Console.Write("Sisesta oma arvatav arv: ");
                kasutajaArv = int.Parse(Console.ReadLine());
                katsed++;

                if (kasutajaArv == arvutiArv)
                {
                    Console.WriteLine("Õige! Sa arvasid arvu ära.");
                    arvatiOigesti = true;
                }
                else if (kasutajaArv < arvutiArv)
                {
                    Console.WriteLine("Liiga väike!");
                }
                else
                {
                    Console.WriteLine("Liiga suur!");
                }
            }


            if (arvatiOigesti = false)
            {
                Console.WriteLine($"Kahjuks ei arvanud sa õiget arvu ära. Programm mõtles välja arvu {arvutiArv}.");
            }

            //// Küsi kasutajalt 4 arvu ning väljasta nendest koostatud suurim neliarvuline arv.

            int[] arvudV2 = new int[4];


            for (int i = 0; i < 4; i++)
            {
                Console.Write($"Sisesta arv: ");
                arvudV2[i] = int.Parse(Console.ReadLine());
            }

            Array.Sort(arvudV2);
            Array.Reverse(arvudV2);


            string suurimArv = $"{arvudV2[0]}{arvudV2[1]}{arvudV2[2]}{arvudV2[3]}";


            Console.WriteLine($"Suurim neliarvuline arv on: {int.Parse(suurimArv)}");

            // Korrutustabel väljata ekraanile sellisel kujul:


            for (int i = 1; i <= 10; i++)
            {

                for (int j = 1; j <= 10; j++)
                {

                    Console.Write($"{i * j,4}");
                }

                Console.WriteLine();
            }


            // Klassitöö 30.08.2024 Listid
            List<string> abc = new List<string>();
            try
            {
                foreach (string rida in File.ReadAllLines(@"..\..\..\ABC.txt"))
                {
                    abc.Add(rida);
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Fail ei saa leida!");
            }

            foreach (string e in abc)
            {
                Console.WriteLine(e);
            }
            Console.ReadLine();

            //-----------------------------

            ArrayList arrayList = new ArrayList();
            arrayList.Add("Esimine");
            arrayList.Add("Teine");
            arrayList.Add("Kolmas");

            Console.WriteLine("Otsing: ");
            string vas=Console.ReadLine();
            if (vas != null && arrayList.Contains(vas))
            {
                Console.WriteLine($"Otsitav element asub: {arrayList.IndexOf(vas)} kohal");
            }
            else 
            {
                Console.WriteLine($"Kokku oli {arrayList.Count} elemente vaid otsistav puudub");
            }

            arrayList.Clear();
            arrayList.Insert(0, "Anna");
            Console.WriteLine(arrayList);
            //---------------------------------

            List<Inimine> inimised = new List<Inimine>();
            Inimine inimene1 = new Inimine();
            inimene1.Nimi = "Pjotr 1";
            inimene1.Vanus = 352;
            Inimine inimene2 = new Inimine("Jelizaveta II");
            inimene2.Vanus = 98;
            Inimine inimene3 = new Inimine("Jelizaveta", 20);

            inimised.Add(inimene1);
            inimised.Add(inimene2);
            inimised.Add(inimene3);

            inimised.Add(new Inimine("Irina", 18));

            foreach (Inimine inimene in inimised)
            {
                Console.WriteLine($"{inimene.Nimi} on {inimene.Vanus} aastat vana");
            }



        }
    }
}
