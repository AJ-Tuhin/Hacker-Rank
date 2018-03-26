using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day14Scope
{
    class Program
    {
        static void Main(string[] args)
        {
            Convert.ToInt32(Console.ReadLine());

            int[] a = Console.ReadLine().Split(' ').Select(x => Convert.ToInt32(x)).ToArray();

            Difference d = new Difference(a);

            d.computeDifference();

            Console.Write(d.maximumDifference);
            Console.ReadKey();
        }
    }

    class Difference
    {
        private int[] elements;
        public int maximumDifference;

        public Difference(int[] e)  
        {
            this.elements = e;
        }
        public int computeDifference()
        {
            int b = elements.Length - 1;
            for (int i = 0; i < elements.Length; i++)
            {
                int a;
                for (int j = b; j >= 0 ; j--)
                {
                    a = elements[i] - elements[j];
                    a = Math.Abs(a);
                    if (maximumDifference <= a)
                    {
                        maximumDifference = a;
                    }
                } 
            }
            return maximumDifference;
        }
    }
}
