﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4ClassVsInstance
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        class Person
        {
            public int age;

            public Person(int initialAge)
            {
                if (initialAge < 0)
                {
                    age = 0;
                    Console.WriteLine("Age is not valid, setting age to 0.");
                }
                else
                {
                    age = initialAge;
                }
            }

            public void amIOld()
            {
                if (age < 13)
                {
                    Console.WriteLine("You are young.");
                }
                else if (age >= 13 && age < 18)
                {
                    Console.WriteLine("You are a teenager.");
                }
                else
                {
                    Console.WriteLine("You are old.");
                }
            }

            public void yearPasses()
            {
                age = age + 1;
            }
        }
    }
}
