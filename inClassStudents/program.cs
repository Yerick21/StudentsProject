using system;
using system.collections.Generic;
using system.IO;

class Program 
{
    static void Main()
    {
        List<Student> students = new List<Student>();

        Student student1 = new Student(0, "", "", DateTime.MinValue, new List<string>(), true);
        Student student2 = new Student(0, "", "", DateTime.MinValue, new List<string>(), true);
        
        Console.WriteLine("Enter deails for student: ");
        student1.CreateStudent();
        students.Add(student1);

        Console.WriteLine("Enter deails for student: ");
        student2.CreateStudent();
        students.Add(student2);




        string filePath = "students.csv";
        using (StreamWriter writer = new StreamWriter(filePath))
        {

            writer.WriteLine("ID,First Name,Last Name,DOB,Major,Classes,Is Enrolled");
            foreach (student in students)
            {
                writer.WriteLine(student1.ToCsv());
            }

        }
        
        
         //check if the file exists so you can append 


    }
}