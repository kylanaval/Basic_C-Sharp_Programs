using System;

class Program
{
    static void Main()
    {
        // Display the name of the college.
        Console.WriteLine("Academy of Learning Career College");

        // Display the title of the report.
        Console.WriteLine("Student Daily Report.");

        // Ask the student for their name and save it as a string.
        Console.Write("What is your name? ");
        string studentName = Console.ReadLine();

        // Ask the student which course they are taking and save it as a string.
        Console.Write("What course are you on? ");
        string courseName = Console.ReadLine();

        // Ask the student for the page number and convert the answer to an integer.
        Console.Write("What page number? ");
        int pageNumber = Convert.ToInt32(Console.ReadLine());

        // Ask if the student needs help and convert the answer to a Boolean (true or false).
        Console.Write("Do you need help with anything? Please answer \"true\" or \"false\": ");
        bool needsHelp = Convert.ToBoolean(Console.ReadLine());

        // Ask the student to describe any positive experiences.
        Console.Write("Were there any positive experiences you'd like to share? Please give specifics: ");
        string positiveExperiences = Console.ReadLine();

        // Ask the student for any additional feedback.
        Console.Write("Is there any other feedback you'd like to provide? Please be specific: ");
        string additionalFeedback = Console.ReadLine();

        // Ask how many hours the student studied and convert the answer to a double.
        Console.Write("How many hours did you study today? ");
        double studyHours = Convert.ToDouble(Console.ReadLine());

        // Thank the student for completing the daily report.
        Console.WriteLine();
        Console.WriteLine("Thank you for your answers. An Instructor will respond shortly. Have a great day!");
    }
}