using System;

namespace Class_Method_Assignment
{
    // This class contains the methods used by the Main class.
    public class MathOperations
    {
        // This void method takes an integer and divides it by 2.
        // The result is displayed directly to the screen.
        public void MathOp(int dividend)
        {
            // Divide the number entered by the user by 2.
            int result = dividend / 2;

            // Display the result.
            Console.WriteLine("The number divided by 2 is: " + result);
        }


        // This method uses an output parameter.
        // The output parameter returns the number of characters in the phrase.
        public string StringCounter(string input, out int count)
        {
            // Count the number of characters in the input phrase.
            count = input.Length;

            // Return the original phrase.
            return "You entered: " + input;
        }


        // This is an overloaded version of StringCounter.
        // It has the same method name but different parameters.
        public int StringCounter(string input)
        {
            // Return the number of characters in the phrase.
            return input.Length;
        }


        // This is a static method.
        // It counts how many times the letter "i" appears in the phrase.
        public static int IFinder(string input)
        {
            // Create a variable to keep track of the number of i's.
            int count = 0;

            // Check each character in the input.
            foreach (char letter in input)
            {
                // Check if the character is an uppercase or lowercase i.
                if (letter == 'i' || letter == 'I')
                {
                    // Increase the count by 1.
                    count++;
                }
            }

            // Return the total number of i's.
            return count;
        }
    }


    // This is a static class.
    // A static class cannot be instantiated with the new keyword.
    public static class StaticHelper
    {
        // This static method displays a message.
        public static void ShowMessage()
        {
            // Display a message on the screen.
            Console.WriteLine("This is a method from a static class.");
        }
    }
}