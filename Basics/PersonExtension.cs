using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics
{
    static class PersonExtension
    {
        public static void Write(this Person p) //A this kulcsszóval egészítjük ki a Person típust
        {
            Console.WriteLine(p.Name + " fizetése: " + p.Salary);
        }
    }
}
