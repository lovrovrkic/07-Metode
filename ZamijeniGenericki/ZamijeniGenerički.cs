using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Vsite.CSharp
{
    class Program
    {
        // Primjer kako prevoditelj automatski generira različite metode za različite tipove parametara
        static void ZamijeniGenerički<T>(ref T o1, ref T o2)
        {
            T temp = o2;
            o2 = o1;
            o1 = temp;
        }

        static void Main(string[] args)
        {
            // prevesti program i otvoriti i pogledati generirani kod s ILDASM alatom te međukod metode Main prekopirati u ZamijeniGenerički.txt
            // u datoteku odgovoriti: koliko se metoda iz metode Main poziva?

            int i1 = 5;
            int i2 = 10;
            ZamijeniGenerički(ref i1, ref i2);

            double d1 = 3.14;
            double d2 = 2.76;
            ZamijeniGenerički(ref d1, ref d2);

            //ZamijeniGenerički("mirko", "slavko");

        }
    }
}
