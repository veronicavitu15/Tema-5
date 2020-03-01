using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema_5
{
    public class Iepure : Animal
    {
        public string numeIepure { get; set; }
        public Iepure(string numeIepure, int varsta, string culoare) : base(numeIepure) 
        {
            this.numeIepure = numeIepure;
            this.varsta = varsta;
            this.culoare = culoare;
            
        }
        public void sare()
        {
            Console.WriteLine("Hop!");

        }
        public string afiseazaInformatii()
        {
            return "Nume iepure: " + numeIepure + "\nCuloare: " + base.culoare + "\nVarsta: " + base.varsta;
        }




    }
}
