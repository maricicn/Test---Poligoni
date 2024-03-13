using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Funkcije
    {
        public static int SIS(Vektor AB, Tacka C, Tacka D)
        {
            Vektor AC = new Vektor(AB.pocetak, C);
            Vektor AD = new Vektor(AB.pocetak, D);
            double prvi = Vektor.Vektorski(AB, AC);
            double drugi = Vektor.Vektorski(AB, AD);
            if (prvi * drugi > 0)
            {
                Console.WriteLine("Sa iste strane su");
                return 0;
            }
            else if (prvi * drugi == 0)
            {
                Console.WriteLine("Jedna tacka se nalazi na vektoru");
                return 1;
            }
            else 
            {
                Console.WriteLine("Sa razlicite strane su");
                return 2;
            }
            
        }
    }
}
