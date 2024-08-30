using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__TARpv23
{
    internal class Listid_sõnastikud
    {
        public static void Main(string[] args)
        {
            Random random = new Random();
            Console.OutputEncoding = Encoding.UTF8;

            // Ülesanne 1
            List<int> arvud = new List<int>();
            arvud.Add(5);
            arvud.Add(9);
            arvud.Add(8);
            arvud.Add(14);
            arvud.Add(20);

            // Ülesanne 2
            int[] arvudV2 = new int[20];

            for (int i = 0; i < 20; i++)
            {
                arvudV2[i] = random.Next(101);
            }





        }
    }
}
