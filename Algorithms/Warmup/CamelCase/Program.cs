using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CamelCase
{
    class Program
    {
        static int camelcase(string s)
        {
            int a = 1;
            char[] s1 = s.ToCharArray();

            foreach (char t in s1)
            {
                if (t <= 'Z' && t >= 'A')
                {
                    a++;
                }
            }
            return a;
        }

        static void Main(String[] args)
        {
            string s = Console.ReadLine();
            int result = camelcase(s);
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
