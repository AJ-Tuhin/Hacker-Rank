using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day12Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    class Person
    {
        protected string firstName;
        protected string lastName;
        protected int id;   

        public Person()
        {
            
        }

        public Person(string firstName, string lastName, int identification)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.id = identification;
        }

        public void PrintPerson()
        {
            Console.WriteLine("Name : " + lastName + ", " + firstName + "\nId : " + id);
        }

    }

    class  Student:Person
    {
        private int[] testScores;

        public Student()
        {
            
        }
        
        public Student(string firstName, string lastName, int id, int[] score): base(firstName,lastName,id)
        {
            this.testScores = score;
        }

        public char Calculate()
        {
            int sum = 0;
            char ch = 'A';

            for (int i = 0; i < testScores.Length; i++)
            {
                sum += testScores[i];

            }
            int total = sum/testScores.Length;


            if (total <= 100 && total >= 90)
            {
                ch = 'O';
            }
            else if (total < 90 && total >= 80)
            {
                ch = 'E';
            }
            else if (total < 80 && total >= 70)
            {
                ch = 'A';
            }
            else if (total < 70 && total >= 55)
            {
                ch = 'P';
            }
            else if (total < 55 && total >= 40)
            {
                ch = 'D';
            }
            else if (total < 40)
            {
                ch = 'T';
            }
            return ch;
        }
    }
}
