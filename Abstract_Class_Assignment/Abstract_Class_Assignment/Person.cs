using System;

// Create an abstract class called Person.
// An abstract class cannot be instantiated directly.
abstract class Person
{
    // Create a string property to store the person's first name.
    public string firstName { get; set; }

    // Create a string property to store the person's last name.
    public string lastName { get; set; }

    // Declare an abstract SayName() method.
    // The Employee class will provide the actual code for this method.
    public abstract void SayName();
}