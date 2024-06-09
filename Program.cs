using System;
using System.Collections.Generic;


namespace ConsoleApp___Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // arrays, lists, collection
            var names = new List<string> { "major", "simon", "janet", "kevin" };

            foreach (var name in names)
            {
                Console.WriteLine($"Hello {name.ToUpper()}!");
            }

        }
    }
}
