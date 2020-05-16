using System;

namespace WorkingWithLoops
{
    class Program
    {
        static void Main()
        {
            int counter = 10;

            while (counter > 0) // run until counter is no longer greater than j0
            {
                Console.WriteLine(counter);
                counter--; // post decrement our counter
            }
            Console.WriteLine("Blast Off!");

            // do - while -> code executes at least once
            do
            {
                Console.WriteLine($"Counter Value: {counter}");
                counter++;
            } while (counter < 10);

            // for loops - most commonly used loop in C#
            for (int index = 0; index < 10; index++)
            {
                Console.WriteLine($"Index Value: {index}");
            }

            // Display the sum of all integers 1 - 20 that are NOT divisible by 3
            int sum = 0;

            for (int i = 1; i < 21; i++)
            {
                if (i % 3 != 0)
                {
                    sum += i;
                }
            }
            Console.WriteLine($"The sum of all integers betwee 1 - 20 that are NOT divisible by 3: {sum}");

            // Display the sum of all integers 1 - 20 that ARE divisible by 3
            int s = 0;

            for (int i = 1; i < 21; i++)
            {
                if (i % 3 == 0)
                {
                    s += i;
                }
            }
            Console.WriteLine($"The sum of all integers betwee 1 - 20 that ARE divisible by 3: {s}");
        }
    }
}
