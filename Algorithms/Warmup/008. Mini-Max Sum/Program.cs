using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mini_Max_Sum
{
    class Program
    {
        static void miniMaxSum(long[] arr)
        {
            long[] result = new long[5];
            long result1 = 0;

            for (long i = 0; i < arr.Length; i++)
            {
                result1 += arr[i];
            }

            for (long i = 0; i < result.Length; i++)
            {
                result[i] = result1 - arr[i];
            }

            long small = result[0];
            foreach (long t in result)
            {
                if (t <= small)
                {
                    small = t;
                }
            }

            long big = result[0];
            foreach (long t in result)
            {
                if (t >= big)
                {
                    big = t;
                }
            }

            Console.Write(small + " " + big);
        }

        static void Main(String[] args)
        {
            string[] arr_temp = Console.ReadLine().Split(' ');
            long[] arr = Array.ConvertAll(arr_temp, long.Parse);
            miniMaxSum(arr);


            Console.ReadKey();
        }
    }
}
