using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema_5
{
    class Ex2
    {
        static void Main(string[] args)
        {
            Vila v1 = new Vila(10, 100);
            Console.WriteLine(v1.afiseazaInformatii());

            Apartament a1 = new Apartament(3, 57);

            Console.WriteLine(a1.afiseazaInformatii());
        }
    }
}
