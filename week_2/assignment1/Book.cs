using System;
using System.Collections.Generic;
using System.Text;

namespace assignment1
{
    class Book
    {
        public string title, author;
        public double price;

        public Book(string title, string author, double price)
        {
            this.title = title;
            this.author = author;
            this.price = price;
        }

        public virtual void Print()
        {
            Console.WriteLine(String.Format("[Book]'{0}' by {1}, {2:0.00}", this.title, this.author, this.price));
        }
    }
}
