using System;
using System.Collections.Generic;
using System.Text;

namespace assignment1
{
    class Programmer
    {
        string name;
        Specialty member;

        public Programmer(string name)
        {
            this.name = name;
            this.member = Specialty.Unknown;
        }

        public Programmer(string name, Specialty member)
        {
            this.name = name;
            this.member = member;
        }

        public void Print()
        {
            Console.WriteLine("Name: {0}, Specialty: {1}", this.name, this.member);
        }
    }
}
