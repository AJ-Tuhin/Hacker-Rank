using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day25RunningTimeAndComplexity
{
    class Program
    {
        static void Main(String[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[n];
            for(int i = 0; i < n; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
            }


            foreach(int i in a)
            {
                if (isPrime(i))
                {
                    Console.WriteLine("Prime");
                }
                else
                {
                    Console.WriteLine("Not Prime");
                }
            }
            
            Console.ReadKey();
        }
        public static bool isPrime(int n)
        {
            if (n == 2)
            {
                return true;
            }
            if (n == 1 || n % 2 == 0)
            {
                return false;
            }
            for (int i = 3; i * i <= n;)
            {
                if (n % i == 0)
                {
                    return false;
                }
                i += 2;
            }
            return true;
        }
    }
}
