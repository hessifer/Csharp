using System;
using System.Collections.Generic;
using System.Linq;

namespace WorkingWithArraysListCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            var names = new List<string> { "Nagalot", "Charles", "Chloe", "Xaviera", "Cheeseburger" }; // generic - List<T> where T is a type such as string

            // loop over names with foreach
            foreach (var item in names)
            {
                Console.WriteLine($"Item: {item}");
            }

            if (names.Contains("Cheeseburger"))
            {
                Console.WriteLine($"Found Cheeseburger in the list of names.");
            }

            // loop over names with for
            for (int i = 0; i < names.Count; i++)
            {
                Console.WriteLine(names[i]);
            }

            // Add some values to names
            names.Add("Bill");
            names.Add("Bob");
            names.Add("Chucky");

            foreach (var item in names)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();

            // Sort the list in place
            names.Sort();
            foreach (var item in names)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();

            // Array of numbers
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            foreach (var item in numbers)
            {
                if (item % 2 == 0) // check if item (number) is even
                {
                    Console.WriteLine($"{item} is even.");
                }
            }

            // Get the index of Chloe in our names list
            Console.WriteLine($"Chloe was found at index {names.IndexOf("Chloe")} of our names list.");

            // If Spongebob is not in the names list we will get a -1 as the return value.
            var location = names.IndexOf("Spongebob");

            if (location >= 0)
            {
                Console.WriteLine("I found Spongebob!");
            }

            // Create a list of integers
            var fibonacciNumbers = new List<int> { 1, 1 };

            // Get the first 20 Fibonacci numbers
            for (int _ = 1; _ < 19; _++)
            {
                fibonacciNumbers.Add(fibonacciNumbers[^1] + fibonacciNumbers[^2]); // shortcut for indexing
            }

            foreach (var item in fibonacciNumbers)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();

            // Get the first 20 Fibonacci numbers
            var fibNumbers = new List<int> { 1, 1 };

            while (fibNumbers.Count < 20)
            {
                fibNumbers.Add(fibNumbers[^1] + fibNumbers[^2]); // shortcut for indexing
            }

            foreach (var item in fibNumbers)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
        }
    }
}
