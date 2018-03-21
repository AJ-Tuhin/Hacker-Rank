using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day9Recursion
{
    class Program
    {
        static int factorial(int n)
        {
            int factorial = 1;
            for (int i = n; i >= 1; i--)
            {
                factorial *= i;
            }
            return factorial;
        }

        static void Main(String[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int result = factorial(n);
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
