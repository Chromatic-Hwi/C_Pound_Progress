using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Number_Data
{
    class Number
    {
        static void Main(string[] args)
        {
            sbyte iSByte = 127;//이게 한계값이네 나는 180 값 넣었다가 할당 안되서 에러남.
            short iInt16 = 32_000; //여기도 마찬가지.
            int iInt32 = 123_456_789;
            long iInt64 = 132156416165156;

            float f = 3.14F;
            double d = 3.14D;
            decimal m = 3.14M;

            Console.WriteLine(iSByte);
            Console.WriteLine(iInt16);
            Console.WriteLine(iInt32);
            Console.WriteLine(iInt64);

            Console.WriteLine(f);
            Console.WriteLine(d);
            Console.WriteLine(m);
        }
    }
}
