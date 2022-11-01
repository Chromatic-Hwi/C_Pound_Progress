using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30_Map
{
    class Program
    {
        static void Main()
        {
            int[] numbers = { 1, 2, 3, 4, 5 };

            var nums = numbers.Select(it => it * it);

            foreach (var num in nums)
            {
                Console.WriteLine(num);
            }
        }
    }
}
