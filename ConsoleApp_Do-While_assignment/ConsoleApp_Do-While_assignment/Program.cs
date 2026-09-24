using System; // Allows the program to use Console input and output.

class Program // Defines the Program class.
{
    static void Main() // The Main method is where the program starts.
    {
        // Display the program title.
        Console.WriteLine("Boolean Comparison Program");
        Console.WriteLine();

        // Ask the user to enter a number for the while loop.
        Console.Write("Enter a number between 1 and 5: ");

        // Read the user's input and convert it to an integer.
        int number = Convert.ToInt32(Console.ReadLine());

        // Display a heading for the while loop.
        Console.WriteLine();
        Console.WriteLine("WHILE LOOP:");

        // The while statement checks whether the number is less than or equal to 5.
        while (number <= 5)
        {
            // Display the current number.
            Console.WriteLine("The number is " + number);

            // Increase the number by 1.
            number++;

            // Check if the number has become greater than 5.
            if (number > 5)
            {
                // Display a message when the boolean comparison becomes false.
                Console.WriteLine("The comparison is now false.");
            }
        }

        // Add a blank line before the next example.
        Console.WriteLine();

        // Ask the user to enter their age.
        Console.Write("Enter your age: ");

        // Read the user's age and convert it to an integer.
        int age = Convert.ToInt32(Console.ReadLine());

        // Display a heading for the do while loop.
        Console.WriteLine();
        Console.WriteLine("DO WHILE LOOP:");

        // The do block executes at least once.
        do
        {
            // Compare the user's age with 18.
            if (age >= 18)
            {
                // Display this message if the comparison is true.
                Console.WriteLine("You are 18 or older.");
            }
            else
            {
                // Display this message if the comparison is false.
                Console.WriteLine("You are under 18.");
            }

            // Ask the user if they want to enter another age.
            Console.Write("Enter another age: ");

            // Read the new age from the user.
            age = Convert.ToInt32(Console.ReadLine());

            // Continue the loop while the user's age is less than 18.
        } while (age < 18);

        // Display a message when the program ends.
        Console.WriteLine();
        Console.WriteLine("The do while comparison is now false.");
        Console.WriteLine("Program completed.");

        // Wait for the user to press Enter before closing.
        Console.ReadLine();
    }
}