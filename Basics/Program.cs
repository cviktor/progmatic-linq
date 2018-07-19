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
            var line = Console.ReadLine(); //met�dus visszat�r�si �rt�k t�rol�s�ra nem mindig prefer�lj�k, van hogy ink�bb ki kell �rni

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
                new Person("G�za"){Age = 22, Salary = 3000}
            };

            Console.ReadKey();
        }

        static int Y()
        {
            var y = 21; //y-t vissza lehet t�rni vele mert a var egy int-et fog jel�lni

            return y;
        }
    }
}
