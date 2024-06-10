using System;
using System.Collections.Generic;


namespace ConsoleApp___Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // arrays, lists, collection
            var numbers = new List<int> {1, 1};

            while(numbers.Count <= 20)
            {
                var previousNumber = numbers[numbers.Count - 1];
                var previousNumber2 = numbers[numbers.Count - 2];
                int total = previousNumber + previousNumber2;
                Console.WriteLine($"{previousNumber} and {previousNumber2} = {total}");

                numbers.Add(previousNumber + previousNumber2);
            }
            Console.ReadKey();
            
        }
    }
}
