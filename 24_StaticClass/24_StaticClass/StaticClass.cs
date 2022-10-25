using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24_StaticClass
{
    class StaticClass
    {
        static void StaticMethod() => Console.WriteLine("[1] 정적 메서드");
            void InstanceMethod() => Console.WriteLine("[2] 인스턴스 메서드");
        static void Main()
        {
            StaticClass.StaticMethod();
            StaticClass my = new StaticClass();
            my.InstanceMethod();
        }
    }
}
