using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_2dArraySumAverage
{
    class Program
    {
        static void Main()
        {
            int[,] scores =
                {
                { 90, 100, 0, 0},
                { 80, 90, 0, 0},
                { 100, 80, 0, 0}
            };

            for (int i = 0; i < (scores.Length) / 4; i++)
            {
                scores[i, 2] = scores[i, 0] + scores[i, 1];
                scores[i, 3] = scores[i, 2] / 2;
            }
                Console.WriteLine("국어 영어 합계 평균");

            for (int i = 0; i < (scores.Length) / 4; i++)
            {
                for (int j = 0; j < (scores.Length) / 4 + 1; j++)
                {
                    Console.Write($"{scores[i, j],4}");
                }
                Console.WriteLine();
                //Console.WriteLine(scores.Length);
            }
        }
    }
}
