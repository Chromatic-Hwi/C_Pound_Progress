using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_doWhile
{
    class Program
    {
        static void Main()
        {
            var sum = 0;
            int i = 1;

            do
            {
                if (i % 3 == 0 && i % 4 == 0)
                {
                    sum += i;
                }
                i++;
            } while (i <= 100);
            Console.WriteLine(sum);
        }
    }
}
