using System;

class Program
{
    static void Main()
    {
        // Display the welcome message to the user.
        Console.WriteLine("Welcome to Package Express. Please input the following details of your package below.");

        // Ask the user to enter the package weight.
        Console.WriteLine("Please enter the package weight in kg:");

        // Read the user's weight and convert it from text to a decimal number.
        decimal weight = Convert.ToDecimal(Console.ReadLine());

        // Check if the package weight is greater than 50.
        if (weight > 50)
        {
            // Display an error message if the package is too heavy.
            Console.WriteLine();
            Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
            Console.WriteLine("Please note that the maximum weight allowed is 50 kg.");
            Console.WriteLine();
            Console.WriteLine("Thank you for your time!");
            // End the program because the package is too heavy.
            return;
        }

        // Ask the user to enter the package width.
        Console.WriteLine("Please enter the package width in inches:");

        // Read the width and convert it to a decimal number.
        decimal width = Convert.ToDecimal(Console.ReadLine());

        // Ask the user to enter the package height.
        Console.WriteLine("Please enter the package height in inches:");

        // Read the height and convert it to a decimal number.
        decimal height = Convert.ToDecimal(Console.ReadLine());

        // Ask the user to enter the package length.
        Console.WriteLine("Please enter the package length in inches:");

        // Read the length and convert it to a decimal number.
        decimal length = Convert.ToDecimal(Console.ReadLine());

        // Add the width, height, and length together.
        decimal totalDimensions = width + height + length;

        // Check if the total dimensions are greater than 50.
        if (totalDimensions > 50)
        {
            // Display an error message if the package is too large.
            Console.WriteLine();
            Console.WriteLine("Package too big to be shipped via Package Express.");
            Console.WriteLine("Please note that the maximum combined dimensions (width + height + length) allowed is 50 inches.");
            Console.WriteLine();
            Console.WriteLine("Thank you for your time!");
            // End the program because the package is too large.
            return;
        }

        // Multiply the height, width, and length together to get the package volume.
        decimal volume = height * width * length;

        // Multiply the package volume by the package weight.
        decimal shippingCost = volume * weight;

        // Divide the result by 100 to calculate the shipping quote.
        shippingCost = shippingCost / 100;

        // Display the final shipping quote as a dollar amount with two decimal places.
        Console.WriteLine($"Your estimated total for shipping this package is: ${shippingCost:F2}");

        // Display a thank-you message.
        Console.WriteLine("Thank you for doing business with us!");
        Console.ReadLine();
    }
}