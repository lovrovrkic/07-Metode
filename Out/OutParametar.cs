using System;

namespace Vsite.CSharp
{
    // Primjer out parametra

    class OutParametar
    {
        static void InicijalizirajBrojNaDeset(out int x)
        {
            x = 10;
        }

        static void InicijalizirajBrojNaDvaDeset(int x)
        {
            x = 20;
        }

        static void Main(string[] args)
        {
            int x;

            // TODO: Dodati pozive metoda InicijalizirajBrojNaDeset i InicijalizirajBrojNaDvaDeset tako da prevoditelj ne javlja pogrešku
            // Iza svakog poziva ispisati vrijednost varijable x, pokrenuti program i ispis prekopirati u datoteku OutParametar.txt
            InicijalizirajBrojNaDeset(out x);
            InicijalizirajBrojNaDvaDeset(x);
            Console.WriteLine(x);
            Console.WriteLine("GOTOVO!!!");
            Console.ReadKey();
        }
    }
}
