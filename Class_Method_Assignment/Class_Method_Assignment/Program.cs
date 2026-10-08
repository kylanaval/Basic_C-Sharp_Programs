using System;

namespace Class_Method_Assignment
{
    // This class contains the Main method where the program starts.
    class Program
    {
        // The Main method is the starting point of the console application.
        static void Main(string[] args)
        {
            // Ask the user to enter a number.
            Console.Write("Enter a number: ");

            // Read the user's input and convert it to an integer.
            int dividend = Convert.ToInt32(Console.ReadLine());

            // Instantiate the MathOperations class.
            MathOperations math = new MathOperations();

            // Call the void method that divides the number by 2.
            math.MathOp(dividend);

            // Ask the user to enter a phrase.
            Console.Write("Input a phrase: ");
            string input = Console.ReadLine();

            // Call the method with an output parameter.
            string phrase = math.StringCounter(input, out int count);

            // Display the phrase returned by the method.
            Console.WriteLine(phrase);

            // Display the count returned through the output parameter.
            Console.WriteLine("Number of characters: " + count);

            // Call the overloaded version of StringCounter.
            Console.Write("Input another phrase: ");
            string input2 = Console.ReadLine();

            // The overloaded method returns the number of characters.
            int phrase2_len = math.StringCounter(input2);

            // Display the number of characters.
            Console.WriteLine("This phrase is: " + phrase2_len + " characters long");

            // Ask the user for another phrase.
            Console.Write("Input another phrase: ");
            string input3 = Console.ReadLine();

            // Call the static method.
            int i_count = MathOperations.IFinder(input3);

            // Display the number of i's found in the phrase.
            Console.WriteLine("This phrase has: " + i_count + " i's in it.");

            // Keep the console window open.
            Console.WriteLine("\nPress any key to exit.");
            Console.ReadKey();
        }
    }
}