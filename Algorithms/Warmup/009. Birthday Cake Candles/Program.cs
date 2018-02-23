using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Birthday_Cake_Candles
{
    class Program
    {
        static int birthdayCakeCandles(int n, int[] ar)
        {
            int a = 0;
            int h = ar[0];
            foreach (int i in ar)
            {
                if (i >= h)
                {
                    h = i;
                }
            }
            foreach (int i in ar)
            {
                if (h == i)
                {
                    a++;
                }
            }
            return a;
        }

        static void Main(String[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] ar_temp = Console.ReadLine().Split(' ');
            int[] ar = Array.ConvertAll(ar_temp, Int32.Parse);
            int result = birthdayCakeCandles(n, ar);
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
