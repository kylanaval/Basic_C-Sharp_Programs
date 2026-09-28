
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

        // Loop through the array and add the user's text
        for (int i = 0; i < words.Length; i++)
        {
            words[i] = words[i] + " " + userText;
        }

        // Display each updated string
        Console.WriteLine("\nUpdated strings:");

        foreach (string word in words)
        {
            Console.WriteLine(word);
        }

        // The infinite loop was fixed by using a condition that can become false.
        // The loop starts with continueLoop = true, but the user can enter "no"
        // to change it to false and stop the loop.
        bool continueLoop = true;

        while (continueLoop)
        {
            Console.Write("\nWould you like to continue? (yes/no): ");
            string answer = Console.ReadLine();

            if (answer.ToLower() == "no")
            {
                // Changing continueLoop to false stops the loop.
                continueLoop = false;
            }
            else
            {
                Console.WriteLine("The loop is still running.");
            }
        }

        Console.WriteLine("The loop has ended.");
        Console.ReadLine();
    }
}