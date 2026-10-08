
using System;

namespace OperatorOverloadingAssignment
{
    // Create an Employee class to represent an employee.
    public class Employee
    {
        // Store the employee's unique ID.
        public int Id { get; set; }

        // Store the employee's first name.
        public string FirstName { get; set; }

        // Store the employee's last name.
        public string LastName { get; set; }

        // Overload the == operator to compare two Employee objects by Id.
        public static bool operator ==(Employee employee1, Employee employee2)
        {
            // Return true if both references are the same object.
            if (ReferenceEquals(employee1, employee2))
                return true;

            // Return false if one object is null.
            if (employee1 is null || employee2 is null)
                return false;

            // Compare the Id properties of both employees.
            return employee1.Id == employee2.Id;
        }

        // Overload the != operator because comparison operators
        // must be overloaded in pairs.
        public static bool operator !=(Employee employee1, Employee employee2)
        {
            // Return the opposite result of the == operator.
            return !(employee1 == employee2);
        }

        // Override Equals to use the same Id-based equality rule.
        public override bool Equals(object obj)
        {
            // Check whether the other object is an Employee.
            if (obj is not Employee otherEmployee)
                return false;

            // Return true if both employees have the same Id.
            return Id == otherEmployee.Id;
        }

        // Override GetHashCode to remain consistent with Equals.
        public override int GetHashCode()
        {
            // Generate a hash code based on the employee's Id.
            return Id.GetHashCode();
        }
    }
}