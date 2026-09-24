using System;                 // Allows the program to use Console for input and output.
using System.Text;            // Allows the program to use the StringBuilder class.

class Program
{
    static void Main()
    {
        // Display the title of the program.
        Console.WriteLine("Welcome to String Operations Program");
        Console.WriteLine();

        // Ask the user to enter the first string.
        Console.Write("Enter the first string (First Name): ");
        string firstString = Console.ReadLine();

        // Ask the user to enter the second string.
        Console.Write("Enter the second string (Middle Name): ");
        string secondString = Console.ReadLine();

        // Ask the user to enter the third string.
        Console.Write("Enter the third string (Last Name): ");
        string thirdString = Console.ReadLine();

        // Concatenate the three strings together with spaces between them.
        string combinedString = firstString + " " + secondString + " " + thirdString;

        // Display the three concatenated strings.
        Console.WriteLine();
        Console.WriteLine("Concatenated String:");
        Console.WriteLine(combinedString);

        // Convert the concatenated string to uppercase.
        string uppercaseString = combinedString.ToUpper();

        // Display the uppercase version of the concatenated string.
        Console.WriteLine();
        Console.WriteLine("String in Uppercase:");
        Console.WriteLine(uppercaseString);

        // Create a new StringBuilder object to build a paragraph.
        StringBuilder paragraph = new StringBuilder();

        // Ask the user to enter the first sentence.
        Console.WriteLine();
        Console.Write("Enter the first sentence: ");
        string sentence1 = Console.ReadLine();

        // Add the first sentence to the StringBuilder.
        paragraph.Append(sentence1 + " ");

        // Ask the user to enter the second sentence.
        Console.Write("Enter the second sentence: ");
        string sentence2 = Console.ReadLine();

        // Add the second sentence to the StringBuilder.
        paragraph.Append(sentence2 + " ");

        // Ask the user to enter the third sentence.
        Console.Write("Enter the third sentence: ");
        string sentence3 = Console.ReadLine();

        // Add the third sentence to the StringBuilder.
        paragraph.Append(sentence3);

        // Display the completed paragraph created by StringBuilder.
        Console.WriteLine();
        Console.WriteLine("Your Paragraph:");
        Console.WriteLine(paragraph.ToString());

        // Pause the program so the user can see the results.
        Console.WriteLine();
        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }
}