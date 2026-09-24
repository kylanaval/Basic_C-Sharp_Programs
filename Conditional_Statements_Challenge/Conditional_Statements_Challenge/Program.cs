
using System;

namespace IfElseExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Student Grade Checker");
            Console.WriteLine("----------------------");

            Console.Write("Enter your grade (0-100): ");
            int grade = Convert.ToInt32(Console.ReadLine());

            if (grade >= 90)
            {
                Console.WriteLine("Grade: A");
                Console.WriteLine("Excellent work!");
            }
            else if (grade >= 80)
            {
                Console.WriteLine("Grade: B");
                Console.WriteLine("Great job!");
            }
            else if (grade >= 70)
            {
                Console.WriteLine("Grade: C");
                Console.WriteLine("Good work!");
            }
            else if (grade >= 60)
            {
                Console.WriteLine("Grade: D");
                Console.WriteLine("You passed.");
            }
            else
            {
                Console.WriteLine("Grade: F");
                Console.WriteLine("You did not pass.");
            }

            Console.WriteLine();
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}