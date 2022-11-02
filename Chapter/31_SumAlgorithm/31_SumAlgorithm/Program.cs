using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31_SumAlgorithm
{
    class Program
    {
        static void Main()
        {
            int[] scores = { 100, 75, 50, 37, 90, 95 };
            int sum = 0;

            for (int i = 0; i < scores.Length; i++)
            {
                if (scores[i] >= 80)
                {
                    sum += scores[i];
                }
            }

            Console.WriteLine($"{scores.Length}명의 점수 중 80점 이상 총점 : {sum}");
        }
    }
}
