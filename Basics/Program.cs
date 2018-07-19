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

            //Megadhatom r�gi neves�tett met�dus szintaktik�val
            //Action<int> writerDel = new Action<int>(WriteNumber);

            //Megadhatom a neves�tett met�dust
            //Action<int> writerDel = WriteNumber; //fels� sor egyszer�s�t�se

            //Anonymus met�dussal is megoldhatom az el�z� r�szt ilyenkor nem kell a WriteNumber
            //hanem mag�t a met�dust defini�lom itt
            //Action<int> writerDel = delegate (int n)
            //{
            //    Console.WriteLine("Anonymus met�dus vagyok: " + n);
            //};

            //Megadhatom lambda kifejez�ssel ami hasonl� mint az el�z� megold�s
            //csak egyszer�bb az �r�sm�dja
            Action<int> writerDel = (n) =>
            {
                Console.WriteLine("Lambda vagyok: " + n);
            };

            //writerDel(132423); //ez gyakorlatilag a WriteNumber(132423);

            //Func<int, int, bool> evenDel = IsEven;
            //bool result = evenDel(4, 3);
            //Console.WriteLine(result);
            //var evenNumbers = Filter(numbers, IsEven, 4, writerDel);

            //A h�v�skor param�terek�nt defini�ljuk mag�t a met�dust amit futtatni akarunk
            var evenNumbers = Filter(numbers, (n, min) =>
            {
                return n > min && n % 2 == 0;
            },
            4, writerDel);

            foreach (var n in evenNumbers)
            {
                Console.WriteLine(n);
            }

            //P�ratlan sz�mokra ugyanez, minden param�tere a filternek k�l�n sorba szerepel
            var oddNumbers = Filter(numbers, //bemen� sz�mok list�ja
                (n, min) => n >= min && n % 2 != 0, //a met�dus ami alapj�n sz�r�nk (p�ratlan min-n�l nagyobb egyenl� sz�mok)
                3, //minimum sz�m
                (j) => Console.WriteLine("�ppen {0}-t n�zem", j) //a met�dus amivel ki�rjuk �ppen mit vizsg�lunk
            );
            Console.ReadKey();
        }

        static void WriteNumber(int n)
        {
            Console.WriteLine("�ppen a {0} sz�mot vizsg�ljuk", n);
        }

        static bool IsEven(int n, int min)
        {
            return n > min && n % 2 == 0;
        }

        //FilterDelegate helyett megfelel a Func<int, bool>
        static List<int> Filter(List<int> numbers,
            Func<int, int, bool> filter,
            int minimum,
            Action<int> write) //delegate form�ba �gy k�ne felvenni: delegate void WriteDelegate(int x);
        {
            var result = new List<int>();

            foreach (var n in numbers)
            {
                write(n); //kiirjuk melyik sz�mot vizsg�ljuk �ppen
                if (filter(n, minimum))
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
