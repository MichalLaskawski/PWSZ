using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie
{
    class Program
    {
        static void Main(string[] args)
        {
            Liczby L1 = new Liczby();
            Liczby L2 = new Liczby();

            L1.A = 2;
            L1.B = 3;
            L1.C = 4;

            L2.A = 5;
            L2.B = 6;
            L2.C = 7;

            Lepsze_liczby liczby = new Lepsze_liczby();
            liczby.liczby();

            Lepsze_liczby LL1 = new Lepsze_liczby();

        }
    }

}
