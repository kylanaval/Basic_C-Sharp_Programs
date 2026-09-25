using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Create a one-dimensional array of strings.
        string[] names = { "John", "Mary", "David", "Sarah", "Michael" };

        // Display the available string array indexes.
        Console.WriteLine("String Array");
        Console.WriteLine("Available indexes: 0 - 4");

        // Ask the user to enter an index.
        Console.Write("Enter an index: ");
        int stringIndex = Convert.ToInt32(Console.ReadLine());

        // Check if the selected index exists in the string array.
        if (stringIndex >= 0 && stringIndex < names.Length)
        {
            // Display the string stored at the selected index.
            Console.WriteLine("String at that index: " + names[stringIndex]);
        }
        else
        {
            // Display an error message if the index does not exist.
            Console.WriteLine("That index does not exist in the string array.");
        }

        Console.WriteLine();


        // Create a one-dimensional array of integers.
        int[] numbers = { 10, 20, 30, 40, 50 };

        // Display the available integer array indexes.
        Console.WriteLine("Integer Array");
        Console.WriteLine("Available indexes: 0 - 4");

        // Ask the user to enter an index.
        Console.Write("Enter an index: ");
        int numberIndex = Convert.ToInt32(Console.ReadLine());

        // Check if the selected index exists in the integer array.
        if (numberIndex >= 0 && numberIndex < numbers.Length)
        {
            // Display the integer stored at the selected index.
            Console.WriteLine("Integer at that index: " + numbers[numberIndex]);
        }
        else
        {
            // Display an error message if the index does not exist.
            Console.WriteLine("That index does not exist in the integer array.");
        }

        Console.WriteLine();


        // Create a List of strings.
        List<string> fruits = new List<string>()
        {
            "Apple",
            "Banana",
            "Orange",
            "Mango",
            "Strawberry"
        };

        // Display the available list indexes.
        Console.WriteLine("String List");
        Console.WriteLine("Available indexes: 0 - 4");

        // Ask the user to enter an index.
        Console.Write("Enter an index: ");
        int listIndex = Convert.ToInt32(Console.ReadLine());

        // Check if the selected index exists in the list.
        if (listIndex >= 0 && listIndex < fruits.Count)
        {
            // Display the string stored at the selected index.
            Console.WriteLine("Item at that index: " + fruits[listIndex]);
        }
        else
        {
            // Display an error message if the index does not exist.
            Console.WriteLine("That index does not exist in the string list.");
        }

        // Pause the program so the user can see the results.
        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
    }
}