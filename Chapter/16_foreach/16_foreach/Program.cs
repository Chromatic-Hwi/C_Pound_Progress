using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_foreach
{
    class Program
    {
        static void Main()
        {
            string str = "ABC123";

            foreach (char word in str)
            {
                Console.WriteLine($"{word} ");
            }
        }
    }
}
