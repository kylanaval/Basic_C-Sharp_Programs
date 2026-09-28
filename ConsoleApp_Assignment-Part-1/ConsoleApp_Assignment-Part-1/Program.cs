using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // --------------------------------------------------
        // PART 1: One-dimensional array of strings
        // --------------------------------------------------

        // Create a one-dimensional array containing several strings.
        string[] words = { "Hello", "Welcome", "Goodbye", "Thank you" };

        // Ask the user to enter text that will be added to each string.
        Console.Write("Enter some text to add to each string: ");
        string userText = Console.ReadLine();

        // Loop through every element in the array.
        for (int i = 0; i < words.Length; i++)
        {
            // Add the user's text to the end of the current string.
            words[i] = words[i] + " " + userText;
        }

        // Display a heading before showing the updated strings.
        Console.WriteLine("\nUpdated strings:");

        // Loop through each updated string in the array.
        foreach (string word in words)
        {
            // Display the current string on the screen.
            Console.WriteLine(word);
        }


        // --------------------------------------------------
        // PART 2: Loop using the < operator
        // --------------------------------------------------

        // Display a heading for the less-than loop.
        Console.WriteLine("\nLoop using < operator:");

        // Continue the loop while i is less than 5.
        for (int i = 0; i < 5; i++)
        {
            // Display the current value of i.
            Console.WriteLine("Number: " + i);
        }


        // --------------------------------------------------
        // PART 3: Loop using the <= operator
        // --------------------------------------------------

        // Display a heading for the less-than-or-equal-to loop.
        Console.WriteLine("\nLoop using <= operator:");

        // Continue the loop while i is less than or equal to 5.
        for (int i = 0; i <= 5; i++)
        {
            // Display the current value of i.
            Console.WriteLine("Number: " + i);
        }


        // --------------------------------------------------
        // PART 4: List with duplicate strings
        // --------------------------------------------------

        // Create a list of strings.
        // "Mary" appears multiple times so the list contains duplicates.
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

        // Ask the user to enter a name to search for.
        Console.Write("\nEnter a name to search for: ");
        string searchText = Console.ReadLine();

        // Create a Boolean variable to keep track of whether a match was found.
        bool found = false;

        // Loop through every item in the names list.
        for (int i = 0; i < names.Count; i++)
        {
            // Check if the current name contains the user's search text.
            if (names[i].ToLower().Contains(searchText.ToLower()))
            {
                // Display the index and the matching name.
                Console.WriteLine(
                    "Match found at index " + i + ": " + names[i]
                );

                // Set found to true because a match was found.
                found = true;

                // No break statement is used.
                // This allows the loop to continue and find all matches.
            }
        }

        // Check whether the user's search text was not found.
        if (!found)
        {
            // Tell the user that their input is not on the list.
            Console.WriteLine(
                "Your input \"" + searchText + "\" is not on the list."
            );
        }


        // --------------------------------------------------
        // PART 5: Check for duplicate strings
        // --------------------------------------------------

        // Create another list containing duplicate strings.
        List<string> letters = new List<string>
        {
            "A",
            "B",
            "C",
            "D",
            "C"
        };

        // Create a separate list to keep track of items already seen.
        List<string> itemsAlreadySeen = new List<string>();

        // Display a heading for the duplicate check.
        Console.WriteLine("\nChecking the list for duplicates:");

        // Use a foreach loop to examine every item in the letters list.
        foreach (string letter in letters)
        {
            // Check if the current letter has already appeared.
            if (itemsAlreadySeen.Contains(letter))
            {
                // The letter has appeared before, so it is a duplicate.
                Console.WriteLine(letter + " - this item is a duplicate");
            }
            else
            {
                // The letter has not appeared before, so it is unique.
                Console.WriteLine(letter + " - this item is unique");

                // Add the new letter to the list of items already seen.
                itemsAlreadySeen.Add(letter);
            }
        }

        // Ask the user to press Enter before closing the program.
        Console.WriteLine("\nPress Enter to exit.");

        // Wait for the user to press Enter.
        Console.ReadLine();
    }
}