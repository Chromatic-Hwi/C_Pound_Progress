using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_goto
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("START");
        Start:
            Console.WriteLine("0, 1, 2 중 하나 입력 :\t");
            int chapter = Convert.ToInt32(Console.ReadLine());

            if (chapter == 1){ goto Chapter1;}
            else if (chapter == 2) { goto Chapter2;}
            else { goto End;}

        Chapter1:
            Console.WriteLine("1장입니다.");
            goto Start;
        Chapter2:
            Console.WriteLine("2장입니다.");

        goto Start;

        End: { Console.WriteLine("종료"); }
        }
    }
}
