using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Person
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public int age { get; set; }

        public void getFullName()
        {
            Console.WriteLine("My name is {0} {1} and I am {2} years old", firstName, lastName, age);
        }

    }
}
