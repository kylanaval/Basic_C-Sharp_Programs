using System;

// Create the Employee class and inherit from the Person class.
class Employee : Person
{
    // Implement the abstract SayName() method from the Person class.
    public override void SayName()
    {
        // Display the person's full name to the console.
        Console.WriteLine("Name: " + firstName + " " + lastName);
    }
}