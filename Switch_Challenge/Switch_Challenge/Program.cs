using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Choose a day of the week:");
        Console.WriteLine("1 - Monday");
        Console.WriteLine("2 - Tuesday");
        Console.WriteLine("3 - Wednesday");
        Console.WriteLine("4 - Thursday");
        Console.WriteLine("5 - Friday");

        Console.Write("Enter your choice: ");
        int day = Convert.ToInt32(Console.ReadLine());

        switch (day)
        {
            case 1:
                Console.WriteLine("You chose Monday.");
                break;

            case 2:
                Console.WriteLine("You chose Tuesday.");
                break;

            case 3:
                Console.WriteLine("You chose Wednesday.");
                break;

            case 4:
                Console.WriteLine("You chose Thursday.");
                break;

            case 5:
                Console.WriteLine("You chose Friday.");
                break;

            default:
                Console.WriteLine("Invalid choice.");
                break;
        }
    }
}