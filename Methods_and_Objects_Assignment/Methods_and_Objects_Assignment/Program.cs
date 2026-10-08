using System;

namespace Methods_Objects_Assignment
{
    // The Program class contains the Main method where the application starts.
    class Program
    {
        // The Main method is the starting point of the console application.
        static void Main(string[] args)
        {
            // Create and initialize an Employee object.
            // The Employee inherits the FirstName and LastName properties from Person.
            Employee employee = new Employee
            {
                FirstName = "Sample",
                LastName = "Student",
                Id = 1
            };

            // Call the SayName() method inherited from the Person class.
            // This displays the employee's full name to the console.
            employee.SayName();

            // Keep the console window open so the user can see the result.
            Console.ReadLine();
        }
    }
}