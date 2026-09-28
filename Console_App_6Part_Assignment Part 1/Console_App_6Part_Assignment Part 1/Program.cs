using System;
class Program
{
    static void Main()
    {
        // 1. Create a one-dimensional array of strings
        string[] words = { "Hello", "Welcome", "Goodbye", "Thank you" };

        // 2. Ask the user to input some text
        Console.Write("Enter some text to add to each string: ");
        string userText = Console.ReadLine();

        // 3. Loop through the array and append the user's text
        for (int i = 0; i < words.Length; i++)
        {
            words[i] = words[i] + " " + userText;
        }

        // 4. Second loop to print each updated string
        Console.WriteLine("\nUpdated strings:");

        foreach (string word in words)
        {
            Console.WriteLine(word);
        }

        Console.ReadLine();
    }
}