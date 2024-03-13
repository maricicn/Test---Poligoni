using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Prvi*/
            /*string alfabet = "ABCDEFGH";
            Poligon prviP = new Poligon(4);
            for(int i = 0; i < 4; i++)
            {
                Tacka pom = new Tacka();
                Console.WriteLine("Unesite koordinate tacke " + alfabet[i] + " :");
                pom.x = Convert.ToDouble(Console.ReadLine());
                pom.y = Convert.ToDouble(Console.ReadLine());
                prviP.teme[i] = pom;
            }
            Vektor BD = new Vektor(prviP.teme[1], prviP.teme[3]);
            Tacka A = prviP.teme[0];
            Tacka C = prviP.teme[2];
            Funkcije.SIS(BD, A, C);*/

            /*Drugi*/
            /*string alfabet = "ABCDEFGH";
            Poligon drugiP = new Poligon(4);
            for (int i = 0; i < 4; i++)
            {
                Tacka pom = new Tacka();
                Console.WriteLine("Unesite koordinate tacke " + alfabet[i] + " :");
                pom.x = Convert.ToDouble(Console.ReadLine());
                pom.y = Convert.ToDouble(Console.ReadLine());
                drugiP.teme[i] = pom;

            }
            int k = 0;
            Vektor[] nizV = new Vektor[4];
            bool jeste = false;
            for(int i = 0; i < 4; i++)
            {
                Vektor prvi = new Vektor(drugiP.teme[i], drugiP.teme[(i + 1) % drugiP.broj_t]);
                nizV[i] = prvi;
                Vektor drugi = new Vektor(drugiP.teme[(i+1) % drugiP.broj_t], drugiP.teme[(i + 2) % drugiP.broj_t]);
                if (Vektor.Skalarni(prvi, drugi) == 0) k++;
            }
            for (int i = 0; i < 4; i++)
            {
                Vektor jedan = nizV[i];
                Vektor dva = nizV[(i + 1) % 4];
                Vektor tri = nizV[(i + 2) % 4];
                if ((Vektor.Skalarni(jedan, dva) == 0) && (Vektor.Skalarni(dva, tri) == 0))
                {
                    jeste = true;
                }
            }
            if ((k == 2) && (jeste)) Console.WriteLine("Jeste pravougli trapez");
            else Console.WriteLine("Nije pravougli trapez");*/

            /*Treci*/
            /*string alfabet = "ABCDEFGH";
            Poligon treciP = new Poligon(4);
            for (int i = 0; i < 4; i++)
            {
                Tacka pom = new Tacka();
                Console.WriteLine("Unesite koordinate tacke " + alfabet[i] + " :");
                pom.x = Convert.ToDouble(Console.ReadLine());
                pom.y = Convert.ToDouble(Console.ReadLine());
                treciP.teme[i] = pom;
            }
            int k = 0;
            bool jeste = false;
            for (int i = 0; i < 4; i++)
            {
                Vektor prvi = new Vektor(treciP.teme[i], treciP.teme[(i + 1) % treciP.broj_t]);
                Vektor drugi = new Vektor(treciP.teme[(i + 1) % treciP.broj_t], treciP.teme[(i + 2) % treciP.broj_t]);
                if (Vektor.Skalarni(prvi, drugi) == 0) k++;
            }
            Vektor AC = new Vektor(treciP.teme[0], treciP.teme[2]);
            Vektor BD = new Vektor(treciP.teme[1], treciP.teme[3]);

            if (Vektor.Skalarni(AC, BD) == 0) jeste = true;
            if ((k == 4) && (jeste)) Console.WriteLine("Jeste kvadrat");
            else Console.WriteLine("Nije kvadrat");*/

            /*Cetvrti*/
            /*string alfabet = "ABCDEFGH";
            int n;
            n = int.Parse(Console.ReadLine());
            Poligon cetvrtiP = new Poligon(n);
            for (int i = 0; i < n; i++)
            {
                Tacka pom = new Tacka();
                Console.WriteLine("Unesite koordinate tacke " + alfabet[i] + " :");
                pom.x = Convert.ToDouble(Console.ReadLine());
                pom.y = Convert.ToDouble(Console.ReadLine());
                cetvrtiP.teme[i] = pom;
            }
            Poligon.Konveksan(cetvrtiP);*/
                    
            /*Peti*/
            string alfabet = "ABCDEFGH";
            int n;
            n = int.Parse(Console.ReadLine());
            Poligon cetvrtiP = new Poligon(n);
            for (int i = 0; i < n; i++)
            {
                Tacka pom = new Tacka();
                Console.WriteLine("Unesite koordinate tacke " + alfabet[i] + " :");
                pom.x = Convert.ToDouble(Console.ReadLine());
                pom.y = Convert.ToDouble(Console.ReadLine());
                cetvrtiP.teme[i] = pom;
            }
            Console.WriteLine(Poligon.Povrsina(cetvrtiP));


            
        }
    }
}
