using System;

namespace WorkingWithCommandLineArgs
{
    public class Program
    {
        private static void Main(string[] args)
        {
            /*
                The Main method is the entry point of an executable program; it is where the program control starts and ends.
                Main is declared inside a class or struct. Main must be static and it need not be public. (In the earlier 
                example, it receives the default access of private.) The enclosing class or struct is not required to be static.
                Main can either have a void, int, or, starting with C# 7.1, Task, or Task<int> return type.

                If and only if Main returns a Task or Task<int>, the declaration of Main may include the async modifier. Note 
                that this specifically excludes an async void Main method.
                
                The Main method can be declared with or without a string[] parameter that contains command-line arguments. When 
                using Visual Studio to create Windows applications, you can add the parameter manually or else use the 
                GetCommandLineArgs() method to obtain the command-line arguments. Parameters are read as zero-indexed command-line 
                arguments. Unlike C and C++, the name of the program is not treated as the first command-line argument in the args 
                array, but it is the first element of the GetCommandLineArgs() method.
                */
                Console.WriteLine(args.Length);

                // You can also use GetCommandLineArgs()
                /*
                The first element in the array contains the file name of the executing program. If the file name is not available, the first 
                element is equal to String.Empty. The remaining elements contain any additional tokens entered on the command line.

                The program file name can, but is not required to, include path information.

                Command line arguments are delimited by spaces. You can use double quotation marks (") to include spaces within an argument. 
                The single quotation mark ('), however, does not provide this functionality.

                If a double quotation mark follows two or an even number of backslashes, each proceeding backslash pair is replaced with one 
                backslash and the double quotation mark is removed. If a double quotation mark follows an odd number of backslashes, including 
                just one, each preceding pair is replaced with one backslash and the remaining backslash is removed; however, in this case 
                the double quotation mark is not removed.
            */
            string[] arguments = Environment.GetCommandLineArgs();

            Console.WriteLine($"Number of arguments: {arguments.Length}");
            foreach (var item in arguments)
            {
             Console.WriteLine($"Argument: {item}");   
            }
        }
    }
}
