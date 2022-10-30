using System;
using static System.Console;
using static System.Math;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_UsingStaticClasses
{
    class UsingStaticClasses
    {
        static void Two()
        {
            Write("Type the number to square\n>> ");
            var num = Convert.ToInt32(ReadLine());
            WriteLine(Math.Pow(num, 2));
        }

        static void Main()
        {
            Two();
        }
    }
}
