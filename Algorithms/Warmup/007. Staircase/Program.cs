using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Staircase
{
    class Program
    {
        static void staircase(int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = n - 1; j >i; j--)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("#");
                }

                Console.WriteLine();
            }
        }

        static void Main(String[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            staircase(n);

            Console.ReadKey();
        }
    }
}
