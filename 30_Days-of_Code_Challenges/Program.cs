using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day13AbstractClasses
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    abstract class Book
    {
        protected string title;
        protected string author;

        public Book(string t, string a)
        {
            title = t;
            author = a;
        }

        public abstract void Display(); 
    }

    class MyBook:Book
    {
        private int price = 0;

        public MyBook(string title, string authore, int price) : base(title, authore)
        {
            this.price = price;
        }
        public override void Display()
        {
           Console.WriteLine("Title: {0} \nAuthor: {1} \nPrice: {2}", title, author, price); 
        }
    }
}
