using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1Data_Types
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            double d = 4.0;
            string s = "Heaker Rank";
            int a;
            double b; 
            string c;
            // Read and save an integer, double, and String to your variables.
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToDouble(Console.ReadLine());
            c = Console.ReadLine();
            // Print the sum of both integer variables on a new line.
            Console.WriteLine(a + i);
            // Print the sum of the double variables on a new line.
            Console.WriteLine("{0:n1}",d + b);
            // Concatenate and print the String variables on a new line
            Console.WriteLine(s + c);
            Console.ReadKey();
        }
    }
}
