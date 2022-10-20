using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_conditionalOperator
{
    class Conditional
    {
        static void Main()
        {
            Console.Write("Type number >> ");
            var number = Console.ReadLine();
            var number2 = Convert.ToInt32(number);

            string result = (number2 % 2 == 0) ? "짝수" : "홀수";

            Console.WriteLine($"{number}은(는) {result}입니다.");
        }
    }
}
