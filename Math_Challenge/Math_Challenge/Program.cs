using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome to the Math Challenge!");
        Console.WriteLine("This program will perform basic arithmetic operations on two numbers.");
        Console.WriteLine("The number1 is 20 and number2 is 5.");
        Console.WriteLine();

        // Two numbers
        double number1 = 20;
        double number2 = 5;

        // Addition
        double addition = number1 + number2;
        Console.WriteLine("Addition: " + addition);

        // Subtraction
        double subtraction = number1 - number2;
        Console.WriteLine("Subtraction: " + subtraction);

        // Multiplication
        double multiplication = number1 * number2;
        Console.WriteLine("Multiplication: " + multiplication);

        // Division
        double division = number1 / number2;
        Console.WriteLine("Division: " + division);

        Console.ReadLine();
    }
}