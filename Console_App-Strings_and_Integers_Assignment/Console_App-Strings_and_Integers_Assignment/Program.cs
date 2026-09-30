
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create a list of integers that will be divided by the user's number.
        List<int> numbers = new List<int> { 10, 20, 30, 40, 50 };

        // Display a title for the program.
        Console.WriteLine("Console App Strings and Integers Assignment");
        Console.WriteLine("------------------------------------------");

        // Ask the user to enter a number to divide each integer by.
        Console.Write("Enter a number to divide each number in the list by: ");

        // Start a try block to handle possible errors from the user's input
        // and from dividing the integers.
        try
        {
            // Read the user's input as a string.
            string userInput = Console.ReadLine();

            // Convert the user's string input into an integer.
            // This can cause a FormatException if the user enters text.
            int divisor = Convert.ToInt32(userInput);

            // Display the number that the user entered.
            Console.WriteLine();
            Console.WriteLine("You entered: " + divisor);
            Console.WriteLine("Results:");

            // Loop through every integer in the list.
            foreach (int number in numbers)
            {
                // Divide the current number by the user's number.
                // If the divisor is zero, this causes a DivideByZeroException.
                int result = number / divisor;

                // Display the original number and the division result.
                Console.WriteLine(number + " / " + divisor + " = " + result);
            }
        }
        // Catch an error caused when the user enters zero.
        catch (DivideByZeroException)
        {
            // Display an appropriate message explaining the error.
            Console.WriteLine("Error: You cannot divide a number by zero.");
        }
        // Catch an error caused when the user enters text instead of a number.
        catch (FormatException)
        {
            // Display an appropriate message explaining the error.
            Console.WriteLine("Error: Please enter a valid number, not a string.");
        }
        // Catch any other unexpected errors.
        catch (Exception ex)
        {
            // Display the error message from the exception.
            Console.WriteLine("An unexpected error occurred: " + ex.Message);
        }

        // This message is outside the try/catch block.
        // It proves that the program continued executing after the try/catch block.
        Console.WriteLine();
        Console.WriteLine("The program has emerged from the try/catch block.");
        Console.WriteLine("Program execution has continued.");

        // Pause the program so the user can see the results.
        Console.WriteLine();
        Console.WriteLine("Press any key to exit.");
        Console.ReadKey();
    }
}