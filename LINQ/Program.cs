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

            IEnumerable<int> evens = numbers.Where((n) => n % 2 == 0);
            var evenAndBiggerThan4 = evens.Where((n) => n > 4);
            foreach (var number in evenAndBiggerThan4)
            {
                Console.WriteLine(number);
            }


            Console.ReadKey();
        }
    }
}
