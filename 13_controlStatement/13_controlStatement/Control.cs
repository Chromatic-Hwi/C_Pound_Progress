using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_controlStatement
{
    class Control
    {
        static void Main()
        {
            Console.Write("Type number >> ");
            var number = Console.ReadLine();

            var number2 = Convert.ToInt32(number);

            if (number2 > 0)
            {
                Console.WriteLine($"{number2} bigger than 0");
            }
            else if (number2 < 0)
            {
                Console.WriteLine($"{number2} smaller than 0");
            }
            else
            {
                Console.WriteLine($"{number2} is 0");
            }
        }
    }
}
