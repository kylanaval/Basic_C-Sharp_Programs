using System;

// Create the Program class that contains the Main() method.
class Program
{
    // The Main() method is where the console application starts.
    static void Main(string[] args)
    {
        // Create a new Employee object.
        // Set the firstName property to "Sample".
        // Set the lastName property to "Student".
        Employee employee = new Employee
        {
            firstName = "Sample",
            lastName = "Student"
        };

        // Call the SayName() method from the Employee class.
        // This displays the employee's full name on the screen.
        employee.SayName();

        // Pause the console so the user can see the output.
        Console.ReadLine();
    }
}