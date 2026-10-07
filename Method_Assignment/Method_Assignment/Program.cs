using System;

// Create a class that contains our math method.
class MathOperations
{
    // This method takes two integer parameters.
    // The second parameter is optional and has a default value of 0.
    // The method adds the two numbers together and returns the integer result.
    public int AddNumbers(int number1, int number2 = 0)
    {
        // Add the two numbers and store the result.
        int result = number1 + number2;

        // Return the calculated result to the calling method.
        return result;
    }
}

// The Program class contains the Main() method.
class Program
{
    // Main() is the starting point of the console application.
    static void Main()
    {
        // Create an object (instance) of the MathOperations class.
        MathOperations math = new MathOperations();

        // Ask the user to enter the first number.
        Console.Write("Enter the first number: ");

        // Read the user's input and convert it from text to an integer.
        int number1 = Convert.ToInt32(Console.ReadLine());

        // Ask the user to enter the second number.
        // Tell the user that they can leave it blank.
        Console.Write("Enter the second number (optional - press Enter to skip): ");

        // Read the second input as text.
        string? secondInput = Console.ReadLine();

        // Check whether the user entered a second number.
        if (string.IsNullOrWhiteSpace(secondInput))
        {
            // Call the method using only the first number.
            // The optional second parameter will automatically use 0.
            int result = math.AddNumbers(number1);

            // Display the result to the user.
            Console.WriteLine("Result: " + result);
        }
        else
        {
            // Convert the second input from text to an integer.
            int number2 = Convert.ToInt32(secondInput);

            // Call the method using both numbers.
            int result = math.AddNumbers(number1, number2);

            // Display the result to the user.
            Console.WriteLine("Result: " + result);
        }

        // Pause the program so the user can see the result before the console closes.
        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }
}