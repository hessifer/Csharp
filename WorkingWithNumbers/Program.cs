using System;

namespace WorkingWithNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 6;
            int c = 9;
            double d = 10.0;

            // Display the values of a b c
            Console.Write($"a: {a}\nb: {b}\nc: {c}\nd: {d}\n\n");
            
            // Addition
            Console.WriteLine($"Sum of a + b + c is: {a + b + c}");
            
            // Multiplication
            Console.WriteLine($"Product of a * b * c is: {a * b * c}");
            
            // Order of Operations
            Console.WriteLine($"a + b * c is: {a + b * c}"); // NOTE: Order of operation matters PEMDAS
            Console.WriteLine($"(a + b) * c is: {(a + b) * c}");

            // Integer Division
            Console.WriteLine($"c / a is: {c / a}"); // NOTE: Integer division used here

            // Division
            Console.WriteLine($"d / a is: {d / a}");
            Console.WriteLine($"d / b is: {d / b}"); // NOTE: Division with a double and an int

            // Modulo
            Console.WriteLine($"The remainder of d / b is: {d % b}");

            // Max Value of int
            Console.WriteLine($"Max Value of int: {int.MaxValue:N}"); // NOTE use of ':N' for formatting numeric strings

            // Min Value of int
            Console.WriteLine($"Min Value of int: {int.MinValue:N}");

            // Example of Overflow where we wrap around from the Max Value of int to the Min Value
            // Console.WriteLine($"Overflow of Max Value to Min Value: {int.MaxValue + 3}"); // -2,147,483,646

            // Max Value of a double
            Console.WriteLine($"Max Value of double: {double.MaxValue:N}");

            // Min Value of a double
            Console.WriteLine($"Min Value of double: {double.MinValue}");

            // Max Value of decimal
            Console.WriteLine($"Max Value of decimal: {decimal.MaxValue}");

            // Min Value of decimal
            Console.WriteLine($"Min Value of decimal: {decimal.MinValue}");

            // Max Value of long
            Console.WriteLine($"Max Value of long: {long.MaxValue}");

            // Min Value of long
            Console.WriteLine($"Min Value of long: {long.MinValue}");

            // Max Value of short
            Console.WriteLine($"Max Value of short: {short.MaxValue}");

            // Min Value of short
            Console.WriteLine($"Min Value of short: {short.MinValue}");

            // Determine Radius of a Circlt using the Math Class and the constant PI
            double radius = 2.50;
            double area = Math.PI * radius * radius;

            Console.WriteLine($"The area is: {area}");

        }
    }
}
