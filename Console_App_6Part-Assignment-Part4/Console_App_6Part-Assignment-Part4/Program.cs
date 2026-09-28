
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


        // --------------------------------------------------
        // PART 2: Loop using the < operator
        // --------------------------------------------------

        Console.WriteLine("\nLoop using < operator:");

        // This loop continues while i is less than 5
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("Number: " + i);
        }


        // --------------------------------------------------
        // PART 3: Loop using the <= operator
        // --------------------------------------------------

        Console.WriteLine("\nLoop using <= operator:");

        // This loop continues while i is less than or equal to 5
        for (int i = 0; i <= 5; i++)
        {
            Console.WriteLine("Number: " + i);
        }


        // --------------------------------------------------
        // PART 4: List of unique strings
        // --------------------------------------------------

        // Create a list of strings.
        // Each item in this list is unique.
        List<string> names = new List<string>
        {
            "John",
            "Mary",
            "David",
            "Sarah",
            "Michael",
            "Jessica"
        };

        // Ask the user what text they want to search for
        Console.Write("\nEnter a name to search for: ");
        string searchText = Console.ReadLine();

        // This variable keeps track of whether a match was found
        bool found = false;

        // Loop through each item in the list
        for (int i = 0; i < names.Count; i++)
        {
            // Check if the current list item contains the user's search text
            if (names[i].ToLower().Contains(searchText.ToLower()))
            {
                // Display the index where the match was found
                Console.WriteLine(
                    "Match found at index " + i + ": " + names[i]
                );

                // A match was found
                found = true;

                // Stop the loop once a match has been found
                break;
            }
        }

        // Check if no match was found
        if (!found)
        {
            Console.WriteLine(
                "Your input \"" + searchText + "\" is not on the list."
            );
        }

        Console.WriteLine("\nPress Enter to exit.");
        Console.ReadLine();
    }
}
