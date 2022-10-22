using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_ZigZag
{
    class ZigZag
    {
        static void Main()
        {
            int[][] zagArray = new int[2][];

            zagArray[0] = new int[] { 1, 2 };
            zagArray[1] = new int[] { 3, 4, 5 };

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < zagArray[i].Length; j++)
                {
                    Console.Write($"{zagArray[i][j]}\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
