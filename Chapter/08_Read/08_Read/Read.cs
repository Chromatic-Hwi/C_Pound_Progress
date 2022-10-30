using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Read
{
    /*
    class Read
    {
        static void Main(string[] args)
        {
            Console.Write("Type message>> ");
            string msg = Console.ReadLine();
            Console.WriteLine($"Your message is \"{msg}\"");
        }
    }*/

    /*
    class IntToByte
    {
        static void Main()
        {
            int x = 255;
            byte y = (byte)x;

            Console.WriteLine($"{x} => {y}");
        }
    }*/

    class BinaryString
    {
        static void Main()
        {
            Console.Write("Type origin number>> ");
            string x = Console.ReadLine();
            int y = Convert.ToInt32(x);
            Console.WriteLine($"You typed {y}\n");

            string yB = Convert.ToString(y, 2).PadLeft(8, '0');
            Console.Write("Your number\'s type is converted to ");
            Console.WriteLine("\'"+yB.GetType()+"\'\n");
            Console.Write("Converted binary number => ");
            Console.WriteLine(yB+"\n");

            byte b1 = 0b0010;
            Console.WriteLine(b1);
        }
    
    }
}
