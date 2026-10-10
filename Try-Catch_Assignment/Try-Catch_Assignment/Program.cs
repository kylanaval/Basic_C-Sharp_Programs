
using System;

class Program
{
    static void Main(string[] args)
    {
        // Start a try block to handle any errors that may occur.
        try
        {
            // Ask the user to enter their age.
            Console.Write("Please enter your age: ");

            // Read the user's input and convert it to an integer.
            int age = Convert.ToInt32(Console.ReadLine());

            // Check if the age is zero.
            if (age == 0)
            {
                // Display an error message if the age is zero.
                Console.WriteLine("Error: Age cannot be zero.");
            }
            // Check if the age is a negative number.
            else if (age < 0)
            {
                // Display an error message if the age is negative.
                Console.WriteLine("Error: Age cannot be a negative number.");
            }
            else
            {
                // Get the current year from the system date.
                int currentYear = DateTime.Now.Year;

                // Calculate the approximate year the user was born.
                int birthYear = currentYear - age;

                // Display the calculated birth year to the user.
                Console.WriteLine("You were born approximately in the year "
                    + birthYear + ".");
            }
        }
        // Catch errors caused by invalid number input, such as letters.
        catch (FormatException)
        {
            // Display an appropriate message if the input is not a valid number.
            Console.WriteLine("Error: Please enter a valid whole number for your age.");
        }
        // Catch errors caused by a number that is too large or too small.
        catch (OverflowException)
        {
            // Inform the user that the entered number is outside the allowed range.
            Console.WriteLine("Error: The number entered is too large or too small.");
        }
        // Catch any other unexpected exceptions.
        catch (Exception)
        {
            // Display a general error message for any other unexpected problem.
            Console.WriteLine("An unexpected error occurred. Please try again.");
        }

        // Pause the program so the user can read the output before closing.
        Console.WriteLine("Press any key to exit.");
        Console.ReadKey();
    }
}
