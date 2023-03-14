using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TARgv22_C
{
    public class Loom
    {
        public string Nimi { get; set; }

        public Loom()
        {
        }
        public Loom(string nimi)
        {
            Nimi = nimi;
        }
        
        public void Loomi_häll()
        {
            Console.WriteLine("Auu,auuuuu");
        }
    }
}
