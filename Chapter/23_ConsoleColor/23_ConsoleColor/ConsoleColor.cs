using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23_ConsoleColor
{
    class ConsoleColor
    {
        static void Main()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.ResetColor();
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.ResetColor();
        }
    }
}
