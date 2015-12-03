using System;

namespace Vsite.CSharp
{
    // Primjer s virtualnim metodama

    class Bazna
    {
        public virtual void PredstaviSe()
        {
            Console.WriteLine("Ja sam Bazna");
        }
    }

    class Izvedena : Bazna
    {
        // pregaziti virtualnu metodu PredstaviSe tako da ispiše ime klase
        public override void PredstaviSe()
        {
            Console.WriteLine("Ja sam izvedena");
        }
    }

    class Izvedena2 : Bazna
    {
        // pregaziti virtualnu metodu PredstaviSe tako da ispiše ime klase
        public override void PredstaviSe()
        {
            Console.WriteLine("Ja sam izvedena2");
        }
    }

    class Program
    {

        static void Main(string[] args)
        {
            // Izvesti program, ispis prekopirati u datoteku Virtualne.txt te dopisati obrazloženje
            Bazna[] bazne = new Bazna[] { new Bazna(), new Izvedena(), new Izvedena2()};
            foreach (Bazna b in bazne)
            {
                b.PredstaviSe();
                Console.WriteLine();
            }

            Console.WriteLine("GOTOVO!!!");
            Console.ReadKey();
        }
    }
}
