using System;
using System.Collections.Generic;
using System.Linq;

public class Student
{
    //place holders
    int ID = 0;
    string fName = "John";
    string lName = "Doe";
    DateTime DOB = new DateTime(2000, 12, 5);
    string major = "CIS";
    List<string> classes = new List<string> { "Home Ec", "WebDev", "Welding", "Biology" };
    bool isEnrolled = true;
    //Returnees from the Creating New Students part in the Main, Depending on if we JUST need this call they'll have to be modified, but since they don't leave this class if they complain about being undifined you can probably set them to Private without issue.
    string ans;
    bool repeat = true;
    int year = 0;
    int day = 0;
    int month = 0;
    int classesnum = 0;
    string Classname;


    public void CreateStudent()
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
                    if (month <= 0 && month > 12)
                    {
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
                classes = new List<string> { };
                for (int i = 0; i < classesnum; i++)
                {
                    Console.WriteLine($"please Enter Class number {(i + 1)}");
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


    }

    public override string ToString()
    {
        return $"ID: {ID}, First Name: {fName}, Last Name: {lName}, DOB: {DOB}, Major: {major}, Classes: {classes.Count}, Enrolled: {isEnrolled}\n";
    }
}