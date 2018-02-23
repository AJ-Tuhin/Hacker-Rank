using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grading_Students
{
    class Program
    {
        static int[] solve(int n, int[] grades)
        {
            int[] final = new int[n];

            for (int i = 0; i < grades.Length; i++)
            {
                if (grades[i] >= 38)
                {
                    int r = grades[i] % 5;
                    int f = grades[i] / 5;
                    if (r >= 3)
                    {
                        final[i] = (f + 1) * 5;
                    }
                    else
                    {
                        final[i] = grades[i];
                    }
                }
                else
                {
                    final[i] = grades[i];
                }

            }
            return final;
        }

        static void Main(String[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int[] grades = new int[n];
            for (int grades_i = 0; grades_i < n; grades_i++)
            {
                grades[grades_i] = Convert.ToInt32(Console.ReadLine());
            }
            int[] result = solve(n, grades);
            Console.WriteLine(String.Join("\n", result));
            Console.ReadKey();

        }
    }
}
