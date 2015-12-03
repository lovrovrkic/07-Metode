using System;

namespace Vsite.CSharp
{
    // Referentni tip kao parametar metode

    class ParametarRefTip
    {
        class MojaKlasa
        {
            public int N = 10;
        }

        static void Uvećaj(MojaKlasa mk)
        {
            mk.N += 1;
            Console.WriteLine("Unutar metode Uvećaj: {0}", mk.N);
        }

        static void Main(string[] args)
        {
            // Pokrenuti program, ispis prekopirati u datoteku ParametarRefTip.txt te u njoj dopisati obrazloženje rezultata

            MojaKlasa mk = new MojaKlasa();
            Console.WriteLine("Prije metode Uvećaj: {0}", mk.N);
            Uvećaj(mk);
            Console.WriteLine("Nakon metode Uvećaj: {0}", mk.N);

            Console.WriteLine("GOTOVO!!!");
            Console.ReadKey();
        }
    }
}
