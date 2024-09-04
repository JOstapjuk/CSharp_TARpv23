using C__TARpv23;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TARpv23_CSharp
{
    public class MainClass
    {
        public static void Main(string[] args)
        {
            //I.osa Admetüübid, Alamfunktsioonid, If
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Hello, World");
            string nimetus = "Python";
            Console.WriteLine("Hello, {0}",nimetus);
            Functions.Tere(nimetus);



            Console.Write("Sisesta esimine arv: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Sisesta teine arv: ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Siseta funktsioon(+,-,*,/): ");
            string function = Console.ReadLine();
            int result = Functions.Arvuta(function, a, b);
            Console.WriteLine(result);
            
            
            //int vastus=Functions.Liitmine(a,b);
            //Console.WriteLine(vastus);
            //double arv=5.541;
            //vastus = Functions.Liitmine(a,(int)arv);
            //Console.WriteLine(vastus);
            //char taht = 'A';
            //if (vastus == 0)
            //{
            //    Console.WriteLine(taht);
            //}
            //else
            //{
            //    Console.WriteLine(vastus);
            //}

        }

    }
}
