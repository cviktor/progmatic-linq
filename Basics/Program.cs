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
            //var line = Console.ReadLine(); //metódus visszatérési érték tárolására nem mindig preferálják, van hogy inkább ki kell írni

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
            //persons.Add(new Person("Géza"){Age = 22, Salary = 3000});

            var persons = new List<Person>()
            {
                p,
                new Person("Géza"){Age = 22, Salary = 3000}
            };
            Console.WriteLine(persons[1].Name);

            //Console.WriteLine(p.Name + " fizetés: " + p.Salary);
            //Console.WriteLine(p2.Name + " fizetés: " + p2.Salary);
            //Console.WriteLine(persons[1].Name + " fizetés: " + persons[1].Salary);
            //WritePerson(p);
            //WritePerson(p2);
            //WritePerson(persons[1]);

            //Megegyezik az alsóval
            PersonExtension.Write(p);
            PersonExtension.Write(p2);
            PersonExtension.Write(persons[1]);
            
            //Extension method hívása
            p.Write();
            p2.Write();
            persons[1].Write();

            Console.ReadKey();
        }

        static void WritePerson(Person p)
        {
            Console.WriteLine(p.Name + " fizetés: " + p.Salary);
        }

        static int Y()
        {
            var y = 21; //y-t vissza lehet térni vele mert a var egy int-et fog jelölni

            return y;
        }
    }
}
