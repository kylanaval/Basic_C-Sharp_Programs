
using System; // Allows us to use Console for input and output.
using System.Collections.Generic; // Allows us to create generic lists.
using Generics_Assignment; // Allows us to access the Employee class.

namespace Generics_Assignment // Defines the namespace for the program.
{
    class Program // Declares the Program class.
    {
        static void Main(string[] args) // The Main method is where the program starts.
        {
            // Creates an Employee object that uses string as its generic type.
            Employee<string> stringEmployee = new Employee<string>();

            // Assigns a list of strings to the Things property.
            stringEmployee.Things = new List<string>
            {
                "Laptop", // First string item.
                "Keyboard", // Second string item.
                "Mouse" // Third string item.
            };

            // Prints a heading before displaying the string items.
            Console.WriteLine("String Things:");

            // Loops through each string stored in the Things list.
            foreach (string thing in stringEmployee.Things)
            {
                // Prints the current string item to the console.
                Console.WriteLine(thing);
            }

            // Creates an Employee object that uses int as its generic type.
            Employee<int> intEmployee = new Employee<int>();

            // Assigns a list of integers to the Things property.
            intEmployee.Things = new List<int>
            {
                10, // First integer item.
                20, // Second integer item.
                30 // Third integer item.
            };

            // Prints a heading before displaying the integer items.
            Console.WriteLine("\nInteger Things:");

            // Loops through each integer stored in the Things list.
            foreach (int thing in intEmployee.Things)
            {
                // Prints the current integer item to the console.
                Console.WriteLine(thing);
            }

            // Keeps the console window open until the user presses Enter.
            Console.WriteLine("\nPress Enter to exit.");
            Console.ReadLine();
        }
    }
}