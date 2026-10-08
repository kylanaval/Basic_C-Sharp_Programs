using System;

namespace Methods_Objects_Assignment
{
    // The Person class represents a person and stores their first and last name.
    class Person
    {
        // This property stores the person's first name.
        public string FirstName { get; set; }

        // This property stores the person's last name.
        public string LastName { get; set; }

        // This void method displays the person's full name.
        // It does not take any parameters and does not return a value.
        public void SayName()
        {
            // Display the person's first and last name to the console.
            Console.WriteLine("Name: " + FirstName + " " + LastName);
        }
    }
}