using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_Array_Sum
{
    class Program
    {
        static int SimpleArraySum(int n, int[] ar)
        {
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                sum = sum + ar[i];
            }
            return sum;
        }

        static void Main(String[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] arTemp = Console.ReadLine().Split(' ');
            int[] ar = Array.ConvertAll(arTemp, Int32.Parse);
            int result = SimpleArraySum(n, ar);
            Console.WriteLine(result);
        }
    }
}
