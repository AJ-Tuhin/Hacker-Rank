using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day17MoreExceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator c = new Calculator();
            Console.WriteLine(c.power(3, 5));
            Console.WriteLine(Math.Pow(3, 5 ));
            Console.ReadKey();
        }
    }
    class Calculator
    {
        public int power(int n, int p)
        {
            int result = 1;
            if (n < 0 || p < 0)
            {
                throw new Exception("n and p should be non-negative");
            }
            else
            {
                for (int i = 1; i <= p; i++)
                {
                    result *= n;
                }
            }
                
            return result;
        }
    }
}
