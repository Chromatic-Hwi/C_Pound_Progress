using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30_MinAndMax
{
    class MinAndMax
    {
        static void Main()
        {
            int[] arr = { 1, 2, 3 };
            int min = arr.Min();
            int max = arr.Max();

            Console.WriteLine($"Min Value : {min}, Max Value : {max}");
        }
    }
}
