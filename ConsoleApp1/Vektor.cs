using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Vektor
    {
        public Tacka pocetak, kraj;
        public Vektor() { }
        public Vektor(Tacka pocetak, Tacka kraj)
        {
            this.pocetak = pocetak;
            this.kraj = kraj;
        }
        public Tacka Centriraj()
        {
            Tacka Nova = new Tacka();
            Nova.x = pocetak.x - kraj.x;
            Nova.y = pocetak.y - kraj.y;
            return Nova;
        }
        public static double Vektorski(Vektor A, Vektor B)
        {
            Tacka Ac = A.Centriraj();
            Tacka Bc = B.Centriraj();
            return (Ac.x * Bc.y - Ac.y * Bc.x);
        }
        public static double Skalarni(Vektor A, Vektor B)
        {
            Tacka Ac = A.Centriraj();
            Tacka Bc = B.Centriraj();
            return (Ac.x * Bc.x + Ac.y * Bc.y);
        }
    }
}
