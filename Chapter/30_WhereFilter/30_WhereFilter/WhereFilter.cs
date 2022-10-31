using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30_WhereFilter
{
    class WhereFilter
    {
        static void Main()
        {
            int[] numbers = { 1, 2, 3, 4, 5 };

            var nums = numbers.Where(it => it % 2 == 0 && it > 3);

            foreach (var num in nums)
            {
                Console.WriteLine(num);
            }
        }
    }
}
