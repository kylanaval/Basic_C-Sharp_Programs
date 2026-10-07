using System;

namespace Method_Class_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of the MathOperations class so its methods can be accessed.
            MathOperations math = new MathOperations();

            // Call the method by passing the arguments in their normal order.
            Console.WriteLine("Method Call Using Positional Parameters:");
            math.DisplayResult(5, 15);

            // Call the same method again, this time specifying the parameter names.
            Console.WriteLine("\nMethod Call Using Named Parameters:");
            math.DisplayResult(secondNumber: 20, firstNumber: 10);
        }
    }
}