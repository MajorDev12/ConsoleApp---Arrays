using System;
using System.Collections.Generic;


namespace ConsoleApp___Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // arrays, lists, collection
            var names = new List<string> { "major", "peter", "Collins", "joyce" };

            while (true)
            {
                Console.WriteLine("Please enter the name: ");
                string searchName = Console.ReadLine();
                bool found = false;

                // Loop through the list to find the exact match
                for (int i = 0; i < names.Count; i++)
                {
                    if (names[i].Equals(searchName, StringComparison.OrdinalIgnoreCase))
                    {
                        // Print the index if a match is found
                        Console.WriteLine($"{searchName} is at index {i}");
                        found = true; 
                        break; 
                    }
                }

                // If the name was found, exit the search loop
                if (found)
                {
                    break;
                }
                else
                {
                    // Prompt the user to try again if the name wasn't found
                    Console.WriteLine("Not Found!! Try again.");
                }
            }

            // Wait for user input before closing the console
            Console.ReadKey();
        }
    }
}
