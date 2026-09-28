using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // --------------------------------------------------
        // PART 1: One-dimensional array of strings
        // --------------------------------------------------

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

        // Display each updated string
        Console.WriteLine("\nUpdated strings:");

        foreach (string word in words)
        {
            Console.WriteLine(word);
        }


        // --------------------------------------------------
        // PART 2: Loop using the < operator
        // --------------------------------------------------

        Console.WriteLine("\nLoop using < operator:");

        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("Number: " + i);
        }


        // --------------------------------------------------
        // PART 3: Loop using the <= operator
        // --------------------------------------------------

        Console.WriteLine("\nLoop using <= operator:");

        for (int i = 0; i <= 5; i++)
        {
            Console.WriteLine("Number: " + i);
        }


        // --------------------------------------------------
        // PART 4: List with duplicate strings
        // --------------------------------------------------

        // Create a list that contains duplicate strings
        List<string> names = new List<string>
        {
            "John",
            "Mary",
            "David",
            "Mary",
            "Sarah",
            "Michael",
            "Mary"
        };

        // Ask the user what text they want to search for
        Console.Write("\nEnter a name to search for: ");
        string searchText = Console.ReadLine();

        // Keep track of whether a match was found
        bool found = false;

        // Loop through every item in the list
        for (int i = 0; i < names.Count; i++)
        {
            // Check if the current list item contains the user's search text
            if (names[i].ToLower().Contains(searchText.ToLower()))
            {
                // Display the index where the matching text was found
                Console.WriteLine(
                    "Match found at index " + i + ": " + names[i]
                );

                // A match was found
                found = true;

                // There is NO break statement here.
                // This allows the loop to continue and find all matches.
            }
        }

        // After the loop, check if no matches were found
        if (!found)
        {
            Console.WriteLine(
                "Your input \"" + searchText + "\" is not on the list."
            );
        }

        // Keep the console window open
        Console.WriteLine("\nPress Enter to exit.");
        Console.ReadLine();
    }
}