using System;

namespace Vsite.CSharp
{
    class Program
    {
        // Pokrenut program i kopirati ispis u datoteku PreopterecenjePodrazumijevaniArg.txt priloženu projektu

        public static int Zbroji(int x = 3, int y = 4) 
        {
            return x + y;
        }

        // Dodati definiciju funkcije public static int Zbroji(int x) i ponoviti pokretanje programa te usporediti ispise
        public static int Zbroji(int x)
        {
            return x + 1;
        }


        static void Main(string[] args)
        {
            Console.WriteLine(Zbroji(5, 6));
            Console.WriteLine(Zbroji(5));
            Console.WriteLine(Zbroji());

            Console.ReadKey();
        }
    }
}
