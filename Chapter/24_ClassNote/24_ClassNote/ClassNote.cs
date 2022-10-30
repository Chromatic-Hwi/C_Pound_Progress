using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24_ClassNote
{
    class ClassNote
    {
        static void Run()
        {
            Console.WriteLine("ClassNote 클래스의 Run 메서드");
        }
        static void Main()
        {
            Run(); //매서드 레벨 : 같은 클래스의 메서드 호출
            ClassNote.Run(); // 클래스 레벨 : 클래스.메서드(); 형태로 호출. 다른 클래스에 있는 메서드는 이렇게 호출.
        }
    }
}
