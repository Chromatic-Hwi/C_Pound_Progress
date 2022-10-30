using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_arrayStudent
{
    class ArrayStudent
    {
        static void Main()
        {
            int[] students = new int[3];

            students[0] = Convert.ToInt32(Console.ReadLine());
            students[1] = Convert.ToInt32(Console.ReadLine());
            students[2] = Convert.ToInt32(Console.ReadLine());

            int total = students[0] + students[1] + students[2];
            Console.WriteLine($"Total sum >> {total}");
        }
    }
}
