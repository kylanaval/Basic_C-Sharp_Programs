
using System; // Imports basic C# functionality, including DateTime and Console.

namespace DatetimeAssignment // Groups the code under a namespace named DatetimeAssignment.
{
    internal class Program // Defines the Program class that contains the application.
    {
        static void Main(string[] args) // The Main method is the starting point of the console application.
        {
            // Gets the current date and time from the computer's system clock.
            DateTime currentDateTime = DateTime.Now;

            // Prints the current date and time to the console.
            Console.WriteLine("Current date and time: " + currentDateTime);

            // Asks the user to enter the number of hours to add.
            Console.Write("Enter the number of hours: ");

            // Reads the user's input as a string from the console.
            string userInput = Console.ReadLine();

            // Attempts to convert the user's input into a decimal number.
            // Using decimal allows the user to enter partial hours, such as 1.5.
            if (decimal.TryParse(userInput, out decimal hours))
            {
                // Adds the specified number of hours to the current date and time.
                DateTime futureDateTime = currentDateTime.AddHours((double)hours);

                // Prints the calculated future date and time in a readable format.
                Console.WriteLine(
                    $"The date and time in {hours} hour(s) will be: " +
                    futureDateTime.ToString("MMMM dd, yyyy hh:mm:ss tt"));
            }
            else
            {
                // Displays an error message if the user enters an invalid number.
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }

            // Pauses the console so the user can read the output before closing.
            Console.WriteLine("Press any key to exit.");

            // Waits until the user presses a key.
            Console.ReadKey();
        }
    }
}