using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_FunctionCall
{
    class FucntionCall
    {
        static void Msg(string message)
        {
            Console.WriteLine(message);
        }

        static double CircleArea(double radius)
        {
            ///<summary>
            /// 반지름을 입력 받아 원넓이를 구하는 함수. 데이터 형식 오류 때문에 double 로 만들어봤음.
            ///</summary>
            
            Console.Write("Type the radius >> ");
            radius = Convert.ToDouble(Console.ReadLine());
            double circle = radius * radius * 3.14f;
            return circle;
        }

        static void Main()
        {
            //for (int i = 0; i <= 2; i++) { Msg("parameter"); }
            Console.WriteLine(CircleArea(5));
        }
    }
}
