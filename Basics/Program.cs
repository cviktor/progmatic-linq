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

            //var p = new Person("Lajos");
            //p.Age = 31;

            var p = new Person("Lajos")
            {
                Age = 31,
                Salary = 1000
            };

            //var persons = new List<Person>();
            //persons.Add(p);

            var persons = new List<Person>()
            {
                p,
                new Person("Géza"){Age = 22, Salary = 3000}
            };

            Console.ReadKey();
        }

        static int Y()
        {
            var y = 21; //y-t vissza lehet térni vele mert a var egy int-et fog jelölni

            return y;
        }
    }
}
