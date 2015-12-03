using System;

namespace Vsite.CSharp
{
    // dodati proširujuću metodu (extension method) BrojRiječi klasi string koja kao rezultat vraća broj riječi
    static class ProširenjeStringa
    {
        public static int BrojRijeci(this string s)
        {
            s.Split(new char[] { ' ', '?', ',', '.' }, StringSplitOptions.RemoveEmptyEntries).Length;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            string s = "Kako je počeo rat na mom otoku";
            int brojRiječi = s.BrojRiječi();

            Console.WriteLine(brojRiječi);
            Console.ReadKey();
        }
    }
}
