using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 2, 3, 4, 5, 6, 7, 8, 9 };

            //IEnumerable<int> evens = numbers.Where((n) => n % 2 == 0);
            //var evenAndBiggerThan4 = evens.Where((n) => n > 4);
            //var evenAndBiggerThan4 = numbers.Where((n) => n % 2 == 0).Where((n) => n > 4);
            //foreach (var number in evenAndBiggerThan4)
            //{
            //    Console.WriteLine(number);
            //}

            IEnumerable<string> stringNumbers = numbers.Select((n) => n + " sz�m");
            foreach (string numberText in stringNumbers)
            {
                Console.WriteLine(numberText);
            }

            Console.ReadKey();
        }
    }
}
