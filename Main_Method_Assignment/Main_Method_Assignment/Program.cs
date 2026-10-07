// This is the main program where the application starts.
class Program
{
    // The Main method is the starting point of the console application.
    static void Main(string[] args)
    {
        // Display a message asking the user to enter a number.
        Console.Write("Enter a number: ");

        // Read the user's input from the keyboard as a string.
        string userInput = Console.ReadLine();

        // Convert the user's input from a string into an integer.
        int number = Convert.ToInt32(userInput);

        // Create an object of the MathOperations class.
        MathOperations math = new MathOperations();

        // Call the MultiplyByTwo method and store the returned result.
        int result1 = math.MultiplyByTwo(number);

        // Display the result of the first math operation.
        Console.WriteLine("Number multiplied by 2: " + result1);

        // Call the AddTen method and store the returned result.
        int result2 = math.AddTen(number);

        // Display the result of the second math operation.
        Console.WriteLine("Number plus 10: " + result2);

        // Call the SquareNumber method and store the returned result.
        int result3 = math.SquareNumber(number);

        // Display the result of the third math operation.
        Console.WriteLine("Number squared: " + result3);

        // Keep the console window open so the user can see the results.
        Console.WriteLine("Press any key to exit.");

        // Wait for the user to press a key before closing the application.
        Console.ReadKey();
    }
}