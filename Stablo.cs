using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stablo
{
    class Stablo
    {
        bool otpadajuListovi;
        string vrstaStabla;
        public bool OtpadajuLisovi { get => otpadajuListovi; set => otpadajuListovi = value; }
        public string VrstaStabla { get => vrstaStabla; set => vrstaStabla = value; }
        public Stablo(bool Otpadajulistovi)
        {
            this.otpadajuListovi = Otpadajulistovi;
        }
        public override string ToString()
        {
            string ispis = "Ovo stablo je";
            if (!otpadajuListovi)
            {
                ispis += "zimzeleno";
            }
            {
                ispis += "listopadno.";
            }
            return ispis;
        }
        internal class program
        {
            static void Main(string[] args)
            {
                Stablo stablo1 = new Stablo(false);
                Stablo stablo2 = new Stablo(true);
                Console.WriteLine("Stablo 1:" + stablo1.ToString());
                Console.WriteLine("Stablo 2:" + stablo2.ToString());
                Console.WriteLine(stablo1.otpadajuListovi);
                Console.WriteLine(stablo2.otpadajuListovi);
                Console.ReadKey();
            }
        }
    }
}
