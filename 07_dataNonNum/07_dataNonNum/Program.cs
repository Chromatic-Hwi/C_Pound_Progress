using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_dataNonNum
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            char grade = 'A';
            char kor = '가';
            string name = "김성모";
            Console.WriteLine(grade);
            Console.WriteLine(kor);
            Console.WriteLine(name);
            */

            int phoneNum = 222_3456;
            string name = "Hwi";
            string msg = @"Welcome!
C# class!";
            bool pass = true;
            Console.WriteLine($"{DateTime.Now}\n\nGreetings! {name}\n\nWe check your P.H as {phoneNum}\n{msg}\nYour test condition is {pass}");
        }
    }
}
