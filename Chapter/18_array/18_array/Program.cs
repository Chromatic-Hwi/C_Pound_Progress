using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_array
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("<array>");
            var array = new string[] { "apple", "banana", "cranberry" };
            foreach (var arr in array) { Console.WriteLine(arr); }
            Console.WriteLine();

            Console.WriteLine("<list>");
            var list = new List<string> { "apple", "banana", "cranberry" };
            foreach (var item in list) { Console.WriteLine(item); }
            Console.WriteLine();

            Console.WriteLine("<dicitonary>");
            var dictionary = new Dictionary<int, string> 
            {
                {0, "apple"}, {1, "banana"}, {2, "cranberry"}
            };
            foreach (var pair in dictionary) { Console.WriteLine($"{pair.Key} - {pair.Value}"); }
        }
    }
}
