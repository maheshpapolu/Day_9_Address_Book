﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Address_Book
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book System");
            ContactsRecord record = new ContactsRecord(); // Creating object of ContactRecord class
            record.Input(); // Calling a Input Method of ContactRecord Class
        }
    }
}
