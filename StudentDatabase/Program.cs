using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;


//5 students
//Student List
//students.csv file
//Comment out list creation Then call the student creator 5 times  add to students.
class Program
{
    static void Main()
    {
        string filePath = "students.csv";
        List<Student> students = new List<Student> { };
        //Temp Student values that get sent to the Student Class
        int ID = 0;
        string fName;
        string lName;
        DateTime DOB;
        string major;
        List<string> classes = new List<string> { };
        bool isEnrolled = true;
        //Placeholder string, is used whenever I need a String answer that doesn't matter in the grand scheme of things (I.E. Asking Yes or No)
        string ans;
        //Bool to Tell the system to we want to add more students
        bool repeat = true;
        //ints for DOB
        int year = 0;
        int day = 0;
        int month = 0;
        //Number for the Classes: for loop
        int classesnum = 0;
        string Classname;

        students.Add(new Student());
        students.Add(new Student());
        students.Add(new Student());
        students.Add(new Student());
        students.Add(new Student());
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
                while (repeat == true)
                {
                    while (ID == 0)
                    {
                        Console.WriteLine("Please Enter The students ID:");
                        try { ID = Convert.ToInt32(Console.ReadLine()); }
                        catch
                        {
                            Console.WriteLine("This is not a valid ID");
                            ID = 0;
                        }
                    }
                    Console.WriteLine("Please Enter the Students First Name");
                    fName = Console.ReadLine();
                    Console.WriteLine("Please Enter the Students Last Name");
                    lName = Console.ReadLine();
                    while (year == 0)
                    {
                        Console.WriteLine("Please Enter the Students Year of Birth");
                        try { year = Convert.ToInt32(Console.ReadLine()); }
                        catch
                        {
                            Console.WriteLine("This is not a valid Year");
                            year = 0;
                        }
                    }
                    while (month == 0)
                    {
                        Console.WriteLine("Please Enter the Students Month Of Birth (Numerical)");
                        try 
                        {
                            month = Convert.ToInt32(Console.ReadLine());
                            if (month <= 0 && month > 12) {
                                Console.WriteLine("Month Must be between 1-12");
                                month = 0;
                            }
                        }
                        catch
                        {
                            Console.WriteLine("This is not a valid month");
                            month = 0;
                        }
                    }
                    while (day == 0)
                    {
                        Console.WriteLine("Please Entrer the Students Date of Birth");
                        try { day = Convert.ToInt32(Console.ReadLine()); }
                        catch
                        {
                            Console.WriteLine("This is not a valid Day");
                            day = 0;
                        }
                    }
                    DOB = new DateTime(year, month, day);
                    Console.WriteLine("is this Student Enrolled? Y/N");
                    ans = Console.ReadLine();
                    while (ans != "Y" && ans != "N")
                    {
                        Console.WriteLine("Please Enter Either Y or N");
                        ans = Console.ReadLine();
                    }
                    if (ans == "Y")
                    {
                        isEnrolled = true;
                        Console.WriteLine("What is this students major?");
                        major = Console.ReadLine();
                        while (classesnum == 0)
                        {
                            Console.WriteLine("How many classes is this student taking?");
                            try
                            {
                                classesnum = Convert.ToInt32(Console.ReadLine());
                                if (classesnum < 0)
                                {
                                    classesnum = 0;
                                    Console.WriteLine("Number must be higher than Zero.");
                                }
                            }
                            catch
                            {
                                Console.WriteLine("This is not a valid number.");
                                month = 0;
                            }
                        }
                        classes = new List<string> {};
                        for (int i = 0; i < classesnum; i++)
                        {
                            Console.WriteLine($"please Enter Class number {(i+1)}");
                            Classname = Console.ReadLine();
                            classes.Add(new string(Classname));
                        }
                        Console.WriteLine();

                    }
                    else
                    {
                        isEnrolled = false;
                        major = "N/A";
                        classes = new List<string> { "N/A" };
                    }
                    //TURN INTO STUDENT HERE! Soemthing Like: Student Student = New Student(ID:, fname, lname, DOB, isenrolled, major, classes); The Student Class object would have to have its values in matching order though, so be prepared!
                    Console.WriteLine("Would you Like to Add another Student? Y/N");
                    ans = Console.ReadLine();
                    while (ans != "Y" && ans != "N")
                    {
                        Console.WriteLine("Please Enter Either Y or N");
                        ans = Console.ReadLine();
                    }
                    if (ans == "Y")
                    {
                        //resetting the board, only needed if we're loopin.
                        ans = "";
                        ID = 0;
                        year = 0;
                        month = 0;
                        day = 0;
                        classesnum = 0;
                    }
                    else { repeat = false; }
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