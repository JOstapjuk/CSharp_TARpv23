using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__TARpv23
{
    internal class Inimine
    {
        public string Nimi {  get; set; }
        public int Vanus { get; set; }

        public Inimine() { }

        public Inimine(string nimi)
        {
            Nimi = nimi;
        }

        public Inimine(string nimi, int vanus=2)
        {
            Nimi = nimi;
            Vanus = vanus;
        }
    }
}
