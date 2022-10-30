using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28_EnumerableDemo
{
    class EnumerableDemo
    {
        static void Main()
        {
            var numbers = Enumerable.Range(1, 5); // 1 ~ 5
            foreach (var n in numbers)
                Console.Write("{0}\t", n);
            Console.WriteLine();

            var sameNumbers = Enumerable.Repeat(-1, 5); // -1 5ea
            foreach (var n in sameNumbers)
                Console.Write("{0}\t", n);
            Console.WriteLine();
        }
    }
}
