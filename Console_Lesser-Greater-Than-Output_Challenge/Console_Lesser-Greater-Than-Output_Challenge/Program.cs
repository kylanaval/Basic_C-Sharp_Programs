using System;
using static System.Net.Mime.MediaTypeNames;

class Program
{
    static void Main(string[] args)
    {
        // Greater than operator
        int num1 = 10;
        int num2 = 5;

        bool greaterResult = num1 > num2;

        Console.WriteLine("Greater Than Operator:");
        Console.WriteLine(num1 + " > " + num2 + " = " + greaterResult);

        Console.WriteLine();

        // Less than or equal to operator
        int num3 = 5;
        int num4 = 5;

        bool lessOrEqualResult = num3 <= num4;

        Console.WriteLine("Less Than or Equal To Operator:");
        Console.WriteLine(num3 + " <= " + num4 + " = " + lessOrEqualResult);

        Console.ReadLine();
    }
}