
using System;

namespace Parsing_Enums_Assignment
{
    // Create an enum that represents the seven days of the week.
    // Each name is a constant value that can be used as a day.
    public enum DaysOfWeek
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }

    // The Program class contains the entry point of the application.
    class Program
    {
        // The Main method runs when the console application starts.
        static void Main(string[] args)
        {
            // Ask the user to enter the current day of the week.
            Console.WriteLine("Please enter the current day of the week:");

            // Read the user's input from the console and store it as a string.
            string input = Console.ReadLine();

            // Use a try block to attempt to convert the user's input
            // into a value from the DaysOfWeek enum.
            try
            {
                // Parse the input string into the DaysOfWeek enum.
                // If the input is not a valid day, an exception is thrown.
                DaysOfWeek currentDay = Enum.Parse<DaysOfWeek>(input, true);

                // Display the successfully parsed day to the console.
                Console.WriteLine("Have a nice " + currentDay);
            }
            catch (Exception)
            {
                // Display this message if the input cannot be parsed
                // into a valid day of the week.
                Console.WriteLine(
                    "Please enter an actual day of the week.");
            }

            // Keep the console window open until the user presses a key.
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}