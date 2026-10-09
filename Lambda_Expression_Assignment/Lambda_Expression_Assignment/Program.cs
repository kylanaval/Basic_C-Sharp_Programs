
using System;
using System.Collections.Generic;
using System.Linq;

namespace LambdaExpressionAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a list containing 10 employees.
            // Two employees have the first name "Joe".
            List<Employee> employees = new List<Employee>
            {
                new Employee { Id = 1, FirstName = "Joe", LastName = "Smith" },
                new Employee { Id = 2, FirstName = "Mary", LastName = "Brown" },
                new Employee { Id = 3, FirstName = "Joe", LastName = "Johnson" },
                new Employee { Id = 4, FirstName = "Anna", LastName = "Davis" },
                new Employee { Id = 5, FirstName = "Mark", LastName = "Wilson" },
                new Employee { Id = 6, FirstName = "Sarah", LastName = "Miller" },
                new Employee { Id = 7, FirstName = "David", LastName = "Taylor" },
                new Employee { Id = 8, FirstName = "Lisa", LastName = "Anderson" },
                new Employee { Id = 9, FirstName = "Peter", LastName = "Thomas" },
                new Employee { Id = 10, FirstName = "Emily", LastName = "White" }
            };

            // Create an empty list to store employees whose first name is Joe.
            List<Employee> joeEmployeesLoop = new List<Employee>();

            // Use a foreach loop to examine every employee in the original list.
            foreach (Employee employee in employees)
            {
                // Check the FirstName property of the current employee.
                if (employee.FirstName == "Joe")
                {
                    // Add the employee to the new list if the first name is Joe.
                    joeEmployeesLoop.Add(employee);
                }
            }

            // Display the results obtained using the foreach loop.
            Console.WriteLine("Employees named Joe (foreach loop):");

            foreach (Employee employee in joeEmployeesLoop)
            {
                // Print the ID and full name of each matching employee.
                Console.WriteLine(
                    $"ID: {employee.Id}, Name: {employee.FirstName} {employee.LastName}");
            }

            // Use a lambda expression with Where() to find employees named Joe.
            // ToList() converts the matching results into a new List<Employee>.
            List<Employee> joeEmployeesLambda = employees
                .Where(employee => employee.FirstName == "Joe")
                .ToList();

            // Display the results obtained using the lambda expression.
            Console.WriteLine("\nEmployees named Joe (lambda expression):");

            foreach (Employee employee in joeEmployeesLambda)
            {
                // Print the ID and full name of each matching employee.
                Console.WriteLine(
                    $"ID: {employee.Id}, Name: {employee.FirstName} {employee.LastName}");
            }

            // Use a lambda expression to find employees whose IDs are greater than 5.
            // Where() filters the employees, and ToList() creates a new list.
            List<Employee> employeesWithIdGreaterThanFive = employees
                .Where(employee => employee.Id > 5)
                .ToList();

            // Display the employees whose ID numbers are greater than 5.
            Console.WriteLine("\nEmployees with ID greater than 5:");

            foreach (Employee employee in employeesWithIdGreaterThanFive)
            {
                // Print the ID and full name of each matching employee.
                Console.WriteLine(
                    $"ID: {employee.Id}, Name: {employee.FirstName} {employee.LastName}");
            }

            // Pause the console so the user can read the results.
            Console.WriteLine("\nPress any key to exit.");
            Console.ReadKey();
        }
    }
}
