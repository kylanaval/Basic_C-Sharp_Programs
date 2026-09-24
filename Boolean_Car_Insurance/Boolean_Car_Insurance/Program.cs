
// This program determines whether an applicant qualifies for car insurance.
// The applicant must be over 15, have no DUI, and have no more than 3 speeding tickets.

// Display the title of the program.
Console.WriteLine("Car Insurance Approval Program");

// Ask the applicant for their age.
Console.WriteLine("What is your age?");

// Read the applicant's age and convert the input from text to an integer.
int age = Convert.ToInt32(Console.ReadLine());

// Ask the applicant if they have ever had a DUI.
Console.WriteLine("Have you ever had a DUI?True or False");

// Read the DUI answer and convert it from text to a Boolean value (true or false).
bool hasDUI = Convert.ToBoolean(Console.ReadLine());

// Ask the applicant how many speeding tickets they have.
Console.WriteLine("How many speeding tickets do you have?");

// Read the number of speeding tickets and convert the input to an integer.
int speedingTickets = Convert.ToInt32(Console.ReadLine());

// Determine if the applicant qualifies for car insurance.
// The applicant must be over 15 years old.
// The applicant must NOT have a DUI.
// The applicant must have 3 or fewer speeding tickets.
bool qualified = (age > 15) && (hasDUI == false) && (speedingTickets <= 3);

// Display the qualification result.
Console.WriteLine("Qualified?");

// Print true if the applicant qualifies, or false if they do not.
Console.WriteLine(qualified);
