using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27_ArrayClass
{
    class ArrayClass
    {
        static void Main()
        {
            int[] arr = { 3, 2, 1, 4, 5 };
            Array.Sort(arr);
            foreach (var item in arr) { Console.WriteLine(item); }
            Console.WriteLine();

            int[] arr2 = { 5, 4, 3, 2, 1 };
            Array.Reverse(arr2);
            foreach (var item in arr2) { Console.WriteLine(item); }
        }
    }
}
