using System;
using System.Collections.Generic;
using System.Text;

namespace assignment1
{
    class BookStore
    {
        List<Book> books = new List<Book>();

        public void Add(Book book)
        {
            books.Add(book);
        }

        public void PrintCompleteStock()
        {
            double totalSales = 0;

            for (int i = 0; i < books.Count; i++)
            {
                books[i].Print();
                totalSales += books[i].price;
            }

            Console.WriteLine(String.Format($"\nTotal sales price: {totalSales:0.00}"));
        }
    }
}
