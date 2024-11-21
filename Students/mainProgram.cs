using System.Runtime.InteropServices;

public class Program
{
    public static void Main(string[] args)
    {
        // Create Student objects
        var student1 = new Student(1, "John", "Doe", new DateTime(2000, 1, 6), "Computer Science", true);
        var student2 = new Student(2, "Jane", "Smith", new DateTime(2001, 2, 7), "Engineering", true);
        var student3 = new Student(3, "Jane", "Smith", new DateTime(2002, 3, 8), "Engineering", true);
        var student4 = new Student(3, "Jane", "Smith", new DateTime(2003, 4, 9), "Engineering", true);
        var student5 = new Student(3, "Jane", "Smith", new DateTime(2004, 5, 10), "Engineering", true);

        // Create Course objects
        var class1 = new Course("Mathematics", "MATH101", "Professor James");
        var class2 = new Course("Computer Science", "CS101", "Professor Williams");

        // Add courses to students
        student1.AddCourse(class1);  // student1 is enrolled in Mathematics
        student2.AddCourse(class2);  // student2 is also enrolled in Computer Science

        // Example of displaying student info and their courses
        if (student1.isEnrolled)
        {
            Console.WriteLine($"Name: {student1.fName} {student1.lName}, Major: {student1.Major}");
            Console.WriteLine("Enrolled in the following courses:");

            foreach (var course in student1.Courses)
            {
                Console.WriteLine($"{course.ClassName} ({course.ClassCode}) - Instructor: {course.Instructor}");
            }
        }
    }
}
