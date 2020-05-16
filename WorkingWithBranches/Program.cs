using System; // import the System library where Console is found

namespace WorkingWithBranches // namespace is used to group and organize your code and avoid namespace collision
{
    class Program // Blueprint or Structure for Program 
    {
        // Entry point for C# Program (You need one Main entry point)
        // string[] args - array of command line arguments (Does not include name of command)
        // void is the return type of Main (no return value in this case)
        // static - you do not need an instance of the class to execute
        static void Main(string[] args)
        {
            int a = 5;
            int b = 6;

            // check length of args
            Console.WriteLine($"Length of Commandline Arguments: {args.Length}");

            // if branch
            if (a + b > 10) // returns true of false
                Console.WriteLine("The answer is greater than 10."); // NOTE: multi-line if statements require {}
            else
                Console.WriteLine("The answer is NOT greater than 10.");
            
            // if-else branch
            if (b * a < 22)
            {
                Console.WriteLine("The product of b and a is less than 22.");
            }
            else
            {
                Console.WriteLine("The product of b and a is greater than 22.");
            }

            // if-else if-else branch
            string message = "all people seem to need data processing";

            if (message.StartsWith("people"))
            {
                Console.WriteLine("Starting with 'people'");
            }
            else if (message.StartsWith("cat"))
            {
                Console.WriteLine("Starting with 'cat'");
            }
            else if (message.StartsWith("sup"))
            {
                Console.WriteLine("Starting with 'sup'");
            }
            else
            {
                Console.WriteLine($"Starting with: {message.Split()[0]}"); // NOTE: here we use the Split() method from the string Class and display index 0
            }

            // logical AND '&&'
            if (message.StartsWith("all") && message.EndsWith("processing")) // both conditions need to be true
            {
                Console.WriteLine(message.ToUpper());
            }


            // logical OR '||'
            if (message.StartsWith("bob") || message.EndsWith("processing")) // one of the conditions need to be true
            {
                Console.WriteLine("It's Peanut Butter Jelly Time!");
            }
        }
    }
}
