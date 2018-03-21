using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8DictionariesAndMaps
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            Dictionary<string, string> PhoneBook = new Dictionary<string, string>();

            for (int i = 0; i < n; i++)
            {
                var a = Console.ReadLine().Split(' ');
                PhoneBook.Add(a[0], a[1]);
            }

            for (int i = 0; i < n; i++)
            {
                var b = Console.ReadLine();
                if (PhoneBook.ContainsKey(b))
                {
                    Console.WriteLine(b + "=" + PhoneBook[b]);
                }
                else
                {
                    Console.WriteLine("Not found");
                }
            }
            
            Console.ReadKey();
        }
        
    }
}
