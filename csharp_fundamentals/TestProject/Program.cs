using System.Net.Http.Headers;

Random dice = new();
int roll1 = dice.Next();
int roll2 = dice.Next(101);
int roll3 = dice.Next(50, 101);

Console.WriteLine($"Frist roll: {roll1}");
Console.WriteLine($"Second roll: {roll2}");
Console.WriteLine($"Third roll: {roll3}");


int firstValue = 500;
int secondValue = 600;
int largerValue = Math.Max(firstValue, secondValue);

Console.WriteLine($"The large number of {firstValue} and {secondValue} is {largerValue}");


int[] numbers = new int[3];
numbers[0] = 5;
numbers[1] = 7;
numbers[2] = 9;

// simplified int[] numbers = [5, 7, 9];

foreach (int number in numbers) {
    if (number % 2 == 0) {
        Console.WriteLine($"The number {number} is even!");
    } else {
        Console.WriteLine($"The number {number} is odd.");
    }
}