using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day10BinaryNumbers
{
    class Program
    {
        static void Main(String[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            List<int> binary = new List<int>();
            int b = 0;
            int c = 0;
            int d = 0;

            for (int i = n; i > 0; i = i / 2)
            {
                int mod = i%2;
                binary.Add(mod);
            }

            binary.Reverse();

            foreach (int i in binary)
            {
                if (i == 0)
                {
                    c = b;
                    b = 0;
                    if (c > d)
                    {
                        d = c;
                    }
                    continue;
                }
                else
                {
                    b++;
                }
            }
            Console.WriteLine(b > d ? b : d);

            Console.ReadKey();
        }
    }
}
