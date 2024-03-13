using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Poligon
    {
        public int broj_t;
        public Tacka[] teme;
        public Poligon(int n)
        {
            broj_t = n;
            teme = new Tacka[n];
        }
        public static void Konveksan(Poligon poli)
        {
            int plusevi = 0;
            for(int i = 0; i < poli.broj_t; i++)
            {
                Vektor prvi = new Vektor(poli.teme[i], poli.teme[(i + 1) % poli.broj_t]);
                Vektor drugi = new Vektor(poli.teme[(i + 1) % poli.broj_t], poli.teme[(i + 2) % poli.broj_t]);
                if (Vektor.Vektorski(prvi, drugi) > 0) plusevi++;
            }
            if ((plusevi == 0) || (plusevi == poli.broj_t)) Console.WriteLine("Konveksan je");
            else Console.WriteLine("Nije konveksan");

        }
        public static double Povrsina(Poligon poli)
        {
            double povrsina = 0;
            for(int i = 0; i < poli.broj_t; i++)
            {
                Tacka prva = poli.teme[i];
                Tacka druga = poli.teme[(i + 1) % poli.broj_t];
                povrsina = povrsina + (prva.x * druga.y - prva.y * druga.x);
            }
            if (povrsina < 0) return (-povrsina) / 2;
            else return povrsina / 2;
        }
    }
}
