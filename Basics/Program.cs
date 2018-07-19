using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = 2;
            var line = Console.ReadLine(); //metódus visszatérési érték tárolására nem mindig preferálják, van hogy inkább ki kell írni



            Console.ReadKey();
        }

        static int Y()
        {
            var y = 21; //y-t vissza lehet térni vele mert a var egy int-et fog jelölni

            return y;
        }
    }
}
