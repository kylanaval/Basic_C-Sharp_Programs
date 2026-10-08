
using System;

namespace OperatorOverloadingAssignment
{
    // The Program class contains the entry point of the application.
    class Program
    {
        // The Main method is where the program starts executing.
        static void Main(string[] args)
        {
            // Create the first Employee object.
            Employee employee1 = new Employee();

            // Assign values to the first employee's properties.
            employee1.Id = 101;
            employee1.FirstName = "John";
            employee1.LastName = "Smith";

            // Create the second Employee object.
            Employee employee2 = new Employee();

            // Assign values to the second employee's properties.
            employee2.Id = 101;
            employee2.FirstName = "Mary";
            employee2.LastName = "Jones";

            // Display the details of the first employee.
            Console.WriteLine("Employee 1:");
            Console.WriteLine("ID: " + employee1.Id);
            Console.WriteLine("Name: " + employee1.FirstName + " " + employee1.LastName);

            // Display the details of the second employee.
            Console.WriteLine("\nEmployee 2:");
            Console.WriteLine("ID: " + employee2.Id);
            Console.WriteLine("Name: " + employee2.FirstName + " " + employee2.LastName);

            // Compare both employees using the overloaded == operator.
            // The result is true because both employees have the same Id.
            Console.WriteLine("\nAre the employees equal? " + (employee1 == employee2));

            // Compare both employees using the overloaded != operator.
            // The result is false because both employees have the same Id.
            Console.WriteLine("Are the employees different? " + (employee1 != employee2));

            // Pause the console so the user can read the results.
            Console.WriteLine("\nPress any key to exit.");
            Console.ReadKey();
        }
    }
}