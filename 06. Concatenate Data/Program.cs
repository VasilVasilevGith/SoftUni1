﻿namespace _06._Concatenate_Data
{
    using System;
    internal class Program
    {
        //"You are <firstName> <lastName>, a <age>-years old person from <town>."
        static void Main(string[] args)
        {
           string firstName =Console.ReadLine();
            string lastName = Console.ReadLine();
            int  age  =int.Parse(Console.ReadLine());
            string town = Console.ReadLine();

            Console.WriteLine($"You are {firstName} {lastName}, a {age}-years old person from {town}.");
        }
    }
}