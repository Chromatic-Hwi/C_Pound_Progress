using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22_StructDemo
{
    struct Point
    {
        public int X;
        public int Y;
    }
    class StructDemo
    {
        static void Main()
        {
            Point point;
            point.X = 100;
            point.Y = 200;
            Console.WriteLine($"X : {point.X}, Y : {point.Y}");
        }
    }
}
