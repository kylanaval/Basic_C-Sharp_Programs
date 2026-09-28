using System;

class Program
{
    static void Main()
    {
        // Create a one-dimensional array of strings
        string[] words = { "Hello", "Welcome", "Goodbye", "Thank you" };

        // Ask the user to enter some text
        Console.Write("Enter some text to add to each string: ");
        string userText = Console.ReadLine();

        // Add the user's text to the end of each string
        for (int i = 0; i < words.Length; i++)
        {
            words[i] = words[i] + " " + userText;
        }

        // Display the updated strings
        Console.WriteLine("\nUpdated strings:");

        foreach (string word in words)
        {
            Console.WriteLine(word);
        }

        // Loop using the LESS THAN (<) operator
        Console.WriteLine("\nLoop using < operator:");

        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("Number: " + i);
        }

        // Loop using the LESS THAN OR EQUAL TO (<=) operator
        Console.WriteLine("\nLoop using <= operator:");

        for (int i = 0; i <= 5; i++)
        {
            Console.WriteLine("Number: " + i);
        }

        Console.WriteLine("\nPress Enter to exit.");
        Console.ReadLine();
    }
}
