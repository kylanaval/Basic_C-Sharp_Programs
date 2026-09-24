using System;

class Program
{
    static void Main()
    {
        // Display a title for the program.
        Console.WriteLine("C# Mathematical Operations");
        Console.WriteLine();

        // Ask the user to enter a number for multiplication.
        Console.Write("Enter a number to multiply by 50: ");

        // Read the user's input and convert it to a long integer.
        // 'long' allows numbers much larger than 10,000,000.
        long number1 = Convert.ToInt64(Console.ReadLine());

        // Multiply the user's number by 50.
        long result1 = number1 * 50;

        // Display the multiplication result.
        Console.WriteLine("Result: " + result1);
        Console.WriteLine();


        // Ask the user to enter a number to add 25.
        Console.Write("Enter a number to add 25 to: ");

        // Read the user's input and convert it to an integer.
        int number2 = Convert.ToInt32(Console.ReadLine());

        // Add 25 to the user's number.
        int result2 = number2 + 25;

        // Display the addition result.
        Console.WriteLine("Result: " + result2);
        Console.WriteLine();


        // Ask the user to enter a number to divide by 12.5.
        Console.Write("Enter a number to divide by 12.5: ");

        // Read the user's input and convert it to a decimal number.
        decimal number3 = Convert.ToDecimal(Console.ReadLine());

        // Divide the number by 12.5.
        decimal result3 = number3 / 12.5m;

        // Display the division result.
        Console.WriteLine("Result: " + result3);
        Console.WriteLine();


        // Ask the user to enter a number to check against 50.
        Console.Write("Enter a number to check if it is greater than 50: ");

        // Read the user's input and convert it to an integer.
        int number4 = Convert.ToInt32(Console.ReadLine());

        // Check whether the number is greater than 50.
        // This produces either True or False.
        bool result4 = number4 > 50;

        // Display the true/false result.
        Console.WriteLine("Is the number greater than 50? " + result4);
        Console.WriteLine();


        // Ask the user to enter a number for the remainder calculation.
        Console.Write("Enter a number to divide by 7 and find the remainder: ");

        // Read the user's input and convert it to an integer.
        int number5 = Convert.ToInt32(Console.ReadLine());

        // Use the % operator to find the remainder after division by 7.
        int result5 = number5 % 7;

        // Display the remainder.
        Console.WriteLine("Remainder: " + result5);
        Console.WriteLine();


        // Keep the console window open until the user presses Enter.
        Console.WriteLine("Press Enter to exit.");
        Console.ReadLine();
    }
}