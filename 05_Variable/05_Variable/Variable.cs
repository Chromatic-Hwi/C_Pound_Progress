using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Variable
{
    class Variable
    {
        static void Main(string[] args)
        {
            object word;

            int num0, num1, num2;
            num0 = 0;
            num1 = 1;
            num2 = 2;

            const int numStart = 20191223;

            word = "Hello";
            Console.WriteLine(100);
            Console.WriteLine(3.14f);
            Console.WriteLine("Literal");
            Console.WriteLine(word);
            Console.Write(num0);
            Console.Write(num1);
            Console.Write(num2);
            Console.WriteLine();
            Console.WriteLine(numStart);
        }
    }
}
