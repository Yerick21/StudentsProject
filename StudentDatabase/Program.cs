using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
class Program
{
    static void Main()
    {
        string filePath = "students.csv";
        List<Student> students = new List<Student> { };
        string ans;
        // students.Add(new Student());
        // students.Add(new Student());
        // students.Add(new Student());
        // students.Add(new Student());
        // students.Add(new Student());
        //Creating Database
        try
        {
            if (!File.Exists(filePath))
            {
                Console.WriteLine("Creating the Database, Please Hold...");
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    writer.WriteLine("Student Database:\n");
                }
                Console.WriteLine("Database Created, Title Created.");
            }
            else { Console.WriteLine("Database already Exists, Skipping to Reading step."); }
            //Reading Out Data
            Console.WriteLine("Reading Current Data...");
            using (StreamReader reader = new StreamReader(filePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }
            //CREATING NEW STUDENTS
            Console.WriteLine("Would you Like to add new Students? Y/N");
            ans = Console.ReadLine();
            while (ans != "Y" && ans != "N")
            {
                Console.WriteLine("Please Enter Either Y or N");
                ans = Console.ReadLine();
            }
            if (ans == "Y")
            {

                for (int B = 0; B < 5; B++)
                {
                    Student Academic = new Student();
                    Academic.CreateStudent();
                    students.Add(Academic);
                    Console.WriteLine("Creation done,\nStarting Next Student:\n");
                }
                //appending new students
                Console.WriteLine("Adding Students to Database...");
                using (StreamWriter writer = new StreamWriter(filePath, append: true))
                {
                    foreach (Student Student in students)
                    {
                        writer.WriteLine(Student);
                    }
                }
                Console.WriteLine("Additions Successful!");
                //reading one last time
                Console.WriteLine("Reading Database...");
                using (StreamReader reader = new StreamReader(filePath))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                    }
                }
                Console.WriteLine("thank you for using the DataBase...\nPROGRAM ENDED.");
            }
        }
        catch (IOException ioEx)
        {
            Console.WriteLine($"An I/O Error Has Occured: {ioEx.Message}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"A general Error has Occured: {ex.Message}");
        }
    }
}