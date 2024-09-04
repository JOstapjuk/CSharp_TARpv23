using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__TARpv23
{
    internal class Toode
    { 
        public string ToodeNimetus { get; set; }
        public int Kalorid { get; set; }
        public Toode() { }
        public Toode(string toodeNimetus, int kalorid)
        {
            ToodeNimetus = toodeNimetus;
            Kalorid = kalorid;
        }
    }
}
