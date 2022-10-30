using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_continue
{
    class Program
    {
        static void Main()
        {
            for (int i = 1; i <= 10; i++)
            {
                if (i % 2 == 0){continue;}
                Console.WriteLine(i);
            }
        }
    }
}
