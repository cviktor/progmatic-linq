using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics
{
    delegate bool FilterDelegate(int n);

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
            //Console.WriteLine(persons[1].Name);

            //Console.WriteLine(p.Name + " fizet�s: " + p.Salary);
            //Console.WriteLine(p2.Name + " fizet�s: " + p2.Salary);
            //Console.WriteLine(persons[1].Name + " fizet�s: " + persons[1].Salary);
            //WritePerson(p);
            //WritePerson(p2);
            //WritePerson(persons[1]);

            //Megegyezik az als�val
            //PersonExtension.Write(p);
            //PersonExtension.Write(p2);
            //PersonExtension.Write(persons[1]);

            //Extension method h�v�sa
            //p.Write();
            //p2.Write();
            //persons[1].Write();

            //var line = Console.ReadLine();
            //1. megold�s
            //var moved = StringExtension.MoveFirstToLast(line);
            //moved = StringExtension.MoveFirstToLast(moved);

            //2. megold�s
            //var moved = StringExtension.MoveFirstToLast(StringExtension.MoveFirstToLast(line));

            //3. megold�s
            //var moved = line.MoveFirstToLast().MoveFirstToLast();
            //Console.WriteLine(moved);

            var numbers = new List<int> { 2, 3, 4, 5, 6, 7, 8 };
            var evenNumbers = Filter(numbers, IsEven);
            foreach (var n in evenNumbers)
            {
                Console.WriteLine(n);
            }
            Console.ReadKey();
        }

        static bool IsEven(int n)
        {
            return n % 2 == 0;
        }

        static List<int> Filter(List<int> numbers, FilterDelegate filter)
        {
            var result = new List<int>();

            foreach (var n in numbers)
            {
                if (filter(n))
                {
                    result.Add(n);
                }
            }

            return result;
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
