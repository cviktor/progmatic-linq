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
            //Console.WriteLine(persons[1].Name);

            //Console.WriteLine(p.Name + " fizetés: " + p.Salary);
            //Console.WriteLine(p2.Name + " fizetés: " + p2.Salary);
            //Console.WriteLine(persons[1].Name + " fizetés: " + persons[1].Salary);
            //WritePerson(p);
            //WritePerson(p2);
            //WritePerson(persons[1]);

            //Megegyezik az alsóval
            //PersonExtension.Write(p);
            //PersonExtension.Write(p2);
            //PersonExtension.Write(persons[1]);

            //Extension method hívása
            //p.Write();
            //p2.Write();
            //persons[1].Write();

            //var line = Console.ReadLine();
            //1. megoldás
            //var moved = StringExtension.MoveFirstToLast(line);
            //moved = StringExtension.MoveFirstToLast(moved);

            //2. megoldás
            //var moved = StringExtension.MoveFirstToLast(StringExtension.MoveFirstToLast(line));

            //3. megoldás
            //var moved = line.MoveFirstToLast().MoveFirstToLast();
            //Console.WriteLine(moved);

            var numbers = new List<int> { 2, 3, 4, 5, 6, 7, 8 };

            //Megadhatom régi nevesített metódus szintaktikával
            //Action<int> writerDel = new Action<int>(WriteNumber);

            //Megadhatom a nevesített metódust
            //Action<int> writerDel = WriteNumber; //felsõ sor egyszerûsítése

            //Anonymus metódussal is megoldhatom az elõzõ részt ilyenkor nem kell a WriteNumber
            //hanem magát a metódust definiálom itt
            //Action<int> writerDel = delegate (int n)
            //{
            //    Console.WriteLine("Anonymus metódus vagyok: " + n);
            //};

            //Megadhatom lambda kifejezéssel ami hasonló mint az elõzõ megoldás
            //csak egyszerûbb az írásmódja
            Action<int> writerDel = (n) =>
            {
                Console.WriteLine("Lambda vagyok: " + n);
            };

            //writerDel(132423); //ez gyakorlatilag a WriteNumber(132423);

            //Func<int, int, bool> evenDel = IsEven;
            //bool result = evenDel(4, 3);
            //Console.WriteLine(result);
            //var evenNumbers = Filter(numbers, IsEven, 4, writerDel);

            //A híváskor paramétereként definiáljuk magát a metódust amit futtatni akarunk
            var evenNumbers = Filter(numbers, (n, min) =>
            {
                return n > min && n % 2 == 0;
            },
            4, writerDel);

            foreach (var n in evenNumbers)
            {
                Console.WriteLine(n);
            }

            //Páratlan számokra ugyanez, minden paramétere a filternek külön sorba szerepel
            var oddNumbers = Filter(numbers, //bemenõ számok listája
                (n, min) => n >= min && n % 2 != 0, //a metódus ami alapján szûrünk (páratlan min-nél nagyobb egyenlõ számok)
                3, //minimum szám
                (j) => Console.WriteLine("Éppen {0}-t nézem", j) //a metódus amivel kiírjuk éppen mit vizsgálunk
            );
            Console.ReadKey();
        }

        static void WriteNumber(int n)
        {
            Console.WriteLine("Éppen a {0} számot vizsgáljuk", n);
        }

        static bool IsEven(int n, int min)
        {
            return n > min && n % 2 == 0;
        }

        //FilterDelegate helyett megfelel a Func<int, bool>
        static List<int> Filter(List<int> numbers,
            Func<int, int, bool> filter,
            int minimum,
            Action<int> write) //delegate formába így kéne felvenni: delegate void WriteDelegate(int x);
        {
            var result = new List<int>();

            foreach (var n in numbers)
            {
                write(n); //kiirjuk melyik számot vizsgáljuk éppen
                if (filter(n, minimum))
                {
                    result.Add(n);
                }
            }

            return result;
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
