using System;

class Program
{
    static void Main()
    {
        int num1 = 10;
        int num2 = 20;

        Console.WriteLine("Welcome to the Operator Challenge!");
        Console.WriteLine("This program will compare two numbers and determine if they are equal or not.");
        Console.WriteLine();
        Console.WriteLine("Number 1: " + num1);
        Console.WriteLine("Number 2: " + num2);

        if (num1 != num2)
        {
            Console.WriteLine("The numbers are not equal.");
        }
        else
        {
            Console.WriteLine("The numbers are equal.");
        }

        Console.ReadLine();
    }
}