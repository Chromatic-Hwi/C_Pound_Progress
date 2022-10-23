using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22_StructArray
{
    struct BusinessCard
    {
        public string Name;
        public int Age;
    }
    class StructArray
    {
        static void Print(string name, int age) => Console.WriteLine($"{name}은(는) {age}살입니다.");
        static void Main()
        {
            BusinessCard biz;
            biz.Name = "Hwi";
            biz.Age = 27;
            Print(biz.Name, biz.Age);

            BusinessCard[] names = new BusinessCard[2];
            names[0].Name = "김길벗"; names[0].Age = 78;
            names[1].Name = "박위키"; names[1].Age = 42;

            for (int i = 0; i < names.Length; i++)
            {
                Print(names[i].Name, names[i].Age);
            }
        }
    }
}
