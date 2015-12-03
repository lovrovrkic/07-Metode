using System;

namespace Vsite.CSharp
{
    // Primjer strukture kao parametra metode

    struct MojaStruktura
    {
        public MojaStruktura(int n) 
        { 
            N = n; 
        }
        
        public int N;
    }

    class ParametarStruktura
    {
        static void Uvećaj(MojaStruktura ms)
        {
            ms.N += 1;
            Console.WriteLine("Unutar metode Uvecaj: {0}", ms.N);
        }

        static void Main(string[] args)
        {
            // Pokrenuti program, ispis prekopirati u datoteku ParametarStruktura.txt te u njoj dopisati obrazloženje rezultata

            MojaStruktura ms = new MojaStruktura(20);
            Console.WriteLine("Prije metode Uvecaj: {0}", ms.N);
            Uvećaj(ms);
            Console.WriteLine("Nakon metode Uvecaj: {0}", ms.N);

            Console.WriteLine("GOTOVO!!!");
            Console.ReadKey();
        }
   }
}
