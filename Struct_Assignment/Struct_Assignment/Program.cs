
using System; // Imports basic .NET functionality, including Console.

// Defines a struct named Number to store a decimal amount.
struct Number
{
    // Declares a public property named Amount with a decimal data type.
    public decimal Amount { get; set; }
}

class Program
{
    // The Main method is the starting point of the console application.
    static void Main(string[] args)
    {
        // Creates an object of the Number struct.
        Number number = new Number();

        // Assigns a decimal value to the Amount property.
        number.Amount = 100.50m;

        // Prints the Amount value to the console.
        Console.WriteLine("Amount: " + number.Amount);

        // Keeps the console window open until the user presses a key.
        Console.ReadKey();
    }
}