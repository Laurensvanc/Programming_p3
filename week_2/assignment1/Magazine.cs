using System;
using System.Collections.Generic;
using System.Text;

namespace assignment1
{
    class Magazine : Book
    {
        public string release;

        public Magazine(string title, string author, double price, string release) : base(title, author, price)
        {
            this.release = release;
        }

        public override void Print()
        {
            Console.WriteLine(String.Format("[Magazine] {0} - release day:{1}, {2:0.00}", this.title, this.release, this.price));
        }
    }
}
