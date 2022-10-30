using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26_ExceptionDemo
{
    class ExceptionDemo
    {
        static void Main()
        {
            try
            {
                int[] arr = new int[2];
                arr[100] = 1234;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
