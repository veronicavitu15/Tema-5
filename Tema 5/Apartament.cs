using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema_5
{
    public class Apartament : Imobil 
    {
        public int numarGeamuri { get; set; }
        public int suprafata { get; set; }
        public Apartament(int numarGeamuri, int suprafata): base()
        {
            this.numarGeamuri = numarGeamuri;
            this.suprafata = suprafata;
        }
        public string afiseazaInformatii()
        {
            return "Apartament: " + "\nNumar Geamuri: " + this.numarGeamuri + "\nSuprafata: " + base.suprafata;
        }
    }
}
