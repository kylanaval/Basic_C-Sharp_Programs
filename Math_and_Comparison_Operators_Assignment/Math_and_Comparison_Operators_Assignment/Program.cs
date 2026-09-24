
// Anonymous Income Comparison Program
// This program calculates and compares the annual salaries of two people.

// Display the title of the program.
Console.WriteLine("Anonymous Income Comparison Program");

// Add a blank line for readability.
Console.WriteLine();

// Display Person 1 heading.
Console.WriteLine("Person 1");

// Ask for Person 1's hourly rate.
Console.Write("Hourly Rate: ");

// Read the hourly rate and convert it to a decimal.
decimal person1HourlyRate = Convert.ToDecimal(Console.ReadLine());

// Ask for Person 1's hours worked per week.
Console.Write("Hours worked per week: ");

// Read the number of hours and convert it to a decimal.
decimal person1HoursPerWeek = Convert.ToDecimal(Console.ReadLine());

// Add a blank line.
Console.WriteLine();

// Display Person 2 heading.
Console.WriteLine("Person 2");

// Ask for Person 2's hourly rate.
Console.Write("Hourly Rate: ");

// Read the hourly rate and convert it to a decimal.
decimal person2HourlyRate = Convert.ToDecimal(Console.ReadLine());

// Ask for Person 2's hours worked per week.
Console.Write("Hours worked per week: ");

// Read the number of hours and convert it to a decimal.
decimal person2HoursPerWeek = Convert.ToDecimal(Console.ReadLine());

// Calculate Person 1's annual salary.
// There are 52 weeks in one year.
decimal person1AnnualSalary = person1HourlyRate * person1HoursPerWeek * 52;

// Calculate Person 2's annual salary.
// There are 52 weeks in one year.
decimal person2AnnualSalary = person2HourlyRate * person2HoursPerWeek * 52;

// Add a blank line before displaying the results.
Console.WriteLine();

// Display Person 1's annual salary heading.
Console.WriteLine("Annual salary of Person 1:");

// Display Person 1's exact annual salary.
Console.WriteLine(person1AnnualSalary);

// Add a blank line.
Console.WriteLine();

// Display Person 2's annual salary heading.
Console.WriteLine("Annual salary of Person 2:");

// Display Person 2's exact annual salary.
Console.WriteLine(person2AnnualSalary);

// Add a blank line.
Console.WriteLine();

// Display the comparison statement.
Console.WriteLine("Person 1 makes more money than Person 2");

// Compare Person 1's salary to Person 2's salary.
// This displays True if Person 1 makes more money,
// or False if Person 1 does not make more money.
Console.WriteLine(person1AnnualSalary > person2AnnualSalary);

Console.ReadLine();