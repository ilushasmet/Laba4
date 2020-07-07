using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Laba4
{

   

    class Program
    {
        static void Main(string[] args)
        {
            var sb = new Snowboard(213);
            var sk = new Ski(400);
            var cr = new CrossCountrySkiing(114);

            var printer = new EquipmentPrinter();

            printer.printClass(sb);
            printer.printClass(sk);
            printer.printClass(cr);

            Console.ReadKey();

        }
    }
}
