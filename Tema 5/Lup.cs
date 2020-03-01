using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema_5
{
    public class Lup : Animal
    {
        public string numeLup { get; set; }
        public Lup(string numeLup, int varsta, string culoare) : base(numeLup)
        {
            this.numeLup = numeLup;
            this.varsta = varsta;
            this.culoare = culoare;
            
        }
        public void urla()
        {
            Console.WriteLine("Auuuu!");

        }
        public string afiseazaInformatii()
        {
            return "Nume Lup: " + numeLup + "\nCuloare: " + base.culoare + "\nVarsta: " + base.varsta;
        }




    }
}
