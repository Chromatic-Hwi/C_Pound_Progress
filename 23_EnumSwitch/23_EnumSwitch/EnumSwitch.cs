using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23_EnumSwitch
{
    enum Animal { Chicken, Pig, Cow}
    class EnumSwitch
    {
        static void Main()
        {
            Animal animal = Animal.Pig;

            switch (animal)
            {
                case Animal.Chicken:
                    Console.WriteLine("닭");
                    break;
                case Animal.Pig:
                    Console.WriteLine("돼지");
                    break;
                case Animal.Cow:
                    Console.WriteLine("소");
                    break;
                default:
                    Console.WriteLine("기본값 설정 영역");
                    break;
            }
        }
    }
}
