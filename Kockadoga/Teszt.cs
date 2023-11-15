using Negyszog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kockadoga
{
    class Teszt
    {
        static void Main(string[] args)
        {

            NegyszogClass sz = new NegyszogClass(3, 5);
            sz.SetKerulet();
            sz.SetTerulet();


            Console.WriteLine("A négyszög kerülete: {0:0.00}, területe {1:0.00}", sz.getKerulet(), sz.getTerulet());

            Console.ReadKey();

        }
    }
}
