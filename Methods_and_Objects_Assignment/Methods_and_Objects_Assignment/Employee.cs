namespace Methods_Objects_Assignment
{
    // The Employee class inherits from the Person class.
    // This means Employee automatically has FirstName, LastName, and SayName().
    class Employee : Person
    {
        // This property stores the employee's ID number.
        public int Id { get; set; }
    }
}