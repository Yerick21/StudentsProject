using System;
using System.Collections.Generic;

public class Program
{
    public static void Main(string[] args)
    {
        // Create Student objects
        var student1 = new Student(1, "John", "Doe", new DateTime(2000, 1, 6), "Computer Science", true);
        var student2 = new Student(2, "Jane", "Smith", new DateTime(2001, 2, 7), "Engineering", true);
        var student3 = new Student(3, "Jake", "Johnson", new DateTime(2002, 3, 8), "Engineering", false);
        var student4 = new Student(4, "Sara", "Lee", new DateTime(2003, 4, 9), "Engineering", true);
        var student5 = new Student(5, "Mike", "Davis", new DateTime(2004, 5, 10), "Engineering", false);

        // Create Course objects
        var class1 = new Course("Mathematics", "MATH101", "Professor James");
        var class2 = new Course("Computer Science", "CS101", "Professor Williams");

        // Add courses to students
        student1.AddCourse(class1);  // student1 is enrolled in Mathematics
        student2.AddCourse(class2);  // student2 is enrolled in Computer Science
        student3.AddCourse(class2);  // student3 is also enrolled in Computer Science
        student4.AddCourse(class1);  // student4 is enrolled in Mathematics
        student5.AddCourse(class1);  // student5 is enrolled in Mathematics

        // Create a list of all students
        List<Student> students = new List<Student> { student1, student2, student3, student4, student5 };

        // Display all student information
        foreach (var student in students)
        {
            if (student.isEnrolled)
            {
                Console.WriteLine($"Name: {student.fName} {student.lName}");
                Console.WriteLine($"Student ID: {student.ID}");
                Console.WriteLine($"Date of Birth: {student.DOB.ToShortDateString()}");
                Console.WriteLine($"Major: {student.Major}");
                Console.WriteLine($"Enrolled: {student.isEnrolled}");
                Console.WriteLine("Enrolled in the following courses:");
                

                foreach (var course in student.Courses)
                {
                    Console.WriteLine($"- {course.ClassName} ({course.ClassCode}) - Instructor: {course.Instructor}");
                }

                Console.WriteLine(); // Add a blank line for better readability
            }

            else
            {
                Console.WriteLine($"Name: {student.fName} {student.lName} {student.ID} {student.DOB.ToShortDateString()} {student.Major},");
                Console.WriteLine("Student has not been enrolled in any course");
                Console.WriteLine();
            }
        }
    }
}