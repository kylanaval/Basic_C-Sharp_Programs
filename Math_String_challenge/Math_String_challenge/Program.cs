
using System;
using static System.Net.Mime.MediaTypeNames;

class Program
{
    static void Main()
    {
        Console.WriteLine("Math Operation on a String");
        Console.WriteLine("I'm using the convert dot to int32 method to convert a string to an integer");
        Console.WriteLine();

        string number1 = "20";
        string number2 = "5";

        int firstNumber = Convert.ToInt32(number1);
        int secondNumber = Convert.ToInt32(number2);

        int result = firstNumber + secondNumber;

        Console.WriteLine("First number: " + number1);
        Console.WriteLine("Second number: " + number2);
        Console.WriteLine("Result: " + result);

        Console.ReadLine();
    }
}