
using System; // Provides basic classes such as Console for input and output.
using System.IO; // Provides classes for reading and writing text files.

namespace InputAssignment // Defines a namespace to organize this application.
{
    internal class Program // Defines the main Program class.
    {
        static void Main(string[] args) // The Main method is where the program starts.
        {
            // Display a message asking the user to enter a number.
            Console.Write("Please enter a number: ");

            // Read the user's input from the console and store it as a string.
            string userInput = Console.ReadLine();

            // Define the name of the text file where the number will be saved.
            string fileName = "numbers.txt";

            // Write the user's input to the text file.
            // If the file does not exist, it will be created.
            // If the file already exists, its previous contents will be overwritten.
            File.WriteAllText(fileName, userInput);

            // Display a message confirming that the number was saved.
            Console.WriteLine("\nYour number has been saved to the text file.");

            // Read all the text stored in the file and save it in a string variable.
            string fileContents = File.ReadAllText(fileName);

            // Display a heading before printing the contents of the text file.
            Console.WriteLine("\nContents of the text file:");

            // Print the contents of the text file to the console.
            Console.WriteLine(fileContents);

            // Pause the program so the user can see the output before closing.
            Console.WriteLine("\nPress any key to exit.");
            Console.ReadKey();
        }
    }
}
