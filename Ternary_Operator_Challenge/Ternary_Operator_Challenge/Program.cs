using System;

// Determines if the user is an adult or minor based on their input age using a ternary operator.
class Program
{
    static void Main()
    {
        Console.Write("Enter your age: ");
        int age = Convert.ToInt32(Console.ReadLine());

        string result = age >= 18 ? "You are an adult." : "You are a minor.";

        Console.WriteLine(result);
        Console.ReadLine();
    }
}