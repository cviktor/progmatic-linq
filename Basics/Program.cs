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
            //var line = Console.ReadLine(); //met�dus visszat�r�si �rt�k t�rol�s�ra nem mindig prefer�lj�k, van hogy ink�bb ki kell �rni

            //var p = new Person("Lajos");
            //p.Age = 31;

            var p = new Person("Lajos")
            {
                Age = 31,
                Salary = 1000
            };

            var p2 = new Person("Armando")
            {
                Age = 27,
                Salary = 2000
            };


            //var persons = new List<Person>();
            //persons.Add(p);
            //persons.Add(new Person("G�za"){Age = 22, Salary = 3000});

            var persons = new List<Person>()
            {
                p,
                new Person("G�za"){Age = 22, Salary = 3000}
            };
            Console.WriteLine(persons[1].Name);

            //Console.WriteLine(p.Name + " fizet�s: " + p.Salary);
            //Console.WriteLine(p2.Name + " fizet�s: " + p2.Salary);
            //Console.WriteLine(persons[1].Name + " fizet�s: " + persons[1].Salary);
            //WritePerson(p);
            //WritePerson(p2);
            //WritePerson(persons[1]);

            //Megegyezik az als�val
            PersonExtension.Write(p);
            PersonExtension.Write(p2);
            PersonExtension.Write(persons[1]);
            
            //Extension method h�v�sa
            p.Write();
            p2.Write();
            persons[1].Write();

            Console.ReadKey();
        }

        static void WritePerson(Person p)
        {
            Console.WriteLine(p.Name + " fizet�s: " + p.Salary);
        }

        static int Y()
        {
            var y = 21; //y-t vissza lehet t�rni vele mert a var egy int-et fog jel�lni

            return y;
        }
    }
}
