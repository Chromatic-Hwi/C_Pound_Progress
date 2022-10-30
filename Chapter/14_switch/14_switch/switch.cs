using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_switch
{
    class Program
    {
        static void Main()
        {
            WriteLine("Type the number of your main programming language?");
            Write("1. C\t");
            Write("2. Python\t");
            Write("3. C#\t");
            Write("4. java\t");
            Write("5. etc\n");

            var choice = Convert.ToInt32(ReadLine());

            switch (choice)
            {
                case 1:
                    WriteLine("C!");
                    break;
                case 2:
                    WriteLine("Python!!");
                    break;
                case 3:
                    WriteLine("C#!");
                    break;
                case 4:
                    WriteLine("Java..!");
                    break;
                default:
                    WriteLine("Ok...");
                    break;

            }
        }
    }
}
