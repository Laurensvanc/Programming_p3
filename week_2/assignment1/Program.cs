using System;
using System.Globalization;
using System.Threading;

namespace assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            Program mainProgram = new Program();
            mainProgram.Start();
        }

        void Start()
        {
            // set culture of program
            CultureInfo ci = new CultureInfo("en-US");
            Thread.CurrentThread.CurrentCulture = ci;
            Thread.CurrentThread.CurrentCulture = ci;

            Book book_1 = new Book("Dracula", "Bram Stoker", 15.00);
            Book book_2 = new Book("Joe speedboot", "Tommy Wieringa", 12.50);
            Book book_3 = new Book("The hobbit", "J.R.R. Tolkien", 12.50);

            Magazine mag_1 = new Magazine("Time", "Bob", 3.90, "Friday");
            Magazine mag_2 = new Magazine("Donald Duck", "Beb", 2.50, "Thursday");

            BookStore bookStore_1 = new BookStore();

            bookStore_1.Add(book_1);
            bookStore_1.Add(book_2);
            bookStore_1.Add(mag_1);
            bookStore_1.Add(mag_2);
            bookStore_1.Add(book_3);
            
            

            bookStore_1.PrintCompleteStock();
        }
    }
}
