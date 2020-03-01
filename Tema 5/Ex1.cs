using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema_5
{
    class Ex1
    {
        static void Main(string[] args)
        {
            Iepure i1 = new Iepure("Pufosul", 2, "alb");
            
            Console.WriteLine(i1.afiseazaInformatii());
            i1.sare();

            Console.WriteLine();

            Lup l1 = new Lup("Bruno", 7, "gri");
            Console.WriteLine(l1.afiseazaInformatii());
            l1.urla();
            
            
        }
    }
}
