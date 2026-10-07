using System;

namespace Calling_Methods_Assignment
{
    class Program
    {
        static void Main()
        {
            // Call the method to get user input
            int number1 = MathOperations.GetUserInput("addition");

            // Call the Add method and store the returned value.
            int result1 = MathOperations.Add(number1);

            // Display the result returned from the Add method.
            Console.WriteLine($"{number1} + {MathOperations.rand1} = {result1}");

            // Call the method to get user input
            int number2 = MathOperations.GetUserInput("multiplication");
            // Call the Multiply method and store the returned value.
            int result2 = MathOperations.Multiply(number2);
            Console.WriteLine($"{number2} * {MathOperations.rand2} = {result2}");

            // Call the method to get user input
            int number3 = MathOperations.GetUserInput("subtraction");
            // Call the Subtract method and store the returned value.
            int result3 = MathOperations.Subtract(number3);
            Console.WriteLine($"{number3} - {MathOperations.rand3} = {result3}");
        }
    }
}