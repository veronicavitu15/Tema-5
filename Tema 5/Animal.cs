using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema_5
{
    public class Animal
    {
        public string nume { get; set; }
        public int varsta { get; set; }
        public string culoare { get; set; }

        public string afiseazaInformatii(string nume)
        {
            return "Nume: " + nume;
        }
        public string afiseazaInformatii()
        {
            return "Nume: " + nume + "\nCuloare: " + culoare + "\nVarsta: " + varsta;

        }

        public Animal (string nume, int varsta, string culoare)
        {
            this.nume = nume;
            this.varsta = varsta;
            this.culoare = culoare;
        }
        
        
    }
}
