﻿using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static List<int> numList = new List<int>();

        static void Main(string[] args)
        {
            for(int i =0; i < 10; i++)
            {
                numList.Add(i);
            }

            int[] array = numList.ToArray();

            foreach(int i in array)
            {
                Console.WriteLine(i);
            }

            Person person = new Person();

            person.firstName = "Dan";
            person.lastName = "Le Lievre";
            person.age = 29;

            person.getFullName();

            Console.ReadLine();
        }
    }
}