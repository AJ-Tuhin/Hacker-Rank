using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plus_Minus
{
    class Program
    {
        static void plusMinus(int n, int[] arr)
        {
            decimal pS = 0;
            decimal nS = 0;
            decimal zS = 0; 
            foreach (decimal i in arr)
            {
                if (i > 0)
                {
                    pS ++;
                }
                if (i < 0)
                {
                    nS ++;
                }
                if(i == 0)
                {
                    zS ++;
                }
            }
            decimal pSDecimal = pS/n;
            decimal nSDecimal = nS/n;
            decimal zSDecimal = zS/n;

            Console.WriteLine(pSDecimal.ToString("N6"));
            Console.WriteLine(nSDecimal.ToString("N6"));
            Console.WriteLine(zSDecimal.ToString("N6"));
        }

        static void Main(String[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] arr_temp = Console.ReadLine().Split(' ');
            int[] arr = Array.ConvertAll(arr_temp, Int32.Parse);
            plusMinus(n, arr);
            Console.ReadKey();
        }
    }
}
