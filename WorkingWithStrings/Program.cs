using System;

namespace WorkingWithStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            // use the keyword 'string' to identify the type
            string firstName = "charles";
            string greeting = "     Nagalot     ";
            string phrase = "All - Work - & - No - Play";

            // Display firstName to the console as is.
            Console.WriteLine($"First Name: {firstName}");

            // Display firstName to the console in all caps.
            Console.WriteLine($"First Name: {firstName.ToUpper()}");

            // Display greeting with whitespaces.
            Console.WriteLine($"Whitespaces: [{greeting}]");

            // Display greeting with whitespace removed from the start of the string.
            Console.WriteLine($"Whitespace Removed from Start: [{greeting.TrimStart()}]");

            // Display greeting with whitespace removed from the end.
            Console.WriteLine($"Whitespace Removed from End: [{ greeting.TrimStart()}]");

            // Display greeting with whitespace removed from both the start and end of the string.
            Console.WriteLine($"Whitespace Removed from Both Start and End: [{greeting.Trim()}]");

            // Display the length of the string firstName.
            Console.WriteLine($"Length of First Name: {firstName.Length}"); // NOTE: Length is a property and NOT a method

            // Display the length of the string greeting.
            Console.WriteLine($"Length of Greeting: {greeting.Length}"); // NOTE: Length returns the number of chars which includes spaces

            // Replace the '-' with '+' in the string phrase.
            Console.WriteLine($"Phrase Modified: {phrase.Replace('-', '+')}"); // NOTE: This will replace ALL occurrences but not in place (see below)
            Console.WriteLine($"Phrase: {phrase}"); // NOTE: a copy of pharse above was modified NOT the original phrase

            // Search for a string inside of another string
            Console.WriteLine($"Does the word 'work' appear in phrase: {phrase.Contains("work")}"); // NOTE: case sensitivity

            // Search for a string inside of another string
            Console.WriteLine($"Does the word 'Work' appear in phrase: {phrase.Contains("Work")}"); // NOTE: case sensitivity

            // Check if a string starts with another string
            Console.WriteLine($"Does phrase start with 'B': {phrase.StartsWith('B')}");

            // Check if a string starts with another string
            Console.WriteLine($"Does phrase start with 'All': {phrase.StartsWith("All")}");

            // Check if a string ends with another string
            Console.WriteLine($"Does phrase end with 'Play': {phrase.EndsWith("Play")}");

        }
    }
}
