
using System;
using System.Data.Entity;

// Main program
namespace StudentDatabase
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a database context to connect to the database.
            using (var db = new SchoolContext())
            {
                // Create one new student.
                var student = new Student
                {
                    StudentName = "Kyla Cartalla"
                };

                // Add the student to the Students table.
                db.Students.Add(student);

                // Save the student to the database.
                db.SaveChanges();

                Console.WriteLine("Student database created successfully!");
                Console.WriteLine("A student has been added.");
                Console.WriteLine();

                // Display the students saved in the database.
                foreach (var s in db.Students)
                {
                    Console.WriteLine(
                        "Student ID: " + s.StudentId);
                    Console.WriteLine(
                        "Student Name: " + s.StudentName);
                }
            }

            // Keep the console window open.
            Console.WriteLine();
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }

    // Student entity class
    public class Student
    {
        // Entity Framework identifies this as the primary key.
        public int StudentId { get; set; }

        // Stores the student's name.
        public string StudentName { get; set; }
    }

    // Database context class
    public class SchoolContext : DbContext
    {
        // Represents the Students table in the database.
        public DbSet<Student> Students { get; set; }
    }
}
