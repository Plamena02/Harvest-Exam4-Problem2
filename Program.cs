using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Rekolta
{
    class Program
    {
        static void Main(string[] args)
        {
            var loze = int.Parse(Console.ReadLine());
            var g = double.Parse(Console.ReadLine());
            var l = int.Parse(Console.ReadLine());
            var n = int.Parse(Console.ReadLine());
            var sum = loze * g;
            var vino =  sum *0.4 / 2.5;
            var raz=0.00;
            var ost=0.0;
            if (vino >= l)
            {
                raz = vino - l; ost = raz / n;
                Console.WriteLine("Good harvest this year! Total wine: {0} liters.", Math.Floor(vino));
                Console.WriteLine("{0} liters left -> {1} liters per person", Math.Ceiling(raz),Math.Ceiling(ost));
            }
            else
            {
            raz = l - vino;
                Console.WriteLine("It will be a tough winter! More {0} liters wine needed.",Math.Floor(raz));
            }

        }
    }
}
